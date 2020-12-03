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

        List<Label> labels = new List<Label>();
        // Word under consideration
        public string currentWord { get => currentWord1; set => currentWord1 = value; }         // Default character for hidden word letters
        public string DefaultChar { get { return "__"; } }
        ArrayList coleccion = new ArrayList();
        string resolver = "";
        ArrayList aguiones = new ArrayList();
        ArrayList palabras = new ArrayList();
        int puntos = 0;
        int contador = 8;

        private string usuarioRef;
        private string currentWord1 = "";

        public Pantalla_de_juego(string valor)
        {
            InitializeComponent();
            AddButtons();

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
            label1.Text = "0";
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

        }

        private void metroButton29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void b_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            char charClicked = b.Text.ToCharArray()[0];
            b.Enabled = false;

            if ((resolver = resolver.ToUpper()).Contains(charClicked))
            {

                // char is there (right guess)
                lblInfo.Text = "Has acertado";
                lblInfo.ForeColor = Color.Green;
                char[] charArray = resolver.ToCharArray();
                puntos += 2;
                label1.Text = puntos.ToString();

                for (int i = 0; i < resolver.Length; i++)
                {
                    if (charArray[i] == charClicked)
                        labels[i].Text = charClicked.ToString();

                }

                // Winning condition               
                if (labels.Where(x => x.Text.Equals(DefaultChar)).Any())
                    return;

                lblInfo.ForeColor = Color.Green;
                lblInfo.Text = "Has ganado.";
                flowLayoutPanel1.Enabled = false;
            }
            else
            {
                // Fallo
                if ((!(resolver = resolver.ToUpper()).Contains(charClicked)))
                {

                    contador--;
                    puntos -= 1;
                    label1.Text = puntos.ToString();

                    switch (contador)
                    {

                        case 7:
                            pictureBox1.Image = Image.FromFile("./res/1.jpg");

                            break;
                        case 6:
                            pictureBox1.Image = Image.FromFile("./res/2.jpg");

                            break;
                        case 5:
                            pictureBox1.Image = Image.FromFile("./res/3.jpg");

                            break;
                        case 4:
                            pictureBox1.Image = Image.FromFile("./res/4.jpg");

                            break;
                        case 3:
                            pictureBox1.Image = Image.FromFile("./res/5.jpg");

                            break;
                        case 2:
                            pictureBox1.Image = Image.FromFile("./res/6.jpg");

                            break;
                        case 1:
                            pictureBox1.Image = Image.FromFile("./res/7.jpg");
                            lblInfo.Text = "Has perdido";
                            lblInfo.ForeColor = Color.Red;
                            flowLayoutPanel1.Enabled = false;

                            // Revela la palabra
                            for (int i = 0; i < resolver.Length; i++)
                            {
                                if (labels[i].Text.Equals(DefaultChar))
                                {
                                    labels[i].Text = resolver[i].ToString();
                                    labels[i].ForeColor = Color.Blue;
                                }

                            }

                            break;

                    }
                    pictureBox1.Refresh();
                    lblInfo.Text = "Has fallado";
                    lblInfo.ForeColor = Color.Brown;

                }
            }
        }

        public void AddLabels()
        {
            // Añadir palabra a las etiquetas y las etiquetas al groupbox
            groupBox1.Controls.Clear();
            labels.Clear();
            char[] wordChars = resolver.ToCharArray();
            int len = wordChars.Length;
            int refer = groupBox1.Width / len;
            for (int i = 0; i < len; i++)
            {
                Label l = new Label();
                l.Text = DefaultChar;
                l.Location = new Point(10 + i * refer, groupBox1.Height - 30);
                l.Parent = groupBox1;
                l.BringToFront();
                labels.Add(l);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {


            switch (metroComboBox1.SelectedItem.ToString())
            {
                case "Animales":
                    {

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

                        AddLabels();

                        break;

                    }
                case "Comida":
                    {
                        ArrayList palabras = new ArrayList();

                        XmlDocument xDoc = new XmlDocument();
                        xDoc.Load(Path.GetFullPath("./BBDD.xml"));

                        XmlNodeList xPalabras = xDoc.GetElementsByTagName("wordList");
                        XmlNodeList xCategorias = xDoc.GetElementsByTagName("category");
                        XmlNodeList xPalabra = ((XmlElement)xCategorias[1]).GetElementsByTagName("palabra");
                        foreach (XmlElement nodo in xPalabra)
                        {
                            String palabra = nodo.InnerText;
                            palabras.Add(palabra);
                        }

                        int aleatorio = new Random().Next(palabras.Count); //Creo un numero aletorio entre 0 y el nº de palabras que haya en el array

                        resolver = (String)palabras[aleatorio]; //Elijo una palabra aleatoria del array

                        AddLabels();


                        break;
                    }
                case "Deportes":
                    {
                        ArrayList palabras = new ArrayList();

                        XmlDocument xDoc = new XmlDocument();
                        xDoc.Load(Path.GetFullPath("./BBDD.xml"));

                        XmlNodeList xPalabras = xDoc.GetElementsByTagName("wordList");
                        XmlNodeList xCategorias = xDoc.GetElementsByTagName("category");
                        XmlNodeList xPalabra = ((XmlElement)xCategorias[2]).GetElementsByTagName("palabra");
                        foreach (XmlElement nodo in xPalabra)
                        {
                            String palabra = nodo.InnerText;
                            palabras.Add(palabra);
                        }

                        int aleatorio = new Random().Next(palabras.Count); //Creo un numero aletorio entre 0 y el nº de palabras que haya en el array

                        resolver = (String)palabras[aleatorio]; //Elijo una palabra aleatoria del array


                        AddLabels();
                        break;
                    }
                case "Tecnologia":
                    {
                        ArrayList palabras = new ArrayList();

                        XmlDocument xDoc = new XmlDocument();
                        xDoc.Load(Path.GetFullPath("./BBDD.xml"));

                        XmlNodeList xPalabras = xDoc.GetElementsByTagName("wordList");
                        XmlNodeList xCategorias = xDoc.GetElementsByTagName("category");
                        XmlNodeList xPalabra = ((XmlElement)xCategorias[3]).GetElementsByTagName("palabra");
                        foreach (XmlElement nodo in xPalabra)
                        {
                            String palabra = nodo.InnerText;
                            palabras.Add(palabra);
                        }

                        int aleatorio = new Random().Next(palabras.Count); //Creo un numero aletorio entre 0 y el nº de palabras que haya en el array

                        resolver = (String)palabras[aleatorio]; //Elijo una palabra aleatoria del array

                        AddLabels();
                        break;
                    }
                case "Hardware":
                    {
                        ArrayList palabras = new ArrayList();

                        XmlDocument xDoc = new XmlDocument();
                        xDoc.Load(Path.GetFullPath("./BBDD.xml"));

                        XmlNodeList xPalabras = xDoc.GetElementsByTagName("wordList");
                        XmlNodeList xCategorias = xDoc.GetElementsByTagName("category");
                        XmlNodeList xPalabra = ((XmlElement)xCategorias[4]).GetElementsByTagName("palabra");
                        foreach (XmlElement nodo in xPalabra)
                        {
                            String palabra = nodo.InnerText;
                            palabras.Add(palabra);
                        }

                        int aleatorio = new Random().Next(palabras.Count); //Creo un numero aletorio entre 0 y el nº de palabras que haya en el array

                        resolver = (String)palabras[aleatorio]; //Elijo una palabra aleatoria del array

                        AddLabels();
                        break;
                    }
                case "Informatica":
                    {
                        ArrayList palabras = new ArrayList();

                        XmlDocument xDoc = new XmlDocument();
                        xDoc.Load(Path.GetFullPath("./BBDD.xml"));

                        XmlNodeList xPalabras = xDoc.GetElementsByTagName("wordList");
                        XmlNodeList xCategorias = xDoc.GetElementsByTagName("category");
                        XmlNodeList xPalabra = ((XmlElement)xCategorias[5]).GetElementsByTagName("palabra");
                        foreach (XmlElement nodo in xPalabra)
                        {
                            String palabra = nodo.InnerText;
                            palabras.Add(palabra);
                        }

                        int aleatorio = new Random().Next(palabras.Count); //Creo un numero aletorio entre 0 y el nº de palabras que haya en el array

                        resolver = (String)palabras[aleatorio]; //Elijo una palabra aleatoria del array

                        AddLabels();
                        break;

                    }

            }
        }
        private void AddButtons()
        {
            for (int i = (int)'A'; i <= (int)'Z'; i++)
            {
                Button b = new Button();
                b.Text = ((char)i).ToString();
                b.Parent = flowLayoutPanel1;
                b.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);
                b.Size = new Size(40, 40);
                b.BackColor = Color.LawnGreen;
                b.Click += b_Click; //Cada botón que se haga click llama al evento
            }

        }

        private void ResetControls()
        {
            // Resetting things
            flowLayoutPanel1.Controls.Clear();
            AddButtons();
            lblInfo.Text = "";
            flowLayoutPanel1.Enabled = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            /*string respuesta = "";

            for (int i = 0; i < resolver.Length; i++)
            {
                respuesta = resolver[i].ToString().ToUpper();

             
            }

            if (respuesta.Equals(resolveBox.Text.ToUpper())){

                puntos += 10;

            }*/

            MessageBox.Show("Esta característica todavía no está implementada, siga jugando :)", "Control no implementado"); 
        }

        private void resolveBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
