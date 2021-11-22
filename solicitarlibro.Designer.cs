
namespace proyectolibreriaOF1
{
    partial class solicitarlibro
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.editarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TituloLibreria2 = new System.Windows.Forms.Label();
            this.TituloSolicitar = new System.Windows.Forms.Label();
            this.genero = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.fondo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.libreriagandtablas = new proyectolibreriaOF1.libreriagandtablas();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new proyectolibreriaOF1.libreriagandtablasTableAdapters.inventarioTableAdapter();
            this.idinventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroTableAdapter = new proyectolibreriaOF1.libreriagandtablasTableAdapters.libroTableAdapter();
            this.idlibroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomlibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriagandtablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
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
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.consultarComprasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 86);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1899, 30);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // editarLibrosToolStripMenuItem
            // 
            this.editarLibrosToolStripMenuItem.Name = "editarLibrosToolStripMenuItem";
            this.editarLibrosToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.editarLibrosToolStripMenuItem.Text = "Editar Libros";
            this.editarLibrosToolStripMenuItem.Click += new System.EventHandler(this.editarLibrosToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.registrarToolStripMenuItem.Text = "Registrar Inventario";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.consultarToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // consultarComprasToolStripMenuItem
            // 
            this.consultarComprasToolStripMenuItem.Name = "consultarComprasToolStripMenuItem";
            this.consultarComprasToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.consultarComprasToolStripMenuItem.Text = "Consultar Compras";
            this.consultarComprasToolStripMenuItem.Click += new System.EventHandler(this.consultarComprasToolStripMenuItem_Click);
            // 
            // TituloLibreria2
            // 
            this.TituloLibreria2.BackColor = System.Drawing.Color.Maroon;
            this.TituloLibreria2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloLibreria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLibreria2.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloLibreria2.Location = new System.Drawing.Point(0, 0);
            this.TituloLibreria2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLibreria2.Name = "TituloLibreria2";
            this.TituloLibreria2.Size = new System.Drawing.Size(1899, 86);
            this.TituloLibreria2.TabIndex = 18;
            this.TituloLibreria2.Text = "Sistema de Librería";
            this.TituloLibreria2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TituloSolicitar
            // 
            this.TituloSolicitar.BackColor = System.Drawing.Color.Sienna;
            this.TituloSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloSolicitar.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloSolicitar.Location = new System.Drawing.Point(1, 116);
            this.TituloSolicitar.Name = "TituloSolicitar";
            this.TituloSolicitar.Size = new System.Drawing.Size(1897, 79);
            this.TituloSolicitar.TabIndex = 19;
            this.TituloSolicitar.Text = "Solicitar Libros";
            this.TituloSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genero
            // 
            this.genero.BackColor = System.Drawing.Color.BurlyWood;
            this.genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero.Location = new System.Drawing.Point(68, 321);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(119, 25);
            this.genero.TabIndex = 25;
            this.genero.Text = "Fecha del pedido";
            this.genero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 324);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 22);
            this.textBox2.TabIndex = 7;
            // 
            // autor
            // 
            this.autor.BackColor = System.Drawing.Color.BurlyWood;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.Location = new System.Drawing.Point(68, 275);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(96, 25);
            this.autor.TabIndex = 23;
            this.autor.Text = "Cantidad";
            this.autor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.autor.Click += new System.EventHandler(this.autor_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(204, 278);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 22);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardar.Location = new System.Drawing.Point(71, 414);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(316, 37);
            this.btn_guardar.TabIndex = 43;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_limpiar.Location = new System.Drawing.Point(71, 467);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(316, 37);
            this.btn_limpiar.TabIndex = 42;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.BurlyWood;
            this.fondo.Location = new System.Drawing.Point(5, 209);
            this.fondo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(487, 508);
            this.fondo.TabIndex = 51;
            this.fondo.Click += new System.EventHandler(this.fondo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinventarioDataGridViewTextBoxColumn,
            this.idlibroDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(518, 233);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(612, 414);
            this.dataGridView1.TabIndex = 52;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Maroon;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_hora.Location = new System.Drawing.Point(1707, 41);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(111, 46);
            this.lbl_hora.TabIndex = 53;
            this.lbl_hora.Text = "Hora";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Maroon;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_fecha.Location = new System.Drawing.Point(1433, 0);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(85, 29);
            this.lbl_fecha.TabIndex = 54;
            this.lbl_fecha.Text = "Fecha";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // libreriagandtablas
            // 
            this.libreriagandtablas.DataSetName = "libreriagandtablas";
            this.libreriagandtablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "inventario";
            this.inventarioBindingSource.DataSource = this.libreriagandtablas;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // idinventarioDataGridViewTextBoxColumn
            // 
            this.idinventarioDataGridViewTextBoxColumn.DataPropertyName = "id_inventario";
            this.idinventarioDataGridViewTextBoxColumn.HeaderText = "id_inventario";
            this.idinventarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idinventarioDataGridViewTextBoxColumn.Name = "idinventarioDataGridViewTextBoxColumn";
            this.idinventarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // idlibroDataGridViewTextBoxColumn
            // 
            this.idlibroDataGridViewTextBoxColumn.DataPropertyName = "id_libro";
            this.idlibroDataGridViewTextBoxColumn.HeaderText = "id_libro";
            this.idlibroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlibroDataGridViewTextBoxColumn.Name = "idlibroDataGridViewTextBoxColumn";
            this.idlibroDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlibroDataGridViewTextBoxColumn1,
            this.nomlibroDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.libroBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1151, 233);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(422, 414);
            this.dataGridView2.TabIndex = 55;
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataMember = "libro";
            this.libroBindingSource.DataSource = this.libreriagandtablas;
            // 
            // libroTableAdapter
            // 
            this.libroTableAdapter.ClearBeforeFill = true;
            // 
            // idlibroDataGridViewTextBoxColumn1
            // 
            this.idlibroDataGridViewTextBoxColumn1.DataPropertyName = "id_libro";
            this.idlibroDataGridViewTextBoxColumn1.HeaderText = "id_libro";
            this.idlibroDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idlibroDataGridViewTextBoxColumn1.Name = "idlibroDataGridViewTextBoxColumn1";
            this.idlibroDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nomlibroDataGridViewTextBoxColumn
            // 
            this.nomlibroDataGridViewTextBoxColumn.DataPropertyName = "nom_libro";
            this.nomlibroDataGridViewTextBoxColumn.HeaderText = "nom_libro";
            this.nomlibroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomlibroDataGridViewTextBoxColumn.Name = "nomlibroDataGridViewTextBoxColumn";
            this.nomlibroDataGridViewTextBoxColumn.Width = 125;
            // 
            // solicitarlibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1899, 702);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TituloSolicitar);
            this.Controls.Add(this.TituloLibreria2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.fondo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "solicitarlibro";
            this.Text = "Sistema de Libreria - Solictar Libros";
            this.Load += new System.EventHandler(this.solicitarlibro_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriagandtablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLibrosToolStripMenuItem;
        private System.Windows.Forms.Label TituloLibreria2;
        private System.Windows.Forms.Label TituloSolicitar;
        private System.Windows.Forms.Label genero;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label fondo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Timer Tiempo;
        private libreriagandtablas libreriagandtablas;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private libreriagandtablasTableAdapters.inventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private libreriagandtablasTableAdapters.libroTableAdapter libroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomlibroDataGridViewTextBoxColumn;
    }
}