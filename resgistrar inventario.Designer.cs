
namespace proyectolibreriaOF1
{
    partial class resgistrar_inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.editarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TituloLibreria3 = new System.Windows.Forms.Label();
            this.TituloInventario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.box_limpiar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.fondo = new System.Windows.Forms.Label();
            this.Intruccion2 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.box_cantidad = new System.Windows.Forms.TextBox();
            this.id_libro = new System.Windows.Forms.Label();
            this.box_idcliente = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarLibrosToolStripMenuItem,
            this.solicitarLibrosToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.consultarComprasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 70);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1367, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // editarLibrosToolStripMenuItem
            // 
            this.editarLibrosToolStripMenuItem.Name = "editarLibrosToolStripMenuItem";
            this.editarLibrosToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.editarLibrosToolStripMenuItem.Text = "Editar Libros";
            this.editarLibrosToolStripMenuItem.Click += new System.EventHandler(this.editarLibrosToolStripMenuItem_Click);
            // 
            // solicitarLibrosToolStripMenuItem
            // 
            this.solicitarLibrosToolStripMenuItem.Name = "solicitarLibrosToolStripMenuItem";
            this.solicitarLibrosToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.solicitarLibrosToolStripMenuItem.Text = "Solicitar Libros";
            this.solicitarLibrosToolStripMenuItem.Click += new System.EventHandler(this.solicitarLibrosToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.consultarToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // consultarComprasToolStripMenuItem
            // 
            this.consultarComprasToolStripMenuItem.Name = "consultarComprasToolStripMenuItem";
            this.consultarComprasToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.consultarComprasToolStripMenuItem.Text = "Consultar Compras";
            this.consultarComprasToolStripMenuItem.Click += new System.EventHandler(this.consultarComprasToolStripMenuItem_Click);
            // 
            // TituloLibreria3
            // 
            this.TituloLibreria3.BackColor = System.Drawing.Color.Maroon;
            this.TituloLibreria3.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloLibreria3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLibreria3.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloLibreria3.Location = new System.Drawing.Point(0, 0);
            this.TituloLibreria3.Name = "TituloLibreria3";
            this.TituloLibreria3.Size = new System.Drawing.Size(1367, 70);
            this.TituloLibreria3.TabIndex = 17;
            this.TituloLibreria3.Text = "Sistema de Librería";
            this.TituloLibreria3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TituloInventario
            // 
            this.TituloInventario.BackColor = System.Drawing.Color.Sienna;
            this.TituloInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloInventario.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloInventario.Location = new System.Drawing.Point(0, 94);
            this.TituloInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TituloInventario.Name = "TituloInventario";
            this.TituloInventario.Size = new System.Drawing.Size(1367, 64);
            this.TituloInventario.TabIndex = 18;
            this.TituloInventario.Text = "Registrar Inventario";
            this.TituloInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(440, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 323);
            this.dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 54;
            this.label1.Text = "Introduce los datos a enviar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // box_limpiar
            // 
            this.box_limpiar.Location = new System.Drawing.Point(64, 388);
            this.box_limpiar.Name = "box_limpiar";
            this.box_limpiar.Size = new System.Drawing.Size(237, 20);
            this.box_limpiar.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(64, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 30);
            this.button1.TabIndex = 51;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_enviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_enviar.Location = new System.Drawing.Point(64, 340);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(237, 30);
            this.btn_enviar.TabIndex = 49;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.BurlyWood;
            this.fondo.Location = new System.Drawing.Point(0, 158);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(365, 404);
            this.fondo.TabIndex = 50;
            // 
            // Intruccion2
            // 
            this.Intruccion2.BackColor = System.Drawing.Color.Peru;
            this.Intruccion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intruccion2.Location = new System.Drawing.Point(437, 171);
            this.Intruccion2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Intruccion2.Name = "Intruccion2";
            this.Intruccion2.Size = new System.Drawing.Size(240, 37);
            this.Intruccion2.TabIndex = 57;
            this.Intruccion2.Text = "Listado del inventario:";
            this.Intruccion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cantidad
            // 
            this.cantidad.BackColor = System.Drawing.Color.BurlyWood;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(61, 302);
            this.cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(72, 20);
            this.cantidad.TabIndex = 61;
            this.cantidad.Text = "Cantidad:";
            this.cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // box_cantidad
            // 
            this.box_cantidad.Location = new System.Drawing.Point(165, 302);
            this.box_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.box_cantidad.Name = "box_cantidad";
            this.box_cantidad.Size = new System.Drawing.Size(136, 20);
            this.box_cantidad.TabIndex = 60;
            // 
            // id_libro
            // 
            this.id_libro.BackColor = System.Drawing.Color.BurlyWood;
            this.id_libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_libro.Location = new System.Drawing.Point(61, 278);
            this.id_libro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_libro.Name = "id_libro";
            this.id_libro.Size = new System.Drawing.Size(72, 20);
            this.id_libro.TabIndex = 59;
            this.id_libro.Text = "Id_libro";
            this.id_libro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // box_idcliente
            // 
            this.box_idcliente.Location = new System.Drawing.Point(165, 278);
            this.box_idcliente.Margin = new System.Windows.Forms.Padding(2);
            this.box_idcliente.Name = "box_idcliente";
            this.box_idcliente.Size = new System.Drawing.Size(136, 20);
            this.box_idcliente.TabIndex = 58;
            // 
            // resgistrar_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1367, 559);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.box_cantidad);
            this.Controls.Add(this.id_libro);
            this.Controls.Add(this.box_idcliente);
            this.Controls.Add(this.Intruccion2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_limpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.fondo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TituloInventario);
            this.Controls.Add(this.TituloLibreria3);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "resgistrar_inventario";
            this.Text = "Sistema de Libreria - Registrar Inventario";
            this.Load += new System.EventHandler(this.resgistrar_inventario_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarLibrosToolStripMenuItem;
        private System.Windows.Forms.Label TituloLibreria3;
        private System.Windows.Forms.Label TituloInventario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_limpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label fondo;
        private System.Windows.Forms.Label Intruccion2;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.TextBox box_cantidad;
        private System.Windows.Forms.Label id_libro;
        private System.Windows.Forms.TextBox box_idcliente;
    }
}