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
    public partial class consultarcliente : Form
    {
        public consultarcliente()
        {
            InitializeComponent();
        }

        private void consultarcliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'libreriagandtablas.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.libreriagandtablas.cliente);
            this.FormClosed += new FormClosedEventHandler(cerrarform);      //Cierra formulario
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libreriagandtablas);

        }

        private void consultarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void editarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            editarlibros f2 = new editarlibros();
            f2.Show();
        }

        private void solicitarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            solicitarlibro f2 = new solicitarlibro();
            f2.Show();
        }

        private void registrarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            resgistrar_inventario f2 = new resgistrar_inventario();
            f2.Show();
        }

        private void cerrarform(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
