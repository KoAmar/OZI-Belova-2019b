using System;
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
        byte[] originData, encryptedData, decryptedData;

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
                originData = Encoding.ASCII.GetBytes(messageTextBox.Text);
                encryptedData = rsa.Encrypt(originData);
                encryptedTextBox.Text = new string(Encoding.ASCII.GetChars(encryptedData));

                infoTextBox.Text += "Encrypting".PadLeft(65, '=').PadRight(120, '=') + Environment.NewLine;
                infoTextBox.Text += $"N: {string.Join(":", rsa.GetField(Info.N))}\n\r\n\r";
                infoTextBox.Text += $"e: {string.Join(":", rsa.GetField(Info.EXPONENT))}\n\r\n\r";
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

        private void decryptButton_Click(object sender, EventArgs e)
        {
            storageName = storageNameTextBox.Text;
            bool result = rsa.LoadFromStorage(storageName);
            MessageBox.Show($"Private Key {(result ? "is" : "isn't")} loaded form {storageName}");
            if (result)
            {
                decryptedData = rsa.Decrypt(encryptedData);
                messageTextBox.Text = new string(Encoding.ASCII.GetChars(decryptedData));
                infoTextBox.Text += "Decrypting".PadLeft(65, '=').PadRight(120, '=') + Environment.NewLine;
                infoTextBox.Text += $"P: {string.Join(":", rsa.GetField(Info.P))}\n\r\n\r";
                infoTextBox.Text += $"Q: {string.Join(":", rsa.GetField(Info.Q))}\n\r\n\r";
                infoTextBox.Text += $"N: {string.Join(":", rsa.GetField(Info.N))}\n\r\n\r";
                infoTextBox.Text += $"e: {string.Join(":", rsa.GetField(Info.EXPONENT))}\n\r\n\r";
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
