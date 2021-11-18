
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
            this.components = new System.ComponentModel.Container();
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
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.libreriagandtablas = new proyectolibreriaOF1.libreriagandtablas();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new proyectolibreriaOF1.libreriagandtablasTableAdapters.inventarioTableAdapter();
            this.tableAdapterManager = new proyectolibreriaOF1.libreriagandtablasTableAdapters.TableAdapterManager();
            this.idinventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriagandtablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
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
            this.menuStrip2.Location = new System.Drawing.Point(0, 86);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1823, 30);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // editarLibrosToolStripMenuItem
            // 
            this.editarLibrosToolStripMenuItem.Name = "editarLibrosToolStripMenuItem";
            this.editarLibrosToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.editarLibrosToolStripMenuItem.Text = "Editar Libros";
            this.editarLibrosToolStripMenuItem.Click += new System.EventHandler(this.editarLibrosToolStripMenuItem_Click);
            // 
            // solicitarLibrosToolStripMenuItem
            // 
            this.solicitarLibrosToolStripMenuItem.Name = "solicitarLibrosToolStripMenuItem";
            this.solicitarLibrosToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.solicitarLibrosToolStripMenuItem.Text = "Solicitar Libros";
            this.solicitarLibrosToolStripMenuItem.Click += new System.EventHandler(this.solicitarLibrosToolStripMenuItem_Click);
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
            // TituloLibreria3
            // 
            this.TituloLibreria3.BackColor = System.Drawing.Color.Maroon;
            this.TituloLibreria3.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloLibreria3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLibreria3.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloLibreria3.Location = new System.Drawing.Point(0, 0);
            this.TituloLibreria3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLibreria3.Name = "TituloLibreria3";
            this.TituloLibreria3.Size = new System.Drawing.Size(1343, 86);
            this.TituloLibreria3.TabIndex = 17;
            this.TituloLibreria3.Text = "Sistema de Librería";
            this.TituloLibreria3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TituloInventario
            // 
            this.TituloInventario.BackColor = System.Drawing.Color.Sienna;
            this.TituloInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloInventario.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloInventario.Location = new System.Drawing.Point(0, 116);
            this.TituloInventario.Name = "TituloInventario";
            this.TituloInventario.Size = new System.Drawing.Size(1823, 79);
            this.TituloInventario.TabIndex = 18;
            this.TituloInventario.Text = "Registrar Inventario";
            this.TituloInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dataGridView1.Location = new System.Drawing.Point(587, 260);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(434, 398);
            this.dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 46);
            this.label1.TabIndex = 54;
            this.label1.Text = "Introduce los datos a enviar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // box_limpiar
            // 
            this.box_limpiar.Location = new System.Drawing.Point(85, 478);
            this.box_limpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.box_limpiar.Name = "box_limpiar";
            this.box_limpiar.Size = new System.Drawing.Size(315, 22);
            this.box_limpiar.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(85, 527);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 37);
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
            this.btn_enviar.Location = new System.Drawing.Point(85, 418);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(316, 37);
            this.btn_enviar.TabIndex = 49;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.BurlyWood;
            this.fondo.Location = new System.Drawing.Point(0, 194);
            this.fondo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(487, 497);
            this.fondo.TabIndex = 50;
            // 
            // Intruccion2
            // 
            this.Intruccion2.BackColor = System.Drawing.Color.Peru;
            this.Intruccion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intruccion2.Location = new System.Drawing.Point(583, 210);
            this.Intruccion2.Name = "Intruccion2";
            this.Intruccion2.Size = new System.Drawing.Size(320, 46);
            this.Intruccion2.TabIndex = 57;
            this.Intruccion2.Text = "Listado del inventario:";
            this.Intruccion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cantidad
            // 
            this.cantidad.BackColor = System.Drawing.Color.BurlyWood;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(81, 372);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(96, 25);
            this.cantidad.TabIndex = 61;
            this.cantidad.Text = "Cantidad:";
            this.cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // box_cantidad
            // 
            this.box_cantidad.Location = new System.Drawing.Point(220, 372);
            this.box_cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_cantidad.Name = "box_cantidad";
            this.box_cantidad.Size = new System.Drawing.Size(180, 22);
            this.box_cantidad.TabIndex = 60;
            // 
            // id_libro
            // 
            this.id_libro.BackColor = System.Drawing.Color.BurlyWood;
            this.id_libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_libro.Location = new System.Drawing.Point(81, 342);
            this.id_libro.Name = "id_libro";
            this.id_libro.Size = new System.Drawing.Size(96, 25);
            this.id_libro.TabIndex = 59;
            this.id_libro.Text = "Id_libro";
            this.id_libro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // box_idcliente
            // 
            this.box_idcliente.Location = new System.Drawing.Point(220, 342);
            this.box_idcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_idcliente.Name = "box_idcliente";
            this.box_idcliente.Size = new System.Drawing.Size(180, 22);
            this.box_idcliente.TabIndex = 58;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Maroon;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_hora.Location = new System.Drawing.Point(1193, 40);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(111, 46);
            this.lbl_hora.TabIndex = 62;
            this.lbl_hora.Text = "Hora";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Maroon;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_fecha.Location = new System.Drawing.Point(1151, 0);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(85, 29);
            this.lbl_fecha.TabIndex = 63;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.inventarioTableAdapter = this.inventarioTableAdapter;
            this.tableAdapterManager.libroTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proyectolibreriaOF1.libreriagandtablasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
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
            // resgistrar_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1343, 688);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_fecha);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "resgistrar_inventario";
            this.Text = "Sistema de Libreria - Registrar Inventario";
            this.Load += new System.EventHandler(this.resgistrar_inventario_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriagandtablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Timer Tiempo;
        private libreriagandtablas libreriagandtablas;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private libreriagandtablasTableAdapters.inventarioTableAdapter inventarioTableAdapter;
        private libreriagandtablasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
    }
}