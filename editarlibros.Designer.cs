
namespace proyectolibreriaOF1
{
    partial class editarlibros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.solicitarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TituloEditar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TituloLibreria1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.genero = new System.Windows.Forms.Label();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.Label();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.edicion = new System.Windows.Forms.Label();
            this.txtedicion = new System.Windows.Forms.TextBox();
            this.editorial = new System.Windows.Forms.Label();
            this.txteditorial = new System.Windows.Forms.TextBox();
            this.idioma = new System.Windows.Forms.Label();
            this.txtidioma = new System.Windows.Forms.TextBox();
            this.año = new System.Windows.Forms.Label();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.paginas = new System.Windows.Forms.Label();
            this.txtpaginas = new System.Windows.Forms.TextBox();
            this.sipnosis = new System.Windows.Forms.Label();
            this.txtsipnosis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_editarlibros = new System.Windows.Forms.DataGridView();
            this.idlibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomlibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idiomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sipnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libreriagandtablas = new proyectolibreriaOF1.libreriagandtablas();
            this.Intruccion1 = new System.Windows.Forms.Label();
            this.Intruccion2 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.libroTableAdapter = new proyectolibreriaOF1.libreriagandtablasTableAdapters.libroTableAdapter();
            this.tableAdapterManager = new proyectolibreriaOF1.libreriagandtablasTableAdapters.TableAdapterManager();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_editarlibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriagandtablas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitarLibrosToolStripMenuItem,
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.consultarComprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1459, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // solicitarLibrosToolStripMenuItem
            // 
            this.solicitarLibrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitarLibrosToolStripMenuItem.Name = "solicitarLibrosToolStripMenuItem";
            this.solicitarLibrosToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.solicitarLibrosToolStripMenuItem.Text = "Solictar Libros";
            this.solicitarLibrosToolStripMenuItem.Click += new System.EventHandler(this.solicitarLibrosToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.registrarToolStripMenuItem.Text = "Registrar Inventario";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.consultarToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // consultarComprasToolStripMenuItem
            // 
            this.consultarComprasToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.consultarComprasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarComprasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.consultarComprasToolStripMenuItem.Name = "consultarComprasToolStripMenuItem";
            this.consultarComprasToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.consultarComprasToolStripMenuItem.Text = "Consultar Compras";
            this.consultarComprasToolStripMenuItem.Click += new System.EventHandler(this.consultarComprasToolStripMenuItem_Click);
            // 
            // TituloEditar
            // 
            this.TituloEditar.BackColor = System.Drawing.Color.Sienna;
            this.TituloEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloEditar.Location = new System.Drawing.Point(0, 100);
            this.TituloEditar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TituloEditar.Name = "TituloEditar";
            this.TituloEditar.Size = new System.Drawing.Size(1459, 64);
            this.TituloEditar.TabIndex = 4;
            this.TituloEditar.Text = "Editar Libros";
            this.TituloEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TituloEditar.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 307);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // TituloLibreria1
            // 
            this.TituloLibreria1.BackColor = System.Drawing.Color.Maroon;
            this.TituloLibreria1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloLibreria1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLibreria1.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloLibreria1.Location = new System.Drawing.Point(0, 0);
            this.TituloLibreria1.Name = "TituloLibreria1";
            this.TituloLibreria1.Size = new System.Drawing.Size(1461, 70);
            this.TituloLibreria1.TabIndex = 15;
            this.TituloLibreria1.Text = "Sistema de Librería";
            this.TituloLibreria1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(17, 226);
            this.nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(72, 20);
            this.nombre.TabIndex = 17;
            this.nombre.Text = "Nombre: ";
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtnombre.Location = new System.Drawing.Point(121, 226);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(136, 20);
            this.txtnombre.TabIndex = 16;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // genero
            // 
            this.genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero.Location = new System.Drawing.Point(17, 274);
            this.genero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(72, 20);
            this.genero.TabIndex = 21;
            this.genero.Text = "Genero:";
            this.genero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtgenero
            // 
            this.txtgenero.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtgenero.Location = new System.Drawing.Point(121, 274);
            this.txtgenero.Margin = new System.Windows.Forms.Padding(2);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(136, 20);
            this.txtgenero.TabIndex = 20;
            // 
            // autor
            // 
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.Location = new System.Drawing.Point(17, 250);
            this.autor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(72, 20);
            this.autor.TabIndex = 19;
            this.autor.Text = "Autor:";
            this.autor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtautor
            // 
            this.txtautor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtautor.Location = new System.Drawing.Point(121, 250);
            this.txtautor.Margin = new System.Windows.Forms.Padding(2);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(136, 20);
            this.txtautor.TabIndex = 18;
            // 
            // edicion
            // 
            this.edicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edicion.Location = new System.Drawing.Point(17, 322);
            this.edicion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edicion.Name = "edicion";
            this.edicion.Size = new System.Drawing.Size(72, 20);
            this.edicion.TabIndex = 25;
            this.edicion.Text = "Edición: ";
            this.edicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edicion.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtedicion
            // 
            this.txtedicion.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtedicion.Location = new System.Drawing.Point(121, 322);
            this.txtedicion.Margin = new System.Windows.Forms.Padding(2);
            this.txtedicion.Name = "txtedicion";
            this.txtedicion.Size = new System.Drawing.Size(136, 20);
            this.txtedicion.TabIndex = 24;
            this.txtedicion.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // editorial
            // 
            this.editorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorial.Location = new System.Drawing.Point(17, 298);
            this.editorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editorial.Name = "editorial";
            this.editorial.Size = new System.Drawing.Size(72, 20);
            this.editorial.TabIndex = 23;
            this.editorial.Text = "Editorial:";
            this.editorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txteditorial
            // 
            this.txteditorial.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txteditorial.Location = new System.Drawing.Point(121, 298);
            this.txteditorial.Margin = new System.Windows.Forms.Padding(2);
            this.txteditorial.Name = "txteditorial";
            this.txteditorial.Size = new System.Drawing.Size(136, 20);
            this.txteditorial.TabIndex = 22;
            // 
            // idioma
            // 
            this.idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idioma.Location = new System.Drawing.Point(17, 370);
            this.idioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(72, 20);
            this.idioma.TabIndex = 29;
            this.idioma.Text = "Idioma:";
            this.idioma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtidioma
            // 
            this.txtidioma.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtidioma.Location = new System.Drawing.Point(121, 370);
            this.txtidioma.Margin = new System.Windows.Forms.Padding(2);
            this.txtidioma.Name = "txtidioma";
            this.txtidioma.Size = new System.Drawing.Size(136, 20);
            this.txtidioma.TabIndex = 28;
            // 
            // año
            // 
            this.año.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.año.Location = new System.Drawing.Point(17, 346);
            this.año.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(72, 20);
            this.año.TabIndex = 27;
            this.año.Text = "Año:";
            this.año.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtaño
            // 
            this.txtaño.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtaño.Location = new System.Drawing.Point(121, 346);
            this.txtaño.Margin = new System.Windows.Forms.Padding(2);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(136, 20);
            this.txtaño.TabIndex = 26;
            // 
            // precio
            // 
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(17, 418);
            this.precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(72, 20);
            this.precio.TabIndex = 33;
            this.precio.Text = "Precio:";
            this.precio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtprecio.Location = new System.Drawing.Point(121, 418);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(136, 20);
            this.txtprecio.TabIndex = 32;
            // 
            // paginas
            // 
            this.paginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginas.Location = new System.Drawing.Point(17, 394);
            this.paginas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paginas.Name = "paginas";
            this.paginas.Size = new System.Drawing.Size(72, 20);
            this.paginas.TabIndex = 31;
            this.paginas.Text = "Páginas:";
            this.paginas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpaginas
            // 
            this.txtpaginas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtpaginas.Location = new System.Drawing.Point(121, 394);
            this.txtpaginas.Margin = new System.Windows.Forms.Padding(2);
            this.txtpaginas.Name = "txtpaginas";
            this.txtpaginas.Size = new System.Drawing.Size(136, 20);
            this.txtpaginas.TabIndex = 30;
            // 
            // sipnosis
            // 
            this.sipnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sipnosis.Location = new System.Drawing.Point(17, 442);
            this.sipnosis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sipnosis.Name = "sipnosis";
            this.sipnosis.Size = new System.Drawing.Size(72, 20);
            this.sipnosis.TabIndex = 35;
            this.sipnosis.Text = "Sinopsis:";
            this.sipnosis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtsipnosis
            // 
            this.txtsipnosis.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtsipnosis.Location = new System.Drawing.Point(121, 442);
            this.txtsipnosis.Margin = new System.Windows.Forms.Padding(2);
            this.txtsipnosis.Name = "txtsipnosis";
            this.txtsipnosis.Size = new System.Drawing.Size(136, 20);
            this.txtsipnosis.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(275, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1184, 439);
            this.label3.TabIndex = 37;
            // 
            // dgv_editarlibros
            // 
            this.dgv_editarlibros.AllowUserToDeleteRows = false;
            this.dgv_editarlibros.AutoGenerateColumns = false;
            this.dgv_editarlibros.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_editarlibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_editarlibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_editarlibros.ColumnHeadersHeight = 29;
            this.dgv_editarlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_editarlibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlibroDataGridViewTextBoxColumn,
            this.nomlibroDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.editorialDataGridViewTextBoxColumn,
            this.edicionDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.idiomaDataGridViewTextBoxColumn,
            this.paginasDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.sipnosisDataGridViewTextBoxColumn});
            this.dgv_editarlibros.DataSource = this.libroBindingSource;
            this.dgv_editarlibros.EnableHeadersVisualStyles = false;
            this.dgv_editarlibros.GridColor = System.Drawing.Color.SaddleBrown;
            this.dgv_editarlibros.Location = new System.Drawing.Point(294, 211);
            this.dgv_editarlibros.Name = "dgv_editarlibros";
            this.dgv_editarlibros.ReadOnly = true;
            this.dgv_editarlibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_editarlibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_editarlibros.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_editarlibros.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_editarlibros.Size = new System.Drawing.Size(1153, 369);
            this.dgv_editarlibros.TabIndex = 19;
            this.dgv_editarlibros.DoubleClick += new System.EventHandler(this.dgv_editarlibros_DoubleClick);
            // 
            // idlibroDataGridViewTextBoxColumn
            // 
            this.idlibroDataGridViewTextBoxColumn.DataPropertyName = "id_libro";
            this.idlibroDataGridViewTextBoxColumn.HeaderText = "ID del Libro";
            this.idlibroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlibroDataGridViewTextBoxColumn.Name = "idlibroDataGridViewTextBoxColumn";
            this.idlibroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idlibroDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomlibroDataGridViewTextBoxColumn
            // 
            this.nomlibroDataGridViewTextBoxColumn.DataPropertyName = "nom_libro";
            this.nomlibroDataGridViewTextBoxColumn.HeaderText = "Nombre del Libro";
            this.nomlibroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomlibroDataGridViewTextBoxColumn.Name = "nomlibroDataGridViewTextBoxColumn";
            this.nomlibroDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomlibroDataGridViewTextBoxColumn.Width = 125;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Nombre del Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Width = 125;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Género";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generoDataGridViewTextBoxColumn.Width = 125;
            // 
            // editorialDataGridViewTextBoxColumn
            // 
            this.editorialDataGridViewTextBoxColumn.DataPropertyName = "editorial";
            this.editorialDataGridViewTextBoxColumn.HeaderText = "Editorial";
            this.editorialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editorialDataGridViewTextBoxColumn.Name = "editorialDataGridViewTextBoxColumn";
            this.editorialDataGridViewTextBoxColumn.ReadOnly = true;
            this.editorialDataGridViewTextBoxColumn.Width = 125;
            // 
            // edicionDataGridViewTextBoxColumn
            // 
            this.edicionDataGridViewTextBoxColumn.DataPropertyName = "edicion";
            this.edicionDataGridViewTextBoxColumn.HeaderText = "Edición";
            this.edicionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edicionDataGridViewTextBoxColumn.Name = "edicionDataGridViewTextBoxColumn";
            this.edicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.edicionDataGridViewTextBoxColumn.Width = 125;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.añoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            this.añoDataGridViewTextBoxColumn.ReadOnly = true;
            this.añoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idiomaDataGridViewTextBoxColumn
            // 
            this.idiomaDataGridViewTextBoxColumn.DataPropertyName = "idioma";
            this.idiomaDataGridViewTextBoxColumn.HeaderText = "Idioma";
            this.idiomaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idiomaDataGridViewTextBoxColumn.Name = "idiomaDataGridViewTextBoxColumn";
            this.idiomaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idiomaDataGridViewTextBoxColumn.Width = 125;
            // 
            // paginasDataGridViewTextBoxColumn
            // 
            this.paginasDataGridViewTextBoxColumn.DataPropertyName = "paginas";
            this.paginasDataGridViewTextBoxColumn.HeaderText = "Páginas";
            this.paginasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paginasDataGridViewTextBoxColumn.Name = "paginasDataGridViewTextBoxColumn";
            this.paginasDataGridViewTextBoxColumn.ReadOnly = true;
            this.paginasDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // sipnosisDataGridViewTextBoxColumn
            // 
            this.sipnosisDataGridViewTextBoxColumn.DataPropertyName = "sipnosis";
            this.sipnosisDataGridViewTextBoxColumn.HeaderText = "Sinopsis";
            this.sipnosisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sipnosisDataGridViewTextBoxColumn.Name = "sipnosisDataGridViewTextBoxColumn";
            this.sipnosisDataGridViewTextBoxColumn.ReadOnly = true;
            this.sipnosisDataGridViewTextBoxColumn.Width = 125;
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataMember = "libro";
            this.libroBindingSource.DataSource = this.libreriagandtablas;
            // 
            // libreriagandtablas
            // 
            this.libreriagandtablas.DataSetName = "libreriagandtablas";
            this.libreriagandtablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Intruccion1
            // 
            this.Intruccion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intruccion1.Location = new System.Drawing.Point(17, 172);
            this.Intruccion1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Intruccion1.Name = "Intruccion1";
            this.Intruccion1.Size = new System.Drawing.Size(240, 37);
            this.Intruccion1.TabIndex = 39;
            this.Intruccion1.Text = "Introduce los datos del libro a editar:";
            this.Intruccion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Intruccion2
            // 
            this.Intruccion2.BackColor = System.Drawing.Color.Peru;
            this.Intruccion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intruccion2.Location = new System.Drawing.Point(291, 172);
            this.Intruccion2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Intruccion2.Name = "Intruccion2";
            this.Intruccion2.Size = new System.Drawing.Size(240, 37);
            this.Intruccion2.TabIndex = 40;
            this.Intruccion2.Text = "Listado de los libros registrados:";
            this.Intruccion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Intruccion2.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardar.Location = new System.Drawing.Point(20, 469);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(237, 30);
            this.btn_guardar.TabIndex = 42;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminar.Location = new System.Drawing.Point(20, 503);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(237, 30);
            this.btn_eliminar.TabIndex = 43;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cancelar.Location = new System.Drawing.Point(20, 537);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(237, 30);
            this.btn_cancelar.TabIndex = 44;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtbuscar.Location = new System.Drawing.Point(1163, 179);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(136, 20);
            this.txtbuscar.TabIndex = 45;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_buscar.Location = new System.Drawing.Point(1015, 173);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(144, 30);
            this.btn_buscar.TabIndex = 46;
            this.btn_buscar.Text = "Buscar por ID";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizar.Location = new System.Drawing.Point(1303, 175);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(144, 26);
            this.btn_actualizar.TabIndex = 47;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // libroTableAdapter
            // 
            this.libroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.inventarioTableAdapter = null;
            this.tableAdapterManager.libroTableAdapter = this.libroTableAdapter;
            this.tableAdapterManager.UpdateOrder = proyectolibreriaOF1.libreriagandtablasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Maroon;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_fecha.Location = new System.Drawing.Point(1125, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(69, 24);
            this.lbl_fecha.TabIndex = 48;
            this.lbl_fecha.Text = "Fecha";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_fecha.Click += new System.EventHandler(this.lbl_fecha_Click);
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Maroon;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_hora.Location = new System.Drawing.Point(1316, 33);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(91, 37);
            this.lbl_hora.TabIndex = 0;
            this.lbl_hora.Text = "Hora";
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // editarlibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1461, 603);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.Intruccion2);
            this.Controls.Add(this.Intruccion1);
            this.Controls.Add(this.dgv_editarlibros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sipnosis);
            this.Controls.Add(this.txtsipnosis);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.paginas);
            this.Controls.Add(this.txtpaginas);
            this.Controls.Add(this.idioma);
            this.Controls.Add(this.txtidioma);
            this.Controls.Add(this.año);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.edicion);
            this.Controls.Add(this.txtedicion);
            this.Controls.Add(this.editorial);
            this.Controls.Add(this.txteditorial);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.TituloLibreria1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TituloEditar);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "editarlibros";
            this.Text = "Sistema de Libreria - Editar Libros";
            this.Load += new System.EventHandler(this.editarlibros_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_editarlibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriagandtablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem solicitarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarComprasToolStripMenuItem;
        private System.Windows.Forms.Label TituloEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TituloLibreria1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label genero;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label edicion;
        private System.Windows.Forms.TextBox txtedicion;
        private System.Windows.Forms.Label editorial;
        private System.Windows.Forms.TextBox txteditorial;
        private System.Windows.Forms.Label idioma;
        private System.Windows.Forms.TextBox txtidioma;
        private System.Windows.Forms.Label año;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label paginas;
        private System.Windows.Forms.TextBox txtpaginas;
        private System.Windows.Forms.Label sipnosis;
        private System.Windows.Forms.TextBox txtsipnosis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_editarlibros;
        private System.Windows.Forms.Label Intruccion1;
        private System.Windows.Forms.Label Intruccion2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancelar;
        private libreriagandtablas libreriagandtablas;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private libreriagandtablasTableAdapters.libroTableAdapter libroTableAdapter;
        private libreriagandtablasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomlibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idiomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sipnosisDataGridViewTextBoxColumn;
    }
}