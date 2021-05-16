using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionSeguros
{
    public partial class inicio : Form
    {
        Alta Alta = new Alta();
        public inicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agencia_segurosDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.agencia_segurosDataSet.cliente);



        }

        private void baja_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in tablaDatos.SelectedCells)
            {
                if (oneCell.Selected)
                    tablaDatos.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void alta_btn_Click(object sender, EventArgs e)
        {
            Alta.ShowDialog();
        }

        public void Busqueda(string buscar)
        {

            MySqlConnection conn = new MySqlConnection("Server=localhost,3307;Database=agencia_seguros;User Id=root;Password=root;");
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM cliente where Nombre like '%" + buscar + "%'" , conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tablaDatos.DataSource = dt;
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Busqueda(textBox1.Text);
        }
    }
}
