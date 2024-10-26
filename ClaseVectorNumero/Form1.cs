using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examensb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vector v1, v2, v3;
        NEnt n1;

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
            n1 = new NEnt();
        }

        private void cargarRndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void cargarRndToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void cargarManualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.Descargar();
        }

        private void cargarRndToolStripMenuItem2_Click(object sender, EventArgs e)
        {
    
        }

        private void cargarManualToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void mENUV3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eJERCICIO1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void eJERCICIO2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
