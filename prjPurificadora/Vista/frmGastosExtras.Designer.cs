namespace prjPurificadora.Vista
{
    partial class frmGastosExtras
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
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblGastosExtras = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModifcar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblGastosExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(143, 34);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 67;
            this.dtFecha.Visible = false;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Enabled = false;
            this.txtAsunto.Location = new System.Drawing.Point(143, 117);
            this.txtAsunto.MaxLength = 50;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(261, 20);
            this.txtAsunto.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(80, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Asunto:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(634, 117);
            this.txtTotal.MaxLength = 6;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(261, 20);
            this.txtTotal.TabIndex = 71;
            this.txtTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(571, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Total:";
            // 
            // tblGastosExtras
            // 
            this.tblGastosExtras.AllowUserToAddRows = false;
            this.tblGastosExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblGastosExtras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblGastosExtras.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblGastosExtras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblGastosExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblGastosExtras.Location = new System.Drawing.Point(77, 228);
            this.tblGastosExtras.Name = "tblGastosExtras";
            this.tblGastosExtras.ReadOnly = true;
            this.tblGastosExtras.Size = new System.Drawing.Size(818, 150);
            this.tblGastosExtras.TabIndex = 72;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Location = new System.Drawing.Point(251, 176);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 23);
            this.btnRegistrar.TabIndex = 73;
            this.btnRegistrar.Text = "Confirmar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(775, 176);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 23);
            this.btnSalir.TabIndex = 76;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(599, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 23);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(77, 176);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 23);
            this.btnNuevo.TabIndex = 74;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnModifcar
            // 
            this.btnModifcar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModifcar.Enabled = false;
            this.btnModifcar.FlatAppearance.BorderSize = 0;
            this.btnModifcar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifcar.Location = new System.Drawing.Point(416, 176);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(120, 23);
            this.btnModifcar.TabIndex = 77;
            this.btnModifcar.Text = "Modificar";
            this.btnModifcar.UseVisualStyleBackColor = false;
            // 
            // frmGastosExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 502);
            this.Controls.Add(this.btnModifcar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tblGastosExtras);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFecha);
            this.Name = "frmGastosExtras";
            this.Text = "Gastos Extras";
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtAsunto, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.tblGastosExtras, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnModifcar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblGastosExtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tblGastosExtras;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnModifcar;
    }
}