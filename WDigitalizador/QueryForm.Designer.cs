namespace WConsultas
{
    partial class QueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDocumentosPorUnidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.panelQry = new System.Windows.Forms.Panel();
            this.labelCount = new System.Windows.Forms.Label();
            this.checkBoxDesechado = new System.Windows.Forms.CheckBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxNivelI = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxNivel0 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCurrPage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumPages = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxQryDocRS = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerIni = new System.Windows.Forms.DateTimePicker();
            this.textBoxNro = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSelectedDoc = new System.Windows.Forms.PictureBox();
            this.axAcroPDFDocSelected = new AxAcroPDFLib.AxAcroPDF();
            this.menuStrip1.SuspendLayout();
            this.panelConfig.SuspendLayout();
            this.panelQry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFDocSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catalogarToolStripMenuItem,
            this.configurarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.archivoToolStripMenuItem.Text = "Escanear";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // catalogarToolStripMenuItem
            // 
            this.catalogarToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.catalogarToolStripMenuItem.Name = "catalogarToolStripMenuItem";
            this.catalogarToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.catalogarToolStripMenuItem.Text = "Catalogar";
            this.catalogarToolStripMenuItem.Click += new System.EventHandler(this.catalogarToolStripMenuItem_Click);
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem1,
            this.departamentosToolStripMenuItem,
            this.subDepartamentosToolStripMenuItem,
            this.tiposDeDocumentosToolStripMenuItem,
            this.tiposDeDocumentosPorUnidadToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.cajasToolStripMenuItem});
            this.configurarToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.configurarToolStripMenuItem.Text = "Administración";
            // 
            // configurarToolStripMenuItem1
            // 
            this.configurarToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.configurarToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.configurarToolStripMenuItem1.Name = "configurarToolStripMenuItem1";
            this.configurarToolStripMenuItem1.Size = new System.Drawing.Size(366, 30);
            this.configurarToolStripMenuItem1.Text = "Configurar";
            this.configurarToolStripMenuItem1.Click += new System.EventHandler(this.configurarToolStripMenuItem1_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.departamentosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(366, 30);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // subDepartamentosToolStripMenuItem
            // 
            this.subDepartamentosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.subDepartamentosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.subDepartamentosToolStripMenuItem.Name = "subDepartamentosToolStripMenuItem";
            this.subDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(366, 30);
            this.subDepartamentosToolStripMenuItem.Text = "SubDepartamentos";
            this.subDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.subDepartamentosToolStripMenuItem_Click);
            // 
            // tiposDeDocumentosToolStripMenuItem
            // 
            this.tiposDeDocumentosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.tiposDeDocumentosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tiposDeDocumentosToolStripMenuItem.Name = "tiposDeDocumentosToolStripMenuItem";
            this.tiposDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(366, 30);
            this.tiposDeDocumentosToolStripMenuItem.Text = "Tipos de Documentos";
            this.tiposDeDocumentosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDocumentosToolStripMenuItem_Click);
            // 
            // tiposDeDocumentosPorUnidadToolStripMenuItem
            // 
            this.tiposDeDocumentosPorUnidadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.tiposDeDocumentosPorUnidadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tiposDeDocumentosPorUnidadToolStripMenuItem.Name = "tiposDeDocumentosPorUnidadToolStripMenuItem";
            this.tiposDeDocumentosPorUnidadToolStripMenuItem.Size = new System.Drawing.Size(366, 30);
            this.tiposDeDocumentosPorUnidadToolStripMenuItem.Text = "Tipos de Documentos por Unidad";
            this.tiposDeDocumentosPorUnidadToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDocumentosPorUnidadToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(366, 30);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // cajasToolStripMenuItem
            // 
            this.cajasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.cajasToolStripMenuItem.Enabled = false;
            this.cajasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cajasToolStripMenuItem.Name = "cajasToolStripMenuItem";
            this.cajasToolStripMenuItem.Size = new System.Drawing.Size(366, 30);
            this.cajasToolStripMenuItem.Text = "Cajas";
            this.cajasToolStripMenuItem.Click += new System.EventHandler(this.cajasToolStripMenuItem_Click);
            // 
            // panelConfig
            // 
            this.panelConfig.Controls.Add(this.panelQry);
            this.panelConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfig.Location = new System.Drawing.Point(0, 33);
            this.panelConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(1924, 1006);
            this.panelConfig.TabIndex = 1;
            // 
            // panelQry
            // 
            this.panelQry.Controls.Add(this.labelCount);
            this.panelQry.Controls.Add(this.checkBoxDesechado);
            this.panelQry.Controls.Add(this.buttonEditar);
            this.panelQry.Controls.Add(this.label9);
            this.panelQry.Controls.Add(this.textBoxRef);
            this.panelQry.Controls.Add(this.button4);
            this.panelQry.Controls.Add(this.dateTimePickerFin);
            this.panelQry.Controls.Add(this.label8);
            this.panelQry.Controls.Add(this.comboBoxNivelI);
            this.panelQry.Controls.Add(this.label7);
            this.panelQry.Controls.Add(this.comboBoxNivel0);
            this.panelQry.Controls.Add(this.label5);
            this.panelQry.Controls.Add(this.button3);
            this.panelQry.Controls.Add(this.button2);
            this.panelQry.Controls.Add(this.lblCurrPage);
            this.panelQry.Controls.Add(this.label6);
            this.panelQry.Controls.Add(this.lblNumPages);
            this.panelQry.Controls.Add(this.label4);
            this.panelQry.Controls.Add(this.listBoxQryDocRS);
            this.panelQry.Controls.Add(this.button1);
            this.panelQry.Controls.Add(this.dateTimePickerIni);
            this.panelQry.Controls.Add(this.textBoxNro);
            this.panelQry.Controls.Add(this.comboBoxTipoDoc);
            this.panelQry.Controls.Add(this.label3);
            this.panelQry.Controls.Add(this.label2);
            this.panelQry.Controls.Add(this.label1);
            this.panelQry.Controls.Add(this.pictureBoxSelectedDoc);
            this.panelQry.Controls.Add(this.axAcroPDFDocSelected);
            this.panelQry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQry.Location = new System.Drawing.Point(0, 0);
            this.panelQry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelQry.Name = "panelQry";
            this.panelQry.Size = new System.Drawing.Size(1924, 1006);
            this.panelQry.TabIndex = 0;
            this.panelQry.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQry_Paint);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.ForeColor = System.Drawing.Color.MistyRose;
            this.labelCount.Location = new System.Drawing.Point(18, 941);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(153, 20);
            this.labelCount.TabIndex = 28;
            this.labelCount.Text = " Resultado Consulta";
            // 
            // checkBoxDesechado
            // 
            this.checkBoxDesechado.AutoSize = true;
            this.checkBoxDesechado.ForeColor = System.Drawing.Color.White;
            this.checkBoxDesechado.Location = new System.Drawing.Point(215, 392);
            this.checkBoxDesechado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDesechado.Name = "checkBoxDesechado";
            this.checkBoxDesechado.Size = new System.Drawing.Size(117, 24);
            this.checkBoxDesechado.TabIndex = 27;
            this.checkBoxDesechado.Text = "Desechado";
            this.checkBoxDesechado.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(597, 934);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(112, 35);
            this.buttonEditar.TabIndex = 26;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(51, 341);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Referencia";
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(216, 338);
            this.textBoxRef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(373, 26);
            this.textBoxRef.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(597, 392);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "Configurar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.buttonCfg_Click);
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(216, 295);
            this.dateTimePickerFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(374, 26);
            this.dateTimePickerFin.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha Fin";
            // 
            // comboBoxNivelI
            // 
            this.comboBoxNivelI.FormattingEnabled = true;
            this.comboBoxNivelI.Location = new System.Drawing.Point(216, 119);
            this.comboBoxNivelI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxNivelI.Name = "comboBoxNivelI";
            this.comboBoxNivelI.Size = new System.Drawing.Size(374, 28);
            this.comboBoxNivelI.TabIndex = 20;
            this.comboBoxNivelI.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivelI_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(51, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sub Departamento";
            // 
            // comboBoxNivel0
            // 
            this.comboBoxNivel0.FormattingEnabled = true;
            this.comboBoxNivel0.Location = new System.Drawing.Point(216, 71);
            this.comboBoxNivel0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxNivel0.Name = "comboBoxNivel0";
            this.comboBoxNivel0.Size = new System.Drawing.Size(374, 28);
            this.comboBoxNivel0.TabIndex = 18;
            this.comboBoxNivel0.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivel0_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Departamento";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1400, 55);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1210, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCurrPage
            // 
            this.lblCurrPage.AutoSize = true;
            this.lblCurrPage.ForeColor = System.Drawing.Color.White;
            this.lblCurrPage.Location = new System.Drawing.Point(990, 69);
            this.lblCurrPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrPage.Name = "lblCurrPage";
            this.lblCurrPage.Size = new System.Drawing.Size(91, 20);
            this.lblCurrPage.TabIndex = 14;
            this.lblCurrPage.Text = "lblCurrPage";
            this.lblCurrPage.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(818, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Página Actual";
            this.label6.Visible = false;
            // 
            // lblNumPages
            // 
            this.lblNumPages.AutoSize = true;
            this.lblNumPages.ForeColor = System.Drawing.Color.White;
            this.lblNumPages.Location = new System.Drawing.Point(990, 41);
            this.lblNumPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPages.Name = "lblNumPages";
            this.lblNumPages.Size = new System.Drawing.Size(102, 20);
            this.lblNumPages.TabIndex = 12;
            this.lblNumPages.Text = "lblNumPages";
            this.lblNumPages.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(818, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nro. Páginas";
            this.label4.Visible = false;
            // 
            // listBoxQryDocRS
            // 
            this.listBoxQryDocRS.FormattingEnabled = true;
            this.listBoxQryDocRS.ItemHeight = 20;
            this.listBoxQryDocRS.Location = new System.Drawing.Point(18, 438);
            this.listBoxQryDocRS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxQryDocRS.Name = "listBoxQryDocRS";
            this.listBoxQryDocRS.Size = new System.Drawing.Size(689, 484);
            this.listBoxQryDocRS.TabIndex = 8;
            this.listBoxQryDocRS.SelectedIndexChanged += new System.EventHandler(this.listBoxQryDocRS_SelectedIndexChanged);
            this.listBoxQryDocRS.DoubleClick += new System.EventHandler(this.listBoxQryDocRS_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(480, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dateTimePickerIni
            // 
            this.dateTimePickerIni.Location = new System.Drawing.Point(216, 249);
            this.dateTimePickerIni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerIni.Name = "dateTimePickerIni";
            this.dateTimePickerIni.Size = new System.Drawing.Size(374, 26);
            this.dateTimePickerIni.TabIndex = 5;
            // 
            // textBoxNro
            // 
            this.textBoxNro.Location = new System.Drawing.Point(215, 209);
            this.textBoxNro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNro.Name = "textBoxNro";
            this.textBoxNro.Size = new System.Drawing.Size(376, 26);
            this.textBoxNro.TabIndex = 4;
            this.textBoxNro.TextChanged += new System.EventHandler(this.textBoxNro_TextChanged);
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(215, 168);
            this.comboBoxTipoDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(374, 28);
            this.comboBoxTipoDoc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Inicio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Documento";
            // 
            // pictureBoxSelectedDoc
            // 
            this.pictureBoxSelectedDoc.Location = new System.Drawing.Point(802, 132);
            this.pictureBoxSelectedDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxSelectedDoc.Name = "pictureBoxSelectedDoc";
            this.pictureBoxSelectedDoc.Size = new System.Drawing.Size(1161, 785);
            this.pictureBoxSelectedDoc.TabIndex = 10;
            this.pictureBoxSelectedDoc.TabStop = false;
            this.pictureBoxSelectedDoc.Click += new System.EventHandler(this.pictureBoxSelectedDoc_Click);
            // 
            // axAcroPDFDocSelected
            // 
            this.axAcroPDFDocSelected.Enabled = true;
            this.axAcroPDFDocSelected.Location = new System.Drawing.Point(712, 104);
            this.axAcroPDFDocSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axAcroPDFDocSelected.Name = "axAcroPDFDocSelected";
            this.axAcroPDFDocSelected.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFDocSelected.OcxState")));
            this.axAcroPDFDocSelected.Size = new System.Drawing.Size(774, 510);
            this.axAcroPDFDocSelected.TabIndex = 9;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1924, 1039);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QueryForm";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelConfig.ResumeLayout(false);
            this.panelQry.ResumeLayout(false);
            this.panelQry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFDocSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Panel panelQry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIni;
        private System.Windows.Forms.TextBox textBoxNro;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxQryDocRS;
        private AxAcroPDFLib.AxAcroPDF axAcroPDFDocSelected;
        private System.Windows.Forms.PictureBox pictureBoxSelectedDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumPages;
        private System.Windows.Forms.Label lblCurrPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxNivelI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxNivel0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDocumentosPorUnidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxDesechado;
        private System.Windows.Forms.ToolStripMenuItem cajasToolStripMenuItem;
        private System.Windows.Forms.Label labelCount;

    }
}

