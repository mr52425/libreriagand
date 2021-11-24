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
                    if (MessageBox.Show("¿Estás seguro de realizar este pedido", "Mensaje de Advertencia.",
                     MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        modelo = DB.libro.Where(x => x.id_libro == modelo.id_libro).FirstOrDefault();
                        MessageBox.Show("Se a realizo el pedido del siguiente libro: " + modelo.nom_libro + "\n Autor: " + modelo.autor
                            + "\n Genero: " + modelo.genero + "\n Editorial: " + modelo.editorial + "\n Edicion: " +
                            modelo.edicion + "\n Precio: " + modelo.precio + "\n Con la siguiente cantidad: " + textBox3.Text + " \n Solicitud enviada el: " + textBox2.Text + " \n solicitud enviada al provedor gracias :)");

                        System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                        msg.To.Add("josuito.ramirez9@gmail.com");
                        msg.Subject = "Solicitud de abastecimiento libreriasPrueba";
                        msg.SubjectEncoding = System.Text.Encoding.UTF8;
                        msg.Body = "Solicitud del siguiente libro: " + modelo.nom_libro + "\n Autor: " + modelo.autor
                            + "\n Genero: " + modelo.genero + "\n Editorial: " + modelo.editorial + "\n Edicion: " +
                            modelo.edicion + "\n Precio: " + modelo.precio + "\n Con la siguiente cantidad: " + textBox3.Text + "\n Gracias esperamos su respuesta";
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

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        }
    }
}
