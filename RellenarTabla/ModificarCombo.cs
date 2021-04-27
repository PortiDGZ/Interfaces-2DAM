using MySql.Data.MySqlClient;
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
    public partial class ModificarCombo : Form
    {
        public ModificarCombo()
        {
            InitializeComponent();
        }

        private void cbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=interfaces;User Id=root;Password=root;");

            MySqlDataAdapter da2 = new MySqlDataAdapter($"SELECT * FROM municipios where provincia = {cbProv.SelectedValue.ToString()}", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbPob.DisplayMember = "municipio";
            cbPob.ValueMember = "id";
            cbPob.DataSource = dt2;


        }

        private void ModificarCombo_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=interfaces;User Id=root;Password=root;");

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM provincias", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbProv.DataSource = dt;
            string cb_Prov = cbProv.Text.ToString();
           
        }
    }
}
