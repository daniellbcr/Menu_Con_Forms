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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MedicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           


        }

        private void ModuloDeMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicos nuevo = new Medicos();
            
            nuevo.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Medicos nuevo = new Medicos();
            nuevo.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Pacientes nuevo = new Pacientes();
            nuevo.Show();
        }
    }
}
