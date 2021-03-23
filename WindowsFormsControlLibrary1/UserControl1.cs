using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static char calcularLetra(int n)
        {
            string cadena = "TRWAGMYFPDXBNJZSQVHLCKE";
            return (char)cadena[n % 23];
        }

        public bool LabelVisibility
        {
            get { return label1.Visible; }

            set { label1.Visible = value; }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(maskedTextBox1.Text);

            if (maskedTextBox1.Text.Length == 8)
            {
                LabelVisibility = true;
                label1.Text = Convert.ToString(calcularLetra(numero));
            }
            else LabelVisibility = false;
        }
    }
}
