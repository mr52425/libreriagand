
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.editarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TituloLibreria3 = new System.Windows.Forms.Label();
            this.TituloInventario = new System.Windows.Forms.Label();
            this.Grid_inventario = new System.Windows.Forms.DataGridView();
            this.idinventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libreriagandtablas = new proyectolibreriaOF1.libreriagandtablas();
            this.label1 = new System.Windows.Forms.Label();
            this.fondo = new System.Windows.Forms.Label();
            this.Intruccion2 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.box_cantidad = new System.Windows.Forms.TextBox();
            this.id_libro = new System.Windows.Forms.Label();
            this.box_idlibro = new System.Windows.Forms.TextBox();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.inventarioTableAdapter = new proyectolibreriaOF1.libreriagandtablasTableAdapters.inventarioTableAdapter();
            this.tableAdapterManager = new proyectolibreriaOF1.libreriagandtablasTableAdapters.TableAdapterManager();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.textBox_idinventario = new System.Windows.Forms.TextBox();
            this.id_inventario = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriagandtablas)).BeginInit();
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
            this.menuStrip2.Size = new System.Drawing.Size(879, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // editarLibrosToolStripMenuItem
            // 
            this.editarLibrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarLibrosToolStripMenuItem.Name = "editarLibrosToolStripMenuItem";
            this.editarLibrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.editarLibrosToolStripMenuItem.Text = "Editar Libros";
            this.editarLibrosToolStripMenuItem.Click += new System.EventHandler(this.editarLibrosToolStripMenuItem_Click);
            // 
            // solicitarLibrosToolStripMenuItem
            // 
            this.solicitarLibrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitarLibrosToolStripMenuItem.Name = "solicitarLibrosToolStripMenuItem";
            this.solicitarLibrosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.solicitarLibrosToolStripMenuItem.Text = "Solicitar Libros";
            this.solicitarLibrosToolStripMenuItem.Click += new System.EventHandler(this.solicitarLibrosToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.consultarToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // consultarComprasToolStripMenuItem
            // 
            this.consultarComprasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarComprasToolStripMenuItem.Name = "consultarComprasToolStripMenuItem";
            this.consultarComprasToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
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
            this.TituloLibreria3.Size = new System.Drawing.Size(879, 70);
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
            this.TituloInventario.Size = new System.Drawing.Size(879, 64);
            this.TituloInventario.TabIndex = 18;
            this.TituloInventario.Text = "Registrar Inventario";
            this.TituloInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grid_inventario
            // 
            this.Grid_inventario.AutoGenerateColumns = false;
            this.Grid_inventario.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.Grid_inventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid_inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinventarioDataGridViewTextBoxColumn,
            this.idlibroDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.Grid_inventario.DataSource = this.inventarioBindingSource;
            this.Grid_inventario.EnableHeadersVisualStyles = false;
            this.Grid_inventario.GridColor = System.Drawing.Color.SaddleBrown;
            this.Grid_inventario.Location = new System.Drawing.Point(409, 198);
            this.Grid_inventario.Name = "Grid_inventario";
            this.Grid_inventario.ReadOnly = true;
            this.Grid_inventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_inventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Grid_inventario.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.Grid_inventario.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Grid_inventario.Size = new System.Drawing.Size(429, 327);
            this.Grid_inventario.TabIndex = 19;
            this.Grid_inventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_registrar_inventario_CellContentClick);
            this.Grid_inventario.DoubleClick += new System.EventHandler(this.Grid_inventario_DoubleClick);
            // 
            // idinventarioDataGridViewTextBoxColumn
            // 
            this.idinventarioDataGridViewTextBoxColumn.DataPropertyName = "id_inventario";
            this.idinventarioDataGridViewTextBoxColumn.HeaderText = "ID Inventario";
            this.idinventarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idinventarioDataGridViewTextBoxColumn.Name = "idinventarioDataGridViewTextBoxColumn";
            this.idinventarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idinventarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // idlibroDataGridViewTextBoxColumn
            // 
            this.idlibroDataGridViewTextBoxColumn.DataPropertyName = "id_libro";
            this.idlibroDataGridViewTextBoxColumn.HeaderText = "ID Libro";
            this.idlibroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlibroDataGridViewTextBoxColumn.Name = "idlibroDataGridViewTextBoxColumn";
            this.idlibroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idlibroDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "inventario";
            this.inventarioBindingSource.DataSource = this.libreriagandtablas;
            // 
            // libreriagandtablas
            // 
            this.libreriagandtablas.DataSetName = "libreriagandtablas";
            this.libreriagandtablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 54;
            this.label1.Text = "Introduce los datos a registrar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.BurlyWood;
            this.fondo.Location = new System.Drawing.Point(3, 158);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(347, 404);
            this.fondo.TabIndex = 50;
            // 
            // Intruccion2
            // 
            this.Intruccion2.BackColor = System.Drawing.Color.Peru;
            this.Intruccion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intruccion2.Location = new System.Drawing.Point(406, 158);
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
            this.cantidad.Location = new System.Drawing.Point(53, 266);
            this.cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(72, 20);
            this.cantidad.TabIndex = 61;
            this.cantidad.Text = "Cantidad:";
            this.cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // box_cantidad
            // 
            this.box_cantidad.BackColor = System.Drawing.Color.AntiqueWhite;
            this.box_cantidad.Location = new System.Drawing.Point(154, 268);
            this.box_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.box_cantidad.Name = "box_cantidad";
            this.box_cantidad.Size = new System.Drawing.Size(136, 20);
            this.box_cantidad.TabIndex = 60;
            // 
            // id_libro
            // 
            this.id_libro.BackColor = System.Drawing.Color.BurlyWood;
            this.id_libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_libro.Location = new System.Drawing.Point(54, 243);
            this.id_libro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_libro.Name = "id_libro";
            this.id_libro.Size = new System.Drawing.Size(72, 20);
            this.id_libro.TabIndex = 59;
            this.id_libro.Text = "Id_libro:";
            this.id_libro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.id_libro.Click += new System.EventHandler(this.id_libro_Click);
            // 
            // box_idlibro
            // 
            this.box_idlibro.BackColor = System.Drawing.Color.AntiqueWhite;
            this.box_idlibro.Location = new System.Drawing.Point(154, 243);
            this.box_idlibro.Margin = new System.Windows.Forms.Padding(2);
            this.box_idlibro.Name = "box_idlibro";
            this.box_idlibro.Size = new System.Drawing.Size(136, 20);
            this.box_idlibro.TabIndex = 58;
            this.box_idlibro.TextChanged += new System.EventHandler(this.box_idlibro_TextChanged);
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Maroon;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_hora.Location = new System.Drawing.Point(735, 33);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(91, 37);
            this.lbl_hora.TabIndex = 62;
            this.lbl_hora.Text = "Hora";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Maroon;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_fecha.Location = new System.Drawing.Point(594, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(59, 20);
            this.lbl_fecha.TabIndex = 63;
            this.lbl_fecha.Text = "Fecha";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_fecha.Click += new System.EventHandler(this.lbl_fecha_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
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
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminar.Location = new System.Drawing.Point(53, 335);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(237, 30);
            this.btn_eliminar.TabIndex = 64;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardar.Location = new System.Drawing.Point(53, 301);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(237, 30);
            this.btn_guardar.TabIndex = 65;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cancelar.Location = new System.Drawing.Point(53, 369);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(237, 30);
            this.btn_cancelar.TabIndex = 66;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // textBox_idinventario
            // 
            this.textBox_idinventario.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox_idinventario.Location = new System.Drawing.Point(154, 218);
            this.textBox_idinventario.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_idinventario.Name = "textBox_idinventario";
            this.textBox_idinventario.Size = new System.Drawing.Size(136, 20);
            this.textBox_idinventario.TabIndex = 69;
            this.textBox_idinventario.TextChanged += new System.EventHandler(this.textBox_idinventario_TextChanged);
            // 
            // id_inventario
            // 
            this.id_inventario.BackColor = System.Drawing.Color.BurlyWood;
            this.id_inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_inventario.Location = new System.Drawing.Point(53, 216);
            this.id_inventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_inventario.Name = "id_inventario";
            this.id_inventario.Size = new System.Drawing.Size(83, 20);
            this.id_inventario.TabIndex = 70;
            this.id_inventario.Text = "Id_inventario: ";
            this.id_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizar.Location = new System.Drawing.Point(54, 474);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(237, 30);
            this.btn_actualizar.TabIndex = 72;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_buscar.Location = new System.Drawing.Point(53, 440);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(136, 30);
            this.btn_buscar.TabIndex = 71;
            this.btn_buscar.Text = "Buscar por ID";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtbuscar.Location = new System.Drawing.Point(193, 446);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(97, 20);
            this.txtbuscar.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 37);
            this.label2.TabIndex = 74;
            this.label2.Text = "Busqueda por inventario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resgistrar_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(879, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.id_inventario);
            this.Controls.Add(this.textBox_idinventario);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.box_cantidad);
            this.Controls.Add(this.id_libro);
            this.Controls.Add(this.box_idlibro);
            this.Controls.Add(this.Intruccion2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fondo);
            this.Controls.Add(this.Grid_inventario);
            this.Controls.Add(this.TituloInventario);
            this.Controls.Add(this.TituloLibreria3);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "resgistrar_inventario";
            this.Text = "Sistema de Libreria - Registrar Inventario";
            this.Load += new System.EventHandler(this.resgistrar_inventario_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriagandtablas)).EndInit();
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
        private System.Windows.Forms.DataGridView Grid_inventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fondo;
        private System.Windows.Forms.Label Intruccion2;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.TextBox box_cantidad;
        private System.Windows.Forms.Label id_libro;
        private System.Windows.Forms.TextBox box_idlibro;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Timer Tiempo;
        private libreriagandtablas libreriagandtablas;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private libreriagandtablasTableAdapters.inventarioTableAdapter inventarioTableAdapter;
        private libreriagandtablasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox textBox_idinventario;
        private System.Windows.Forms.Label id_inventario;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
    }
}