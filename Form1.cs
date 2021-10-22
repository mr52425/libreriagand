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
            // TODO: esta línea de código carga datos en la tabla 'libreriagandtablas.inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.libreriagandtablas.inventario);

        }
    }
}
