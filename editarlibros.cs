using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace proyectolibreriaOF1
{
    public partial class editarlibros : Form
    {
        libro modelo = new libro();
        public editarlibros()
        {
            InitializeComponent();
        }

        private void editarlibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'libreriagandtablas.libro' Puede moverla o quitarla según sea necesario.
            this.libroTableAdapter.Fill(this.libreriagandtablas.libro);
            llenarGrid();
            clear();
            this.ActiveControl = txtnombre;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                modelo.nom_libro = txtnombre.Text.Trim();
                modelo.autor = txtautor.Text.Trim();
                modelo.genero = txtgenero.Text.Trim();
                modelo.editorial = txteditorial.Text.Trim();
                modelo.edicion = txtedicion.Text.Trim();
                modelo.año = int.Parse(txtaño.Text.Trim());
                modelo.idioma = txtidioma.Text.Trim();
                modelo.paginas = int.Parse(txtpaginas.Text.Trim());
                modelo.precio = decimal.Parse(txtprecio.Text.Trim());
                modelo.sipnosis = txtsipnosis.Text.Trim();
                if (string.IsNullOrWhiteSpace(txtnombre.Text))
                {
                    MessageBox.Show("¡Por favor digite el nombre del libro!", "Mensaje de Advertencia.");
                }
                if (txtautor.Text == " ")
                {
                    MessageBox.Show("¡Por favor digite el nombre del autor!");
                }
                if (txtgenero.Text == " ")
                {
                    MessageBox.Show("¡Por favor digite el genero del libro!");
                }
                if (txteditorial.Text == " ")
                {
                    MessageBox.Show("¡Por favor digite el nombre de la editorial del libro!");
                }
                if (txtedicion.Text == " ")
                {
                    MessageBox.Show("¡Por favor digite el número de la edición del libro!");
                }
                if (txtaño.Text == " ")
                {
                    MessageBox.Show("¡Por favor digite el año del libro!");
                }
                if (txtidioma.Text == " ")
                {
                    MessageBox.Show("¡Por favor digite el idioma del libro!");
                }
                if (txtpaginas.Text == " ")
                {
                    MessageBox.Show("¡Por favor digite el número de páginas del libro!");
                }
                if (txtprecio.Text == " ")
                {
                    MessageBox.Show("¡Por favor digite el precio del libro!");
                }
                if (txtsipnosis.Text == " ")
                {
                    MessageBox.Show("¡Por favor digite la sipnosis del libro!");
                }
                else
                {
                    using (libreriagandEntities1 DB = new libreriagandEntities1())
                    {
                        if (modelo.id_libro == 0)//insertar
                            DB.libro.Add(modelo);
                        else //modificar
                            DB.Entry(modelo).State = EntityState.Modified;
                        DB.SaveChanges();
                    }
                    clear();
                    llenarGrid();
                    MessageBox.Show("¡Regsitro guardado con exito!", "Mensaje de Confirmación.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtnombre.Text = txtautor.Text = txtgenero.Text = txteditorial.Text = txtedicion.Text = txtaño.Text = txtidioma.Text = txtpaginas.Text = txtprecio.Text = txtsipnosis.Text = "";
            btn_guardar.Text = "Guardar";
            btn_eliminar.Enabled = false;
            modelo.id_libro = 0;
        }

        void llenarGrid()
        {
            dgv_editarlibros.AutoGenerateColumns = false;
            using (libreriagandEntities1 DB = new libreriagandEntities1())
            {
                dgv_editarlibros.DataSource = DB.libro.ToList<libro>();
            }
        }

        private void dgv_editarlibros_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                modelo.id_libro = Convert.ToInt32(dgv_editarlibros.CurrentRow.Cells["idlibroDataGridViewTextBoxColumn"].Value);
                using (libreriagandEntities1 DB = new libreriagandEntities1())
                {
                    modelo = DB.libro.Where(x => x.id_libro == modelo.id_libro).FirstOrDefault();
                    txtnombre.Text = modelo.nom_libro;
                    txtautor.Text = modelo.autor;
                    txtgenero.Text = modelo.genero;
                    txteditorial.Text = modelo.editorial;
                    txtedicion.Text = modelo.edicion;
                    txtaño.Text = Convert.ToString(modelo.año);
                    txtidioma.Text = modelo.idioma;
                    txtpaginas.Text = Convert.ToString(modelo.paginas);
                    txtprecio.Text = Convert.ToString(modelo.precio);
                    txtsipnosis.Text = modelo.sipnosis;
                }
                btn_guardar.Text = "Modificar";
                btn_eliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de eliminar este registro?", "Mensaje de Advertencia.",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (libreriagandEntities1 DB = new libreriagandEntities1())
                {
                    var entry = DB.Entry(modelo);
                    if (entry.State == EntityState.Detached)
                        DB.libro.Attach(modelo);
                    DB.libro.Remove(modelo);
                    DB.SaveChanges();
                    clear();
                    llenarGrid();
                    MessageBox.Show("¡Se elimino correctamente!", "Mensaje de Confirmación.");
                }
            MessageBox.Show("¡No se elimino el contenido!", "Mensaje de Cancelación.");
        }
    }
}
