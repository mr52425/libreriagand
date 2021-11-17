using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectolibreriaOF1
{
    public partial class resgistrar_inventario : Form
    {
        public resgistrar_inventario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resgistrar_inventario_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarform);      //Cierra formulario
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            consultarcliente f2 = new consultarcliente();
            f2.Show();
        }

        private void consultarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void solicitarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            solicitarlibro f2 = new solicitarlibro();
            f2.Show();
        }

        private void editarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            editarlibros f2 = new editarlibros();
            f2.Show();
        }

        private void cerrarform(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
