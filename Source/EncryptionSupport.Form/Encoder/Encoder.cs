using System;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionSupport.Form
{
    public class RSAEncoder : IEncoder
    {
        public string Key { get; set; }

        public void GenerateKey()
        {
            using (RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider())
                Key = cryptoServiceProvider.ToXmlString(true);
        }

        public string Encrypt(string target)
        {
            var bytes = Encoding.UTF8.GetBytes(target);

            using (RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider())
            {
                cryptoServiceProvider.FromXmlString(Key);
                return Convert.ToBase64String(cryptoServiceProvider.Encrypt(bytes, false));
            }
        }

        public string Decrypt(string target)
        {
            var bytes = Convert.FromBase64String(target);

            using (RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider())
            {
                cryptoServiceProvider.FromXmlString(Key);
                return Encoding.UTF8.GetString(cryptoServiceProvider.Decrypt(bytes, false));
            }
        }
    }
}
