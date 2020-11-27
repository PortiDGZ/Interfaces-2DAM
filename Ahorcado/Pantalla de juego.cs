using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MetroFramework.Controls;


namespace Ahorcado
{
    public partial class Pantalla_de_juego : Form
    {

        private string usuarioRef;
        public Pantalla_de_juego(string valor)
        {
            InitializeComponent();

            this.usuarioRef = valor;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            MetroTile clickedTile = (MetroTile)sender;
        }

        

        private void virtualKeyboard1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            MetroTile clickedTile = (MetroTile)sender;

            Console.WriteLine(clickedTile.Text);
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Pantalla_de_juego_Load(object sender, EventArgs e)
        {
            metroLabel1.Text = usuarioRef;

            XmlDocument document = new XmlDocument();

            document.Load("/res/BBDD.xml");

            string[] animales = { document.SelectSingleNode("wordList/category").Attributes["an"].Value };
            string[] Comida = { document.SelectSingleNode("wordList/category").Attributes["comi"].Value };
            string[] Deportes = { document.SelectSingleNode("wordList/category").Attributes["dep"].Value };
            string[] Tecnologia = { document.SelectSingleNode("wordList/category").Attributes["tec"].Value };
            string[] Hardware = { document.SelectSingleNode("wordList/category").Attributes["com"].Value };
            string[] Informatica = { document.SelectSingleNode("wordList/category").Attributes["inf"].Value };
        }

        private void metroButton29_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }
