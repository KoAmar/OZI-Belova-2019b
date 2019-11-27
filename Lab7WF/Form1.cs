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
        Int32 keySize;
        Storage typeStorage;
        String storageName;
        Byte[] originData, encryptedData, decryptedData;

        private void Form1_Load(object sender, EventArgs e)
        {
            rsa = new RSA();
        }

        private void checkBoxForEncryptedTextBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDataView(checkBoxForEncryptedTextBox1, encryptedTextBox1,  encryptedData);
        }

        private void checkBoxForEncryptedTextBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDataView(checkBoxForEncryptedTextBox2, encryptedTextBox2,  encryptedData);
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            typeStorage = DefineTypeKeyStorage();
            storageName = storageNameTextBox.Text;
            Boolean result = rsa.LoadInfo(typeStorage, TypeKey.PUBLIC_KEY, storageName);
            MessageBox.Show($"Public Key {(result ? "is" : "isn't")} loaded");
            if (result)
            {
                originData = Encoding.ASCII.GetBytes(openTextBox.Text);
                encryptedData = rsa.Encrypt(originData);
                encryptedTextBox1.Text = new String(Encoding.ASCII.GetChars(encryptedData));
                encryptedTextBox2.Text = new String(Encoding.ASCII.GetChars(encryptedData));

                infoTextBox.Text += "Encrypting".PadLeft(48, '-').PadRight(86, '-') + Environment.NewLine;
                infoTextBox.Text += $"N = {String.Join(" ", rsa.GetField(Info.N))}{Environment.NewLine}{Environment.NewLine}";
                infoTextBox.Text += $"e = {String.Join(" ", rsa.GetField(Info.EXPONENT))}{Environment.NewLine}{Environment.NewLine}";
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
            typeStorage = DefineTypeKeyStorage();
            storageName = storageNameTextBox.Text;
            Boolean result = rsa.LoadInfo(typeStorage, TypeKey.PRIVATE_KEY, storageName);
            MessageBox.Show($"Private Key {(result ? "is" : "isn't")} loaded");
            if (result)
            {
                decryptedData = rsa.Decrypt(encryptedData);
                decryptedTextBox.Text = new String(Encoding.ASCII.GetChars(decryptedData));
                infoTextBox.Text += "Decrypting".PadLeft(47, '-').PadRight(85, '-') + Environment.NewLine;
                infoTextBox.Text += $"P = {String.Join(" ", rsa.GetField(Info.P))}{Environment.NewLine}{Environment.NewLine}";
                infoTextBox.Text += $"Q = {String.Join(" ", rsa.GetField(Info.Q))}{Environment.NewLine}{Environment.NewLine}";
                infoTextBox.Text += $"N = {String.Join(" ", rsa.GetField(Info.N))}{Environment.NewLine}{Environment.NewLine}";
                infoTextBox.Text += $"e = {String.Join(" ", rsa.GetField(Info.EXPONENT))}{Environment.NewLine}{Environment.NewLine}";
                infoTextBox.Text += $"d = {String.Join(" ", rsa.GetField(Info.D))}{Environment.NewLine}";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            infoTextBox.Text = String.Empty;
        }

        private Int32 DefineKeySize()
        {
            Int32 keySize = 0;
         
            keySize = 4096;
            
            return keySize;
        }

        private void createAndSaveButton_Click(object sender, EventArgs e)
        {
            if (storageNameTextBox.Text.Trim() != String.Empty)
            {
                keySize = DefineKeySize();
                storageName = storageNameTextBox.Text;
                typeStorage = DefineTypeKeyStorage();
                rsa = new RSA(keySize, typeStorage, storageName);
                Boolean result = rsa.SaveInfo(typeStorage, storageName);
                MessageBox.Show($"Data {(result ? "is" : "isn't")} saved");
            }
            else
            {
                MessageBox.Show("Input name of storage!");
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private Storage DefineTypeKeyStorage()
        {
            Storage typeStorage = Storage.USER_CONTAINER;
         
            typeStorage = Storage.USER_CONTAINER;
            
            return typeStorage;
        }

        private void ChangeDataView(CheckBox checkBox, TextBox textBox, Byte[] textBoxData)
        {
            if (!checkBox.Checked)
            {
                textBox.Text = new String(Encoding.ASCII.GetChars(textBoxData));
            }
            else
            {
                textBox.Text = String.Join(".", textBoxData);
            }
        }

    }
}
