using System;
using System.IO;
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

    public class AESEncoder : IEncoder
    {
        private readonly string AES_KEY = "PwvMiuIPyRm0yBSof/r7Q5+GgK7WRqeGECtXuNR3wfE=";
        private readonly string AES_IV = "6W4GM74JJLJjnIhtKI75Ug==";

        public string Encrypt(string target)
        {
            byte[] encrypted;

            using (var provider = new AesCryptoServiceProvider())
            {
                provider.Key = Convert.FromBase64String(AES_KEY);
                provider.IV = Convert.FromBase64String(AES_IV);
                provider.Mode = CipherMode.CBC;
                provider.Padding = PaddingMode.PKCS7;

                var cryptoTransform = provider.CreateEncryptor(provider.Key, provider.IV);

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
                    {
                        using (var streamWriter = new StreamWriter(cryptoStream))
                            streamWriter.Write(target);

                        encrypted = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encrypted);
        }

        public string Decrypt(string target)
        {
            string decrypted = null;
            var cipher = Convert.FromBase64String(target);

            using (var provider = new AesCryptoServiceProvider())
            {
                provider.Key = Convert.FromBase64String(AES_KEY);
                provider.IV = Convert.FromBase64String(AES_IV);
                provider.Mode = CipherMode.CBC;
                provider.Padding = PaddingMode.PKCS7;

                var cryptoTransform = provider.CreateDecryptor(provider.Key, provider.IV);

                using (var memoryStream = new MemoryStream(cipher))
                    using (var cs = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
                        using (var streamReader = new StreamReader(cs))
                            decrypted = streamReader.ReadToEnd();
            }

            return decrypted;
        }

        public void GenerateKey()
        {
            throw new NotImplementedException();
        }
    }
}
