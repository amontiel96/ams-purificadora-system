namespace prjPurificadora.Vista
{
    partial class frmRVentas
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
            this.label7 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.TextBox();
            this.lblUnidades = new System.Windows.Forms.TextBox();
            this.lblMay2 = new System.Windows.Forms.TextBox();
            this.lblMay1 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.tblPrecios = new System.Windows.Forms.DataGridView();
            this.lblM1 = new System.Windows.Forms.Label();
            this.lblM2 = new System.Windows.Forms.Label();
            this.txtBoni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(545, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Total:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Location = new System.Drawing.Point(561, 132);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(223, 23);
            this.btnContinuar.TabIndex = 34;
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
            this.tblReporte.Location = new System.Drawing.Point(50, 287);
            this.tblReporte.Name = "tblReporte";
            this.tblReporte.ReadOnly = true;
            this.tblReporte.Size = new System.Drawing.Size(471, 299);
            this.tblReporte.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Día final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Día inicial:";
            // 
            // dtFechaf
            // 
            this.dtFechaf.Location = new System.Drawing.Point(321, 131);
            this.dtFechaf.Name = "dtFechaf";
            this.dtFechaf.Size = new System.Drawing.Size(200, 20);
            this.dtFechaf.TabIndex = 30;
            // 
            // dtFechai
            // 
            this.dtFechai.Location = new System.Drawing.Point(45, 131);
            this.dtFechai.Name = "dtFechai";
            this.dtFechai.Size = new System.Drawing.Size(200, 20);
            this.dtFechai.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbVendedor);
            this.groupBox1.Controls.Add(this.rbtEspecifico);
            this.groupBox1.Controls.Add(this.rbtGeneral);
            this.groupBox1.Location = new System.Drawing.Point(30, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 86);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(287, 22);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(195, 21);
            this.cmbVendedor.TabIndex = 1;
            // 
            // rbtEspecifico
            // 
            this.rbtEspecifico.AutoSize = true;
            this.rbtEspecifico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEspecifico.Location = new System.Drawing.Point(140, 23);
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
            this.rbtGeneral.Location = new System.Drawing.Point(21, 26);
            this.rbtGeneral.Name = "rbtGeneral";
            this.rbtGeneral.Size = new System.Drawing.Size(88, 17);
            this.rbtGeneral.TabIndex = 0;
            this.rbtGeneral.TabStop = true;
            this.rbtGeneral.Text = "En General";
            this.rbtGeneral.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Normal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Mayoreo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(545, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Mayoreo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(545, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 49;
            this.label8.Text = "Unidades:";
            // 
            // lblNormal
            // 
            this.lblNormal.Enabled = false;
            this.lblNormal.Location = new System.Drawing.Point(684, 287);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(100, 20);
            this.lblNormal.TabIndex = 51;
            // 
            // lblUnidades
            // 
            this.lblUnidades.Enabled = false;
            this.lblUnidades.Location = new System.Drawing.Point(684, 461);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(100, 20);
            this.lblUnidades.TabIndex = 52;
            // 
            // lblMay2
            // 
            this.lblMay2.Enabled = false;
            this.lblMay2.Location = new System.Drawing.Point(684, 383);
            this.lblMay2.Name = "lblMay2";
            this.lblMay2.Size = new System.Drawing.Size(100, 20);
            this.lblMay2.TabIndex = 53;
            // 
            // lblMay1
            // 
            this.lblMay1.Enabled = false;
            this.lblMay1.Location = new System.Drawing.Point(684, 335);
            this.lblMay1.Name = "lblMay1";
            this.lblMay1.Size = new System.Drawing.Size(100, 20);
            this.lblMay1.TabIndex = 54;
            // 
            // lblTotal
            // 
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(684, 529);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 55;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPDF.Enabled = false;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(542, 563);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(223, 23);
            this.btnPDF.TabIndex = 56;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // tblPrecios
            // 
            this.tblPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPrecios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPrecios.Location = new System.Drawing.Point(703, 217);
            this.tblPrecios.Name = "tblPrecios";
            this.tblPrecios.ReadOnly = true;
            this.tblPrecios.Size = new System.Drawing.Size(81, 16);
            this.tblPrecios.TabIndex = 100;
            this.tblPrecios.Visible = false;
            // 
            // lblM1
            // 
            this.lblM1.AutoSize = true;
            this.lblM1.BackColor = System.Drawing.Color.Transparent;
            this.lblM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM1.Location = new System.Drawing.Point(643, 335);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(21, 24);
            this.lblM1.TabIndex = 101;
            this.lblM1.Text = "1";
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.BackColor = System.Drawing.Color.Transparent;
            this.lblM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM2.Location = new System.Drawing.Point(643, 383);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(21, 24);
            this.lblM2.TabIndex = 102;
            this.lblM2.Text = "2";
            // 
            // txtBoni
            // 
            this.txtBoni.Enabled = false;
            this.txtBoni.Location = new System.Drawing.Point(684, 421);
            this.txtBoni.Name = "txtBoni";
            this.txtBoni.Size = new System.Drawing.Size(100, 20);
            this.txtBoni.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 103;
            this.label3.Text = "Bonificados:";
            // 
            // frmRVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 598);
            this.Controls.Add(this.txtBoni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblM2);
            this.Controls.Add(this.lblM1);
            this.Controls.Add(this.tblPrecios);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMay1);
            this.Controls.Add(this.lblMay2);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.lblNormal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.tblReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaf);
            this.Controls.Add(this.dtFechai);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRVentas";
            this.Text = "Reporte de ventas";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dtFechai, 0);
            this.Controls.SetChildIndex(this.dtFechaf, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tblReporte, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblNormal, 0);
            this.Controls.SetChildIndex(this.lblUnidades, 0);
            this.Controls.SetChildIndex(this.lblMay2, 0);
            this.Controls.SetChildIndex(this.lblMay1, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.btnPDF, 0);
            this.Controls.SetChildIndex(this.tblPrecios, 0);
            this.Controls.SetChildIndex(this.lblM1, 0);
            this.Controls.SetChildIndex(this.lblM2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtBoni, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnContinuar;
        public System.Windows.Forms.DataGridView tblReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtFechaf;
        public System.Windows.Forms.DateTimePicker dtFechai;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbVendedor;
        public System.Windows.Forms.RadioButton rbtEspecifico;
        public System.Windows.Forms.RadioButton rbtGeneral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox lblNormal;
        public System.Windows.Forms.TextBox lblUnidades;
        public System.Windows.Forms.TextBox lblMay2;
        public System.Windows.Forms.TextBox lblMay1;
        public System.Windows.Forms.TextBox lblTotal;
        public System.Windows.Forms.Button btnPDF;
        public System.Windows.Forms.DataGridView tblPrecios;
        public System.Windows.Forms.Label lblM1;
        public System.Windows.Forms.Label lblM2;
        public System.Windows.Forms.TextBox txtBoni;
        private System.Windows.Forms.Label label3;
    }
}