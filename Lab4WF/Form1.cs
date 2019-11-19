using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ECB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            if (plainText.Text.ToString().Length == 0)
            {
                MessageBox.Show("Input text", "Error");
                return;
            }
            if (keyBox.Text.ToString().Length == 0)
            {
                MessageBox.Show("Input key", "Error");
                return;
            }
            string[] resutEncrypt = ECBCrypt(plainText.Text,keyBox.Text);
            encryptedText.Text += resutEncrypt[0];
            logBox.Text += resutEncrypt[1];
        }

        private string[] ECBCrypt(string text, string key)
        {
            StringBuilder encryptedTextBuilder = new StringBuilder();
            StringBuilder logBuilder = new StringBuilder();
            IList<BitArray> textBits = ParseCryptedText(text) ? GetBitArrayFromBits(text): GetBitArrayFromCharacters(text);
            for (int i = 0; i < textBits.Count; i++)
            {
                Tuple<BitArray, String> tuple = SDES.MakeS_DES(textBits[i], key, radioButton1.Checked);
                encryptedTextBuilder.Append(SDES.ToString(tuple.Item1));
                logBuilder.Append(tuple.Item2);
            }
            return new string[] { encryptedTextBuilder.ToString(), logBuilder.ToString() };
        }
        private void button2_Click(object sender, EventArgs e)
        {
            logBox.Text = String.Empty;
            encryptedText.Text = String.Empty;
        }

        private bool ParseCryptedText(string text)
        {
            bool parseResult = false;
            Regex regex = new Regex("^[0-1]+$");
            if (regex.IsMatch(text))
            {
                parseResult = true;
            }
            return parseResult;
        }

        private IList<BitArray> GetBitArrayFromCharacters(string text)
        {
            IList<BitArray> textBits = new List<BitArray>();
            foreach(char character in text)
            {
                BitArray characterBits = new BitArray(new byte[] { (byte)character});
                characterBits = SDES.Reverse(characterBits);
                textBits.Add(characterBits);
            }
            return textBits;
        }

        private IList<BitArray> GetBitArrayFromBits(string text)
        {
            IList<BitArray> textBits = new List<BitArray>();
            int blockLength = 8;
            for (int i = 0; i < text.Length; i += blockLength)
            {
                int difference = text.Length - i;
                string textBitsPart = null;
                if (difference > blockLength)
                {
                    textBitsPart = text.Substring(i, blockLength);
                }
                else
                {
                    textBitsPart = text.Substring(i, difference) + new String('0', blockLength - difference);
                }
                BitArray textBit = new BitArray(blockLength);
                for (int j = 0; j < blockLength; j++)
                {
                    textBit.Set(j, textBitsPart[j].Equals('1') ? true : false);
                }
                textBits.Add(textBit);
            }
            return textBits;
        }
    }
}
