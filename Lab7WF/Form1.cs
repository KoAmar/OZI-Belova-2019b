using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RSA rsa;
        int keySize;
        Storage keyType;
        string storageName;
        Byte[] originData, encryptedData, decryptedData;

        private void Form1_Load(object sender, EventArgs e)
        {
            rsa = new RSA();
            keyType= Storage.USER_CONTAINER;

        }
        
        private void checkBoxForEncryptedTextBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDataView(checkBoxForEncryptedTextBox2, encryptedTextBox,  encryptedData);
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            keyType = DefineTypeKeyStorage();
            storageName = storageNameTextBox.Text;
            bool result = rsa.LoadInfo(keyType, TypeKey.PUBLIC_KEY, storageName);
            MessageBox.Show($"Public Key {(result ? "is" : "isn't")} loaded");
            if (result)
            {
                originData = Encoding.ASCII.GetBytes(messageTextBox.Text);
                encryptedData = rsa.Encrypt(originData);
                encryptedTextBox.Text = new string(Encoding.ASCII.GetChars(encryptedData));

                infoTextBox.Text += "Encrypting".PadLeft(50, '=').PadRight(50, '=') + Environment.NewLine;
                infoTextBox.Text += $"N = {string.Join(" ", rsa.GetField(Info.N))}{Environment.NewLine}{Environment.NewLine}";
                infoTextBox.Text += $"e = {string.Join(" ", rsa.GetField(Info.EXPONENT))}{Environment.NewLine}{Environment.NewLine}";
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
            keyType = DefineTypeKeyStorage();
            storageName = storageNameTextBox.Text;
            bool result = rsa.LoadInfo(keyType, TypeKey.PRIVATE_KEY, storageName);
            MessageBox.Show($"Private Key {(result ? "is" : "isn't")} loaded");
            if (result)
            {
                decryptedData = rsa.Decrypt(encryptedData);
                messageTextBox.Text = new string(Encoding.ASCII.GetChars(decryptedData));
                infoTextBox.Text += "Decrypting".PadLeft(50, '=').PadRight(50, '=') + Environment.NewLine;
                infoTextBox.Text += $"P = {string.Join(" ", rsa.GetField(Info.P))}{Environment.NewLine}{Environment.NewLine}";
                infoTextBox.Text += $"Q = {string.Join(" ", rsa.GetField(Info.Q))}{Environment.NewLine}{Environment.NewLine}";
                infoTextBox.Text += $"N = {string.Join(" ", rsa.GetField(Info.N))}{Environment.NewLine}{Environment.NewLine}";
                infoTextBox.Text += $"e = {string.Join(" ", rsa.GetField(Info.EXPONENT))}{Environment.NewLine}{Environment.NewLine}";
                infoTextBox.Text += $"d = {string.Join(" ", rsa.GetField(Info.D))}{Environment.NewLine}";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            infoTextBox.Text = string.Empty;
        }

        private int DefineKeySize()
        {
            int keySize = 0;
         
            keySize = 4096;
            
            return keySize;
        }

        private void createAndSaveButton_Click(object sender, EventArgs e)
        {
            if (storageNameTextBox.Text.Trim() != string.Empty)
            {
                keySize = DefineKeySize();
                storageName = storageNameTextBox.Text;
                keyType = DefineTypeKeyStorage();
                rsa = new RSA(keySize, keyType, storageName);
                bool result = rsa.SaveInfo(keyType, storageName);
                MessageBox.Show($"Data {(result ? "is" : "isn't")} saved");
            }
            else
            {
                MessageBox.Show("Input name of storage!");
            }
        }

        private Storage DefineTypeKeyStorage()
        {
            Storage typeStorage = Storage.USER_CONTAINER;

            return typeStorage;
        }

        private void ChangeDataView(CheckBox checkBox, TextBox textBox, Byte[] textBoxData)
        {
            if (!checkBox.Checked)
            {
                textBox.Text = new string(Encoding.ASCII.GetChars(textBoxData));
            }
            else
            {
                textBox.Text = string.Join(".", textBoxData);
            }
        }

    }
}
