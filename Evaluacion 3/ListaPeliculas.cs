using Evaluacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_3
{
    public partial class ListaPeliculas : Form
    {
        private List<Pelicula> ListaPelis = new List<Pelicula>();

        private Pelicula peli = new Pelicula();

        private Label lista;

        private Button btnEliminar;
        public ListaPeliculas()
        {
            InitializeComponent();
            borrar();
            InitializeLabel();

        }

        private void InitializeLabel()
        {
            lista = new Label();
            lista.Text = "";
            lista.Visible = true;

            lista.AutoSize = true;
            lista.Location = new Point(10, 250);
            this.Controls.Add(lista);
            cbPuntaje.SelectedIndex = 0;
        }

        public void Cargar(string nombre, string director, string anio, CheckedListBox genero, ComboBox puntaje)
        {
            peli.Nombre = nombre.Trim().ToUpper();
            peli.Director = director.Trim().ToUpper();
            peli.Anio = anio;
            peli.Generos = genero.Items.ToString();
            peli.Puntaje = puntaje.SelectedItem.ToString();
        }
        private void btCargar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtNombre.Text))
                || (string.IsNullOrEmpty(txtDirector.Text)))
            {
                MessageBox.Show("Debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            } Cargar(txtNombre.Text.Trim().ToUpper(), txtDirector.Text.Trim().ToUpper(), txtAnio.Text, clbGeneros, cbPuntaje);

            string gnr = "";
 

            foreach (string s in clbGeneros.CheckedItems)
            {
                gnr = gnr + s + ", ";


            }



            ListaPelis.Add(peli);






                if (lista.Width >= (this.Width - 20))
                {
                    MessageBox.Show("Ya no hay más espacio en el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



                lista.Text = lista.Text + 
                "\n" + "Nombre: " + peli.Nombre + 
                "    -    " + "Director: " + peli.Director + 
                "    -    " + "Año de Estreno: " + peli.Anio + 
                "    -    " + "Géneros: " + gnr +
                "    -    " + "Puntaje: " + peli.Puntaje;

                lista.Show();

            
        }
    


        private void borrar()
        {
            btnEliminar = new Button();
            btnEliminar.Text = "Eliminar Todo";
            btnEliminar.Location = new Point(200, 171);
            btnEliminar.Click += BtnEliminar_Click;
            this.Controls.Add(btnEliminar);

        }

 
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtNombre.Text)) || (string.IsNullOrEmpty(txtDirector.Text)))
            {
                MessageBox.Show("No hay ninguan película cargada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            
            this.Controls.Remove(lista);
    
            this.Refresh();

        }


    }   
        
}