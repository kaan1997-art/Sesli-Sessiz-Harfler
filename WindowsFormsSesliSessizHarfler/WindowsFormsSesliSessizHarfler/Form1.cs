using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSesliSessizHarfler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yazi = textBox1.Text;
            yazi = yazi.ToUpper();
            int sayi = yazi.Length;
            for (int i = 0; i <= sayi - 1; i++)
            {
                char harf = Convert.ToChar(yazi.Substring(i, 1));
                if (harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'o' || harf == 'ö' || harf == 'u' || harf == 'ü')
                {
                    lbSesli.Items.Add(harf);
                }
                else
                {
                    lbSessiz.Items.Add(harf);
                }
            }
        }
    }
}
