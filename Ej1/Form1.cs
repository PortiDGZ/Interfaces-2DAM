using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {

        int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {

                button1.PerformClick();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            num = rnd.Next(0, 50);
            play_btn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num_txt = Convert.ToInt32(maskedTextBox1.Text);
            if (num_txt < num)
            {
                placeholder_txt.Text = "El número es mayor.";

            }
            else if (num_txt > num)
            {
                placeholder_txt.Text = "El número es menor.";
            }
            else if (num_txt == num)
            {
                placeholder_txt.Text = "Has acertado el número";
                play_btn.Enabled = true;

            }
        }

        private void entrada_btn_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }
    }
}
