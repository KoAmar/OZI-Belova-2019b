using System;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private const CipherMode CIPHER_MODE = CipherMode.CBC;
        private const PaddingMode PADDING_MODE = PaddingMode.PKCS7;
        private const string MESSAGE_ERROR_KEY_EMPTY = "The key must not be empty!";
        private const string MESSAGE_LEVEL = "Warning";
        private const string BASE_KEY_SIZE_LABEL = "Key size = ";
        private const string BASE_BLOCK_SIZE_LABEL = "Block size = ";
        private const string BASE_CIPHER_MODE_LABEL = "Cipher Mode = ";
        private const string BASE_PADDING_MODE_LABEL = "Padding Mode = ";
        private const string BASE_IS_WEAK_KEY_LABEL = "Key is weak = ";
        private const string BASE_MAX_KEY_LABEL = "Max key size: ";
        private const string BASE_MIN_KEY_LABEL = "Min key size: ";

        private RC2Implemention rc2;

        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(keyText.Text))
            {
                MessageBox.Show(MESSAGE_ERROR_KEY_EMPTY, MESSAGE_LEVEL, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                encryptedText.Text = String.Join(":", rc2.Encrypt(plainText.Text));
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(keyText.Text))
            {
                MessageBox.Show(MESSAGE_ERROR_KEY_EMPTY, MESSAGE_LEVEL, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                plainText.Text = rc2.Decrypt(RC2Implemention.ToByteArray(encryptedText.Text));
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            rc2 = new RC2Implemention(CIPHER_MODE, PADDING_MODE, textBox1.Text);
            keyText.Text = string.Join(":", rc2.GetKey());
            keySizeLabel.Text = BASE_KEY_SIZE_LABEL + rc2.GetKeySize();
            blockSizeLabel.Text = BASE_BLOCK_SIZE_LABEL + rc2.GetBlockSize();
            cipherModeLabel.Text = BASE_CIPHER_MODE_LABEL + CIPHER_MODE.ToString();
            paddingModeLabel.Text = BASE_PADDING_MODE_LABEL + PADDING_MODE.ToString();
            label4.Text = BASE_MAX_KEY_LABEL + rc2.GetMaxKeySize();
            label5.Text = BASE_MIN_KEY_LABEL + rc2.GetMinKeySize();
        }

        private void plainTextClearButton_Click(object sender, EventArgs e)
        {
            plainText.Text = "";
        }

        private void encryptedTextClearButton_Click(object sender, EventArgs e)
        {
            encryptedText.Text = "";
        }
    }
}
