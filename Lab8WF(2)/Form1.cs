using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TestCore;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        private string allMessage;

        private RSACryptoServiceProvider dsa;

        private string rsaparamsSTR;

        public Form1()
        {
            InitializeComponent();
            dsa = new RSACryptoServiceProvider();
        }

        public static string arrToString(byte[] arr)
        {
            return Encoding.Default.GetString(arr);
        }

        public static string decArrayToHexString(byte[] array)
        {
            string[] hexArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                hexArray[i] = Convert.ToString(array[i], 16);
            }
            return String.Join(":", hexArray);
        }

        public static Byte[] ToByteArray(string text)
        {
            String[] parts = text.Split(':');
            Byte[] array = new Byte[parts.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Byte.Parse(parts[i]);
            }
            return array;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SHA256 hash = new SHA256Managed();

            byte[] messageBytes = Encoding.Default.GetBytes(message.Text);
            byte[] H = hash.ComputeHash(messageBytes);

            byte[] signatureBytes = dsa.SignHash(H, "2.16.840.1.101.3.4.2.1");

            string signatureSRT = XML.Stringify(signatureBytes);
            RSAParameters rsaparam = dsa.ExportParameters(true);
            rsaparamsSTR = XML.Stringify(rsaparam);

            Hashlable.Text = "Hash: " + decArrayToHexString(H);
            HashSizelable.Text = "Hash size: " + H.Length * 8;
            PrivateKeylabel.Text = "Private key: " + String.Join(":", dsa.ExportCspBlob(true));
            PublicKeyLabel.Text = "Public key: " + String.Join(":", dsa.ExportCspBlob(false));
            KeySizelabel.Text = "Key size: " + dsa.KeySize;
            signatureValue.Text = String.Join(":", signatureBytes);

            allMessage = message.Text + "|" + rsaparamsSTR + "|" + signatureSRT;
        }

        private void verifySignature_Click(object sender, EventArgs e)
        {
            allMessage = message.Text + "|" + rsaparamsSTR + "|" + signatureValue.Text;
            string[] components = allMessage.Split('|');

            SHA256 hash = new SHA256Managed();
            byte[] H2 = hash.ComputeHash(Encoding.Default.GetBytes(components[0]));

            RSAParameters DSApar2 = Xml.Parse<RSAParameters>(components[1]);
            dsa.ImportParameters(DSApar2);
            byte[] signature = ToByteArray(components[2]);
            bool result = dsa.VerifyHash(H2, "SHA256", signature);

            string flag;
            if (result)
            {
                flag = "verified successfully.";
            }
            else
            {
                flag = "verification faild!";
            }
            logsAfter.Text = flag;
        }
    }
}