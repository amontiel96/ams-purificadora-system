namespace prjPurificadora.Vista
{
    partial class frmCorteEmpleados
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.tblEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDespensa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtSueldoTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComfirmar = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblExiste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblExiste)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(381, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 103;
            this.label8.Text = "Día final:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(113, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 102;
            this.label7.Text = "Día inicial:";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Location = new System.Drawing.Point(437, 33);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFinal.TabIndex = 101;
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Location = new System.Drawing.Point(175, 34);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicial.TabIndex = 100;
            // 
            // tblEmpleados
            // 
            this.tblEmpleados.AllowUserToAddRows = false;
            this.tblEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblEmpleados.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmpleados.Location = new System.Drawing.Point(76, 141);
            this.tblEmpleados.Name = "tblEmpleados";
            this.tblEmpleados.ReadOnly = true;
            this.tblEmpleados.Size = new System.Drawing.Size(835, 170);
            this.tblEmpleados.TabIndex = 99;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(644, 32);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 98;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Enabled = false;
            this.txtDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeuda.Location = new System.Drawing.Point(181, 334);
            this.txtDeuda.MaxLength = 6;
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(192, 21);
            this.txtDeuda.TabIndex = 110;
            this.txtDeuda.Text = "0";
            // 
            // txtBono
            // 
            this.txtBono.Enabled = false;
            this.txtBono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBono.Location = new System.Drawing.Point(181, 387);
            this.txtBono.MaxLength = 6;
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(192, 21);
            this.txtBono.TabIndex = 109;
            this.txtBono.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 108;
            this.label11.Text = "Bono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 107;
            this.label10.Text = "Deuda:";
            // 
            // txtDespensa
            // 
            this.txtDespensa.Enabled = false;
            this.txtDespensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespensa.Location = new System.Drawing.Point(181, 442);
            this.txtDespensa.MaxLength = 6;
            this.txtDespensa.Name = "txtDespensa";
            this.txtDespensa.Size = new System.Drawing.Size(192, 21);
            this.txtDespensa.TabIndex = 106;
            this.txtDespensa.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 105;
            this.label4.Text = "Despensa:";
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(719, 331);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(192, 21);
            this.txtSalario.TabIndex = 114;
            this.txtSalario.Text = "0";
            // 
            // txtSueldoTotal
            // 
            this.txtSueldoTotal.Enabled = false;
            this.txtSueldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoTotal.Location = new System.Drawing.Point(719, 384);
            this.txtSueldoTotal.MaxLength = 6;
            this.txtSueldoTotal.Name = "txtSueldoTotal";
            this.txtSueldoTotal.Size = new System.Drawing.Size(192, 21);
            this.txtSueldoTotal.TabIndex = 113;
            this.txtSueldoTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 112;
            this.label1.Text = "Sueldo Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 111;
            this.label2.Text = "Salario:";
            // 
            // btnComfirmar
            // 
            this.btnComfirmar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComfirmar.Enabled = false;
            this.btnComfirmar.FlatAppearance.BorderSize = 0;
            this.btnComfirmar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnComfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnComfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnComfirmar.Location = new System.Drawing.Point(719, 437);
            this.btnComfirmar.Name = "btnComfirmar";
            this.btnComfirmar.Size = new System.Drawing.Size(192, 23);
            this.btnComfirmar.TabIndex = 115;
            this.btnComfirmar.Text = "Confirmar...";
            this.btnComfirmar.UseVisualStyleBackColor = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(551, 470);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 116;
            this.dtFecha.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtFechaInicial);
            this.groupBox1.Controls.Add(this.dtFechaFinal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(75, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 10);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione al empleado a pagar";
            this.groupBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 119;
            this.label3.Text = "Fecha de pago:";
            this.label3.Visible = false;
            // 
            // tblExiste
            // 
            this.tblExiste.AllowUserToAddRows = false;
            this.tblExiste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblExiste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblExiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblExiste.Location = new System.Drawing.Point(390, 349);
            this.tblExiste.Name = "tblExiste";
            this.tblExiste.ReadOnly = true;
            this.tblExiste.Size = new System.Drawing.Size(214, 53);
            this.tblExiste.TabIndex = 120;
            this.tblExiste.Visible = false;
            // 
            // frmCorteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 502);
            this.Controls.Add(this.tblExiste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnComfirmar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtSueldoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.txtBono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDespensa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tblEmpleados);
            this.Name = "frmCorteEmpleados";
            this.Text = "frmCorteEmpleados";
            this.Controls.SetChildIndex(this.tblEmpleados, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDespensa, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtBono, 0);
            this.Controls.SetChildIndex(this.txtDeuda, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSueldoTotal, 0);
            this.Controls.SetChildIndex(this.txtSalario, 0);
            this.Controls.SetChildIndex(this.btnComfirmar, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tblExiste, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblExiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtFechaFinal;
        public System.Windows.Forms.DateTimePicker dtFechaInicial;
        public System.Windows.Forms.DataGridView tblEmpleados;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.TextBox txtDeuda;
        public System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtDespensa;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSalario;
        public System.Windows.Forms.TextBox txtSueldoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnComfirmar;
        public System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView tblExiste;
    }
}