using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayi_tahmin_etme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int a;
        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin = int.Parse(textBox1.Text);

            if (tahmin == a)
            {
                label2.Text = "Doğru Bildin Kardeş";
            }
            else if (tahmin > a)
            {
                label2.Text = "Azalt";
            }
            else if (tahmin < a) {
                label2.Text = "Çoğalt";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = rnd.Next(1, 11);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
