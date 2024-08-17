namespace prjPurificadora.Vista
{
    partial class frmMantenimiento
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tblMantenimiento = new System.Windows.Forms.DataGridView();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.txtUniformes = new System.Windows.Forms.TextBox();
            this.txtPapeleria = new System.Windows.Forms.TextBox();
            this.txtLuz = new System.Windows.Forms.TextBox();
            this.txtPlanta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Location = new System.Drawing.Point(259, 277);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 23);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // tblMantenimiento
            // 
            this.tblMantenimiento.AllowUserToAddRows = false;
            this.tblMantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblMantenimiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblMantenimiento.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMantenimiento.Location = new System.Drawing.Point(77, 316);
            this.tblMantenimiento.Name = "tblMantenimiento";
            this.tblMantenimiento.ReadOnly = true;
            this.tblMantenimiento.Size = new System.Drawing.Size(835, 150);
            this.tblMantenimiento.TabIndex = 22;
            // 
            // txtOtros
            // 
            this.txtOtros.Enabled = false;
            this.txtOtros.Location = new System.Drawing.Point(664, 157);
            this.txtOtros.MaxLength = 6;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(248, 20);
            this.txtOtros.TabIndex = 21;
            this.txtOtros.Text = "0";
            // 
            // txtUniformes
            // 
            this.txtUniformes.Enabled = false;
            this.txtUniformes.Location = new System.Drawing.Point(664, 114);
            this.txtUniformes.MaxLength = 6;
            this.txtUniformes.Name = "txtUniformes";
            this.txtUniformes.Size = new System.Drawing.Size(248, 20);
            this.txtUniformes.TabIndex = 20;
            this.txtUniformes.Text = "0";
            // 
            // txtPapeleria
            // 
            this.txtPapeleria.Enabled = false;
            this.txtPapeleria.Location = new System.Drawing.Point(156, 199);
            this.txtPapeleria.MaxLength = 6;
            this.txtPapeleria.Name = "txtPapeleria";
            this.txtPapeleria.Size = new System.Drawing.Size(248, 20);
            this.txtPapeleria.TabIndex = 19;
            this.txtPapeleria.Text = "0";
            // 
            // txtLuz
            // 
            this.txtLuz.Enabled = false;
            this.txtLuz.Location = new System.Drawing.Point(156, 157);
            this.txtLuz.MaxLength = 6;
            this.txtLuz.Name = "txtLuz";
            this.txtLuz.Size = new System.Drawing.Size(248, 20);
            this.txtLuz.TabIndex = 18;
            this.txtLuz.Text = "0";
            // 
            // txtPlanta
            // 
            this.txtPlanta.Enabled = false;
            this.txtPlanta.Location = new System.Drawing.Point(156, 118);
            this.txtPlanta.MaxLength = 6;
            this.txtPlanta.Name = "txtPlanta";
            this.txtPlanta.Size = new System.Drawing.Size(248, 20);
            this.txtPlanta.TabIndex = 17;
            this.txtPlanta.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(581, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Otros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(581, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Uniformes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(78, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Papeleria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(78, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Luz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(78, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Man/Plant:";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(191, 12);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 24;
            this.dtFecha.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(79, 277);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 23);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(434, 277);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 23);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(792, 277);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 23);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(613, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Enabled = false;
            this.txtAsunto.Location = new System.Drawing.Point(664, 199);
            this.txtAsunto.MaxLength = 99;
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(248, 56);
            this.txtAsunto.TabIndex = 99;
            this.txtAsunto.Text = "Sin Asunto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(581, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Asunto:";
            // 
            // frmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 498);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tblMantenimiento);
            this.Controls.Add(this.txtOtros);
            this.Controls.Add(this.txtUniformes);
            this.Controls.Add(this.txtPapeleria);
            this.Controls.Add(this.txtLuz);
            this.Controls.Add(this.txtPlanta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMantenimiento";
            this.Text = "Mantenimiento";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtPlanta, 0);
            this.Controls.SetChildIndex(this.txtLuz, 0);
            this.Controls.SetChildIndex(this.txtPapeleria, 0);
            this.Controls.SetChildIndex(this.txtUniformes, 0);
            this.Controls.SetChildIndex(this.txtOtros, 0);
            this.Controls.SetChildIndex(this.tblMantenimiento, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtAsunto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.DataGridView tblMantenimiento;
        public System.Windows.Forms.TextBox txtOtros;
        public System.Windows.Forms.TextBox txtUniformes;
        public System.Windows.Forms.TextBox txtPapeleria;
        public System.Windows.Forms.TextBox txtLuz;
        public System.Windows.Forms.TextBox txtPlanta;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label6;
    }
}