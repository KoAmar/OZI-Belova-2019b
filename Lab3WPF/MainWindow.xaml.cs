﻿using System;
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

namespace Lab3WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int[] P10 = { 3, 5, 2, 7, 4, 10, 1, 9, 8, 6 };
        public static int[] P8 = { 6, 3, 7, 4, 8, 5, 10, 9 };
        public static int[] P4 = { 2, 4, 3, 1 };
        public static int[] IP = { 2, 6, 3, 1, 4, 8, 5, 7 };
        public static int[] IP2 = { 4, 1, 3, 5, 7, 2, 8, 6 };
        public static int[] EP = { 4, 1, 2, 3, 2, 3, 4, 1 };
        public static int[,] SL = {
            {1, 0, 3, 2},
            {3, 2, 1, 0},
            {0, 2, 1, 3},
            {3, 1, 3, 1}
    };
        public static int[,] SR = {
            {1, 1, 2, 3},
            {2, 0, 1, 3},
            {3, 0, 1, 0},
            {2, 1, 0, 3}
    };
        public MainWindow()
        {
            InitializeComponent();
            KeyTextBox.Text = "412";
            MessageTextBox.Text = "f";
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            if (KeyTextBox.Text.Length == 0 | MessageTextBox.Text.Length == 0)
            {
                return;
            }

            string result = "";
            //result += $"{Permutation("1110", P4)}\n";
            //result += $"LeftCircularShift1: 35274a1986\n";
            //result += $"LeftCircularShift2: {LeftCircularShift("35274a1986", 3)}\n";
            //result += $"{XOR("01001101","10000010")}\n";
            //result += $"{CountSMatrix("11001111")}\n";
            var key = ToBinaryString(int.Parse(KeyTextBox.Text), 10);
            result += $"Key0: {key}\n";
            var (key1, key2) = GetKeys(key);
            result += $"Key1: {key1}\nKey2: {key2}\n";

            var ip = Permutation(ToBinaryString(MessageTextBox.Text[0], 8), IP);
            result += $"IP: {ip}\n";

            string f1 = Fk(ip, key1);
            result += $"f1: {f1}\n";

            string sw = ip.Substring(4, 4) + f1;

            string f2 = Fk(sw, key2);
            result += $"f2: {f2}\n";

            var end = f2 + sw.Substring(4, 4);

            string ip_2 = Permutation(end, IP2);
            result += $"IP^(-1): {ip_2}\n";

            result += $"ASCII: {Convert.ToInt32(ip_2, 2)}";

            ChiperTextBox.Text = Convert.ToInt32(ip_2, 2).ToString();

            MessageBox.Show(result);
        }

        private void DecryptBox_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(int.Parse(ChiperTextBox.Text).ToString());
            string result = "";

            var key = ToBinaryString(int.Parse(KeyTextBox.Text), 10);
            result += $"Key0: {key}\n";
            var (key1, key2) = GetKeys(key);
            result += $"Key1: {key1}\nKey2: {key2}\n";

            var ip = Permutation(ToBinaryString(int.Parse(ChiperTextBox.Text), 8), IP);
            result += $"IP: {ip}\n";

            string f1 = Fk(ip, key2);
            result += $"f1: {f1}\n";

            string sw = ip.Substring(4, 4) + f1;

            string f2 = Fk(sw, key1);
            result += $"f2: {f2}\n";

            var end = f2 + sw.Substring(4, 4);

            var ip_2 = Permutation(end, IP2);
            result += $"IP^(-1): {ip_2}\n";

            result += $"ASCII: {Convert.ToInt32(ip_2, 2)}";

            EncryptedTextBox.Text = Convert.ToInt32(ip_2, 2) + "";
            EncryptedTextBox.Text += " = " + (char)Convert.ToInt32(ip_2, 2);

            MessageBox.Show(result);
        }

        public static string Permutation(string value, int[] positions)
        {
            var result = "";
            foreach (var position in positions)
            {
                result += value[position - 1];
            }
            return result;
        }

        public static string LeftCircularShift(string value, int positions)
        {
            var len = value.Length;
            var partL = value.Substring(0, len / 2);
            var partR = value.Substring(len / 2, len / 2);

            for (int i = 0; i < positions; i++)
            {
                partL = partL.Substring(1) + partL.Substring(0, 1);
                partR = partR.Substring(1) + partR.Substring(0, 1);
            }

            return partL + partR;
        }

        public static string XOR(string arg1, string arg2)
        {
            var result = "";
            for (int num = 0; num < arg1.Length; num++)
            {
                result += Convert.ToInt32(arg1[num]) ^ Convert.ToInt32(arg2[num]);
            }

            return result;
        }

        public static string ToBinaryString(int digit, int length)
        {
            string BinaryRes = "";
            int holder;

            while (digit > 0)
            {
                holder = digit % 2;
                BinaryRes += holder;
                digit /= 2;
            }
            while (BinaryRes.Length < length)
            {
                BinaryRes += 0;
            }

            string res = new string(BinaryRes.Reverse().ToArray());

            return res;
        }

        public static string CountSMatrix(string value)
        {
            var result = "";
            var len = value.Length;

            string partL = value.Substring(0, len / 2);
            int str = Convert.ToInt32(partL[0].ToString() + partL[3], 2);
            int col = Convert.ToInt32(partL[1].ToString() + partL[2], 2);
            int L = SL[str, col];

            var partR = value.Substring(len / 2, len / 2);
            str = Convert.ToInt32(partR[0].ToString() + partR[3], 2);
            col = Convert.ToInt32(partR[1].ToString() + partR[2], 2);
            int R = SR[str, col];

            result = ToBinaryString(L, 2) + ToBinaryString(R, 2);
            return result;
        }

        public static string SW(string value)
        {
            var len = value.Length;
            return value.Substring(len / 2, len / 2) + value.Substring(0, len / 2);
        }

        public static (string, string) GetKeys(string key)
        {
            var p10 = Permutation(key, P10);
            var key1 = Permutation(LeftCircularShift(p10, 1), P8);
            var key2 = Permutation(LeftCircularShift(p10, 3), P8);
            return (key1, key2);
        }

        public static string Fk(string ip, string key)
        {
            //a
            string ep = Permutation(ip.Substring(4, 4), EP);
            //MessageBox.Show($"ep={ep}");
            //b
            string xor_ep_k1 = XOR(ep, key);
            //MessageBox.Show($"xor_ep_k1={xor_ep_k1}");
            //c
            string s_matrix = CountSMatrix(xor_ep_k1);
            //MessageBox.Show($"s_matrix={s_matrix}");
            //e
            string p4 = Permutation(s_matrix, P4);
            //MessageBox.Show($"p4={p4}");
            //f
            string xor_l_p4 = XOR(ip.Substring(0, 4), p4);
            //MessageBox.Show($"xor_l_p4={xor_l_p4}");

            //MessageBox.Show($"sw={sw}");

            return xor_l_p4;
        }
    }
}