namespace prjPurificadora.Vista
{
    partial class frmGastosRuta
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.txtRefaccionaria = new System.Windows.Forms.TextBox();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.tblGastosRuta = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGastosRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtMantenimiento);
            this.groupBox2.Controls.Add(this.txtRefaccionaria);
            this.groupBox2.Controls.Add(this.txtGasolina);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(94, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 146);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gastos";
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Enabled = false;
            this.txtMantenimiento.Location = new System.Drawing.Point(111, 114);
            this.txtMantenimiento.MaxLength = 6;
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(261, 20);
            this.txtMantenimiento.TabIndex = 11;
            this.txtMantenimiento.Text = "0";
            // 
            // txtRefaccionaria
            // 
            this.txtRefaccionaria.Enabled = false;
            this.txtRefaccionaria.Location = new System.Drawing.Point(111, 79);
            this.txtRefaccionaria.MaxLength = 6;
            this.txtRefaccionaria.Name = "txtRefaccionaria";
            this.txtRefaccionaria.Size = new System.Drawing.Size(261, 20);
            this.txtRefaccionaria.TabIndex = 10;
            this.txtRefaccionaria.Text = "0";
            // 
            // txtGasolina
            // 
            this.txtGasolina.Enabled = false;
            this.txtGasolina.Location = new System.Drawing.Point(111, 40);
            this.txtGasolina.MaxLength = 6;
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(261, 20);
            this.txtGasolina.TabIndex = 9;
            this.txtGasolina.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mantenimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Refaccionaria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gasolina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(98, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vendedor:";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Items.AddRange(new object[] {
            "Beto",
            "Felipe",
            "Mundo"});
            this.cmbVendedor.Location = new System.Drawing.Point(172, 103);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(192, 21);
            this.cmbVendedor.TabIndex = 18;
            // 
            // tblGastosRuta
            // 
            this.tblGastosRuta.AllowUserToAddRows = false;
            this.tblGastosRuta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblGastosRuta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblGastosRuta.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblGastosRuta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblGastosRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblGastosRuta.Location = new System.Drawing.Point(94, 341);
            this.tblGastosRuta.Name = "tblGastosRuta";
            this.tblGastosRuta.ReadOnly = true;
            this.tblGastosRuta.Size = new System.Drawing.Size(818, 150);
            this.tblGastosRuta.TabIndex = 49;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(792, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 23);
            this.btnSalir.TabIndex = 65;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(602, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 23);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(253, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 23);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Comfirmar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(94, 295);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 23);
            this.btnNuevo.TabIndex = 60;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(712, 99);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 66;
            this.dtFecha.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(426, 295);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 23);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // frmGastosRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 498);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.tblGastosRuta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVendedor);
            this.Name = "frmGastosRuta";
            this.Text = "Gastos de Ruta";
            this.Controls.SetChildIndex(this.cmbVendedor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.tblGastosRuta, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGastosRuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtMantenimiento;
        public System.Windows.Forms.TextBox txtRefaccionaria;
        public System.Windows.Forms.TextBox txtGasolina;
        public System.Windows.Forms.ComboBox cmbVendedor;
        public System.Windows.Forms.DataGridView tblGastosRuta;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.Button btnModificar;
    }
}