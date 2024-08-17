namespace prjPurificadora.Vista
{
    partial class frmRGastosRuta
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.tblReporte = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaf = new System.Windows.Forms.DateTimePicker();
            this.dtFechai = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.rbtEspecifico = new System.Windows.Forms.RadioButton();
            this.rbtGeneral = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.lblGasolina = new System.Windows.Forms.TextBox();
            this.lblRefaccion = new System.Windows.Forms.TextBox();
            this.lblMecanico = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mecanico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Refaccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Gasolina:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Location = new System.Drawing.Point(565, 134);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(223, 23);
            this.btnContinuar.TabIndex = 19;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // tblReporte
            // 
            this.tblReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblReporte.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblReporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblReporte.Location = new System.Drawing.Point(22, 289);
            this.tblReporte.Name = "tblReporte";
            this.tblReporte.ReadOnly = true;
            this.tblReporte.Size = new System.Drawing.Size(471, 297);
            this.tblReporte.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Día final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Día inicial:";
            // 
            // dtFechaf
            // 
            this.dtFechaf.Location = new System.Drawing.Point(319, 133);
            this.dtFechaf.Name = "dtFechaf";
            this.dtFechaf.Size = new System.Drawing.Size(200, 20);
            this.dtFechaf.TabIndex = 15;
            // 
            // dtFechai
            // 
            this.dtFechai.Location = new System.Drawing.Point(48, 133);
            this.dtFechai.Name = "dtFechai";
            this.dtFechai.Size = new System.Drawing.Size(200, 20);
            this.dtFechai.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbVendedor);
            this.groupBox1.Controls.Add(this.rbtEspecifico);
            this.groupBox1.Controls.Add(this.rbtGeneral);
            this.groupBox1.Location = new System.Drawing.Point(22, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 86);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(297, 19);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(200, 21);
            this.cmbVendedor.TabIndex = 1;
            // 
            // rbtEspecifico
            // 
            this.rbtEspecifico.AutoSize = true;
            this.rbtEspecifico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEspecifico.Location = new System.Drawing.Point(150, 23);
            this.rbtEspecifico.Name = "rbtEspecifico";
            this.rbtEspecifico.Size = new System.Drawing.Size(141, 17);
            this.rbtEspecifico.TabIndex = 1;
            this.rbtEspecifico.TabStop = true;
            this.rbtEspecifico.Text = "Vendedor especifico";
            this.rbtEspecifico.UseVisualStyleBackColor = true;
            // 
            // rbtGeneral
            // 
            this.rbtGeneral.AutoSize = true;
            this.rbtGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGeneral.Location = new System.Drawing.Point(26, 23);
            this.rbtGeneral.Name = "rbtGeneral";
            this.rbtGeneral.Size = new System.Drawing.Size(88, 17);
            this.rbtGeneral.TabIndex = 0;
            this.rbtGeneral.TabStop = true;
            this.rbtGeneral.Text = "En General";
            this.rbtGeneral.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Total:";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPDF.Enabled = false;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(565, 563);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(223, 23);
            this.btnPDF.TabIndex = 34;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // lblGasolina
            // 
            this.lblGasolina.Enabled = false;
            this.lblGasolina.Location = new System.Drawing.Point(649, 289);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(139, 20);
            this.lblGasolina.TabIndex = 35;
            // 
            // lblRefaccion
            // 
            this.lblRefaccion.Enabled = false;
            this.lblRefaccion.Location = new System.Drawing.Point(649, 341);
            this.lblRefaccion.Name = "lblRefaccion";
            this.lblRefaccion.Size = new System.Drawing.Size(139, 20);
            this.lblRefaccion.TabIndex = 36;
            // 
            // lblMecanico
            // 
            this.lblMecanico.Enabled = false;
            this.lblMecanico.Location = new System.Drawing.Point(649, 395);
            this.lblMecanico.Name = "lblMecanico";
            this.lblMecanico.Size = new System.Drawing.Size(139, 20);
            this.lblMecanico.TabIndex = 37;
            // 
            // lblTotal
            // 
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(649, 471);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 20);
            this.lblTotal.TabIndex = 38;
            // 
            // frmRGastosRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 598);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMecanico);
            this.Controls.Add(this.lblRefaccion);
            this.Controls.Add(this.lblGasolina);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.tblReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaf);
            this.Controls.Add(this.dtFechai);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRGastosRuta";
            this.Text = "Gastos por Ruta";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dtFechai, 0);
            this.Controls.SetChildIndex(this.dtFechaf, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tblReporte, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnPDF, 0);
            this.Controls.SetChildIndex(this.lblGasolina, 0);
            this.Controls.SetChildIndex(this.lblRefaccion, 0);
            this.Controls.SetChildIndex(this.lblMecanico, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnContinuar;
        public System.Windows.Forms.DataGridView tblReporte;
        public System.Windows.Forms.DateTimePicker dtFechaf;
        public System.Windows.Forms.DateTimePicker dtFechai;
        public System.Windows.Forms.ComboBox cmbVendedor;
        public System.Windows.Forms.RadioButton rbtEspecifico;
        public System.Windows.Forms.RadioButton rbtGeneral;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnPDF;
        public System.Windows.Forms.TextBox lblGasolina;
        public System.Windows.Forms.TextBox lblRefaccion;
        public System.Windows.Forms.TextBox lblMecanico;
        public System.Windows.Forms.TextBox lblTotal;
    }
}