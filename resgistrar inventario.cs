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
   
    public partial class resgistrar_inventario : Form
    {
        inventario modelo = new inventario();
        public resgistrar_inventario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resgistrar_inventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libreriagandtablas.inventario' table. You can move, or remove it, as needed.
            this.inventarioTableAdapter.Fill(this.libreriagandtablas.inventario);
            llenarGrid();
            clear();
            this.ActiveControl = textBox_idinventario;
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

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de eliminar este registro?", "Mensaje de Advertencia.",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (libreriagandEntities1 DB = new libreriagandEntities1())
                {
                    var entry = DB.Entry(modelo);
                    if (entry.State == EntityState.Detached)
                        DB.inventario.Attach(modelo);
                    DB.inventario.Remove(modelo);
                    DB.SaveChanges();
                    clear();
                    llenarGrid();
                    MessageBox.Show("¡Se eliminó correctamente!", "Mensaje de Confirmación.");
                }
            else
            {
                MessageBox.Show("¡No se eliminó el contenido!", "Mensaje de Cancelación.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GridView_registrar_inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void id_libro_Click(object sender, EventArgs e)
        {

        }

        private void textBox_idinventario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                modelo.id_libro = int.Parse(box_idlibro.Text.Trim());
                modelo.cantidad = int.Parse(box_cantidad.Text.Trim());
              
                
                if (id_libro.Text == "")
                {
                    MessageBox.Show("¡Por favor digite el nombre del autor!");
                }
                if (cantidad.Text == "")
                {
                    MessageBox.Show("¡Por favor digite el genero del libro!");
                }
                
                else
                {
                    using (libreriagandEntities1 DB = new libreriagandEntities1())
                    {
                        if (modelo.id_inventario == 0)//insertar
                            DB.inventario.Add(modelo);
                        else //modificar
                            DB.Entry(modelo).State = EntityState.Modified;
                        DB.SaveChanges();
                    }
                    clear();
                    llenarGrid();
                    MessageBox.Show("¡Regsitro guardado con éxito!", "Mensaje de Confirmación.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void clear()
        {
            textBox_idinventario.Text = box_idlibro.Text = box_cantidad.Text = "";
            btn_guardar.Text = "Guardar";
            btn_eliminar.Enabled = false;
            modelo.id_inventario = 0;
        }

        void llenarGrid()
        {
            Grid_inventario.AutoGenerateColumns = false;
            using (libreriagandEntities1 DB = new libreriagandEntities1())
            {
                Grid_inventario.DataSource = DB.inventario.ToList<inventario>();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
          
            clear();
            
        }

        private void Grid_inventario_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                modelo.id_inventario = Convert.ToInt32(Grid_inventario.CurrentRow.Cells["idinventarioDataGridViewTextBoxColumn"].Value);
                using (libreriagandEntities1 DB = new libreriagandEntities1())
                {
                    modelo = DB.inventario.Where(x => x.id_inventario == modelo.id_inventario).FirstOrDefault();
                    
                    textBox_idinventario.Text = Convert.ToString(modelo.id_inventario);
                    box_idlibro.Text = Convert.ToString(modelo.id_libro);
                    box_cantidad.Text = Convert.ToString(modelo.cantidad);
                   
                }
                btn_guardar.Text = "Modificar";
                btn_eliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            
        }

        private void box_idlibro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
