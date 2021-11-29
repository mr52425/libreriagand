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
    public partial class solicitarlibro : Form
    {
        public solicitarlibro()
        {
            InitializeComponent();
        }

        private void solicitarlibro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'libreriagandtablas.libro' Puede moverla o quitarla según sea necesario.
            this.libroTableAdapter.Fill(this.libreriagandtablas.libro);
            // TODO: esta línea de código carga datos en la tabla 'libreriagandtablas.inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.libreriagandtablas.inventario);
            this.FormClosed += new FormClosedEventHandler(cerrarform);      //Cierra formulario
            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fondo_Click(object sender, EventArgs e)
        {

        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            textBox2.Text= DateTime.Now.ToLongDateString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            libro modelo = new libro();
            try
            {
                modelo.id_libro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idlibroDataGridViewTextBoxColumn"].Value);
                using (libreriagandEntities1 DB = new libreriagandEntities1())
                {
                    if (MessageBox.Show("¿Estás seguro de realizar este pedido?", "Mensaje de Advertencia.",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        modelo = DB.libro.Where(x => x.id_libro == modelo.id_libro).FirstOrDefault();
                        MessageBox.Show("Se ha realizo el pedido del siguiente libro: " + modelo.nom_libro + "\n Autor: " + modelo.autor
                            + "\n Género: " + modelo.genero + "\n Editorial: " + modelo.editorial + "\n Edicién: " +
                            modelo.edicion + "\n Precio: " + modelo.precio + "\n Con la siguiente cantidad: " + textBox3.Text + " \n Solicitud enviada el: " + textBox2.Text + " \n ¡Solicitud enviada al provedor satisfactoriamente!",
                            "Mensaje de Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                        msg.To.Add("josuito.ramirez9@gmail.com");
                        msg.Subject = "Solicitud de Abastecimiento LibreriasPrueba";
                        msg.SubjectEncoding = System.Text.Encoding.UTF8;
                        msg.Body = "Solicitud del siguiente libro: " + modelo.nom_libro + "\n Autor: " + modelo.autor
                            + "\n Género: " + modelo.genero + "\n Editorial: " + modelo.editorial + "\n Edición: " +
                            modelo.edicion + "\n Precio: " + modelo.precio + "\n Con la siguiente cantidad: " + textBox3.Text + "\n ¡Muchas gracias, esperamos su respuesta!";
                        msg.BodyEncoding = System.Text.Encoding.UTF8;
                        msg.IsBodyHtml = true;
                        msg.From = new System.Net.Mail.MailAddress("pruebasproyectoram9@gmail.com");
                        System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                        cliente.Credentials = new System.Net.NetworkCredential("pruebasproyectoram9@gmail.com", "Josue524");

                        cliente.Port = 587;
                        cliente.EnableSsl = true;
                        cliente.Host = "smtp.gmail.com";

                        cliente.Send(msg);
                    }
                    else
                    {
                        MessageBox.Show("¡No se realizó el pedido!", "Mensaje de Cancelación.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + ".", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void autor_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txtbuscar1.Text = "";
            txtbuscar2.Text = "";
        }

        void llenarGrid()
        {
            inventario modelo = new inventario();
            dataGridView1.AutoGenerateColumns = false;
            using (libreriagandEntities1 DB = new libreriagandEntities1())
            {
                dataGridView1.DataSource = DB.inventario.ToList<inventario>();
            }
        }

        void llenarGrid2()
        {
            libro modelo = new libro();
            dataGridView2.AutoGenerateColumns = false;
            using (libreriagandEntities1 DB = new libreriagandEntities1())
            {
                dataGridView2.DataSource = DB.libro.ToList<libro>();
            }
        }

        private void btn_buscar1_Click(object sender, EventArgs e)
        {
            inventario modelo = new inventario();
            try
            {
                Int32 keyword = int.Parse(txtbuscar1.Text.Trim());
                using (libreriagandEntities1 DB = new libreriagandEntities1())
                {
                    dataGridView1.DataSource = DB.inventario.Where(y => y.id_inventario.Equals(keyword)).ToList();
                }
                clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("¡Por favor digite el valor que se pide!", "Mensaje de Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            libro modelo = new libro();
            try
            {
                Int32 keyword = int.Parse(txtbuscar2.Text.Trim());
                using (libreriagandEntities1 DB = new libreriagandEntities1())
                {
                    dataGridView2.DataSource = DB.libro.Where(y => y.id_libro.Equals(keyword)).ToList();
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
            llenarGrid2();
        }

        private void lbl_hora_Click(object sender, EventArgs e)
        {

        }
    }
}
