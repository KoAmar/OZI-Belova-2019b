using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        RSA rsa;
        int keySize;
        string storageName;

        private void Form1_Load(object sender, EventArgs e)
        {
            rsa = new RSA();
            keySize = 2048;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            storageName = storageNameTextBox.Text;
            bool result = rsa.LoadFromStorage(storageName);
            MessageBox.Show($"Public Key {(result ? "is" : "isn't")} loaded form {storageName}");
            if (result)
            {
                var originData = Encoding.ASCII.GetBytes(messageTextBox.Text);
                var encryptedData = rsa.Encrypt(originData);
                encryptedTextBox.Text = string.Join(":", encryptedData);

                infoTextBox.Text += "Encrypting".PadLeft(65, '=').PadRight(120, '=') + Environment.NewLine;
                infoTextBox.Text += $"N: {string.Join(":", rsa.GetField(Info.N))}\n\r\n\r";
                infoTextBox.Text += $"e: {ByteArrToInt(rsa.GetField(Info.EXPONENT))}\n\r\n\r";
                KeySizes[] legalKeySizes = rsa.GetPossibleKeySizes();
                if (legalKeySizes.Length > 0)
                {
                    for (int i = 0; i < legalKeySizes.Length; i++)
                    {
                        infoTextBox.Text += $"Keysize min, max, step: {legalKeySizes[i].MinSize}, {legalKeySizes[i].MaxSize}, {legalKeySizes[i].SkipSize}, ";
                    }
                }
                infoTextBox.Text += Environment.NewLine;
            }
        }

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

        private void decryptButton_Click(object sender, EventArgs e)
        {
            storageName = storageNameTextBox.Text;
            bool result = rsa.LoadFromStorage(storageName);
            MessageBox.Show($"Private Key {(result ? "is" : "isn't")} loaded form {storageName}");
            if (result)
            {
                var text = encryptedTextBox.Text.Split(new char[] { ':' });
                var decryptedData = rsa.Decrypt(text.Select(byte.Parse).ToArray());
                messageTextBox.Text = new string(Encoding.ASCII.GetChars(decryptedData));
                infoTextBox.Text += "Decrypting".PadLeft(65, '=').PadRight(120, '=') + Environment.NewLine;
                infoTextBox.Text += $"P: {string.Join(":", rsa.GetField(Info.P))}\n\r\n\r";
                infoTextBox.Text += $"Q: {string.Join(":", rsa.GetField(Info.Q))}\n\r\n\r";
                infoTextBox.Text += $"N: {string.Join(":", rsa.GetField(Info.N))}\n\r\n\r";
                infoTextBox.Text += $"e: {ByteArrToInt(rsa.GetField(Info.EXPONENT))}\n\r\n\r";
                infoTextBox.Text += $"d: {string.Join(":", rsa.GetField(Info.D))}\n\r";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            infoTextBox.Text = string.Empty;
        }

        private void createAndSaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(storageNameTextBox.Text.Trim()))
            {
                storageName = storageNameTextBox.Text;
                rsa = new RSA(keySize, storageName);
                MessageBox.Show("Data saved");
            }
            else
            {
                MessageBox.Show("Input name of storage!");
            }
        }
    }
}
