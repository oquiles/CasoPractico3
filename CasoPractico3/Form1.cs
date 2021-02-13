using System;
using System.Drawing;
using System.Windows.Forms;

namespace CasoPractico3
{
    public partial class Form1 : Form
    {
        // inicializando el entorno
        string fuente = "Verdana";
        float fontSize = 12;
        FontStyle estilo = FontStyle.Regular;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbNombre.Font = new Font(fuente, fontSize, estilo);
            
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void numUpDown_ValueChanged(object sender, EventArgs e)
        {
            fontSize = (float)numUpDown.Value;
            tbNombre.Font = new Font(fuente, fontSize, estilo);

        }


        private void rbtnVerdana_Click(object sender, EventArgs e)
        {
            fuente = "Verdana";
            tbNombre.Font = new Font(fuente, fontSize, estilo);
            
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            fuente = "Tahoma";
            tbNombre.Font = new Font(fuente, fontSize, estilo);
            
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            fuente = "Mistral";
            tbNombre.Font = new Font(fuente, fontSize, estilo);
            
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_Click_1(object sender, EventArgs e)
        {
            // Italic
            if (checkBox1.Checked == true)
            {
                estilo = FontStyle.Italic;
                tbNombre.Font = new Font(fuente, fontSize, estilo);

            }
            else
            {
                estilo = FontStyle.Regular;
                tbNombre.Font = new Font(fuente, fontSize, estilo);

            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            // Bold
            if (checkBox2.Checked == true)
            {
                estilo = FontStyle.Bold;
                tbNombre.Font = new Font(fuente, fontSize, estilo);
            }
            else
            {
                estilo = FontStyle.Regular;
                tbNombre.Font = new Font(fuente, fontSize, estilo);

            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            // Underline
            if (checkBox3.Checked == true)
            {

                estilo = FontStyle.Underline;
                tbNombre.Font = new Font(fuente, fontSize, estilo);
            }
            else
            {
                estilo = FontStyle.Regular;
                tbNombre.Font = new Font(fuente, fontSize, estilo);

            }
        }
    }
}
