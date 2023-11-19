using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerasolucion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("que me apretas gato atrevido bigoton de chele");
            string texto = txtNombre.Text;
            label2.Text = "EL GAUCHO " + texto;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            string elem = cajatxtDOS.Text;
            lwUNO.Items.Add(elem);
        }
    }
}
