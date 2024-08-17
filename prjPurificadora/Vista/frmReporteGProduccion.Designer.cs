namespace prjPurificadora.Vista
{
    partial class frmReporteGProduccion
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
            this.tblBote = new System.Windows.Forms.DataGridView();
            this.tblSellosyTapones = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.TextBox();
            this.lblBotellones = new System.Windows.Forms.TextBox();
            this.lblSellos = new System.Windows.Forms.TextBox();
            this.lblTapones = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.tblPrecios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSellosyTapones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Location = new System.Drawing.Point(550, 142);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(223, 23);
            this.btnContinuar.TabIndex = 18;
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
            this.tblReporte.Location = new System.Drawing.Point(22, 219);
            this.tblReporte.Name = "tblReporte";
            this.tblReporte.ReadOnly = true;
            this.tblReporte.Size = new System.Drawing.Size(471, 350);
            this.tblReporte.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Día final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Día inicial:";
            // 
            // dtFechaf
            // 
            this.dtFechaf.Location = new System.Drawing.Point(293, 141);
            this.dtFechaf.Name = "dtFechaf";
            this.dtFechaf.Size = new System.Drawing.Size(200, 20);
            this.dtFechaf.TabIndex = 14;
            // 
            // dtFechai
            // 
            this.dtFechai.Location = new System.Drawing.Point(22, 141);
            this.dtFechai.Name = "dtFechai";
            this.dtFechai.Size = new System.Drawing.Size(200, 20);
            this.dtFechai.TabIndex = 13;
            // 
            // tblBote
            // 
            this.tblBote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblBote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblBote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBote.Location = new System.Drawing.Point(526, 530);
            this.tblBote.Name = "tblBote";
            this.tblBote.ReadOnly = true;
            this.tblBote.Size = new System.Drawing.Size(81, 10);
            this.tblBote.TabIndex = 23;
            this.tblBote.Visible = false;
            // 
            // tblSellosyTapones
            // 
            this.tblSellosyTapones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSellosyTapones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblSellosyTapones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSellosyTapones.Location = new System.Drawing.Point(526, 575);
            this.tblSellosyTapones.Name = "tblSellosyTapones";
            this.tblSellosyTapones.ReadOnly = true;
            this.tblSellosyTapones.Size = new System.Drawing.Size(81, 16);
            this.tblSellosyTapones.TabIndex = 24;
            this.tblSellosyTapones.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Productos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Botellones:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(509, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Sellos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(509, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 24);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tapones:";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPDF.Enabled = false;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(550, 546);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(223, 23);
            this.btnPDF.TabIndex = 33;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // lblProductos
            // 
            this.lblProductos.Enabled = false;
            this.lblProductos.Location = new System.Drawing.Point(634, 223);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(139, 20);
            this.lblProductos.TabIndex = 34;
            // 
            // lblBotellones
            // 
            this.lblBotellones.Enabled = false;
            this.lblBotellones.Location = new System.Drawing.Point(634, 283);
            this.lblBotellones.Name = "lblBotellones";
            this.lblBotellones.Size = new System.Drawing.Size(139, 20);
            this.lblBotellones.TabIndex = 35;
            // 
            // lblSellos
            // 
            this.lblSellos.Enabled = false;
            this.lblSellos.Location = new System.Drawing.Point(634, 342);
            this.lblSellos.Name = "lblSellos";
            this.lblSellos.Size = new System.Drawing.Size(139, 20);
            this.lblSellos.TabIndex = 36;
            // 
            // lblTapones
            // 
            this.lblTapones.Enabled = false;
            this.lblTapones.Location = new System.Drawing.Point(634, 402);
            this.lblTapones.Name = "lblTapones";
            this.lblTapones.Size = new System.Drawing.Size(139, 20);
            this.lblTapones.TabIndex = 37;
            // 
            // lblTotal
            // 
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(634, 476);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 20);
            this.lblTotal.TabIndex = 38;
            // 
            // tblPrecios
            // 
            this.tblPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPrecios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPrecios.Location = new System.Drawing.Point(684, 575);
            this.tblPrecios.Name = "tblPrecios";
            this.tblPrecios.ReadOnly = true;
            this.tblPrecios.Size = new System.Drawing.Size(81, 16);
            this.tblPrecios.TabIndex = 99;
            this.tblPrecios.Visible = false;
            // 
            // frmReporteGProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 598);
            this.Controls.Add(this.tblPrecios);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTapones);
            this.Controls.Add(this.lblSellos);
            this.Controls.Add(this.lblBotellones);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tblSellosyTapones);
            this.Controls.Add(this.tblBote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.tblReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaf);
            this.Controls.Add(this.dtFechai);
            this.Name = "frmReporteGProduccion";
            this.Text = "Gastos de Produccion";
            this.Load += new System.EventHandler(this.frmReporteGProduccion_Load);
            this.Controls.SetChildIndex(this.dtFechai, 0);
            this.Controls.SetChildIndex(this.dtFechaf, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tblReporte, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tblBote, 0);
            this.Controls.SetChildIndex(this.tblSellosyTapones, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.btnPDF, 0);
            this.Controls.SetChildIndex(this.lblProductos, 0);
            this.Controls.SetChildIndex(this.lblBotellones, 0);
            this.Controls.SetChildIndex(this.lblSellos, 0);
            this.Controls.SetChildIndex(this.lblTapones, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.tblPrecios, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSellosyTapones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrecios)).EndInit();
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
        public System.Windows.Forms.DataGridView tblBote;
        public System.Windows.Forms.DataGridView tblSellosyTapones;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnPDF;
        public System.Windows.Forms.TextBox lblProductos;
        public System.Windows.Forms.TextBox lblBotellones;
        public System.Windows.Forms.TextBox lblSellos;
        public System.Windows.Forms.TextBox lblTapones;
        public System.Windows.Forms.TextBox lblTotal;
        public System.Windows.Forms.DataGridView tblPrecios;
    }
}