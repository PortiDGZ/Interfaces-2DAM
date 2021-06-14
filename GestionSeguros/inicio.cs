using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionSeguros
{
    public partial class inicio : Form
    {
        Alta Alta = new Alta();
        poliza poliza = new poliza();
        public static DataGridViewRow SelectedRow { get; set; }
        public inicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void baja_btn_Click(object sender, EventArgs e)
        {
            int rowId = tablaDatos.CurrentRow.Index;
            DataGridViewRow row = tablaDatos.Rows[rowId];
            string pk = row.Cells[0].Value.ToString();
            string path = "Server=localhost,3306;Database=agencia_seguros;User Id=admin;Password=admin;";
            string query = $"DELETE FROM cliente WHERE dni = '{pk}'";
            MySqlConnection conn = new MySqlConnection(path);
            if (conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = path;
                conn.Open();
            }


            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Quieres borrar los datos?", "Confirmación", buttons);

            if (result == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                refreshdata();


            }
            conn.Close();
        }

        private void alta_btn_Click(object sender, EventArgs e)
        {
            Alta.ShowDialog();
            if (Alta.DialogResult == DialogResult.OK)
            {
                
                string path = "Server=localhost,3306;Database=agencia_seguros;User Id=admin;Password=admin;";
                string dni = Alta.dni_txt.Text;
                string nombre = Alta.name_txt.Text;
                string apellidos = Alta.ape_txt.Text;
                string telefono = Alta.tlf_txt.Text;
                string provincia = Alta.cbProv.GetItemText(Alta.cbProv.SelectedItem);
                string poblacion = Alta.cbPob.Text;
                string tipo_cliente = Alta.cb_tipo.GetItemText(Alta.cb_tipo.SelectedItem);
                string CP = Alta.cp_txt.Text;
                string query = $"INSERT INTO cliente (DNI, Nombre, Apellidos, Telefono, Provincia, Localidad, CP, Tipo_cliente) VALUES('{dni}', '{nombre}', '{apellidos}', '{telefono}', '{provincia}', '{poblacion}', '{CP}', '{tipo_cliente}')";
                MySqlConnection conn = new MySqlConnection(path);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.ConnectionString = path;
                    conn.Open();
                }

            //Creamos la conexión 
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //Ejecutamos la query
                cmd.ExecuteNonQuery();

                //Cerramos la conexión al terminar el foreach
                conn.Close();
                refreshdata();
                Alta.dni_txt.Clear();
                Alta.name_txt.Clear();
                Alta.ape_txt.Clear();
                Alta.cp_txt.Clear();
                Alta.tlf_txt.Clear();
            }
        }

        public void Busqueda(string buscar)
        {

            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=agencia_seguros;User Id=root;Password=admin;");
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM cliente where Nombre like '%" + buscar + "%' OR DNI like '%" + buscar + "%' OR Apellidos like '%" + buscar + "%' OR Telefono like '%" + buscar + "%' OR Localidad like '%" + buscar + "%' OR CP like '%" + buscar + "%' OR Provincia like '%" + buscar + "%' OR Tipo_cliente like '%" + buscar + "%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tablaDatos.DataSource = dt;
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Busqueda(textBox1.Text);
        }

        private void refreshdata()
        {

            MySqlConnection con = new MySqlConnection("Server=localhost,3306;Database=agencia_seguros;User Id=admin;Password=admin;");
            MySqlCommand cmd = new MySqlCommand("select * from cliente", con);
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            tablaDatos.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Quieres salir de la aplicación?", "Confirmación", buttons);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tablaDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //Set the Selected Row in Property.
                SelectedRow = tablaDatos.Rows[e.RowIndex];
                poliza.ShowDialog();

            }
        }
    }
}
