using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoPractico3
{
    public partial class Form1 : Form
    {

        // inicializando el entorno
        string fuente = "Verdana";


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbNombre.Font = new Font("Verdana", 12, FontStyle.Bold);
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            
        }
                
        private void numUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }
                
        
        private void rbtnVerdana_Click(object sender, EventArgs e)
        {
            tbNombre.Font = new Font("Verdana", 12, FontStyle.Regular);
            fuente = "Verdana";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            tbNombre.Font = new Font("Tahoma", 12, FontStyle.Regular);
            fuente = "Tahoma";
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            tbNombre.Font = new Font("Mistral", 12, FontStyle.Regular);
            fuente = "Mistral";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            tbNombre.ForeColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            tbNombre.ForeColor = Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            tbNombre.ForeColor = Color.Blue;
        }
    }
}
