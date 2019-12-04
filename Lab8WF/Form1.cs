using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace lab8_bel
{
    public partial class Form1 : Form
    {
        private const string SHA1_OID = "1.3.14.3.2.26";
        private const string MD5_OID = "1.2.840.113549.2.5";
        private byte[] hash = null;
        private RSAParameters param = new RSAParameters();
        private byte[] signature = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            signature = fromHex(signatureBox.Text);
        }

        private byte[] ComputeHash(string text)
        {
            hashBox.Text = "";
            infoBox.Text = "";
            var bytes = Encoding.UTF8.GetBytes(text);
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            var hash = sha.ComputeHash(bytes);
            infoBox.Text += "Hash size: " + sha.HashSize + "\r\n";
            hashBox.Text += toHex(hash) + "\r\n";
            return hash;
        }

        private byte[] fromHex(string text)
        {
            return SoapHexBinary.Parse(text).Value;
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            var text = plainBox.Text;
            hash = ComputeHash(text);
            signature = SignHash(hash);
            signatureBox.Text = toHex(signature);
        }

        private byte[] SignHash(byte[] hash)
        {
            infoBox.Text += "\r\n\r\n";
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            param = rsa.ExportParameters(true);
            var signature = rsa.SignHash(hash, SHA1_OID);
            infoBox.Text += "Keys size: " + rsa.KeySize + "\r\n" + "\r\n"
                + "Open key(e): " + toHex(param.Exponent) + "\r\n" + "\r\n"
                + "Private key(d): " + toHex(param.D) + "\r\n" + "\r\n"
                + "N: " + toHex(param.Modulus) + "\r\n" + "\r\n"
                + "P: " + toHex(param.P) + "\r\n" + "\r\n"
                + "Q: " + toHex(param.Q) + "\r\n";
            return signature;
        }

        private string toHex(byte[] bytes)
        {
            return new SoapHexBinary(bytes).ToString();
        }

        private void unsignButton_Click(object sender, EventArgs e)
        {
            var text = plainBox.Text;
            var secondHash = ComputeHash(text);
            infoBox.Text = "Is the same hash: " + verifySign(secondHash, signature);
        }

        private bool verifySign(byte[] hash, byte[] signature)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(param);
            return rsa.VerifyHash(hash, SHA1_OID, signature);
        }
    }
}