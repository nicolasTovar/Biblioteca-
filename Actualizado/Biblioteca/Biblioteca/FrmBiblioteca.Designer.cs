namespace Biblioteca
{
    partial class FrmBiblioteca
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiblioteca));
            this.msBiblioteca = new System.Windows.Forms.MenuStrip();
            this.tsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBiblioteca = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBibliotecaSena = new System.Windows.Forms.ToolStrip();
            this.tsbBiblioteca = new System.Windows.Forms.ToolStripButton();
            this.tsbEditorial = new System.Windows.Forms.ToolStripButton();
            this.tsbLibro = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.msBiblioteca.SuspendLayout();
            this.tsBibliotecaSena.SuspendLayout();
            this.SuspendLayout();
            // 
            // msBiblioteca
            // 
            this.msBiblioteca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsArchivo,
            this.tsSalir});
            this.msBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.msBiblioteca.Name = "msBiblioteca";
            this.msBiblioteca.Size = new System.Drawing.Size(800, 24);
            this.msBiblioteca.TabIndex = 1;
            this.msBiblioteca.Text = "menuStrip1";
            this.msBiblioteca.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msBiblioteca_ItemClicked);
            // 
            // tsArchivo
            // 
            this.tsArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBiblioteca,
            this.editorialToolStripMenuItem,
            this.libroToolStripMenuItem});
            this.tsArchivo.Name = "tsArchivo";
            this.tsArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsArchivo.Text = "A&rchivo";
            // 
            // tsBiblioteca
            // 
            this.tsBiblioteca.Name = "tsBiblioteca";
            this.tsBiblioteca.Size = new System.Drawing.Size(126, 22);
            this.tsBiblioteca.Text = "B&iblioteca";
            this.tsBiblioteca.Click += new System.EventHandler(this.tsBiblioteca_Click);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.editorialToolStripMenuItem.Text = "E&ditorial";
            this.editorialToolStripMenuItem.Click += new System.EventHandler(this.editorialToolStripMenuItem_Click);
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.libroToolStripMenuItem.Text = "L&ibro";
            this.libroToolStripMenuItem.Click += new System.EventHandler(this.libroToolStripMenuItem_Click);
            // 
            // tsSalir
            // 
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(41, 20);
            this.tsSalir.Text = "S&alir";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // tsBibliotecaSena
            // 
            this.tsBibliotecaSena.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBiblioteca,
            this.tsbEditorial,
            this.tsbLibro,
            this.tsbSalir});
            this.tsBibliotecaSena.Location = new System.Drawing.Point(0, 24);
            this.tsBibliotecaSena.Name = "tsBibliotecaSena";
            this.tsBibliotecaSena.Size = new System.Drawing.Size(800, 25);
            this.tsBibliotecaSena.TabIndex = 3;
            this.tsBibliotecaSena.Text = "toolStrip1";
            this.tsBibliotecaSena.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsBibliotecaSena_ItemClicked);
            // 
            // tsbBiblioteca
            // 
            this.tsbBiblioteca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBiblioteca.Image = ((System.Drawing.Image)(resources.GetObject("tsbBiblioteca.Image")));
            this.tsbBiblioteca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBiblioteca.Name = "tsbBiblioteca";
            this.tsbBiblioteca.Size = new System.Drawing.Size(23, 22);
            this.tsbBiblioteca.Text = "Biblioteca";
            this.tsbBiblioteca.Click += new System.EventHandler(this.tsbBiblioteca_Click);
            // 
            // tsbEditorial
            // 
            this.tsbEditorial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditorial.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditorial.Image")));
            this.tsbEditorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditorial.Name = "tsbEditorial";
            this.tsbEditorial.Size = new System.Drawing.Size(23, 22);
            this.tsbEditorial.Text = "Editorial";
            this.tsbEditorial.Click += new System.EventHandler(this.tsbEditorial_Click);
            // 
            // tsbLibro
            // 
            this.tsbLibro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLibro.Image = ((System.Drawing.Image)(resources.GetObject("tsbLibro.Image")));
            this.tsbLibro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLibro.Name = "tsbLibro";
            this.tsbLibro.Size = new System.Drawing.Size(23, 22);
            this.tsbLibro.Text = "Libro";
            this.tsbLibro.Click += new System.EventHandler(this.tsbLibro_Click);
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
            // FrmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tsBibliotecaSena);
            this.Controls.Add(this.msBiblioteca);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msBiblioteca;
            this.Name = "FrmBiblioteca";
            this.Text = "Biblioteca Sena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBiblioteca_Load);
            this.msBiblioteca.ResumeLayout(false);
            this.msBiblioteca.PerformLayout();
            this.tsBibliotecaSena.ResumeLayout(false);
            this.tsBibliotecaSena.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msBiblioteca;
        private System.Windows.Forms.ToolStripMenuItem tsArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsBiblioteca;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsBibliotecaSena;
        private System.Windows.Forms.ToolStripButton tsbBiblioteca;
        private System.Windows.Forms.ToolStripButton tsbEditorial;
        private System.Windows.Forms.ToolStripButton tsbLibro;
        private System.Windows.Forms.ToolStripButton tsbSalir;
    }
}

