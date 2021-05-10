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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionDataSet.datos' Puede moverla o quitarla según sea necesario.
            this.datosTableAdapter.Fill(this.gestionDataSet.datos);



        }

        private void baja_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in tablaDatos.SelectedCells)
            {
                if (oneCell.Selected)
                    tablaDatos.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
    }
}
