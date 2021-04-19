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
    public partial class AltaCombo : Form
    {
        public AltaCombo()
        {
            InitializeComponent();
        }


        private void AltaCombo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'interfacesDataSet1.municipios' Puede moverla o quitarla según sea necesario.
            this.municipiosTableAdapter.Fill(this.interfacesDataSet1.municipios);
            // TODO: esta línea de código carga datos en la tabla 'interfacesDataSet1.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.interfacesDataSet1.provincias);
            MySqlConnection conn = new MySqlConnection("Server=localhost,3306;Database=interfaces;User Id=root;Password=root;");
        
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

    }
}
