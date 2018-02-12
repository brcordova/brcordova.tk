using MF_SrvSTP.wsSTP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF_SrvSTP
{
    public partial class MF_STPServicios
    {

        private static readonly MF_SrvSTP.wsSTPConsulta.SpeiConsultaServicesImpl srvCon = new wsSTPConsulta.SpeiConsultaServicesImpl();

        public bool RegistrarOrdenPago(ordenPagoWS orden)
        {
            bool res = false;
            // Datos correctos para verificar conexión
            string fileName = Directory.GetCurrentDirectory().ToString() + @"\llave\prueba.p12";
            string pwd = "12345678";
            string alias = "prueba";

            //#region Orden de Pago
            //ordenPagoWS data = new ordenPagoWS();
            //data.empresa = "MAS_FONDOS";
            //data.claveRastreo = "MSFCH0OEE80003";
            //data.conceptoPago = "Pruebas de Más Fondos";
            //data.cuentaBeneficiario = "846180000400000001";
            //data.cuentaOrdenante = "";
            //data.referenciaNumerica = 2;
            //data.referenciaNumericaSpecified = true;
            //data.monto = 460000.82M;
            //data.montoSpecified = true;
            //data.tipoCuentaBeneficiario = 40;
            //data.tipoCuentaBeneficiarioSpecified = true;
            //data.tipoPago = 1;
            //data.tipoPagoSpecified = true;
            //data.institucionContraparte = 846;
            //data.institucionContraparteSpecified = true;  
            //data.nombreBeneficiario = "Juan Delgado";
            //data.institucionOperante = 90646;
            //data.institucionOperanteSpecified = true;
            //data.iva = 16;
            //data.ivaSpecified = true;

            //#endregion

            STPServices services = new STPServices(fileName, pwd, alias);
            speiServiceResponse respuesta = services.registraOrden(orden);

            return res;
        }

        public void consultaCEP()
        {
            wsSTPConsulta.catalogosWS[] catalogos = srvCon.consultaCatalogos();

        }

    }
}
