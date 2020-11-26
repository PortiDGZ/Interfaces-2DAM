using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura_presu
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.dataGridView1.Rows.Add(codigotxt.Text, desctxt.Text, cantidadtxt.Text, preciotxt.Text);

        }


        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void codigotxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
