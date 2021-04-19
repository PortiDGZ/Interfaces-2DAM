using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace RellenarTabla
{
    public partial class DataGridBBDD : Form
    {
        Alta Alta = new Alta();
        modificar modificar = new modificar();
        AltaCombo AltaCombo = new AltaCombo();
        ModificarCombo ModificarCombo = new ModificarCombo();
        public DataGridBBDD()
        {
            InitializeComponent();
        }

        private void refreshdata()
        {

            MySqlConnection con = new MySqlConnection("Server=localhost,3306;Database=interfaces;User Id=root;Password=root;");
            MySqlCommand cmd = new MySqlCommand("select * from alumnos", con);
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            tablaDatos.DataSource = dt;
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
                string path = "Server=localhost,3306;Database=interfaces;User Id=root;Password=root;";
                string dni = Alta.dni_txt.Text;
                string nombre = Alta.name_txt.Text;
                string apellidos = Alta.ape_txt.Text;
                string curso = Alta.curso_txt.Text;
                string telefono = Alta.tlf_txt.Text;
                string provincia = Alta.prov_txt.Text;
                string poblacion = Alta.pob_txt.Text;
                string query = $"INSERT INTO alumnos (dni, nombre, apellidos, curso, telefono, provincia, poblacion) VALUES('{dni}', '{nombre}', '{apellidos}', '{curso}', '{telefono}', '{provincia}', '{poblacion}')";
                MySqlConnection conn = new MySqlConnection(path);
                do
                {
                    
                    

                } while (String.IsNullOrEmpty(dni) || String.IsNullOrWhiteSpace(dni));
       


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
                Alta.curso_txt.Clear();
                Alta.tlf_txt.Clear();
                Alta.prov_txt.Clear();
                Alta.pob_txt.Clear();
            }
        }

        private void baja_btn_Click(object sender, EventArgs e)
        {
            int rowId = tablaDatos.CurrentRow.Index;
            DataGridViewRow row = tablaDatos.Rows[rowId];
            string pk = row.Cells[0].Value.ToString();
            string path = "Server=localhost,3306;Database=interfaces;User Id=root;Password=root;";
            string query = $"DELETE FROM ALUMNOS WHERE dni = '{pk}'";
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

                //Combo Box
                ModificarCombo.dni_txt.Text = row.Cells[0].Value.ToString();
                ModificarCombo.name_txt.Text = row.Cells[1].Value.ToString();
                ModificarCombo.ape_txt.Text = row.Cells[2].Value.ToString();
                ModificarCombo.curso_txt.Text = row.Cells[3].Value.ToString();
                ModificarCombo.tlf_txt.Text = row.Cells[4].Value.ToString();
                ModificarCombo.cbProv.Text = row.Cells[5].Value.ToString();
                ModificarCombo.cbPob.Text = row.Cells[6].Value.ToString();
            }
        }

        private void mod_btn_Click(object sender, EventArgs e)
        {
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
            {
                string path = "Server=localhost,3306;Database=interfaces;User Id=root;Password=root;";
                string dni = modificar.dni_txt.Text;
                string nombre = modificar.name_txt.Text;
                string apellidos = modificar.ape_txt.Text;
                string curso = modificar.curso_txt.Text;
                string telefono = modificar.tlf_txt.Text;
                string provincia = modificar.prov_txt.Text;
                string poblacion = modificar.pob_txt.Text;
                int rowId = tablaDatos.CurrentRow.Index;
                DataGridViewRow row = tablaDatos.Rows[rowId];
                string pk = row.Cells[0].Value.ToString();
                string query = $"UPDATE alumnos SET dni = '{dni}', nombre = '{nombre}', apellidos = '{apellidos}', curso = '{curso}', telefono = '{telefono}', provincia = '{provincia}', poblacion = '{poblacion}' WHERE dni = '{pk}'";
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

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaCombo.ShowDialog();
            if (AltaCombo.DialogResult == DialogResult.OK)
            {
                string path = "Server=localhost,3306;Database=interfaces;User Id=root;Password=root;";
                string dni = AltaCombo.dni_txt.Text;
                string nombre = AltaCombo.name_txt.Text;
                string apellidos = AltaCombo.ape_txt.Text;
                string curso = AltaCombo.curso_txt.Text;
                string telefono = AltaCombo.tlf_txt.Text;
                string provincia = AltaCombo.cbProv.Text;
                string poblacion = AltaCombo.cbPob.Text;
                string query = $"INSERT INTO alumnos (dni, nombre, apellidos, curso, telefono, provincia, poblacion) VALUES('{dni}', '{nombre}', '{apellidos}', '{curso}', '{telefono}', '{provincia}', '{poblacion}')";
                MySqlConnection conn = new MySqlConnection(path);
                do
                {



                } while (String.IsNullOrEmpty(dni) || String.IsNullOrWhiteSpace(dni));



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
                AltaCombo.dni_txt.Clear();
                AltaCombo.name_txt.Clear();
                AltaCombo.ape_txt.Clear();
                AltaCombo.curso_txt.Clear();
                AltaCombo.tlf_txt.Clear();
                AltaCombo.cbProv.Items.Clear();
                AltaCombo.cbPob.Items.Clear();
            }
        }

        private void modcb_btn_Click(object sender, EventArgs e)
        {
            ModificarCombo.ShowDialog();
            if (ModificarCombo.DialogResult == DialogResult.OK)
            {
                string path = "Server=localhost,3306;Database=interfaces;User Id=root;Password=root;";
                string dni = ModificarCombo.dni_txt.Text;
                string nombre = ModificarCombo.name_txt.Text;
                string apellidos = ModificarCombo.ape_txt.Text;
                string curso = ModificarCombo.curso_txt.Text;
                string telefono = ModificarCombo.tlf_txt.Text;
                string provincia = ModificarCombo.cbProv.Text;
                string poblacion = ModificarCombo.cbPob.Text;
                int rowId = tablaDatos.CurrentRow.Index;
                DataGridViewRow row = tablaDatos.Rows[rowId];
                string pk = row.Cells[0].Value.ToString();
                string query = $"UPDATE alumnos SET dni = '{dni}', nombre = '{nombre}', apellidos = '{apellidos}', curso = '{curso}', telefono = '{telefono}', provincia = '{provincia}', poblacion = '{poblacion}' WHERE dni = '{pk}'";
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

            }
        }
    }
    }