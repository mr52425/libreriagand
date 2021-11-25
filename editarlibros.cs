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
            this.FormClosed += new FormClosedEventHandler(cerrarform);      //Cierra formulario
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

        private void cerrarform(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void lbl_fecha_Click(object sender, EventArgs e)
        {

        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
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
                MessageBox.Show("¡Regsitro guardado con éxito!", "Mensaje de Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("¡Por favor digite los valores que se piden!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtautor.Text == "")
                {
                    MessageBox.Show("¡Por favor digite el nombre del autor!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtgenero.Text == "")
                {
                    MessageBox.Show("¡Por favor digite el genero del libro!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txteditorial.Text == "")
                {
                    MessageBox.Show("¡Por favor digite el nombre de la editorial del libro!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtedicion.Text == "")
                {
                    MessageBox.Show("¡Por favor digite el número de la edición del libro!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtaño.Text == "")
                {
                    MessageBox.Show("¡Por favor digite el año del libro!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtidioma.Text == "")
                {
                    MessageBox.Show("¡Por favor digite el idioma del libro!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtpaginas.Text == "")
                {
                    MessageBox.Show("¡Por favor digite el número de páginas del libro!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtprecio.Text == "")
                {
                    MessageBox.Show("¡Por favor digite el precio del libro!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtsipnosis.Text == "")
                {
                    MessageBox.Show("¡Por favor digite la sipnosis del libro!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtnombre.Text = txtautor.Text = txtgenero.Text = txteditorial.Text = txtedicion.Text = txtaño.Text = txtidioma.Text = txtpaginas.Text = txtprecio.Text = txtsipnosis.Text = txtbuscar.Text = "";
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
                MessageBox.Show("Error: " + ex.Message + ".", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de eliminar este registro?", "Mensaje de Advertencia.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                using (libreriagandEntities1 DB = new libreriagandEntities1())
                {
                    var entry = DB.Entry(modelo);
                    if (entry.State == EntityState.Detached)
                        DB.libro.Attach(modelo);
                    DB.libro.Remove(modelo);
                    DB.SaveChanges();
                    clear();
                    llenarGrid();
                    MessageBox.Show("¡Se eliminó correctamente!", "Mensaje de Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
            {
                MessageBox.Show("¡No se eliminó el contenido!", "Mensaje de Cancelación.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 keyword = int.Parse(txtbuscar.Text.Trim());
                using (libreriagandEntities1 DB = new libreriagandEntities1())
                {
                    dgv_editarlibros.DataSource = DB.libro.Where(y => y.id_libro.Equals(keyword)).ToList();
                }
                clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("¡Por favor digite el valor que se pide!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
