using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int[] IP = { 2, 6, 3, 1, 4, 8, 5, 7 };
        int[] I_P = { 4, 1, 3, 5, 7, 2, 8, 6 };
        int[] P10 = { 3, 5, 2, 7, 4, 10, 1, 9, 8, 6 };
        int[] P8 = { 6, 3, 7, 4, 8, 5, 10, 9 };
        int[] EP = { 4, 1, 2, 3, 2, 3, 4, 1 };
        int[] P4 = { 2, 4, 3, 1 };
        string[] keys;

        public Form1()
        {
            InitializeComponent();
            label6.Text = "";
        }

        private string ToBinary(int digit, int length)
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

        public string XOR(string ar1, string ar2)
        {

            string Res = "";
            for (int i = 0; i < ar1.Length; ++i)
            {
                int res = Convert.ToInt32(ar1[i]) ^ Convert.ToInt32(ar2[i]);
                Res += res;
            }

            return Res;
        }

        public string getR(string ip)
        {
            return ip.Substring(4, 4);
        }

        public string getL(string ip)
        {
            return ip.Substring(0, 4);
        }

        public int[] getIndex(string l)
        {
            int[] res = new int[2];
            string first = l[0].ToString() + l[3].ToString();
            string second = l[1].ToString() + l[2].ToString();

            res[0] = Convert.ToInt32(first, 2);
            res[1] = Convert.ToInt32(second, 2);

            return res;
        }

        public string getSR(int[] indexes)
        {
            int[,] SR = { { 1, 1, 2, 3 }, { 2, 0, 1, 3 }, { 3, 0, 1, 0 }, { 2, 1, 0, 3 } };
            return ToBinary(SR[indexes[0], indexes[1]], 2);
        }

        public string getSL(int[] indexes)
        {
            int[,] SL = { { 1, 0, 3, 2 }, { 3, 2, 1, 0 }, { 0, 2, 1, 3 }, { 3, 1, 3, 1 } };
            return ToBinary(SL[indexes[0], indexes[1]], 2);
        }

          

        public string shuffle(int[] p, string ar)
        {
            string result = "";
            int len = ar.Length;
            for (int i = 0; i < p.Length; ++i)
            {
                result  += ar[p[i] - 1];
            }


            return result;
        }

        public string SW(string key, string R)
        {
            label6.Text += "SW(R) = " + getR(key) + R + '\n';
            return getR(key) + R;
        }
        public string SR(string key, string L)
        {
            label6.Text += "Before IP(-1) = " + L + getR(key) + '\n';
            return L + getR(key);
        }

        public string move(int n, string array)
        {
            string f_arr = array.Substring(0, 5);
            string s_arr = array.Substring(5, 5);

            for (int i = 0; i < n; ++i)
            {
                f_arr = f_arr.Substring(1) + f_arr.First();
                s_arr = s_arr.Substring(1) + s_arr.First();
            }

            return f_arr + s_arr;
        }

        public string encode(string textCode, string[] keys)
        {
            string ip = shuffle(IP,textCode);

            label6.Text += "Ip = " + ip + '\n';

            for (int i = 0; i < 2; ++i)
            {
                string ep = XOR(shuffle(EP, getR(ip)), keys[i]);
                label6.Text += "E/P(R) XOR K[" + i + "] = " + ep + '\n';
                string slsr = getSL(getIndex(getL(ep))) + getSR(getIndex(getR(ep)));
                slsr = XOR(getL(ip),shuffle(P4, slsr));
                ip = i == 0 ? SW(ip, slsr) : SR(ip, slsr);
                
            }

            return shuffle(I_P, ip);
        }

        public void getKeys(string key)
        {
            keys = new string[2];
            key = shuffle(P10, key);
            keys[0] = shuffle(P8, move(1, key));
            keys[1] = shuffle(P8, move(3, key));
            
        }

        public void swapKeys()
        {
            string buffer = keys[0];
            keys[0] = keys[1];
            keys[1] = buffer;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            getKeys(ToBinary(Int32.Parse(textBox1.Text), 10));
            string str = "Key1 = " + keys[0].ToString() + '\n' +
                        "Key 2 = " + keys[1].ToString() + '\n';
            label6.Text = str;

            string textCode = ToBinary((int)(textBox2.Text[0]), 8);

            string res = encode(textCode, keys);
            textBox3.Clear();
            textBox3.Text += res + "   (" + Convert.ToInt32(res, 2) + ")"; ;

            
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            getKeys(ToBinary(Int32.Parse(textBox1.Text), 10));
            swapKeys();
            string str = "Key1 = " + keys[0].ToString() + '\n' +
                        "Key 2 = " + keys[1].ToString() + '\n';
            label6.Text += str;

            string res = encode(textBox3.Text, keys);
            textBox4.Clear();
            textBox4.Text += res + "   (" + Convert.ToInt32(res, 2) + ")";
        }
    }
}
