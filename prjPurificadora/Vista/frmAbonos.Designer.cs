namespace prjPurificadora.Vista
{
    partial class frmAbonos
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
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblDeudas = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeudas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Location = new System.Drawing.Point(812, 373);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar...";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtAbono
            // 
            this.txtAbono.Enabled = false;
            this.txtAbono.Location = new System.Drawing.Point(661, 376);
            this.txtAbono.MaxLength = 6;
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(100, 20);
            this.txtAbono.TabIndex = 24;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Enabled = false;
            this.txtDeuda.Location = new System.Drawing.Point(412, 376);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 20);
            this.txtDeuda.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(558, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad a abonar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(347, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Deuda:";
            // 
            // tblDeudas
            // 
            this.tblDeudas.AllowUserToAddRows = false;
            this.tblDeudas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDeudas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblDeudas.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblDeudas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDeudas.Location = new System.Drawing.Point(127, 160);
            this.tblDeudas.Name = "tblDeudas";
            this.tblDeudas.ReadOnly = true;
            this.tblDeudas.Size = new System.Drawing.Size(785, 190);
            this.tblDeudas.TabIndex = 18;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(414, 110);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(130, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
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
            this.cmbVendedor.Location = new System.Drawing.Point(204, 112);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(192, 21);
            this.cmbVendedor.TabIndex = 15;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(547, 104);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 26;
            this.dtFecha.Visible = false;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(198, 376);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(133, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cliente:";
            // 
            // frmAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 498);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tblDeudas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVendedor);
            this.Name = "frmAbonos";
            this.Text = "Abonos";
            this.Controls.SetChildIndex(this.cmbVendedor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.tblDeudas, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDeuda, 0);
            this.Controls.SetChildIndex(this.txtAbono, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtIdCliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblDeudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.DataGridView tblDeudas;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.TextBox txtAbono;
        public System.Windows.Forms.TextBox txtDeuda;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.ComboBox cmbVendedor;
        public System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label2;
    }
}