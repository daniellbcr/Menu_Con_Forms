using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_11
{
    public partial class Medicos : Form
    {

        List<string> ReginstroMed = new List<string>();
        string cedula;
        String cedulaEliminar;
        
        int contador = 1;

        public Medicos()
        {
            InitializeComponent();
        }

        public void Label3_Click(object sender, EventArgs e)
        {

        }
                       
        public void Button1_Click(object sender, EventArgs e)
        {
            string Cedula = textBox1.Text;
            string Nombre = textBox2.Text;
            string Apellido = textBox3.Text;
            string Especialidad = textBox4.Text;

            ReginstroMed.Add(Cedula + "|" + Nombre + "|" + Apellido + "|" + Especialidad);

            MessageBox.Show("La cedula registrada es: " + Cedula + "\n Nombre registrado es: " + Nombre + "\n Apellido registrado es: " + Apellido + "\n Especialidad registrada es:" + Especialidad);  
            
        }
        
        public void TextBox5_TextChanged(object sender, EventArgs e)
        {
            // cedula a buscar
            cedula = textBox5.Text;
                        
        }        
            public void Button2_Click(object sender, EventArgs e)
            {
            // boton cedula a buscare
                foreach (var _var in ReginstroMed)
                {
                if(_var.Split('|')[0] == cedula)
                {
                    string cuenta = (_var.Split('|')[0] = cedula);

                    MessageBox.Show("Los Datos de Medico son\n" +
                        "Cedula: " + _var.Split('|')[0] +
                        "\nNombre: " + _var.Split('|')[1] +
                        "\nApellido: " + _var.Split('|')[2] +
                        "\nEspecialidad: " + _var.Split('|')[3]);

                }
               
                }

            }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            // borrar medico   cedula
            cedulaEliminar = textBox6.Text;
        }
        
        
        
        private void Button3_Click(object sender, EventArgs e)
        {
            // boton para borrar medico
            int opcion = 0;
                                  
           
                while (opcion == 0)
            {
                contador = 0;
                               
                foreach (var eliminar in ReginstroMed)
                {
                    while (eliminar.Split('|')[0] == cedulaEliminar)
                    {
                        ReginstroMed.RemoveAll(c => c.Equals(cedulaEliminar));
                        contador--;
                        MessageBox.Show("El medico se elimino con exito");

                            cedulaEliminar = " ";
                    }
                    contador++;
                }
                opcion = 1;
            }




        }
    }
}
