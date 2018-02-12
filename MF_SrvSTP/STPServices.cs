
namespace MF_SrvSTP
{
    public class STPServices
    {
        SpeiServicesImplService ss = new SpeiServicesImplService();
        InfoSign infoS;

        public STPServices(string name, string pw, string certAlias)
        {
            infoS = new InfoSign(name, pw, certAlias);
            //ss.Url = "http://demo.stpmex.com:7004/speidemo/webservices/SpeiServices";
            ss.Url = "http://10.5.1.5:7004/speidemo/webservices/SpeiActualizaServices?wsdl";
            
        }

        public speiServiceResponse registraOrden(ordenPagoWS input)
        {
            infoS.signData(ref input);

            return ss.registraOrden(input);
        }

        public speiServiceResponse[] registraOrdenes(ordenPagoWS[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                infoS.signData(ref input[i]);
            }
            return ss.registraOrdenes(input);
        }

    }
}
