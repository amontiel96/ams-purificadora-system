namespace prjPurificadora.Vista
{
    partial class frmAnalisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalisis));
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaf = new System.Windows.Forms.DateTimePicker();
            this.dtFechai = new System.Windows.Forms.DateTimePicker();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.tblVentas = new System.Windows.Forms.DataGridView();
            this.tblGastosRuta = new System.Windows.Forms.DataGridView();
            this.tblSueldo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.txtRefaccion = new System.Windows.Forms.TextBox();
            this.txtMeca = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtGastosVentas = new System.Windows.Forms.TextBox();
            this.txtUtilidadTrabajador = new System.Windows.Forms.TextBox();
            this.txtCostoPorUnidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCanVentas = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnComfirmarAnalisis = new System.Windows.Forms.Button();
            this.dtFechaActual = new System.Windows.Forms.DateTimePicker();
            this.btnPDF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblExiste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGastosRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSueldo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExiste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Location = new System.Drawing.Point(259, 165);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(223, 23);
            this.btnContinuar.TabIndex = 25;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Día Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Día Inicial:";
            // 
            // dtFechaf
            // 
            this.dtFechaf.Location = new System.Drawing.Point(282, 105);
            this.dtFechaf.Name = "dtFechaf";
            this.dtFechaf.Size = new System.Drawing.Size(200, 20);
            this.dtFechaf.TabIndex = 22;
            // 
            // dtFechai
            // 
            this.dtFechai.Location = new System.Drawing.Point(11, 105);
            this.dtFechai.Name = "dtFechai";
            this.dtFechai.Size = new System.Drawing.Size(200, 20);
            this.dtFechai.TabIndex = 21;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(90, 167);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendedor.TabIndex = 1;
            // 
            // tblVentas
            // 
            this.tblVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblVentas.Location = new System.Drawing.Point(517, 12);
            this.tblVentas.Name = "tblVentas";
            this.tblVentas.ReadOnly = true;
            this.tblVentas.Size = new System.Drawing.Size(272, 123);
            this.tblVentas.TabIndex = 26;
            this.tblVentas.Visible = false;
            // 
            // tblGastosRuta
            // 
            this.tblGastosRuta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblGastosRuta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblGastosRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblGastosRuta.Location = new System.Drawing.Point(517, 152);
            this.tblGastosRuta.Name = "tblGastosRuta";
            this.tblGastosRuta.ReadOnly = true;
            this.tblGastosRuta.Size = new System.Drawing.Size(272, 114);
            this.tblGastosRuta.TabIndex = 27;
            this.tblGastosRuta.Visible = false;
            // 
            // tblSueldo
            // 
            this.tblSueldo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSueldo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblSueldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSueldo.Location = new System.Drawing.Point(517, 285);
            this.tblSueldo.Name = "tblSueldo";
            this.tblSueldo.ReadOnly = true;
            this.tblSueldo.Size = new System.Drawing.Size(272, 74);
            this.tblSueldo.TabIndex = 28;
            this.tblSueldo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Gasolina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sueldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mantenimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Refaccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Gastos de venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Utilidad del Trbajador:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Costo por unidad:";
            // 
            // txtGasolina
            // 
            this.txtGasolina.Enabled = false;
            this.txtGasolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGasolina.Location = new System.Drawing.Point(260, 260);
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(100, 29);
            this.txtGasolina.TabIndex = 36;
            this.txtGasolina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRefaccion
            // 
            this.txtRefaccion.Enabled = false;
            this.txtRefaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefaccion.Location = new System.Drawing.Point(260, 292);
            this.txtRefaccion.Name = "txtRefaccion";
            this.txtRefaccion.Size = new System.Drawing.Size(100, 29);
            this.txtRefaccion.TabIndex = 37;
            this.txtRefaccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMeca
            // 
            this.txtMeca.Enabled = false;
            this.txtMeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeca.Location = new System.Drawing.Point(260, 324);
            this.txtMeca.Name = "txtMeca";
            this.txtMeca.Size = new System.Drawing.Size(100, 29);
            this.txtMeca.TabIndex = 38;
            this.txtMeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Enabled = false;
            this.txtSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(260, 355);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 29);
            this.txtSueldo.TabIndex = 39;
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGastosVentas
            // 
            this.txtGastosVentas.Enabled = false;
            this.txtGastosVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGastosVentas.Location = new System.Drawing.Point(260, 385);
            this.txtGastosVentas.Name = "txtGastosVentas";
            this.txtGastosVentas.Size = new System.Drawing.Size(100, 29);
            this.txtGastosVentas.TabIndex = 40;
            this.txtGastosVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUtilidadTrabajador
            // 
            this.txtUtilidadTrabajador.Enabled = false;
            this.txtUtilidadTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidadTrabajador.Location = new System.Drawing.Point(260, 417);
            this.txtUtilidadTrabajador.Name = "txtUtilidadTrabajador";
            this.txtUtilidadTrabajador.Size = new System.Drawing.Size(100, 29);
            this.txtUtilidadTrabajador.TabIndex = 41;
            this.txtUtilidadTrabajador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostoPorUnidad
            // 
            this.txtCostoPorUnidad.Enabled = false;
            this.txtCostoPorUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoPorUnidad.Location = new System.Drawing.Point(260, 447);
            this.txtCostoPorUnidad.Name = "txtCostoPorUnidad";
            this.txtCostoPorUnidad.Size = new System.Drawing.Size(100, 29);
            this.txtCostoPorUnidad.TabIndex = 42;
            this.txtCostoPorUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 43;
            this.label10.Text = "Ventas:";
            // 
            // txtCanVentas
            // 
            this.txtCanVentas.Enabled = false;
            this.txtCanVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanVentas.Location = new System.Drawing.Point(260, 225);
            this.txtCanVentas.Name = "txtCanVentas";
            this.txtCanVentas.Size = new System.Drawing.Size(100, 29);
            this.txtCanVentas.TabIndex = 44;
            this.txtCanVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMoney
            // 
            this.txtMoney.Enabled = false;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(383, 225);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 29);
            this.txtMoney.TabIndex = 45;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Vendedor:";
            // 
            // btnComfirmarAnalisis
            // 
            this.btnComfirmarAnalisis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComfirmarAnalisis.FlatAppearance.BorderSize = 0;
            this.btnComfirmarAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComfirmarAnalisis.Location = new System.Drawing.Point(260, 529);
            this.btnComfirmarAnalisis.Name = "btnComfirmarAnalisis";
            this.btnComfirmarAnalisis.Size = new System.Drawing.Size(223, 23);
            this.btnComfirmarAnalisis.TabIndex = 47;
            this.btnComfirmarAnalisis.Text = "Confirmar ánalisis...";
            this.btnComfirmarAnalisis.UseVisualStyleBackColor = false;
            // 
            // dtFechaActual
            // 
            this.dtFechaActual.Location = new System.Drawing.Point(260, 503);
            this.dtFechaActual.Name = "dtFechaActual";
            this.dtFechaActual.Size = new System.Drawing.Size(200, 20);
            this.dtFechaActual.TabIndex = 48;
            this.dtFechaActual.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(12, 529);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(223, 23);
            this.btnPDF.TabIndex = 49;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-216, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 78);
            this.panel1.TabIndex = 99;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::prjPurificadora.Properties.Resources.carro;
            this.pictureBox3.Location = new System.Drawing.Point(205, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 97;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::prjPurificadora.Properties.Resources.mejorado_editar_hoy_copia_copia;
            this.pictureBox1.Location = new System.Drawing.Point(621, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::prjPurificadora.Properties.Resources.Titulo;
            this.pictureBox2.Location = new System.Drawing.Point(307, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tblExiste
            // 
            this.tblExiste.AllowUserToAddRows = false;
            this.tblExiste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblExiste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblExiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblExiste.Location = new System.Drawing.Point(383, 359);
            this.tblExiste.Name = "tblExiste";
            this.tblExiste.ReadOnly = true;
            this.tblExiste.Size = new System.Drawing.Size(214, 53);
            this.tblExiste.TabIndex = 100;
            this.tblExiste.Visible = false;
            // 
            // frmAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjPurificadora.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 598);
            this.Controls.Add(this.tblExiste);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dtFechaActual);
            this.Controls.Add(this.btnComfirmarAnalisis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtCanVentas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCostoPorUnidad);
            this.Controls.Add(this.txtUtilidadTrabajador);
            this.Controls.Add(this.txtGastosVentas);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtMeca);
            this.Controls.Add(this.txtRefaccion);
            this.Controls.Add(this.txtGasolina);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tblSueldo);
            this.Controls.Add(this.tblGastosRuta);
            this.Controls.Add(this.tblVentas);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaf);
            this.Controls.Add(this.dtFechai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnalisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisis del Trabajador";
            ((System.ComponentModel.ISupportInitialize)(this.tblVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGastosRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSueldo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtFechaf;
        public System.Windows.Forms.DateTimePicker dtFechai;
        public System.Windows.Forms.ComboBox cmbVendedor;
        public System.Windows.Forms.DataGridView tblVentas;
        public System.Windows.Forms.DataGridView tblGastosRuta;
        public System.Windows.Forms.DataGridView tblSueldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtGasolina;
        public System.Windows.Forms.TextBox txtRefaccion;
        public System.Windows.Forms.TextBox txtMeca;
        public System.Windows.Forms.TextBox txtSueldo;
        public System.Windows.Forms.TextBox txtGastosVentas;
        public System.Windows.Forms.TextBox txtUtilidadTrabajador;
        public System.Windows.Forms.TextBox txtCostoPorUnidad;
        public System.Windows.Forms.TextBox txtCanVentas;
        public System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnComfirmarAnalisis;
        public System.Windows.Forms.DateTimePicker dtFechaActual;
        public System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView tblExiste;
    }
}