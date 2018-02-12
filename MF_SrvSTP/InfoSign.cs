using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Crypto;
using System.Globalization;
using MF_SrvSTP.wsSTP;

namespace MF_SrvSTP
{
    class InfoSign
    {
        String filename = "";
        String pwd = "";
        String alias = "";

        public InfoSign(string name, string pw, string certAlias)
        {
            filename = name;
            pwd = pw;
            alias = certAlias;
        }

        public void signData(ref ordenPagoWS data)
        {
            AsymmetricKeyParameter key = KeystoreManager.getCertified(filename, pwd, alias);
            String sign = "";

            if (key != null)
            {
                String dataToSign = getDataToSign(data);
                System.Diagnostics.Debug.WriteLine("Datos a firmar: \n{0}", dataToSign);
                Console.WriteLine("Datos a firmar: \n{0}", dataToSign);
                sign = SignsManager.signInfoKey(key, dataToSign);

                data.firma = sign;
            }
        }

        public String sign(string filename, string pwd, string certAlias, ordenPagoWS data)
        {
            AsymmetricKeyParameter key = KeystoreManager.getCertified(filename, pwd, certAlias);
            String sign = "";

            if (key != null)
            {
                String dataToSign = getDataToSign(data);
                System.Diagnostics.Debug.WriteLine("Datos a firmar: \n{0}", dataToSign);
                Console.WriteLine("Datos a firmar: \n{0}", dataToSign);
                sign = SignsManager.signInfoKey(key, dataToSign);
            }

            System.Diagnostics.Debug.WriteLine("Firma generada: \n{0}", sign);
            Console.WriteLine("Firma generada: \n{0}", sign);

            return sign;
        }

        public string getDataToSign(ordenPagoWS input)
        {
            System.Text.StringBuilder data = new System.Text.StringBuilder("||");

            data.Append(input.institucionContraparte).Append("|");
            data.Append(StringUtils.trimToEmpty(input.empresa)).Append("|");
            if (input.fechaOperacion != 0)
            {
                data.Append(input.fechaOperacion.ToString()).Append("|");
            }
            else
            {
                data.Append("|");
            }
            data.Append(StringUtils.trimToEmpty(input.folioOrigen)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.claveRastreo)).Append("|");

            if (input.institucionOperante != 0)
            {
                data.Append(input.institucionOperante.ToString()).Append("|");
            }
            else
            {
                data.Append("|");
            }
            //formatea el monto a dos decimales usando el punto como separador de decimales.
            data.Append(input.monto.ToString("F2", CultureInfo.InvariantCulture)).Append("|");
            if (input.tipoPago != 0)
            {
                data.Append(input.tipoPago.ToString()).Append("|");
            }
            else
            {
                data.Append("|");
            }
            if (input.tipoCuentaOrdenante != 0)
            {
                data.Append(input.tipoCuentaOrdenante.ToString()).Append("|");
            }
            else
            {
                data.Append("|");
            }
            data.Append(StringUtils.trimToEmpty(input.nombreOrdenante)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.cuentaOrdenante)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.rfcCurpOrdenante)).Append("|");
            if (input.tipoCuentaBeneficiario != 0)
            {
                data.Append(input.tipoCuentaBeneficiario.ToString()).Append("|");
            }
            else
            {
                data.Append("|");
            }
            data.Append(StringUtils.trimToEmpty(input.nombreBeneficiario)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.cuentaBeneficiario)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.rfcCurpBeneficiario)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.emailBeneficiario)).Append("|");
            if (input.tipoCuentaBeneficiario2 != 0)
            {
                data.Append(input.tipoCuentaBeneficiario2.ToString()).Append("|");
            }
            else
            {
                data.Append("|");
            }
            data.Append(StringUtils.trimToEmpty(input.nombreBeneficiario2)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.cuentaBeneficiario2)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.rfcCurpBeneficiario2)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.conceptoPago)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.conceptoPago2)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.claveCatUsuario1)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.claveCatUsuario2)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.clavePago)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.referenciaCobranza)).Append("|");
            if (input.referenciaNumerica != 0)
            {
                data.Append(input.referenciaNumerica.ToString()).Append("|");
            }
            else
            {
                data.Append("|");
            }
            if (input.tipoOperacion != 0)
            {
                data.Append(input.tipoOperacion.ToString()).Append("|");
            }
            else
            {
                data.Append("|");
            }
            data.Append(StringUtils.trimToEmpty(input.topologia)).Append("|");
            data.Append(StringUtils.trimToEmpty(input.usuario)).Append("|");
            if (input.medioEntrega != 0)
            {
                data.Append(input.medioEntrega.ToString()).Append("|");
            }
            else
            {
                data.Append("|");
            }
            if (input.prioridad != 0)
            {
                data.Append(input.prioridad.ToString()).Append("|");
            }
            else
            {
                data.Append("|");
            }
            if (input.iva != 0)
            {
                data.Append(input.iva.ToString("F2", CultureInfo.InvariantCulture)).Append("||");
            }
            else
            {
                data.Append("||");
            }

            return data.ToString();
        }
    }
}
