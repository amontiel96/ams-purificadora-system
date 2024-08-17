namespace prjPurificadora.Vista
{
    partial class frmRAdministrador
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.tblReporte = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaf = new System.Windows.Forms.DateTimePicker();
            this.dtFechai = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.lblPlanta = new System.Windows.Forms.TextBox();
            this.lblLuz = new System.Windows.Forms.TextBox();
            this.lblPapeleria = new System.Windows.Forms.TextBox();
            this.lblUniformes = new System.Windows.Forms.TextBox();
            this.lblOtros = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Total:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Location = new System.Drawing.Point(565, 144);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(223, 23);
            this.btnContinuar.TabIndex = 28;
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
            this.tblReporte.Location = new System.Drawing.Point(53, 219);
            this.tblReporte.Name = "tblReporte";
            this.tblReporte.ReadOnly = true;
            this.tblReporte.Size = new System.Drawing.Size(471, 334);
            this.tblReporte.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Día final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Día inicial:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtFechaf
            // 
            this.dtFechaf.Location = new System.Drawing.Point(324, 143);
            this.dtFechaf.Name = "dtFechaf";
            this.dtFechaf.Size = new System.Drawing.Size(200, 20);
            this.dtFechaf.TabIndex = 24;
            // 
            // dtFechai
            // 
            this.dtFechai.Location = new System.Drawing.Point(53, 143);
            this.dtFechai.Name = "dtFechai";
            this.dtFechai.Size = new System.Drawing.Size(200, 20);
            this.dtFechai.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Planta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Luz:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(546, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Papelaria:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(546, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 37;
            this.label11.Text = "Uniformes:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(546, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 39;
            this.label13.Text = "Otros:";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPDF.Enabled = false;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(565, 530);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(223, 23);
            this.btnPDF.TabIndex = 41;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // lblPlanta
            // 
            this.lblPlanta.Enabled = false;
            this.lblPlanta.Location = new System.Drawing.Point(649, 219);
            this.lblPlanta.Name = "lblPlanta";
            this.lblPlanta.Size = new System.Drawing.Size(139, 20);
            this.lblPlanta.TabIndex = 42;
            // 
            // lblLuz
            // 
            this.lblLuz.Enabled = false;
            this.lblLuz.Location = new System.Drawing.Point(649, 265);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(139, 20);
            this.lblLuz.TabIndex = 43;
            // 
            // lblPapeleria
            // 
            this.lblPapeleria.Enabled = false;
            this.lblPapeleria.Location = new System.Drawing.Point(649, 312);
            this.lblPapeleria.Name = "lblPapeleria";
            this.lblPapeleria.Size = new System.Drawing.Size(139, 20);
            this.lblPapeleria.TabIndex = 44;
            // 
            // lblUniformes
            // 
            this.lblUniformes.Enabled = false;
            this.lblUniformes.Location = new System.Drawing.Point(649, 355);
            this.lblUniformes.Name = "lblUniformes";
            this.lblUniformes.Size = new System.Drawing.Size(139, 20);
            this.lblUniformes.TabIndex = 45;
            // 
            // lblOtros
            // 
            this.lblOtros.Enabled = false;
            this.lblOtros.Location = new System.Drawing.Point(649, 398);
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(139, 20);
            this.lblOtros.TabIndex = 46;
            // 
            // lblTotal
            // 
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(649, 496);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 20);
            this.lblTotal.TabIndex = 47;
            // 
            // frmRAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 598);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOtros);
            this.Controls.Add(this.lblUniformes);
            this.Controls.Add(this.lblPapeleria);
            this.Controls.Add(this.lblLuz);
            this.Controls.Add(this.lblPlanta);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.tblReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaf);
            this.Controls.Add(this.dtFechai);
            this.Name = "frmRAdministrador";
            this.Text = "Gastos de Administrador";
            this.Controls.SetChildIndex(this.dtFechai, 0);
            this.Controls.SetChildIndex(this.dtFechaf, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tblReporte, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.btnPDF, 0);
            this.Controls.SetChildIndex(this.lblPlanta, 0);
            this.Controls.SetChildIndex(this.lblLuz, 0);
            this.Controls.SetChildIndex(this.lblPapeleria, 0);
            this.Controls.SetChildIndex(this.lblUniformes, 0);
            this.Controls.SetChildIndex(this.lblOtros, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnContinuar;
        public System.Windows.Forms.DataGridView tblReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtFechaf;
        public System.Windows.Forms.DateTimePicker dtFechai;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button btnPDF;
        public System.Windows.Forms.TextBox lblPlanta;
        public System.Windows.Forms.TextBox lblLuz;
        public System.Windows.Forms.TextBox lblPapeleria;
        public System.Windows.Forms.TextBox lblUniformes;
        public System.Windows.Forms.TextBox lblOtros;
        public System.Windows.Forms.TextBox lblTotal;
    }
}