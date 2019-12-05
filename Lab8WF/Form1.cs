using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace lab8_bel
{
    public partial class Form1 : Form
    {
        private const string SHA512_OID = "2.16.840.1.101.3.4.2.3";

        private RSAParameters _rsaparams = new RSAParameters();

        private byte[] _signaturebytes = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            var text = messageBox.Text;
            var hash = CalculateHash(text);

            infoBox.Text += "\r\n\r\n";
            var rsa = new RSACryptoServiceProvider();
            _rsaparams = rsa.ExportParameters(includePrivateParameters: true);

            byte[] signature = rsa.SignHash(hash, SHA512_OID);
            _signaturebytes = signature;

            PrintInfo(rsa);
        }

        private void VerifySignatureButton_Click(object sender, EventArgs e)
        {
            var text = messageBox.Text;
            var secondHash = CalculateHash(text);
            var rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(_rsaparams);

            var result = rsa.VerifyHash(secondHash, SHA512_OID, _signaturebytes);

            PrintInfo(rsa);
            MessageBox.Show("Is the same hash: " + result);
        }

        private void PrintInfo(RSACryptoServiceProvider rsa)
        {
            infoBox.Text +=
                  $"Keys size: {rsa.KeySize}\r\n\r\n"
                + $"Open key(e): {ByteArrToInt(_rsaparams.Exponent)}\r\n\r\n"
                + $"Private key(d): {ByteArrToStr(_rsaparams.D)}\r\n\r\n"
                + $"N: {ByteArrToStr(_rsaparams.Modulus) }\r\n\r\n"
                + $"P: {ByteArrToStr(_rsaparams.P)}\r\n\r\n"
                + $"Q: {ByteArrToStr(_rsaparams.Q)}\r\n\r\n";

            if (_signaturebytes != null)
            {
                infoBox.Text += $"Signature: {ByteArrToStr(_signaturebytes)}";
            }
        }

        private byte[] CalculateHash(string text)
        {
            hashBox.Text = string.Empty;
            infoBox.Text = string.Empty;
            var bytes = Encoding.UTF8.GetBytes(text);
            var sha512 = new SHA512CryptoServiceProvider();
            var hash = sha512.ComputeHash(bytes);
            hashBox.Text += ToHex(hash) + Environment.NewLine;
            infoBox.Text += $"Hash size: {sha512.HashSize}\r\n";
            return hash;
        }

        private string ToHex(byte[] bytes) => new SoapHexBinary(bytes).ToString();

        private static string ByteArrToStr(byte[] bytes) => string.Join(":", bytes);

        static public int ByteArrToInt(byte[] bytes)
        {
            string result = string.Empty;

            foreach (var byt in bytes)
            {
                string byteStr = byt.ToString();
                do { byteStr = '0' + byteStr; }
                while (byteStr.Length < 8);
                result += byteStr;
            }

            return Convert.ToInt32(result, 2);
        }
    }
}