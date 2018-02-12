using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Signers;
using System.Text;

namespace MF_SrvSTP
{
    class SignsManager
    {
        public static string signInfoKey(AsymmetricKeyParameter key, string data)
        {
            byte[] dataBytes = Encoding.GetEncoding(65001).GetBytes(data);

            RsaDigestSigner signer = new RsaDigestSigner(new Sha256Digest());
            signer.Init(true, key);
            signer.BlockUpdate(dataBytes, 0, dataBytes.Length);
            byte[] output = signer.GenerateSignature();

            return System.Convert.ToBase64String(output);
        }
    }
}
