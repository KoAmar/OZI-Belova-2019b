using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const CipherMode CIPHER_MODE = CipherMode.CBC;
        private const PaddingMode PADDING_MODE = PaddingMode.PKCS7;

        private RC2Implemention rc2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Text.Length == 0 | MessageTextBox.Text.Length == 0 |
                rc2 == null) { MessageBox.Show("Error!"); return; }


            var chiperText = rc2.Encrypt(MessageTextBox.Text);

            ChiperTextBox.Text = string.Join(":",chiperText);
        }

        private void DecryptBox_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Text.Length == 0 | ChiperTextBox.Text.Length == 0 |
                rc2 == null) { MessageBox.Show("Error!"); return; }

            var message = rc2.Decrypt(ChiperTextBox.Text.ToByteArray());

            DecryptedTextBox.Text = message;
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Text.Length == 0) { MessageBox.Show("Error!"); return; }

            rc2 = new RC2Implemention(CIPHER_MODE, PADDING_MODE, PasswordBox.Text);
            ParametersInfo.FontSize = 12;
            ParametersInfo.Content = rc2.Info();
        }
    }
}
