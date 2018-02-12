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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
        static string conStr = ConfigurationManager.ConnectionStrings["SPEIContext"].ConnectionString;

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

            Cuenta_Abono abono = new Cuenta_Abono();
            Cuenta_Abono_Respuesta abonoResponse = new Cuenta_Abono_Respuesta();
            Cuenta_Abono_Conciliacion abonoConciliacion = new Cuenta_Abono_Conciliacion();
            Cuenta_CLABE clabe = new Cuenta_CLABE();

            MFTool tool = new MFTool();

            List<Cuenta_Abono> sendAbonos = new List<Cuenta_Abono>();

            int intSts_Abono = 0;
            string strCLABE = String.Empty;
            string strCodigoError = intSts_Abono.ToString();
            string strContrato_Id = String.Empty;
            string strDV = String.Empty;
            string strContDV = String.Empty;
            string strContrato = String.Empty;

            try
            {
                if (xmlDoc != null)
                {
                    #region Lectura del documento XML
                    XElement xml = XElement.Load(new XmlNodeReader(xmlDoc));
                    IEnumerable<XElement> abonos = xml.Elements();

                    foreach (var item in abonos)
                    {
                        // Obtenemos la CLABE para validarla.
                        strCLABE = item.Element("cuentaBeneficiario").Value == null ? "" :
                            item.Element("cuentaBeneficiario").Value;

                        #region Configuración de la respuesta
                       
                        strCodigoError = "0";
                        intSts_Abono = 0;

                        strContrato_Id = strCLABE.Substring(11, 6);
                        strDV = tool.devuelveDV(strContrato_Id);

                        strContrato = strContrato_Id;
                        strContrato += strDV;

                        // Verifico si existe la CLABE en caso positivo 
                        if (clabe.validaCLABE(strCLABE))
                        {
                            // Verifico si existe la CLABE en caso positivo 
                            if (clabe.existeCLABE(strCLABE))
                            {
                                strCodigoError = "0"; // Recibido.
                                intSts_Abono = 10;

                            }
                            else
                            {
                                strCodigoError = "0"; // Cuenta inexistente.
                                intSts_Abono = 40; // Error Registro SIIF
                            }
                        }
                        else
                        {
                            strCodigoError = "0"; // Usuario 
                            intSts_Abono = 60; // No definido
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

                        abono.Cuenta_Abono_cuentaOrdenante = item.Element("cuentaOrdenante").Value == null ? "" :
                            item.Element("cuentaOrdenante").Value;

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

                        abono.Cuenta_Abono_referenciaNumerica = Convert.ToInt32(strContrato);

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

                        // Agrego el abono y al listado
                        if (abono.Agregar())
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

                        abonoResponse.Agregar();

                        // Actualizamos la clave de rastreo de Devolución del Abono
                        abono.Cuenta_Abono_claveRastreoDev = abonoResponse.Cuenta_Abono_Respuesta_rastreoDevolucion.Trim();

                        abono.Actualizar();
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
                        if (strCodigoError == "0")
                        {
                            abonoConciliacion.psintBancoId = (int)abono.Cuenta_Abono_institucionBeneficiaria;
                            abonoConciliacion.pstrCuentaId = abono.Cuenta_Abono_cuentaBeneficiario;
                            //abonoConciliacion.pintConciliacionPendienteId  
                            abonoConciliacion.pdtmConciliacionPendienteFecha = abono.Cuenta_Abono_fechaOperacion;
                            abonoConciliacion.pstrConciliacionPendienteDsc = abono.Cuenta_Abono_conceptoPago;
                            abonoConciliacion.pfltConciliacionPendienteImporte =
                                (decimal)abono.Cuenta_Abono_monto;
                            abonoConciliacion.psintConciliacionPendienteIngEgr = 5;
                            abonoConciliacion.pstrUsuarioId = "SPEIMF";
                            abonoConciliacion.pstrConciliacionPendienteReferencia =
                                strContrato;
                            //abono.Cuenta_Abono_referenciaNumerica.ToString();
                            abonoConciliacion.pstrConciliacionPendienteMovtoBanco = "";
                            abonoConciliacion.pstrConciliacionPendienteFechaImp = DateTime.Now.ToString();
                            abonoConciliacion.pbitConciliacionPendienteAut = false;
                            abonoConciliacion.pstrConciliacionPendienteObservaciones = "Proceso SPEI";
                            abonoConciliacion.pstrTipoLoquidacionBancoId = "9999";
                            abonoConciliacion.pstrConciliacionPendienteCheque = "";
                            abonoConciliacion.RegistraConciliacion();

                            if (abonoConciliacion.RegistraConciliacion())
                                abono.Cuenta_Abono_Sts_Abono_Id = 20; // Abono exitoso
                            else
                                abono.Cuenta_Abono_Sts_Abono_Id = 40; //Error al registrar la conciliación

                        }

                        // Actualizo el status del abono.
                        abono.Actualizar();
                        #endregion

                        #region Verifico si existe una orden.

                        /* Tengo que checar que si no existe en la tabla Contrato_Digito
                         * el registro de Contrato_Id, Banco, digito no se va a mostrar
                         * en resultado en Ordenes Pendientes
                        */

                        DataSet ordenesPendientes = tool.obtenerOrdenesPendientes(DateTime.Now);
                        if (ordenesPendientes.Tables.Count > 0)
                        {
                            if (ordenesPendientes.Tables[0].Rows.Count > 0)
                            {
                                foreach (DataRow reg in ordenesPendientes.Tables[0].Rows)
                                {
                                    string strImporte = Convert.ToString(reg["Conciliacion_Pendiente_Importe"]);
                                    if (Convert.ToDecimal(strImporte) == abono.Cuenta_Abono_monto)
                                        abono.Cuenta_Abono_Sts_Abono_Id = 30;
                                    else
                                        abono.Cuenta_Abono_Sts_Abono_Id = 35;
                                }
                            }
                            else
                                abono.Cuenta_Abono_Sts_Abono_Id = 35;
                        }
                        else
                            abono.Cuenta_Abono_Sts_Abono_Id = 35;
                        abono.Actualizar();

                        /*
                         * 
                         *  CREAR UNA CLASE AUXILIAR PARA OBTENER DIGITO VERIFICADOR
                         *  AGREGAR REGISTRO DEL DIGITO VERIFICADOR Y MAS
                         *  Listo clase: MFTools.cs
                         */


                        // Voy a crear una clase para verificar la orden.


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

            return xmlResp.ToXmlDocument();

        }

        /// <summary>
        /// Procesa el cambio de estado de una orden.
        /// </summary>
        /// <param name="xmlDocument">Documento XML con los datos requeridos</param>
        /// <returns>Se devuelve el documento XML de recepción con los campos de respuesta idResponse y Response</returns>
        [WebMethod]
        public XmlDocument cambioEstado(XmlDocument xmlDocument)
        {
            #region Variables
            XDocument xmlResp = new XDocument();
            string strId = String.Empty;
            string strEmpresa = String.Empty;
            string strFolioOrigen = String.Empty;
            string strEstado = String.Empty;
            string strCausaDevolucion = String.Empty;
            int intId = 0;
            #endregion
            try
            {
                #region Proceso
                if (xmlDocument != null)
                {
                    #region Cargamos los datos del cambio de estado
                    XElement xmlDoc = XElement.Load(new XmlNodeReader(xmlDocument));
                    IEnumerable<XElement> cambios = xmlDoc.Elements();

                    foreach (var item in cambios)
                    {
                        strId = item.Element("Id").Value == null ? "" :
                            item.Element("Id").Value;
                        intId = Convert.ToInt32(strId);
                        strEmpresa = item.Element("empresa").Value == null ? "" :
                           item.Element("empresa").Value;
                        strFolioOrigen = item.Element("folioOrigen").Value == null ? "" :
                           item.Element("folioOrigen").Value;
                        strEstado = item.Element("estado").Value == null ? "" :
                           item.Element("estado").Value;
                        strCausaDevolucion = item.Element("causaDevolucion").Value == null ? "" :
                           item.Element("causaDevolucion").Value;
                    }
                    #endregion

                    #region Obtenemos los datos del abono

                    Cuenta_Abono ca = new Cuenta_Abono();
                    Cuenta_Abono cuentaAbono = new Cuenta_Abono();
                    cuentaAbono = ca.ObtenerAbonoId(intId);

                    Sts_Abono st = new Sts_Abono();
                    Sts_Abono estatus = null;

                    #endregion

                    #region Genero la respuesta
                    // Enviamos el estatus de la orden.
                    if (cuentaAbono != null)
                    {
                        estatus = st.DevuelveId((int)cuentaAbono.Cuenta_Abono_Sts_Abono_Id);

                        #region Se devuelve el estado
                        xmlResp = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                            new XElement("cambioEstados",
                            new XElement("cambioEstado",
                            new XElement("Id", strId),
                            new XElement("empresa", "MAS_FONDOS"),
                            new XElement("folioOrigen", strFolioOrigen),
                            new XElement("estado", strEstado),
                            new XElement("causaDevolucion", ""),
                            new XElement("idResponse", cuentaAbono.Cuenta_Abono_Sts_Abono_Id),
                            new XElement("response", estatus.Sts_Abono_Dsc_Corta.Trim()))));
                        #endregion
                    }
                    // Se informa que no existe el folio.
                    else
                    {
                        #region No existe folio
                        xmlResp = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                            new XElement("cambioEstados",
                            new XElement("cambioEstado",
                            new XElement("Id", strId),
                            new XElement("empresa", "MAS_FONDOS"),
                            new XElement("folioOrigen", strFolioOrigen),
                            new XElement("estado", strEstado),
                            new XElement("causaDevolucion", ""),
                            new XElement("idResponse", "20"),
                            new XElement("response", "Folio Inexistente"))));
                        #endregion
                    }
                    #endregion
                }
                else
                {
                    #region Respuesta de documento nulo
                    xmlResp = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                            new XElement("cambioEstados",
                            new XElement("cambioEstado",
                            new XElement("Id", 0),
                            new XElement("empresa", "MAS_FONDOS"),
                            new XElement("folioOrigen", "0"),
                            new XElement("estado", "0"),
                            new XElement("causaDevolucion", "Sin documento"),
                            new XElement("idResponse", "10"),
                            new XElement("response", "Sin documento"))));
                    #endregion
                }
                #endregion
            }

            catch (Exception ex)
            {
                log.Error(ex, "Error en cambioEstado()");
            }

            return xmlResp.ToXmlDocument();
        }


        [WebMethod]
        public string recibeInstituciones(XmlDocument xmlInstituciones)
        {
            string strRes = "En proceso...";

            try
            {
                string bancoClave = "";
                string bancoNombre = "";
                BancoBL banco = new BancoBL();


                if (xmlInstituciones != null)
                {
                    XElement xmlDocto = XElement.Load(new XmlNodeReader(xmlInstituciones));
                    IEnumerable<XElement> xmlDatos = xmlDocto.Elements();

                    foreach (XElement item in xmlDatos)
                    {
                        bancoClave = item.Attribute("clave").Value == null ? "" :
                            item.Attribute("clave").Value;
                        bancoNombre = item.Attribute("nombre").Value == null ? "" :
                            item.Attribute("nombre").Value;

                        banco.Actualiza(bancoClave, bancoNombre);
                    }
                }
                else
                {
                    strRes = "Documento vacio.";
                }

                strRes = "Actualización correcta.";
            }
            catch (Exception ex)
            {
                //log.Error(ex, "Error en ServiciosMF/recibeInstituciones");
                strRes = "Error: " + ex.Message;
            }

            return strRes;
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

    public class ProcesaCompra
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();
        static string conStr = ConfigurationManager.ConnectionStrings["SPEIContext"].ConnectionString;

        #region Propiedades
        public int IngresoEfec { get; set; }
        public int Tipo_Momento_Id { get; set; }
        public int VerifAsig { get; set; }
        public int Consecutivo { get; set; }
        public int VerifPerfilCliente { get; set; }
        #endregion

        #region Constructor

        public ProcesaCompra()
        {
            #region obtieneTipoMomento
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT IngresoEfec = Parametros_Promocion_Ingreso_Efectivo, Tipo_Momento_Id FROM Parametros_Promocion WHERE Empresa_Id = '01'", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.AddWithValue("@Banco_Dsc_Corta", banco_Dsc_Corta);
                    //cmd.Parameters.AddWithValue("@Banco_Clave_CNBV", banco_Clave_CNBV);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error Banco/Agrega");
            }
            #endregion
        }

        #endregion

        #region Métodos

        #endregion


        //public static obtieneDatos
    }

}
