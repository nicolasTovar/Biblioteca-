namespace Biblioteca
{
    partial class FrmCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrud));
            this.tsBiblioteca = new System.Windows.Forms.ToolStrip();
            this.tsbCrudeditorial = new System.Windows.Forms.ToolStripButton();
            this.tsbCrudlibro = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.msBiblioteca = new System.Windows.Forms.MenuStrip();
            this.tsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditorial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBiblioteca.SuspendLayout();
            this.msBiblioteca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBiblioteca
            // 
            this.tsBiblioteca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCrudeditorial,
            this.tsbCrudlibro,
            this.tsbSalir});
            this.tsBiblioteca.Location = new System.Drawing.Point(0, 24);
            this.tsBiblioteca.Name = "tsBiblioteca";
            this.tsBiblioteca.Size = new System.Drawing.Size(800, 25);
            this.tsBiblioteca.TabIndex = 5;
            this.tsBiblioteca.Text = "toolStrip1";
            // 
            // tsbCrudeditorial
            // 
            this.tsbCrudeditorial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCrudeditorial.Image = ((System.Drawing.Image)(resources.GetObject("tsbCrudeditorial.Image")));
            this.tsbCrudeditorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCrudeditorial.Name = "tsbCrudeditorial";
            this.tsbCrudeditorial.Size = new System.Drawing.Size(23, 22);
            this.tsbCrudeditorial.Text = "Editorial";
            this.tsbCrudeditorial.Click += new System.EventHandler(this.tsbCrudeditorial_Click);
            // 
            // tsbCrudlibro
            // 
            this.tsbCrudlibro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCrudlibro.Image = ((System.Drawing.Image)(resources.GetObject("tsbCrudlibro.Image")));
            this.tsbCrudlibro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCrudlibro.Name = "tsbCrudlibro";
            this.tsbCrudlibro.Size = new System.Drawing.Size(23, 22);
            this.tsbCrudlibro.Text = "Libro";
            this.tsbCrudlibro.Click += new System.EventHandler(this.tsbCrudlibro_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // msBiblioteca
            // 
            this.msBiblioteca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsArchivo,
            this.tsSalir});
            this.msBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.msBiblioteca.Name = "msBiblioteca";
            this.msBiblioteca.Size = new System.Drawing.Size(800, 24);
            this.msBiblioteca.TabIndex = 4;
            this.msBiblioteca.Text = "menuStrip1";
            // 
            // tsArchivo
            // 
            this.tsArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEditorial,
            this.tsLibro});
            this.tsArchivo.Name = "tsArchivo";
            this.tsArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsArchivo.Text = "A&rchivo";
            // 
            // tsEditorial
            // 
            this.tsEditorial.Name = "tsEditorial";
            this.tsEditorial.Size = new System.Drawing.Size(180, 22);
            this.tsEditorial.Text = "E&ditorial";
            this.tsEditorial.Click += new System.EventHandler(this.tsEditorial_Click);
            // 
            // tsLibro
            // 
            this.tsLibro.Name = "tsLibro";
            this.tsLibro.Size = new System.Drawing.Size(180, 22);
            this.tsLibro.Text = "L&ibro";
            this.tsLibro.Click += new System.EventHandler(this.tsLibro_Click);
            // 
            // tsSalir
            // 
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(41, 20);
            this.tsSalir.Text = "S&alir";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // FrmCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsBiblioteca);
            this.Controls.Add(this.msBiblioteca);
            this.IsMdiContainer = true;
            this.Name = "FrmCrud";
            this.Text = "Crud";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsBiblioteca.ResumeLayout(false);
            this.tsBiblioteca.PerformLayout();
            this.msBiblioteca.ResumeLayout(false);
            this.msBiblioteca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBiblioteca;
        private System.Windows.Forms.ToolStripButton tsbCrudeditorial;
        private System.Windows.Forms.ToolStripButton tsbCrudlibro;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.MenuStrip msBiblioteca;
        private System.Windows.Forms.ToolStripMenuItem tsArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsEditorial;
        private System.Windows.Forms.ToolStripMenuItem tsLibro;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
    }
}