using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            KeyTextBox.Text = "412";
            MessageTextBox.Text = "f";
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            if (KeyTextBox.Text.Length == 0 | MessageTextBox.Text.Length == 0) { return; }

            var key = KeyTextBox.Text;
            var letters = MessageTextBox.Text.ToArray();

            var chiperText = "";
            foreach (var letter in letters)
            {
                chiperText += SDES_Lab4.Encrypt(key, letter)+" ";
            }

            ChiperTextBox.Text = chiperText;
        }

        private void DecryptBox_Click(object sender, RoutedEventArgs e)
        {
            if (KeyTextBox.Text.Length == 0 | ChiperTextBox.Text.Length == 0) { return; }

            var key = KeyTextBox.Text;
            var letters = ChiperTextBox.Text.Split(new char[] { ' ' });

            var message = "";
            foreach (var letter in letters)
            {
                message += SDES_Lab4.Decrypt(key, letter);
            }

            DecryptedTextBox.Text = message;
        }
    }
}
