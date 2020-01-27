namespace WConsultas
{
    partial class FormConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.textBoxConnStr = new System.Windows.Forms.TextBox();
            this.textBoxPathTmp = new System.Windows.Forms.TextBox();
            this.textBoxPathStorage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdDomTipoDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdDomRef = new System.Windows.Forms.TextBox();
            this.grpScanner = new System.Windows.Forms.GroupBox();
            this.checkBoxIncluyeCodigo = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.trackBarContrastDetectBP = new System.Windows.Forms.TrackBar();
            this.cboTamanioHoja = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.trackBarBrillo = new System.Windows.Forms.TrackBar();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.trackBarContraste = new System.Windows.Forms.TrackBar();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.rbTIFF = new System.Windows.Forms.RadioButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.rbPDF = new System.Windows.Forms.RadioButton();
            this.cboCalidad = new System.Windows.Forms.ComboBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboScanner = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonExpClasificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDirClasificar = new System.Windows.Forms.TextBox();
            this.grpScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrastDetectBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContraste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxConnStr
            // 
            this.textBoxConnStr.Location = new System.Drawing.Point(304, 27);
            this.textBoxConnStr.Name = "textBoxConnStr";
            this.textBoxConnStr.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxConnStr.Size = new System.Drawing.Size(416, 20);
            this.textBoxConnStr.TabIndex = 0;
            // 
            // textBoxPathTmp
            // 
            this.textBoxPathTmp.Location = new System.Drawing.Point(304, 50);
            this.textBoxPathTmp.Name = "textBoxPathTmp";
            this.textBoxPathTmp.Size = new System.Drawing.Size(416, 20);
            this.textBoxPathTmp.TabIndex = 1;
            // 
            // textBoxPathStorage
            // 
            this.textBoxPathStorage.Location = new System.Drawing.Point(304, 77);
            this.textBoxPathStorage.Name = "textBoxPathStorage";
            this.textBoxPathStorage.Size = new System.Drawing.Size(416, 20);
            this.textBoxPathStorage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "String Conexion Base De Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Directorio de Archivos a Procesar x Scanner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Directorio de Archivos De Almacenamiento Definitivo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(745, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(745, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Escoger";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(745, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Escoger";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(664, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id. Dominio Tipo Documento";
            // 
            // textBoxIdDomTipoDoc
            // 
            this.textBoxIdDomTipoDoc.Location = new System.Drawing.Point(306, 141);
            this.textBoxIdDomTipoDoc.Name = "textBoxIdDomTipoDoc";
            this.textBoxIdDomTipoDoc.Size = new System.Drawing.Size(52, 20);
            this.textBoxIdDomTipoDoc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(402, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id. Dominio Referencia";
            // 
            // textBoxIdDomRef
            // 
            this.textBoxIdDomRef.Location = new System.Drawing.Point(675, 144);
            this.textBoxIdDomRef.Name = "textBoxIdDomRef";
            this.textBoxIdDomRef.Size = new System.Drawing.Size(50, 20);
            this.textBoxIdDomRef.TabIndex = 12;
            // 
            // grpScanner
            // 
            this.grpScanner.Controls.Add(this.checkBoxIncluyeCodigo);
            this.grpScanner.Controls.Add(this.label34);
            this.grpScanner.Controls.Add(this.trackBarContrastDetectBP);
            this.grpScanner.Controls.Add(this.cboTamanioHoja);
            this.grpScanner.Controls.Add(this.label32);
            this.grpScanner.Controls.Add(this.label29);
            this.grpScanner.Controls.Add(this.label30);
            this.grpScanner.Controls.Add(this.label31);
            this.grpScanner.Controls.Add(this.trackBarBrillo);
            this.grpScanner.Controls.Add(this.label28);
            this.grpScanner.Controls.Add(this.label27);
            this.grpScanner.Controls.Add(this.label26);
            this.grpScanner.Controls.Add(this.trackBarContraste);
            this.grpScanner.Controls.Add(this.label25);
            this.grpScanner.Controls.Add(this.label22);
            this.grpScanner.Controls.Add(this.label16);
            this.grpScanner.Controls.Add(this.rbTIFF);
            this.grpScanner.Controls.Add(this.pictureBox6);
            this.grpScanner.Controls.Add(this.pictureBox5);
            this.grpScanner.Controls.Add(this.rbPDF);
            this.grpScanner.Controls.Add(this.cboCalidad);
            this.grpScanner.Controls.Add(this.cboColor);
            this.grpScanner.Controls.Add(this.cboScanner);
            this.grpScanner.Controls.Add(this.label15);
            this.grpScanner.Controls.Add(this.label14);
            this.grpScanner.Controls.Add(this.label13);
            this.grpScanner.Controls.Add(this.label18);
            this.grpScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpScanner.ForeColor = System.Drawing.Color.White;
            this.grpScanner.Location = new System.Drawing.Point(34, 187);
            this.grpScanner.Name = "grpScanner";
            this.grpScanner.Size = new System.Drawing.Size(786, 235);
            this.grpScanner.TabIndex = 92;
            this.grpScanner.TabStop = false;
            this.grpScanner.Text = "Configuración Escaner";
            // 
            // checkBoxIncluyeCodigo
            // 
            this.checkBoxIncluyeCodigo.AutoSize = true;
            this.checkBoxIncluyeCodigo.Location = new System.Drawing.Point(373, 188);
            this.checkBoxIncluyeCodigo.Name = "checkBoxIncluyeCodigo";
            this.checkBoxIncluyeCodigo.Size = new System.Drawing.Size(153, 17);
            this.checkBoxIncluyeCodigo.TabIndex = 96;
            this.checkBoxIncluyeCodigo.Text = "Incluye Página Código";
            this.checkBoxIncluyeCodigo.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(375, 84);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(178, 45);
            this.label34.TabIndex = 115;
            this.label34.Text = "Contraste para detección de hojas blancas";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarContrastDetectBP
            // 
            this.trackBarContrastDetectBP.AutoSize = false;
            this.trackBarContrastDetectBP.Location = new System.Drawing.Point(574, 84);
            this.trackBarContrastDetectBP.Minimum = 1;
            this.trackBarContrastDetectBP.Name = "trackBarContrastDetectBP";
            this.trackBarContrastDetectBP.Size = new System.Drawing.Size(167, 45);
            this.trackBarContrastDetectBP.TabIndex = 114;
            this.trackBarContrastDetectBP.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarContrastDetectBP.Value = 1;
            // 
            // cboTamanioHoja
            // 
            this.cboTamanioHoja.BackColor = System.Drawing.Color.LemonChiffon;
            this.cboTamanioHoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTamanioHoja.FormattingEnabled = true;
            this.cboTamanioHoja.Items.AddRange(new object[] {
            "Carta",
            "Legal",
            "A4",
            "Tarjeta"});
            this.cboTamanioHoja.Location = new System.Drawing.Point(373, 151);
            this.cboTamanioHoja.Name = "cboTamanioHoja";
            this.cboTamanioHoja.Size = new System.Drawing.Size(157, 21);
            this.cboTamanioHoja.TabIndex = 113;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(404, 128);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(113, 12);
            this.label32.TabIndex = 112;
            this.label32.Text = "Tamaño Hoja";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(645, 67);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 14);
            this.label29.TabIndex = 107;
            this.label29.Text = "5";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(719, 67);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(28, 14);
            this.label30.TabIndex = 106;
            this.label30.Text = "10";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(580, 67);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(18, 14);
            this.label31.TabIndex = 105;
            this.label31.Text = "1";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBarBrillo
            // 
            this.trackBarBrillo.AutoSize = false;
            this.trackBarBrillo.Location = new System.Drawing.Point(574, 19);
            this.trackBarBrillo.Minimum = 1;
            this.trackBarBrillo.Name = "trackBarBrillo";
            this.trackBarBrillo.Size = new System.Drawing.Size(167, 45);
            this.trackBarBrillo.TabIndex = 104;
            this.trackBarBrillo.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBrillo.Value = 1;
            // 
            // label28
            // 
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(449, 67);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(18, 14);
            this.label28.TabIndex = 103;
            this.label28.Text = "5";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(522, 67);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 14);
            this.label27.TabIndex = 102;
            this.label27.Text = "10";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(384, 67);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(18, 14);
            this.label26.TabIndex = 101;
            this.label26.Text = "1";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBarContraste
            // 
            this.trackBarContraste.AutoSize = false;
            this.trackBarContraste.Location = new System.Drawing.Point(379, 19);
            this.trackBarContraste.Minimum = 1;
            this.trackBarContraste.Name = "trackBarContraste";
            this.trackBarContraste.Size = new System.Drawing.Size(167, 45);
            this.trackBarContraste.TabIndex = 100;
            this.trackBarContraste.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarContraste.Value = 1;
            // 
            // label25
            // 
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(635, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 12);
            this.label25.TabIndex = 99;
            this.label25.Text = "Brillo";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(430, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 12);
            this.label22.TabIndex = 98;
            this.label22.Text = "Contraste";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(237, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "dpi";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbTIFF
            // 
            this.rbTIFF.AutoSize = true;
            this.rbTIFF.Location = new System.Drawing.Point(704, 182);
            this.rbTIFF.Name = "rbTIFF";
            this.rbTIFF.Size = new System.Drawing.Size(51, 17);
            this.rbTIFF.TabIndex = 14;
            this.rbTIFF.Text = "TIFF";
            this.rbTIFF.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(655, 169);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(43, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(555, 176);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // rbPDF
            // 
            this.rbPDF.AutoSize = true;
            this.rbPDF.Checked = true;
            this.rbPDF.Location = new System.Drawing.Point(593, 182);
            this.rbPDF.Name = "rbPDF";
            this.rbPDF.Size = new System.Drawing.Size(49, 17);
            this.rbPDF.TabIndex = 13;
            this.rbPDF.TabStop = true;
            this.rbPDF.Text = "PDF";
            this.rbPDF.UseVisualStyleBackColor = true;
            // 
            // cboCalidad
            // 
            this.cboCalidad.BackColor = System.Drawing.Color.LemonChiffon;
            this.cboCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCalidad.FormattingEnabled = true;
            this.cboCalidad.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200"});
            this.cboCalidad.Location = new System.Drawing.Point(13, 129);
            this.cboCalidad.Name = "cboCalidad";
            this.cboCalidad.Size = new System.Drawing.Size(224, 21);
            this.cboCalidad.TabIndex = 12;
            // 
            // cboColor
            // 
            this.cboColor.BackColor = System.Drawing.Color.LemonChiffon;
            this.cboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "Blanco y Negro",
            "Escala de Grises",
            "Color"});
            this.cboColor.Location = new System.Drawing.Point(13, 84);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(251, 21);
            this.cboColor.TabIndex = 11;
            // 
            // cboScanner
            // 
            this.cboScanner.BackColor = System.Drawing.Color.LemonChiffon;
            this.cboScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboScanner.FormattingEnabled = true;
            this.cboScanner.Location = new System.Drawing.Point(13, 43);
            this.cboScanner.Name = "cboScanner";
            this.cboScanner.Size = new System.Drawing.Size(251, 21);
            this.cboScanner.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(593, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "Formato Final";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(16, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "Calidad";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(10, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 14);
            this.label13.TabIndex = 7;
            this.label13.Text = "Color";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(10, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 12);
            this.label18.TabIndex = 6;
            this.label18.Text = "Scanner Default";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonExpClasificar
            // 
            this.buttonExpClasificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.buttonExpClasificar.ForeColor = System.Drawing.Color.White;
            this.buttonExpClasificar.Location = new System.Drawing.Point(745, 101);
            this.buttonExpClasificar.Name = "buttonExpClasificar";
            this.buttonExpClasificar.Size = new System.Drawing.Size(75, 23);
            this.buttonExpClasificar.TabIndex = 95;
            this.buttonExpClasificar.Text = "Escoger";
            this.buttonExpClasificar.UseVisualStyleBackColor = false;
            this.buttonExpClasificar.Click += new System.EventHandler(this.buttonExpClasificar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Directorio de Archivos x Clasificar";
            // 
            // textBoxDirClasificar
            // 
            this.textBoxDirClasificar.Location = new System.Drawing.Point(304, 103);
            this.textBoxDirClasificar.Name = "textBoxDirClasificar";
            this.textBoxDirClasificar.Size = new System.Drawing.Size(416, 20);
            this.textBoxDirClasificar.TabIndex = 93;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(877, 471);
            this.Controls.Add(this.buttonExpClasificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDirClasificar);
            this.Controls.Add(this.grpScanner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxIdDomRef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdDomTipoDoc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPathStorage);
            this.Controls.Add(this.textBoxPathTmp);
            this.Controls.Add(this.textBoxConnStr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.grpScanner.ResumeLayout(false);
            this.grpScanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrastDetectBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContraste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConnStr;
        private System.Windows.Forms.TextBox textBoxPathTmp;
        private System.Windows.Forms.TextBox textBoxPathStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdDomTipoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdDomRef;
        private System.Windows.Forms.GroupBox grpScanner;
        private System.Windows.Forms.CheckBox checkBoxIncluyeCodigo;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TrackBar trackBarContrastDetectBP;
        private System.Windows.Forms.ComboBox cboTamanioHoja;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TrackBar trackBarBrillo;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TrackBar trackBarContraste;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbTIFF;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton rbPDF;
        private System.Windows.Forms.ComboBox cboCalidad;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.ComboBox cboScanner;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonExpClasificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDirClasificar;
    }
}