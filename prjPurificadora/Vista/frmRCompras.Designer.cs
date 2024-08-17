namespace prjPurificadora.Vista
{
    partial class frmRCompras
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
            this.btnPDF = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(545, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "Total:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Location = new System.Drawing.Point(549, 137);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(224, 23);
            this.btnContinuar.TabIndex = 56;
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
            this.tblReporte.Location = new System.Drawing.Point(44, 214);
            this.tblReporte.Name = "tblReporte";
            this.tblReporte.ReadOnly = true;
            this.tblReporte.Size = new System.Drawing.Size(471, 309);
            this.tblReporte.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Día final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Día inicial:";
            // 
            // dtFechaf
            // 
            this.dtFechaf.Location = new System.Drawing.Point(315, 136);
            this.dtFechaf.Name = "dtFechaf";
            this.dtFechaf.Size = new System.Drawing.Size(200, 20);
            this.dtFechaf.TabIndex = 52;
            // 
            // dtFechai
            // 
            this.dtFechai.Location = new System.Drawing.Point(44, 136);
            this.dtFechai.Name = "dtFechai";
            this.dtFechai.Size = new System.Drawing.Size(200, 20);
            this.dtFechai.TabIndex = 51;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPDF.Enabled = false;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(550, 289);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(223, 23);
            this.btnPDF.TabIndex = 59;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(634, 212);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 20);
            this.lblTotal.TabIndex = 60;
            // 
            // frmRCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 598);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.tblReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaf);
            this.Controls.Add(this.dtFechai);
            this.Name = "frmRCompras";
            this.Text = "Reporte de Compras";
            this.Controls.SetChildIndex(this.dtFechai, 0);
            this.Controls.SetChildIndex(this.dtFechaf, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tblReporte, 0);
            this.Controls.SetChildIndex(this.btnContinuar, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnPDF, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).EndInit();
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
        public System.Windows.Forms.Button btnPDF;
        public System.Windows.Forms.TextBox lblTotal;
    }
}