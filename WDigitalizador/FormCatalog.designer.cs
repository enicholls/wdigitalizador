namespace WCatalogador
{
    partial class FormCatalog
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
            System.Windows.Forms.ListBox listBoxFilesToClass;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalog));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelActual = new System.Windows.Forms.Label();
            this.labelNro = new System.Windows.Forms.Label();
            this.lblNumPages = new System.Windows.Forms.Label();
            this.lblCurrPage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.checkBoxDesechado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNivelI = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxNivel0 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDoc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReferencia = new System.Windows.Forms.TextBox();
            this.comboBoxClaseI = new System.Windows.Forms.ComboBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            listBoxFilesToClass = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFilesToClass
            // 
            listBoxFilesToClass.FormattingEnabled = true;
            listBoxFilesToClass.ItemHeight = 16;
            listBoxFilesToClass.Location = new System.Drawing.Point(8, 34);
            listBoxFilesToClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            listBoxFilesToClass.Name = "listBoxFilesToClass";
            listBoxFilesToClass.Size = new System.Drawing.Size(601, 196);
            listBoxFilesToClass.TabIndex = 0;
            listBoxFilesToClass.SelectedIndexChanged += new System.EventHandler(this.listBoxFilesToClass_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.splitContainer1.Panel1.Controls.Add(this.panelConfig);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.axAcroPDF1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxDesechado);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxNivelI);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxNivel0);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxTipoDoc);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePickerDoc);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNro);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxReferencia);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxClaseI);
            this.splitContainer1.Panel2.Controls.Add(this.buttonGuardar);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(listBoxFilesToClass);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1767, 801);
            this.splitContainer1.SplitterDistance = 1114;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelConfig
            // 
            this.panelConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.panelConfig.Controls.Add(this.button4);
            this.panelConfig.Controls.Add(this.button3);
            this.panelConfig.Controls.Add(this.labelActual);
            this.panelConfig.Controls.Add(this.labelNro);
            this.panelConfig.Controls.Add(this.lblNumPages);
            this.panelConfig.Controls.Add(this.lblCurrPage);
            this.panelConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfig.Location = new System.Drawing.Point(0, 0);
            this.panelConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(1112, 799);
            this.panelConfig.TabIndex = 4;
            this.panelConfig.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConfig_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(313, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(468, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelActual
            // 
            this.labelActual.AutoSize = true;
            this.labelActual.ForeColor = System.Drawing.Color.White;
            this.labelActual.Location = new System.Drawing.Point(5, 34);
            this.labelActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActual.Name = "labelActual";
            this.labelActual.Size = new System.Drawing.Size(95, 17);
            this.labelActual.TabIndex = 5;
            this.labelActual.Text = "Página Actual";
            this.labelActual.Visible = false;
            // 
            // labelNro
            // 
            this.labelNro.AutoSize = true;
            this.labelNro.ForeColor = System.Drawing.Color.White;
            this.labelNro.Location = new System.Drawing.Point(3, 10);
            this.labelNro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNro.Name = "labelNro";
            this.labelNro.Size = new System.Drawing.Size(90, 17);
            this.labelNro.TabIndex = 4;
            this.labelNro.Text = "Nro. Páginas";
            this.labelNro.Visible = false;
            // 
            // lblNumPages
            // 
            this.lblNumPages.AutoSize = true;
            this.lblNumPages.ForeColor = System.Drawing.Color.White;
            this.lblNumPages.Location = new System.Drawing.Point(107, 10);
            this.lblNumPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPages.Name = "lblNumPages";
            this.lblNumPages.Size = new System.Drawing.Size(91, 17);
            this.lblNumPages.TabIndex = 2;
            this.lblNumPages.Text = "lblNumPages";
            this.lblNumPages.Visible = false;
            // 
            // lblCurrPage
            // 
            this.lblCurrPage.AutoSize = true;
            this.lblCurrPage.ForeColor = System.Drawing.Color.White;
            this.lblCurrPage.Location = new System.Drawing.Point(107, 34);
            this.lblCurrPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrPage.Name = "lblCurrPage";
            this.lblCurrPage.Size = new System.Drawing.Size(82, 17);
            this.lblCurrPage.TabIndex = 3;
            this.lblCurrPage.Text = "lblCurrPage";
            this.lblCurrPage.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1077, 736);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(3, 50);
            this.axAcroPDF1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1113, 745);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // checkBoxDesechado
            // 
            this.checkBoxDesechado.AutoSize = true;
            this.checkBoxDesechado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.checkBoxDesechado.ForeColor = System.Drawing.Color.White;
            this.checkBoxDesechado.Location = new System.Drawing.Point(492, 401);
            this.checkBoxDesechado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDesechado.Name = "checkBoxDesechado";
            this.checkBoxDesechado.Size = new System.Drawing.Size(102, 21);
            this.checkBoxDesechado.TabIndex = 22;
            this.checkBoxDesechado.Text = "Desechado";
            this.checkBoxDesechado.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Listado de Archivos a Clasificar";
            // 
            // comboBoxNivelI
            // 
            this.comboBoxNivelI.FormattingEnabled = true;
            this.comboBoxNivelI.Location = new System.Drawing.Point(7, 358);
            this.comboBoxNivelI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxNivelI.Name = "comboBoxNivelI";
            this.comboBoxNivelI.Size = new System.Drawing.Size(601, 24);
            this.comboBoxNivelI.TabIndex = 20;
            this.comboBoxNivelI.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivelI_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Subdepartamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Departamento";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBoxNivel0
            // 
            this.comboBoxNivel0.FormattingEnabled = true;
            this.comboBoxNivel0.Location = new System.Drawing.Point(7, 300);
            this.comboBoxNivel0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxNivel0.Name = "comboBoxNivel0";
            this.comboBoxNivel0.Size = new System.Drawing.Size(601, 24);
            this.comboBoxNivel0.TabIndex = 16;
            this.comboBoxNivel0.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivel0_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(505, 533);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Configurar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(163, 425);
            this.comboBoxTipoDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(284, 24);
            this.comboBoxTipoDoc.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 430);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tipo Documento";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerDoc
            // 
            this.dateTimePickerDoc.Location = new System.Drawing.Point(163, 480);
            this.dateTimePickerDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDoc.Name = "dateTimePickerDoc";
            this.dateTimePickerDoc.Size = new System.Drawing.Size(284, 22);
            this.dateTimePickerDoc.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 485);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNro
            // 
            this.textBoxNro.Location = new System.Drawing.Point(163, 398);
            this.textBoxNro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNro.Name = "textBoxNro";
            this.textBoxNro.Size = new System.Drawing.Size(284, 22);
            this.textBoxNro.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nro.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 454);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Referencia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 645);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categoria 1";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 581);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plantilla";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxReferencia
            // 
            this.textBoxReferencia.Location = new System.Drawing.Point(163, 450);
            this.textBoxReferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxReferencia.Name = "textBoxReferencia";
            this.textBoxReferencia.Size = new System.Drawing.Size(284, 22);
            this.textBoxReferencia.TabIndex = 4;
            // 
            // comboBoxClaseI
            // 
            this.comboBoxClaseI.FormattingEnabled = true;
            this.comboBoxClaseI.Location = new System.Drawing.Point(7, 666);
            this.comboBoxClaseI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxClaseI.Name = "comboBoxClaseI";
            this.comboBoxClaseI.Size = new System.Drawing.Size(567, 24);
            this.comboBoxClaseI.TabIndex = 3;
            this.comboBoxClaseI.Visible = false;
            this.comboBoxClaseI.SelectedIndexChanged += new System.EventHandler(this.comboBoxClaseI_SelectedIndexChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(505, 476);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(100, 28);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Caso 1",
            "Caso 2"});
            this.comboBox1.Location = new System.Drawing.Point(7, 602);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(567, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(473, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sgte >>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 801);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCatalog";
            this.Text = "Catalogador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReferencia;
        private System.Windows.Forms.ComboBox comboBoxClaseI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrPage;
        private System.Windows.Forms.Label lblNumPages;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Label labelNro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelActual;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxNivelI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxNivel0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxDesechado;

    }
}

