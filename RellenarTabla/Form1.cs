using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RellenarTabla
{
    public partial class Form1 : Form
    {
        Alta form = new Alta();
        modificar modificar = new modificar();
        DataGridBBDD dataGridBBDD = new DataGridBBDD();
        public Form1()
        {
            InitializeComponent();

        }

        private void alta_btn_Click(object sender, EventArgs e)
        {

            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                int rowId = tablaDatos.Rows.Add();
                DataGridViewRow row = tablaDatos.Rows[rowId];
                row.Cells["DNI"].Value = form.dni_txt.Text;
                row.Cells["NOMBRE"].Value = form.name_txt.Text;
                row.Cells["APELLIDOS"].Value = form.ape_txt.Text;
                row.Cells["CURSO"].Value = form.curso_txt.Text;
                row.Cells["TELEFONO"].Value = form.tlf_txt.Text;
                row.Cells["PROVINCIA"].Value = form.prov_txt.Text;
                row.Cells["POBLACION"].Value = form.pob_txt.Text;
                form.dni_txt.Clear();
                form.name_txt.Clear();
                form.ape_txt.Clear();
                form.curso_txt.Clear();
                form.tlf_txt.Clear();
                form.prov_txt.Clear();
                form.pob_txt.Clear();
            }

        }

        private void baja_btn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Quieres borrar los datos?", "Confirmación", buttons);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewCell oneCell in tablaDatos.SelectedCells)
                {
                    if (oneCell.Selected && oneCell.Value == null)
                    {
                        MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                        DialogResult result1 = MessageBox.Show("No puedes borrar una fila vacía", "Error", buttons1);
                    }
                    if (oneCell.Selected && oneCell.Value != null)
                    {
                        tablaDatos.Rows.RemoveAt(oneCell.RowIndex);
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
            {
                int rowId = tablaDatos.CurrentRow.Index;
                DataGridViewRow row = tablaDatos.Rows[rowId];
                row.Cells["DNI"].Value = modificar.dni_txt.Text;
                row.Cells["NOMBRE"].Value = modificar.name_txt.Text;
                row.Cells["APELLIDOS"].Value = modificar.ape_txt.Text;
                row.Cells["CURSO"].Value = modificar.curso_txt.Text;
                row.Cells["TELEFONO"].Value = modificar.tlf_txt.Text;
                row.Cells["PROVINCIA"].Value = modificar.prov_txt.Text;
                row.Cells["POBLACION"].Value = modificar.pob_txt.Text;
       
            }
        }

        private void tablaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = tablaDatos.CurrentRow.Index;
            DataGridViewRow row = tablaDatos.Rows[rowId];
            if (row.Cells[rowId].Value != null)
            {
                modificar.dni_txt.Text = row.Cells[0].Value.ToString();
                modificar.name_txt.Text = row.Cells[1].Value.ToString();
                modificar.ape_txt.Text = row.Cells[2].Value.ToString();
                modificar.curso_txt.Text = row.Cells[3].Value.ToString();
                modificar.tlf_txt.Text = row.Cells[4].Value.ToString();
                modificar.prov_txt.Text = row.Cells[5].Value.ToString();
                modificar.pob_txt.Text = row.Cells[6].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void accesobd_btn_Click(object sender, EventArgs e)
        {
            

            dataGridBBDD.Show();
        }
    }
}
