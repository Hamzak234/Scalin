using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad;
            adsoyad = Convert.ToString(textBox1.Text);
            listBox1.Items.Add(adsoyad);
            if (true)
            {

            }
            double sınav1, sınav2;
            double ortalama;
            sınav1 = Convert.ToDouble(textBox2.Text);
            listBox2.Items.Add(sınav1);
            sınav2 = Convert.ToDouble(textBox3.Text);
            if (sınav1 < 0 || sınav2 > 100)
            {
                listBox6.Items.Add("GeçersizNot girişi");
            }
            listBox3.Items.Add(sınav2);
            ortalama = (sınav1 + sınav2) / 2;
            listBox4.Items.Add(ortalama);
            if (ortalama < 0 || ortalama > 100)
            {
                listBox5.Items.Add("hatalıı ortalama");
            }
            else if (ortalama > 0 && ortalama < 50)
            {
                listBox5.Items.Add("kaldı");
            }
            else if (ortalama > 50)
            {
                listBox5.Items.Add("geçti");
            } 
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

