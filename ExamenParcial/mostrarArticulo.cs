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
    public partial class mostrarArticulo : Form
    {
        public mostrarArticulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void mostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrarArticulo_Load(object sender, EventArgs e)
        {
            mostrar.Rows.Add(2, "RTX 3090", 1400);
            mostrar.Rows.Add(3, "RX 6900XT", 900);
        }
    }
}
