using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSeguros
{
    public partial class poliza : Form
    {
        public poliza()
        {
            InitializeComponent();
        }

        private void poliza_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agencia_segurosDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.agencia_segurosDataSet.usuario);
            string primary_key = inicio.SelectedRow.Cells[0].Value.ToString();
        }

        private void agenciasegurosDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
