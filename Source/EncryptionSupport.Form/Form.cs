using System;

namespace EncryptionSupport.Form
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void executeEvent(object sender, EventArgs e)
        {
            IEncoder encoder = new RSAEncoder()
            {
                Key = "<RSAKeyValue><Modulus>scCsKawhMkqRH/RZpaek6S8SYtI6GCe1yJoYX8Amr8nwys2u4rwtw+B1bLpjKRnnmJERj9U+tF9BGQQ5El/gsCYBMByWitLKWy8AIOshoOnXYK3wpacqkwEIuxkLgvlc5IPo4tkoRt66iQXjud66Yj7VcuKMWqjXf09UD6pzvhs=</Modulus><Exponent>AQAB</Exponent><P>vs4Y9GI/Zo/9U6oJJkIc8py+7PTR0GuceWgp3xTtk7npcPOiMvovzoMAMSGEurras8k5GuBsu2zb8QaEes/MJw==</P><Q>7nzdjtdprDrSk1cBzX8FHy3OGMAD0izukcWZA35Wti6Iyr3ve7Kw372GnwhIOiyRjeJN8BpANcXD0RmEJR8S7Q==</Q><DP>jFR39gTsLDpqTkYYRJMLR0QRB6VnSqpagtAhO3jg4m0xS2lkOanXz0J5uai1PcB/aQrtfN7iGVaOzE3G0axSsQ==</DP><DQ>wfyXS2U08381YdvX/4teYyojBkbJ1N/vfms4N3tAlRfs9NziO7/x10yWgC2AcrFmA/8cXj08FYEz8pXKw1cvUQ==</DQ><InverseQ>Z9Sfew5G0pfo7qtHhLwAmX748I+atF4Z/mhxQ5/cFi7YGifJG7L15PoCGV9xY0Ky5chEPR6BclboD84xA286XA==</InverseQ><D>DGkSSO/ClGM3zusKdH7uco6kGLAERcB40cwBRkCOH7lLoK7YqYfC8dY5MwF82X2vn+ugNfi8O1XobFZq16x7BvA/PmlFq2G/QudT2SHfvZHYrDemqW22qZ8FDhrbei3AEkr8r1cpRqeKAgWw3zVghc09tCb/MSMaL1BWbbFsOOU=</D></RSAKeyValue>"
            };

            var encryptionText = encryptionTextBox.Text;
            var decryptionText = decryptionTextBox.Text;

            if (!string.IsNullOrEmpty(encryptionText))
                encryptionResultTextBox.Text = encoder.Encrypt(encryptionText);

            if (!string.IsNullOrEmpty(decryptionText))
                decryptionResultTextBox.Text = encoder.Decrypt(decryptionText);
        }
    }
}
