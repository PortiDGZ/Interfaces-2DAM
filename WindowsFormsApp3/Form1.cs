using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cantidad, precio, calculo;
            cantidad = Convert.ToDouble(cantidad_mask.Text);
            precio = Convert.ToDouble(prec_mask.Text);
            calculo = (cantidad * precio) * 1.21;
            placeholder_lbl.Text = Convert.ToString(calculo);
             
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox2.Text = "21%";
        }
    }
}
