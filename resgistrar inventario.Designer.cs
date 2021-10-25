
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
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightGreen;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.consultarComprasToolStripMenuItem,
            this.editarLibrosToolStripMenuItem,
            this.solicitarLibrosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.consultarToolStripMenuItem.Text = "consultar clientes";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // consultarComprasToolStripMenuItem
            // 
            this.consultarComprasToolStripMenuItem.Name = "consultarComprasToolStripMenuItem";
            this.consultarComprasToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.consultarComprasToolStripMenuItem.Text = "consultar compras";
            this.consultarComprasToolStripMenuItem.Click += new System.EventHandler(this.consultarComprasToolStripMenuItem_Click);
            // 
            // editarLibrosToolStripMenuItem
            // 
            this.editarLibrosToolStripMenuItem.Name = "editarLibrosToolStripMenuItem";
            this.editarLibrosToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.editarLibrosToolStripMenuItem.Text = "editar libros";
            this.editarLibrosToolStripMenuItem.Click += new System.EventHandler(this.editarLibrosToolStripMenuItem_Click);
            // 
            // solicitarLibrosToolStripMenuItem
            // 
            this.solicitarLibrosToolStripMenuItem.Name = "solicitarLibrosToolStripMenuItem";
            this.solicitarLibrosToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.solicitarLibrosToolStripMenuItem.Text = "solicitar libros";
            this.solicitarLibrosToolStripMenuItem.Click += new System.EventHandler(this.solicitarLibrosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(193, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(875, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "registrar inventario";
            // 
            // resgistrar_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "resgistrar_inventario";
            this.Text = "resgistrar_inventario";
            this.Load += new System.EventHandler(this.resgistrar_inventario_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLibrosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem solicitarLibrosToolStripMenuItem;
    }
}