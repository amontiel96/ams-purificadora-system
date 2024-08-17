namespace prjPurificadora.Vista
{
    partial class frmRUnidadesProducidas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.Cht_Poli = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiciembre = new System.Windows.Forms.TextBox();
            this.txtNoviembre = new System.Windows.Forms.TextBox();
            this.txtOctubre = new System.Windows.Forms.TextBox();
            this.txtSeptiembre = new System.Windows.Forms.TextBox();
            this.txtAgosto = new System.Windows.Forms.TextBox();
            this.txtJulio = new System.Windows.Forms.TextBox();
            this.txtJunio = new System.Windows.Forms.TextBox();
            this.txtMayo = new System.Windows.Forms.TextBox();
            this.txtAbril = new System.Windows.Forms.TextBox();
            this.txtMarzo = new System.Windows.Forms.TextBox();
            this.txtFebrero = new System.Windows.Forms.TextBox();
            this.txtEnero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblReporte = new System.Windows.Forms.DataGridView();
            this.dtFechai = new System.Windows.Forms.DateTimePicker();
            this.dtFechaf = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cht_Poli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnPDF);
            this.groupBox1.Controls.Add(this.Cht_Poli);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDiciembre);
            this.groupBox1.Controls.Add(this.txtNoviembre);
            this.groupBox1.Controls.Add(this.txtOctubre);
            this.groupBox1.Controls.Add(this.txtSeptiembre);
            this.groupBox1.Controls.Add(this.txtAgosto);
            this.groupBox1.Controls.Add(this.txtJulio);
            this.groupBox1.Controls.Add(this.txtJunio);
            this.groupBox1.Controls.Add(this.txtMayo);
            this.groupBox1.Controls.Add(this.txtAbril);
            this.groupBox1.Controls.Add(this.txtMarzo);
            this.groupBox1.Controls.Add(this.txtFebrero);
            this.groupBox1.Controls.Add(this.txtEnero);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 467);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafia de únidades producidas por mes";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPDF.Enabled = false;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(572, 423);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(183, 23);
            this.btnPDF.TabIndex = 47;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // Cht_Poli
            // 
            this.Cht_Poli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cht_Poli.BackImage = "C:\\Purificadora\\RECURSOS\\fond.jpg";
            this.Cht_Poli.Location = new System.Drawing.Point(6, 24);
            this.Cht_Poli.Name = "Cht_Poli";
            this.Cht_Poli.Size = new System.Drawing.Size(513, 422);
            this.Cht_Poli.TabIndex = 28;
            this.Cht_Poli.Text = "chart1";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(654, 381);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 27;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(569, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "TOTAL:";
            // 
            // txtDiciembre
            // 
            this.txtDiciembre.Enabled = false;
            this.txtDiciembre.Location = new System.Drawing.Point(655, 272);
            this.txtDiciembre.Name = "txtDiciembre";
            this.txtDiciembre.Size = new System.Drawing.Size(100, 20);
            this.txtDiciembre.TabIndex = 25;
            this.txtDiciembre.Text = "0";
            this.txtDiciembre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNoviembre
            // 
            this.txtNoviembre.Enabled = false;
            this.txtNoviembre.Location = new System.Drawing.Point(655, 249);
            this.txtNoviembre.Name = "txtNoviembre";
            this.txtNoviembre.Size = new System.Drawing.Size(100, 20);
            this.txtNoviembre.TabIndex = 24;
            this.txtNoviembre.Text = "0";
            this.txtNoviembre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOctubre
            // 
            this.txtOctubre.Enabled = false;
            this.txtOctubre.Location = new System.Drawing.Point(655, 226);
            this.txtOctubre.Name = "txtOctubre";
            this.txtOctubre.Size = new System.Drawing.Size(100, 20);
            this.txtOctubre.TabIndex = 23;
            this.txtOctubre.Text = "0";
            this.txtOctubre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSeptiembre
            // 
            this.txtSeptiembre.Enabled = false;
            this.txtSeptiembre.Location = new System.Drawing.Point(655, 204);
            this.txtSeptiembre.Name = "txtSeptiembre";
            this.txtSeptiembre.Size = new System.Drawing.Size(100, 20);
            this.txtSeptiembre.TabIndex = 22;
            this.txtSeptiembre.Text = "0";
            this.txtSeptiembre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAgosto
            // 
            this.txtAgosto.Enabled = false;
            this.txtAgosto.Location = new System.Drawing.Point(655, 182);
            this.txtAgosto.Name = "txtAgosto";
            this.txtAgosto.Size = new System.Drawing.Size(100, 20);
            this.txtAgosto.TabIndex = 21;
            this.txtAgosto.Text = "0";
            this.txtAgosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtJulio
            // 
            this.txtJulio.Enabled = false;
            this.txtJulio.Location = new System.Drawing.Point(655, 160);
            this.txtJulio.Name = "txtJulio";
            this.txtJulio.Size = new System.Drawing.Size(100, 20);
            this.txtJulio.TabIndex = 20;
            this.txtJulio.Text = "0";
            this.txtJulio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtJunio
            // 
            this.txtJunio.Enabled = false;
            this.txtJunio.Location = new System.Drawing.Point(655, 137);
            this.txtJunio.Name = "txtJunio";
            this.txtJunio.Size = new System.Drawing.Size(100, 20);
            this.txtJunio.TabIndex = 19;
            this.txtJunio.Text = "0";
            this.txtJunio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMayo
            // 
            this.txtMayo.Enabled = false;
            this.txtMayo.Location = new System.Drawing.Point(655, 115);
            this.txtMayo.Name = "txtMayo";
            this.txtMayo.Size = new System.Drawing.Size(100, 20);
            this.txtMayo.TabIndex = 18;
            this.txtMayo.Text = "0";
            this.txtMayo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAbril
            // 
            this.txtAbril.Enabled = false;
            this.txtAbril.Location = new System.Drawing.Point(655, 92);
            this.txtAbril.Name = "txtAbril";
            this.txtAbril.Size = new System.Drawing.Size(100, 20);
            this.txtAbril.TabIndex = 17;
            this.txtAbril.Text = "0";
            this.txtAbril.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMarzo
            // 
            this.txtMarzo.Enabled = false;
            this.txtMarzo.Location = new System.Drawing.Point(655, 69);
            this.txtMarzo.Name = "txtMarzo";
            this.txtMarzo.Size = new System.Drawing.Size(100, 20);
            this.txtMarzo.TabIndex = 16;
            this.txtMarzo.Text = "0";
            this.txtMarzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFebrero
            // 
            this.txtFebrero.Enabled = false;
            this.txtFebrero.Location = new System.Drawing.Point(655, 47);
            this.txtFebrero.Name = "txtFebrero";
            this.txtFebrero.Size = new System.Drawing.Size(100, 20);
            this.txtFebrero.TabIndex = 15;
            this.txtFebrero.Text = "0";
            this.txtFebrero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEnero
            // 
            this.txtEnero.Enabled = false;
            this.txtEnero.Location = new System.Drawing.Point(655, 24);
            this.txtEnero.Name = "txtEnero";
            this.txtEnero.Size = new System.Drawing.Size(100, 20);
            this.txtEnero.TabIndex = 14;
            this.txtEnero.Text = "0";
            this.txtEnero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(570, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "DICIEMBRE:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(570, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "NOVIEMBRE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(570, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "OCTUBRE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(570, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "SEPTIEMBRE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(570, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "AGOSTO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(570, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "JULIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(570, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "JUNIO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(570, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "MAYO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(570, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ABRIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(570, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MARZO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(570, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FEBRERO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(570, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENERO:";
            // 
            // tblReporte
            // 
            this.tblReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblReporte.Location = new System.Drawing.Point(786, 295);
            this.tblReporte.Name = "tblReporte";
            this.tblReporte.ReadOnly = true;
            this.tblReporte.Size = new System.Drawing.Size(91, 37);
            this.tblReporte.TabIndex = 39;
            this.tblReporte.Visible = false;
            // 
            // dtFechai
            // 
            this.dtFechai.Location = new System.Drawing.Point(73, 113);
            this.dtFechai.Name = "dtFechai";
            this.dtFechai.Size = new System.Drawing.Size(200, 20);
            this.dtFechai.TabIndex = 45;
            // 
            // dtFechaf
            // 
            this.dtFechaf.Location = new System.Drawing.Point(353, 113);
            this.dtFechaf.Name = "dtFechaf";
            this.dtFechaf.Size = new System.Drawing.Size(200, 20);
            this.dtFechaf.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(285, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Día final:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Día inicial:";
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGraficar.FlatAppearance.BorderSize = 0;
            this.btnGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGraficar.Location = new System.Drawing.Point(597, 114);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(183, 23);
            this.btnGraficar.TabIndex = 41;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = false;
            // 
            // frmRUnidadesProducidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtFechai);
            this.Controls.Add(this.dtFechaf);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.tblReporte);
            this.Name = "frmRUnidadesProducidas";
            this.Text = "Unidades Producidas";
            this.Controls.SetChildIndex(this.tblReporte, 0);
            this.Controls.SetChildIndex(this.btnGraficar, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.dtFechaf, 0);
            this.Controls.SetChildIndex(this.dtFechai, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cht_Poli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtDiciembre;
        public System.Windows.Forms.TextBox txtNoviembre;
        public System.Windows.Forms.TextBox txtOctubre;
        public System.Windows.Forms.TextBox txtSeptiembre;
        public System.Windows.Forms.TextBox txtAgosto;
        public System.Windows.Forms.TextBox txtJulio;
        public System.Windows.Forms.TextBox txtJunio;
        public System.Windows.Forms.TextBox txtMayo;
        public System.Windows.Forms.TextBox txtAbril;
        public System.Windows.Forms.TextBox txtMarzo;
        public System.Windows.Forms.TextBox txtFebrero;
        public System.Windows.Forms.TextBox txtEnero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtFechai;
        public System.Windows.Forms.DateTimePicker dtFechaf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button btnGraficar;
        public System.Windows.Forms.DataGridView tblReporte;
        public System.Windows.Forms.DataVisualization.Charting.Chart Cht_Poli;
        public System.Windows.Forms.Button btnPDF;
    }
}