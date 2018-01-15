using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;
using MF_Modelo;
using NLog;

namespace MF_WebService
{
    /// <summary>
    /// Summary description for serviciosMF
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class serviciosMF : System.Web.Services.WebService
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Servicio para recibir los abonos desde Banxico
        /// </summary>
        /// <param name="xmlDoc">XML con los datos del abono</param>
        /// <returns>Respuesta del abono.</returns>
        [WebMethod]
        public XmlDocument recibeAbono(XmlDocument xmlDoc)
        {
            XmlDocument retorno = new XmlDocument();
            XDocument xmlResp = null;
            try
            {
                Cuenta_Abono abono = new Cuenta_Abono();
                Cuenta_Abono_Respuesta abonoResponse = new Cuenta_Abono_Respuesta();
                Cuenta_Abono_Conciliacion abonoConciliacion = new Cuenta_Abono_Conciliacion();
                Cuenta_CLABE clabe = new Cuenta_CLABE();

                if (xmlDoc != null)
                {
                    #region Lectura del documento XML
                    XElement xml = XElement.Load(new XmlNodeReader(xmlDoc));

                    //Abono abono = null;
                    List<Cuenta_Abono> sendAbonos = new List<Cuenta_Abono>();
                    IEnumerable<XElement> abonos = xml.Elements(); //xml.Elements();
                    foreach (var item in abonos)
                    {
                        string strCLABE = item.Element("cuentaOrdenante").Value == null ? "" :
                            item.Element("cuentaOrdenante").Value;

                        #region Configuración de la respuesta
                        string strCodigoError = "0";
                        int intSts_Abono = 0;

                        // Verifico si existe la CLABE en caso positivo 
                        if ( clabe.existeCLABE(strCLABE))
                        {
                            strCodigoError = "0"; // Registro satisfactorio.
                            intSts_Abono = 10;
                        }
                        else
                        {
                            strCodigoError = "1"; // Cuenta inexistente.
                            intSts_Abono = 40;
                        }
                        #endregion

                        #region Registramos los datos del abono
                        abono.Cuenta_Abono_Id =
                            item.Element("clave").Value == null ? 0 : Convert.ToInt32(item.Element("clave").Value);

                        abono.Cuenta_Abono_fechaOperacion =
                            item.Element("fechaOperacion").Value == null ? DateTime.Now :
                            Convert.ToDateTime(
                            item.Element("fechaOperacion").Value.Substring(6, 2) + "/" +
                            item.Element("fechaOperacion").Value.Substring(4, 2) + "/" +
                            item.Element("fechaOperacion").Value.Substring(0, 4)
                            );

                        abono.Cuenta_Abono_institucionOrdenante =
                            item.Element("institucionOrdenante").Attribute("clave").Value == null ? 0 :
                            Convert.ToInt32(item.Element("institucionOrdenante").Attribute("clave").Value);

                        abono.Cuenta_Abono_institucionBeneficiaria =
                            item.Element("institucionBeneficiaria").Attribute("clave").Value == null ? 40646 :
                            Convert.ToInt32(item.Element("institucionBeneficiaria").Attribute("clave").Value);

                        abono.Cuenta_Abono_claveRastreo =
                            item.Element("claveRastreo").Value == null ? "" :
                            item.Element("claveRastreo").Value;

                        abono.Cuenta_Abono_monto =
                            item.Element("monto").Value == null ? 0.0M :
                            Convert.ToDecimal(item.Element("monto").Value);

                        abono.Cuenta_Abono_nombreOrdenante =
                            item.Element("nombreOrdenante").Value == null ? "" :
                            item.Element("nombreOrdenante").Value;

                        abono.Cuenta_Abono_tipoCuentaOrdenante =
                            item.Element("tipoCuentaOrdenante").Value == null ? 40 :
                            Convert.ToInt32(item.Element("tipoCuentaOrdenante").Value);

                        abono.Cuenta_Abono_cuentaOrdenante = strCLABE;

                        abono.Cuenta_Abono_rfcCurpOrdenante =
                            item.Element("rfcCurpOrdenante").Value == null ? "" :
                            item.Element("rfcCurpOrdenante").Value;

                        abono.Cuenta_Abono_nombreBeneficiario =
                            item.Element("nombreBeneficiario").Value == null ? "" :
                            item.Element("nombreBeneficiario").Value;

                        abono.Cuenta_Abono_tipoCuentaBeneficiario =
                            item.Element("tipoCuentaBeneficiario").Value == null ? 40 :
                            Convert.ToInt32(item.Element("tipoCuentaBeneficiario").Value);

                        abono.Cuenta_Abono_cuentaBeneficiario =
                            item.Element("cuentaBeneficiario").Value == null ? "" :
                            item.Element("cuentaBeneficiario").Value;

                        abono.Cuenta_Abono_rfcCurpBeneficiario =
                            item.Element("rfcCurpBeneficiario").Value == null ? "" :
                            item.Element("rfcCurpBeneficiario").Value;

                        abono.Cuenta_Abono_conceptoPago =
                            item.Element("conceptoPago").Value == null ? "" :
                            item.Element("conceptoPago").Value;

                        abono.Cuenta_Abono_referenciaNumerica =
                            item.Element("referenciaNumerica").Value == null ? 0 :
                            Convert.ToInt32(item.Element("referenciaNumerica").Value);

                        abono.Cuenta_Abono_empresa =
                            item.Element("empresa").Value == null ? "" :
                            item.Element("empresa").Value;

                        abono.Cuenta_Abono_tipoPago =
                            item.Element("tipoPago").Attribute("clave").Value == null ? 1 :
                           Convert.ToInt32(item.Element("tipoPago").Attribute("clave").Value);

                        abono.Cuenta_Abono_tipoOperacion =
                            item.Element("tipoOperacion").Attribute("clave").Value == null ? 4 :
                            Convert.ToInt32(item.Element("tipoOperacion").Attribute("clave").Value);

                        abono.Cuenta_Abono_Sts_Abono_Id = intSts_Abono;

                        // Agrego al listado
                        if(abono.Agregar())
                            sendAbonos.Add(abono);

                        #endregion

                        #region Registramos los datos de la respuesta
                        abonoResponse.Cuenta_Abono_Respuesta_clave = abono.Id;
                        abonoResponse.Cuenta_Abono_Respuesta_empresa = abono.Cuenta_Abono_nombreBeneficiario;
                        abonoResponse.Cuenta_Abono_Respuesta_medioEntrega = "";
                        abonoResponse.Cuenta_Abono_Respuesta_folioOrigen = abono.Cuenta_Abono_Id.ToString();
                        abonoResponse.Cuenta_Abono_Respuesta_codigoError = Convert.ToInt32(strCodigoError);
                        abonoResponse.Cuenta_Abono_Respuesta_tipoPago = 1;
                        abonoResponse.Cuenta_Abono_Respuesta_rastreoDevolucion = "MFRD-" + abono.Id.ToString().PadLeft(5, '0');

                        abonoResponse.Agrega();
                        #endregion

                        #region Generar la respuesta
                        xmlResp = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                            new XElement("devoluciones",
                            new XElement("devolucion",
                            new XElement("clave", abonoResponse.Cuenta_Abono_Respuesta_clave.ToString()),
                            new XElement("empresa", abonoResponse.Cuenta_Abono_Respuesta_empresa),
                            new XElement("medioEntrega", abonoResponse.Cuenta_Abono_Respuesta_medioEntrega.ToString()),
                            new XElement("folioOrigen", abonoResponse.Cuenta_Abono_Respuesta_folioOrigen),
                            new XElement("codigoError", abonoResponse.Cuenta_Abono_Respuesta_codigoError.ToString()),
                            new XElement("tipoPago", abonoResponse.Cuenta_Abono_Respuesta_tipoPago.ToString()),
                            new XElement("rastreoDevolucion", abonoResponse.Cuenta_Abono_Respuesta_rastreoDevolucion))));
                        #endregion

                        #region Registrar conciliación
                        abonoConciliacion.psintBancoId = (int)abono.Cuenta_Abono_institucionBeneficiaria;
                        abonoConciliacion.pstrCuentaId = abono.Cuenta_Abono_cuentaBeneficiario;
                        //abonoConciliacion.pintConciliacionPendienteId  
                        abonoConciliacion.pdtmConciliacionPendienteFecha = abono.Cuenta_Abono_fechaOperacion;
                        abonoConciliacion.pstrConciliacionPendienteDsc = abono.Cuenta_Abono_conceptoPago;
                        abonoConciliacion.pfltConciliacionPendienteImporte =
                            (decimal)abono.Cuenta_Abono_monto;
                        abonoConciliacion.psintConciliacionPendienteIngEgr = 5;
                        abonoConciliacion.pstrUsuarioId = "BROSTOS";
                        abonoConciliacion.pstrConciliacionPendienteReferencia =
                            abono.Cuenta_Abono_referenciaNumerica.ToString();
                        abonoConciliacion.pstrConciliacionPendienteMovtoBanco = "";
                        abonoConciliacion.pstrConciliacionPendienteFechaImp = DateTime.Now.ToString();
                        abonoConciliacion.pbitConciliacionPendienteAut = false;
                        abonoConciliacion.pstrConciliacionPendienteObservaciones = "";
                        abonoConciliacion.pstrTipoLoquidacionBancoId = "9999";
                        abonoConciliacion.pstrConciliacionPendienteCheque = "";
                        abonoConciliacion.RegistraConciliacion();
                        #endregion

                    }
                    #endregion
                }
                else
                {
                    #region Devuelvo el resultado de la petición
                    xmlResp = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("devoluciones",
                        new XElement("devolucion",
                        new XElement("clave", 0),
                        new XElement("empresa", "MAS_FONDOS"),
                        new XElement("medioEntrega", "0"),
                        new XElement("folioOrigen", "0"),
                        new XElement("codigoError", "14"),
                        new XElement("tipoPago", "1"),
                        new XElement("rastreoDevolucion", "Sin documento"))));
                    #endregion
                }
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error Cuenta_Abono/AgregarAbono");
            }

            XmlDocument xmlResponse = DocumentExtensions.ToXmlDocument(xmlResp);
            return retorno;
        }

        [WebMethod]
        public void cambioEstado(int Id, string empresa, string folioOrigen, int estado, string causaDevolucion)
        {

        }

        [WebMethod]
        public void recibeInstituciones(XmlDocument xmlInstituciones)
        {
            string bancoClave = "";
            string bancoNombre = "";
            Banco banco = new Banco();


            if (xmlInstituciones != null)
            {
                XElement xmlDocto = XElement.Load(new XmlNodeReader(xmlInstituciones));
                IEnumerable<XElement> xmlDatos = xmlDocto.Elements();

                foreach (var item in xmlDatos)
                {
                    bancoClave = item.Element("institucion").Attribute("clave").Value == null ? "" :
                        item.Element("institucion").Attribute("clave").Value.ToUpper();
                    bancoNombre = item.Element("institucion").Attribute("nombre").Value == null ? "" :
                        item.Element("institucion").Attribute("nombre").Value.ToUpper();

                    banco.Agrega(bancoClave, bancoNombre);
                }

            }
        }

    }


    public static class DocumentExtensions
    {
        public static XmlDocument ToXmlDocument(this XDocument xDocument)
        {
            var xmlDocument = new XmlDocument();
            using (var xmlReader = xDocument.CreateReader())
            {
                xmlDocument.Load(xmlReader);
            }
            return xmlDocument;
        }

        public static XDocument ToXDocument(this XmlDocument xmlDocument)
        {
            using (var nodeReader = new XmlNodeReader(xmlDocument))
            {
                nodeReader.MoveToContent();
                return XDocument.Load(nodeReader);
            }
        }
    }

}
