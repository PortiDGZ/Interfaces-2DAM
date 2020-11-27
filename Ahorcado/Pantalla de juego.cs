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
using System.IO;
using System.Collections;

namespace Ahorcado
{
    public partial class Pantalla_de_juego : Form
    {
        string resolver = "";

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

            document.Load(Path.GetFullPath("./BBDD.xml"));

            XmlNodeList xPalabras = document.GetElementsByTagName("wordList");
            XmlNodeList xLista = ((XmlElement)xPalabras[0]).GetElementsByTagName("category");
            foreach (XmlElement nodo in xLista)
            {
                String categoria = nodo.GetAttribute("cat");
                metroComboBox1.Items.Add(categoria);
            }

            char[] teclado = { 'Q', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };

            for (int i = (int)'A'; i <= (int)'Z'; i++)
            {
                Button b = new Button();
                b.Text = ((char)i).ToString();
                b.Parent = flowLayoutPanel1;
                b.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);
                b.Size = new Size(40, 40);
                b.BackColor = Color.LawnGreen;
                b.Click += Pantalla_de_juego_Load; // Event hook-up
            }



        }

        private void metroButton29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cat = metroComboBox1.Text;
            
            switch (cat) {
                case "Animales":
                    ArrayList palabras = new ArrayList();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path.GetFullPath("./BBDD.xml"));

            XmlNodeList xPalabras = xDoc.GetElementsByTagName("wordList");
            XmlNodeList xCategorias = xDoc.GetElementsByTagName("category");
            XmlNodeList xPalabra = ((XmlElement)xCategorias[0]).GetElementsByTagName("palabra");
            foreach (XmlElement nodo in xPalabra)
            {
                String palabra = nodo.InnerText;
                palabras.Add(palabra);
            }

            int aleatorio = new Random().Next(palabras.Count); //Creo un numero aletorio entre 0 y el nº de palabras que haya en el array

             resolver = (String)palabras[aleatorio]; //Elijo una palabra aleatoria del array
                    break;


        }
            
        }

        }
    }
    
