namespace Biblioteca
{
    partial class FrmBibliotecaSena
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
            this.gbMostrar = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.cbNombres = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.lblInicial = new System.Windows.Forms.Label();
            this.dgBiblioteca = new System.Windows.Forms.DataGridView();
            this.btnTeditorial = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.gbFdos = new System.Windows.Forms.GroupBox();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnAsc = new System.Windows.Forms.Button();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBiblioteca)).BeginInit();
            this.gbFdos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMostrar
            // 
            this.gbMostrar.BackColor = System.Drawing.Color.White;
            this.gbMostrar.Controls.Add(this.btnQuitar);
            this.gbMostrar.Controls.Add(this.lblEditorial);
            this.gbMostrar.Controls.Add(this.cbNombres);
            this.gbMostrar.Controls.Add(this.btnFiltrar);
            this.gbMostrar.Controls.Add(this.txtInicial);
            this.gbMostrar.Controls.Add(this.lblInicial);
            this.gbMostrar.Location = new System.Drawing.Point(55, 12);
            this.gbMostrar.Name = "gbMostrar";
            this.gbMostrar.Size = new System.Drawing.Size(405, 100);
            this.gbMostrar.TabIndex = 0;
            this.gbMostrar.TabStop = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(310, 71);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar Filtro";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(17, 49);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(133, 13);
            this.lblEditorial.TabIndex = 4;
            this.lblEditorial.Text = "Nombres de los editoriales:";
            // 
            // cbNombres
            // 
            this.cbNombres.FormattingEnabled = true;
            this.cbNombres.Location = new System.Drawing.Point(156, 43);
            this.cbNombres.Name = "cbNombres";
            this.cbNombres.Size = new System.Drawing.Size(121, 21);
            this.cbNombres.TabIndex = 3;
            this.cbNombres.SelectedIndexChanged += new System.EventHandler(this.cbNombres_SelectedIndexChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(310, 19);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(156, 17);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(100, 20);
            this.txtInicial.TabIndex = 1;
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Location = new System.Drawing.Point(17, 20);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(76, 13);
            this.lblInicial.TabIndex = 0;
            this.lblInicial.Text = "Inicial del libro:";
            // 
            // dgBiblioteca
            // 
            this.dgBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBiblioteca.Location = new System.Drawing.Point(101, 177);
            this.dgBiblioteca.Name = "dgBiblioteca";
            this.dgBiblioteca.Size = new System.Drawing.Size(601, 201);
            this.dgBiblioteca.TabIndex = 1;
            // 
            // btnTeditorial
            // 
            this.btnTeditorial.Location = new System.Drawing.Point(181, 148);
            this.btnTeditorial.Name = "btnTeditorial";
            this.btnTeditorial.Size = new System.Drawing.Size(136, 23);
            this.btnTeditorial.TabIndex = 3;
            this.btnTeditorial.Text = "Tabla Editorial";
            this.btnTeditorial.UseVisualStyleBackColor = true;
            this.btnTeditorial.Click += new System.EventHandler(this.btnTeditorial_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.Location = new System.Drawing.Point(455, 148);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(125, 23);
            this.btnLibro.TabIndex = 4;
            this.btnLibro.Text = "Tabla Libro";
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // gbFdos
            // 
            this.gbFdos.BackColor = System.Drawing.Color.White;
            this.gbFdos.Controls.Add(this.btnDesc);
            this.gbFdos.Controls.Add(this.btnAsc);
            this.gbFdos.Controls.Add(this.lstLibros);
            this.gbFdos.Location = new System.Drawing.Point(509, 6);
            this.gbFdos.Name = "gbFdos";
            this.gbFdos.Size = new System.Drawing.Size(245, 117);
            this.gbFdos.TabIndex = 5;
            this.gbFdos.TabStop = false;
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(142, 59);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(75, 23);
            this.btnDesc.TabIndex = 6;
            this.btnDesc.Text = "Desc";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.Location = new System.Drawing.Point(142, 19);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(75, 23);
            this.btnAsc.TabIndex = 5;
            this.btnAsc.Text = "Asc";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.Location = new System.Drawing.Point(6, 19);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(120, 95);
            this.lstLibros.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(651, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmBibliotecaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbFdos);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.btnTeditorial);
            this.Controls.Add(this.dgBiblioteca);
            this.Controls.Add(this.gbMostrar);
            this.Name = "FrmBibliotecaSena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Sena";
            this.Load += new System.EventHandler(this.FrmBibliotecaSena_Load);
            this.gbMostrar.ResumeLayout(false);
            this.gbMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBiblioteca)).EndInit();
            this.gbFdos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMostrar;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.DataGridView dgBiblioteca;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnTeditorial;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.ComboBox cbNombres;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.GroupBox gbFdos;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnQuitar;
    }
}