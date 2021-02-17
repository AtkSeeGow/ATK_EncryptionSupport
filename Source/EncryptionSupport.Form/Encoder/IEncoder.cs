using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionSupport.Form
{
    public interface IEncoder
    {
        void GenerateKey();
        string Encrypt(string target);
        string Decrypt(string target);
    }
}
