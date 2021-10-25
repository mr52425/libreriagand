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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libreriagandtablas);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'libreriagandtablas.ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.libreriagandtablas.ventas);
            // TODO: esta línea de código carga datos en la tabla 'libreriagandtablas.inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.libreriagandtablas.inventario);

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            consultarcliente f2 = new consultarcliente();
            f2.Show();
        }

        private void editarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            editarlibros f2 = new editarlibros();
            f2.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void solicitarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            solicitarlibro f2 = new solicitarlibro();
            f2.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            resgistrar_inventario f2 = new resgistrar_inventario();
            f2.Show();
        }

        private void inventarioBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
