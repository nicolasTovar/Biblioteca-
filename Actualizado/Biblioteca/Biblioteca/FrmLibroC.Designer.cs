namespace Biblioteca
{
    partial class FrmLibroC
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
            this.gbLibro = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbEditorial = new System.Windows.Forms.ComboBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lsbLibro = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoE = new System.Windows.Forms.TextBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.gbLibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLibro
            // 
            this.gbLibro.Controls.Add(this.btnActualizar);
            this.gbLibro.Controls.Add(this.cbEditorial);
            this.gbLibro.Controls.Add(this.lblEditorial);
            this.gbLibro.Controls.Add(this.btnSalir);
            this.gbLibro.Controls.Add(this.btnN);
            this.gbLibro.Controls.Add(this.btnExcluir);
            this.gbLibro.Controls.Add(this.btnSalvar);
            this.gbLibro.Controls.Add(this.btnIncluir);
            this.gbLibro.Controls.Add(this.lsbLibro);
            this.gbLibro.Controls.Add(this.lblNombre);
            this.gbLibro.Controls.Add(this.lblCodigo);
            this.gbLibro.Controls.Add(this.txtNombre);
            this.gbLibro.Controls.Add(this.txtCodigoE);
            this.gbLibro.Location = new System.Drawing.Point(37, 139);
            this.gbLibro.Name = "gbLibro";
            this.gbLibro.Size = new System.Drawing.Size(727, 208);
            this.gbLibro.TabIndex = 21;
            this.gbLibro.TabStop = false;
            this.gbLibro.Text = "Libro";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(273, 101);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "Actualizar combo box ";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cbEditorial
            // 
            this.cbEditorial.FormattingEnabled = true;
            this.cbEditorial.Location = new System.Drawing.Point(146, 101);
            this.cbEditorial.Name = "cbEditorial";
            this.cbEditorial.Size = new System.Drawing.Size(121, 21);
            this.cbEditorial.TabIndex = 31;
            this.cbEditorial.SelectedIndexChanged += new System.EventHandler(this.cbEditorial_SelectedIndexChanged);
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(25, 101);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(44, 13);
            this.lblEditorial.TabIndex = 30;
            this.lblEditorial.Text = "Editorial";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(646, 179);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(273, 58);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(75, 23);
            this.btnN.TabIndex = 28;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(255, 160);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(134, 160);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(19, 161);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 24;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lsbLibro
            // 
            this.lsbLibro.FormattingEnabled = true;
            this.lsbLibro.Location = new System.Drawing.Point(421, 19);
            this.lsbLibro.Name = "lsbLibro";
            this.lsbLibro.Size = new System.Drawing.Size(289, 95);
            this.lsbLibro.TabIndex = 23;
            this.lsbLibro.SelectedIndexChanged += new System.EventHandler(this.lsbLibro_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 13);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre del libro:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(39, 13);
            this.lblCodigo.TabIndex = 21;
            this.lblCodigo.Text = "código";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // txtCodigoE
            // 
            this.txtCodigoE.Location = new System.Drawing.Point(146, 25);
            this.txtCodigoE.Name = "txtCodigoE";
            this.txtCodigoE.ReadOnly = true;
            this.txtCodigoE.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoE.TabIndex = 19;
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.Location = new System.Drawing.Point(362, 85);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(52, 24);
            this.lblLibro.TabIndex = 20;
            this.lblLibro.Text = "Libro";
            // 
            // FrmLibroC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gbLibro);
            this.Controls.Add(this.lblLibro);
            this.Name = "FrmLibroC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libro";
            this.Load += new System.EventHandler(this.FrmLibroC_Load);
            this.gbLibro.ResumeLayout(false);
            this.gbLibro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLibro;
        private System.Windows.Forms.ComboBox cbEditorial;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ListBox lsbLibro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoE;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Button btnActualizar;
    }
}