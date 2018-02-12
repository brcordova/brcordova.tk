using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using System;
using System.IO;

namespace MF_SrvSTP
{
    class KeystoreManager
    {
        public static AsymmetricKeyParameter getCertified(string filename, string passwd, string alias)
        {
            AsymmetricKeyParameter key = null;
            FileStream fS = File.OpenRead(filename);
            Pkcs12Store p12Store = null;
            try
            {
                p12Store = new Pkcs12Store(fS, passwd.ToCharArray());

                try
                {
                    key = p12Store.GetKey(alias).Key;
                }
                catch (NullReferenceException e)
                {
                    System.Diagnostics.Debug.WriteLine("No se encontro certificado con el alias " + alias + " " + e);
                    Console.WriteLine("No se encontro certificado con el alias " + alias + " " + e);
                    throw new ArgumentException("No se encontro certificado con el alias {0} {1}", alias, e);
                }
            }
            catch (IOException e)
            {
                System.Diagnostics.Debug.WriteLine("Error al recuperar el certificado " + e);
                Console.WriteLine("Error al recuperar el certificado " + e);
                throw new ArgumentException("Error al recuperar el certificado{0}", e);
            }
            fS.Close();

            return key;
        }
    }
}
