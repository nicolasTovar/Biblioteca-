namespace Biblioteca
{
    partial class FrmEditorialC
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
            this.lblEditorial = new System.Windows.Forms.Label();
            this.gbEditorial = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lsbEditorial = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoE = new System.Windows.Forms.TextBox();
            this.gbEditorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(335, 85);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(77, 24);
            this.lblEditorial.TabIndex = 10;
            this.lblEditorial.Text = "Editorial";
            // 
            // gbEditorial
            // 
            this.gbEditorial.Controls.Add(this.btnSalir);
            this.gbEditorial.Controls.Add(this.btnN);
            this.gbEditorial.Controls.Add(this.btnExcluir);
            this.gbEditorial.Controls.Add(this.btnSalvar);
            this.gbEditorial.Controls.Add(this.btnIncluir);
            this.gbEditorial.Controls.Add(this.lsbEditorial);
            this.gbEditorial.Controls.Add(this.lblNombre);
            this.gbEditorial.Controls.Add(this.lblCodigo);
            this.gbEditorial.Controls.Add(this.txtNombre);
            this.gbEditorial.Controls.Add(this.txtCodigoE);
            this.gbEditorial.Location = new System.Drawing.Point(61, 121);
            this.gbEditorial.Name = "gbEditorial";
            this.gbEditorial.Size = new System.Drawing.Size(727, 208);
            this.gbEditorial.TabIndex = 19;
            this.gbEditorial.TabStop = false;
            this.gbEditorial.Text = "Editorial ";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(646, 161);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(255, 85);
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
            // lsbEditorial
            // 
            this.lsbEditorial.FormattingEnabled = true;
            this.lsbEditorial.Location = new System.Drawing.Point(421, 19);
            this.lsbEditorial.Name = "lsbEditorial";
            this.lsbEditorial.Size = new System.Drawing.Size(289, 95);
            this.lsbEditorial.TabIndex = 23;
            this.lsbEditorial.SelectedIndexChanged += new System.EventHandler(this.lsbEditorial_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 13);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre del editorial:";
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
            this.txtNombre.Location = new System.Drawing.Point(137, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigoE
            // 
            this.txtCodigoE.Location = new System.Drawing.Point(137, 25);
            this.txtCodigoE.Name = "txtCodigoE";
            this.txtCodigoE.ReadOnly = true;
            this.txtCodigoE.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoE.TabIndex = 19;
            // 
            // FrmEditorialC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gbEditorial);
            this.Controls.Add(this.lblEditorial);
            this.Name = "FrmEditorialC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editorial";
            this.Load += new System.EventHandler(this.FrmEditorialC_Load);
            this.gbEditorial.ResumeLayout(false);
            this.gbEditorial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.GroupBox gbEditorial;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ListBox lsbEditorial;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoE;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnSalir;
    }
}