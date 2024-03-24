using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRP_2
{
    public partial class Principal : Form
    {
        private MenuR menu;
      
        public Principal()
        {

            InitializeComponent();

            menu = CargarMenu();
            
            establecerComboboxConMenu();
            cargarListBox();

            // Crear una lista de personas (solo como ejemplo)
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 25, CorreoElectronico = "juan@example.com" },
                new Persona { Nombre = "María", Edad = 30, CorreoElectronico = "maria@example.com" }
                // Puedes agregar más personas aquí según sea necesario
            };

            // Asignar la lista de personas al DataGridView
            RegistroPedidos.DataSource = personas;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string CorreoElectronico { get; set; }
            // Puedes agregar más propiedades según sea necesario
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }



        private void registrarSopa_Click(object sender, EventArgs e)
        {

            string n = nSopa.Text;
            double p;
            if (double.TryParse(pSopa.Text, out p))
            {
                this.menu.Sopas.Add(n, p);
                string sopa = n + " " + p.ToString();
                ListaSopas.Items.Add(sopa);
            }
            else
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void eliminarSopas_Click(object sender, EventArgs e)
        {
            ListaSopas.Items.Clear();
            this.menu.Sopas.Clear();
        }

        private void eliminarElemento_Opening(object sender, CancelEventArgs e)
        {

        }

        private void registrarSegundo_Click(object sender, EventArgs e)
        {

            string n = nSegundos.Text;
            double p;
            if (double.TryParse(pSegundo.Text, out p))
            {

                string seg = n + " " + p.ToString();
                listaSegundos.Items.Add(seg);
                this.menu.Segundos.Add(n, p);
            }
            else
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void eliminarSegundos_Click(object sender, EventArgs e)
        {
            listaSegundos.Items.Clear();
            this.menu.Segundos.Clear();
        }

        private void registrarPostre_Click(object sender, EventArgs e)
        {
            string n = nPostre.Text;
            double p;
            if (double.TryParse(pPostre.Text, out p))
            {

                string postre = n + " " + p.ToString();
                listaPostres.Items.Add(postre);
                this.menu.Postres.Add(n, p);
            }
            else
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarPostre_Click(object sender, EventArgs e)
        {
            listaPostres.Items.Clear();
            this.menu.Postres.Clear();
        }

        private void registrarBebida_Click(object sender, EventArgs e)
        {
            string n = nBebida.Text;
            double p;
            if (double.TryParse(pBebidas.Text, out p))
            {

                string bebida = n + " " + p.ToString();
                listaBebidas.Items.Add(bebida);
                this.menu.Bebidas.Add(n, p);
            }
            else
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarListaBebidas_Click(object sender, EventArgs e)
        {
            listaBebidas.Items.Clear();
            this.menu.Bebidas.Clear();
        }

        private void registrarEspeciales_Click(object sender, EventArgs e)
        {
            string n = nEspeciales.Text;
            double p;
            if (double.TryParse(pEspeciales.Text, out p))
            {

                string especial = n + " " + p.ToString();
                listaEspeciales.Items.Add(especial);
                this.menu.Especiales.Add(n, p);
            }
            else
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarListaEsp_Click(object sender, EventArgs e)
        {
            listaEspeciales.Items.Clear();
            this.menu.Especiales.Clear();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            limpiarComboBoxes();
            establecerComboboxConMenu();
            guardarMenu();
        }

        public void limpiarComboBoxes()
        {
            lSopas.Items.Clear();
            lSegundos.Items.Clear();
            lBebidas.Items.Clear();
            tipoPedido.Items.Clear();
            lPostres.Items.Clear();    
        }
        public void establecerComboboxConMenu() {
            List<string> sopas = new List<string>(this.menu.Sopas.Keys);
            lSopas.Items.AddRange(sopas.ToArray());

            List<string> segundos = new List<string>(this.menu.Segundos.Keys);
            lSegundos.Items.AddRange(segundos.ToArray());

            List<string> postres = new List<string>(this.menu.Postres.Keys);
            lPostres.Items.AddRange(postres.ToArray());

            List<string> bebidas = new List<string>(this.menu.Bebidas.Keys);
            lBebidas.Items.AddRange(bebidas.ToArray());

            List<string> especiales = new List<string>(this.menu.Especiales.Keys);
            tipoPedido.Items.AddRange(especiales.ToArray());
        }
        public void cargarListBox() {
            ReEstablecerListasBox(this.menu.Sopas, ListaSopas);
            ReEstablecerListasBox(this.menu.Segundos, listaSegundos);
            ReEstablecerListasBox(this.menu.Postres, listaPostres);
            ReEstablecerListasBox(this.menu.Especiales, listaEspeciales);
            ReEstablecerListasBox(this.menu.Bebidas, listaBebidas);
        }
        public void ReEstablecerListasBox(Dictionary <string, double> dic, ListBox a) {
            foreach (var palabra in dic)
            {
                a.Items.Add($"{palabra.Key} {palabra.Value}");
            }
        }
        public void guardarMenu()
        {
         
            using (FileStream fs = new FileStream("menu.dat", FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this.menu);
            }
        } 


        private MenuR CargarMenu() {
            try
            {
                MenuR menu = new MenuR();
                if (File.Exists("menu.dat"))
                {
                    using (FileStream fs = new FileStream("menu.dat", FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        menu = (MenuR)formatter.Deserialize(fs);
                    }
                }
                return menu;
            }
            catch(Exception ex) {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new MenuR();
        }
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Console.WriteLine("");
        }

        private void Registrar_Click(object sender, EventArgs e)
        {

        }

        
        private void addElem_Click(object sender, EventArgs e)
        {
        
        }

        private void RegistroPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }

}
