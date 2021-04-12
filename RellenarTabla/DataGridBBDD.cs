using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace RellenarTabla
{
    public partial class DataGridBBDD : Form
    {
        Alta Alta = new Alta();
        public DataGridBBDD()
        {
            InitializeComponent();
        }


        private void DataGridBBDD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'interfacesDataSet1.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.interfacesDataSet1.alumnos);

        }

        private void alta_btn_Click(object sender, EventArgs e)
        {
            Alta.ShowDialog();
            if (Alta.DialogResult == DialogResult.OK)
            {
                string path = "Server=localhost,3307;Database=interfaces;User Id=root;Password=root;";

                MySqlConnection conn = new MySqlConnection(path);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.ConnectionString = path;
                    conn.Open();
                }

                string dni = Alta.dni_txt.Text; 
                string nombre = Alta.name_txt.Text;
                string apellidos = Alta.ape_txt.Text;
                string curso = Alta.curso_txt.Text;
                string telefono = Alta.tlf_txt.Text;
                string provincia = Alta.prov_txt.Text;
                string poblacion = Alta.pob_txt.Text;
                string query = $"INSERT INTO alumnos (dni, nombre, apellidos, curso, telefono, provincia, poblacion) VALUES({dni}, {nombre}, {apellidos}, {curso}, {telefono}, {provincia}, {poblacion})";

                //Creamos la conexión 

                MySqlCommand cmd = new MySqlCommand(query, conn);
                    
                    //Ejecutamos la query
                    cmd.ExecuteNonQuery();


                
                //Cerramos la conexión al terminar el foreach
                conn.Close();
            }
        }

    }
}


//Recorremos con un foreach cada fila del datagridview
/*foreach (DataGridViewRow row in tablaDatos.Rows)
{
    //Asignamos los valores obtenidos del datagridview
    dni = row.Cells[0].Value.ToString();
    nombre = row.Cells[1].Value.ToString();
    apellidos = row.Cells[2].Value.ToString();
    curso = row.Cells[3].Value.ToString();
    telefono = row.Cells[4].Value.ToString();
    provincia = row.Cells[5].Value.ToString();
    poblacion = row.Cells[6].Value.ToString();
*/