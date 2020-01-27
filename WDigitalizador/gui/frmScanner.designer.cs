

namespace Digitalizador.gui
{
    partial class frmScanner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScanner));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Reconocidos", 4, 4);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("No Reconocidos", 4, 4);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Temporales", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Documentos Locales", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.imageListGral = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripMenuFlotante = new System.Windows.Forms.ToolStrip();
            this.mfBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.mfBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mfBtnRenombrar = new System.Windows.Forms.ToolStripButton();
            this.mfBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.mfBtnEliminarTodo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mfBtnMoveToReconocido = new System.Windows.Forms.ToolStripButton();
            this.mfBtnMoveToNoReconocido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mfBtnAyuda = new System.Windows.Forms.ToolStripButton();
            this.panelStatusBar = new System.Windows.Forms.Panel();
            this.statusBarDigit = new System.Windows.Forms.StatusBar();
            this.statusBarLeft = new System.Windows.Forms.StatusBarPanel();
            this.statusBarCenterLeft = new System.Windows.Forms.StatusBarPanel();
            this.statusBarCenterRigth = new System.Windows.Forms.StatusBarPanel();
            this.statusBarRigth = new System.Windows.Forms.StatusBarPanel();
            this.grpDigitalizacion = new System.Windows.Forms.GroupBox();
            this.panelDocs = new System.Windows.Forms.Panel();
            this.treeViewDocs = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBotonera = new System.Windows.Forms.Panel();
            this.grpProgressBar = new System.Windows.Forms.GroupBox();
            this.chkDetectBlankPage = new System.Windows.Forms.CheckBox();
            this.ckkUsaDuplex = new System.Windows.Forms.CheckBox();
            this.labAccion = new System.Windows.Forms.Label();
            this.pbDigit = new System.Windows.Forms.ProgressBar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDigitAuto = new System.Windows.Forms.Button();
            this.panelImages = new System.Windows.Forms.Panel();
            this.grpViewer = new System.Windows.Forms.GroupBox();
            this.axAcroPDFViewer = new AxAcroPDFLib.AxAcroPDF();
            this.scalablePicSelected = new QAlbum.ScalablePictureBox();
            this.grpBotonerTIFF = new System.Windows.Forms.GroupBox();
            this.labTIFFMultipagina = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimera = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUltima = new System.Windows.Forms.Button();
            this.grpConfigDigitalizador = new System.Windows.Forms.GroupBox();
            this.grpConfigSender = new System.Windows.Forms.GroupBox();
            this.grpConfigSenderInterno = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label38 = new System.Windows.Forms.Label();
            this.nUDSizeToSend = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTimeotWS = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnOpenPathLogSender = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStrPathLogSender = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.btnGrabarParamSender = new System.Windows.Forms.Button();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.grpLogInterno = new System.Windows.Forms.GroupBox();
            this.grpLogBody = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.grpLogFilter = new System.Windows.Forms.GroupBox();
            this.btnLogTodos = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnLogBuscar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picSelected = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.toolStripMenuFlotante.SuspendLayout();
            this.panelStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarCenterLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarCenterRigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarRigth)).BeginInit();
            this.grpDigitalizacion.SuspendLayout();
            this.panelDocs.SuspendLayout();
            this.panelBotonera.SuspendLayout();
            this.grpProgressBar.SuspendLayout();
            this.panelImages.SuspendLayout();
            this.grpViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFViewer)).BeginInit();
            this.grpBotonerTIFF.SuspendLayout();
            this.grpConfigSender.SuspendLayout();
            this.grpConfigSenderInterno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSizeToSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.grpLog.SuspendLayout();
            this.grpLogInterno.SuspendLayout();
            this.grpLogBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.grpLogFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListGral
            // 
            this.imageListGral.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGral.ImageStream")));
            this.imageListGral.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGral.Images.SetKeyName(0, "Printers.ico");
            this.imageListGral.Images.SetKeyName(1, "Printers2.ico");
            this.imageListGral.Images.SetKeyName(2, "Write Document.ico");
            this.imageListGral.Images.SetKeyName(3, "Bitmap Image.ico");
            this.imageListGral.Images.SetKeyName(4, "Open Folder.ico");
            this.imageListGral.Images.SetKeyName(5, "pdf.gif");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStripMenuFlotante);
            this.panel1.Controls.Add(this.panelStatusBar);
            this.panel1.Controls.Add(this.grpDigitalizacion);
            this.panel1.Controls.Add(this.grpConfigDigitalizador);
            this.panel1.Controls.Add(this.grpConfigSender);
            this.panel1.Controls.Add(this.grpLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Size = new System.Drawing.Size(1457, 826);
            this.panel1.TabIndex = 0;
            // 
            // toolStripMenuFlotante
            // 
            this.toolStripMenuFlotante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(229)))), ((int)(((byte)(176)))));
            this.toolStripMenuFlotante.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMenuFlotante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mfBtnRefresh,
            this.mfBtnBuscar,
            this.toolStripSeparator,
            this.mfBtnRenombrar,
            this.mfBtnEliminar,
            this.mfBtnEliminarTodo,
            this.toolStripSeparator1,
            this.mfBtnMoveToReconocido,
            this.mfBtnMoveToNoReconocido,
            this.toolStripSeparator2,
            this.mfBtnAyuda});
            this.toolStripMenuFlotante.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripMenuFlotante.Location = new System.Drawing.Point(4, 270);
            this.toolStripMenuFlotante.Name = "toolStripMenuFlotante";
            this.toolStripMenuFlotante.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripMenuFlotante.Size = new System.Drawing.Size(180, 249);
            this.toolStripMenuFlotante.TabIndex = 0;
            this.toolStripMenuFlotante.Text = "Menu";
            this.toolStripMenuFlotante.Visible = false;
            // 
            // mfBtnRefresh
            // 
            this.mfBtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mfBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mfBtnRefresh.Name = "mfBtnRefresh";
            this.mfBtnRefresh.Size = new System.Drawing.Size(173, 24);
            this.mfBtnRefresh.Text = "Re&frescar";
            this.mfBtnRefresh.Click += new System.EventHandler(this.mfBtnRefresh_Click);
            // 
            // mfBtnBuscar
            // 
            this.mfBtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mfBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mfBtnBuscar.Name = "mfBtnBuscar";
            this.mfBtnBuscar.Size = new System.Drawing.Size(173, 24);
            this.mfBtnBuscar.Text = "&Buscar";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(173, 6);
            // 
            // mfBtnRenombrar
            // 
            this.mfBtnRenombrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mfBtnRenombrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mfBtnRenombrar.Name = "mfBtnRenombrar";
            this.mfBtnRenombrar.Size = new System.Drawing.Size(173, 24);
            this.mfBtnRenombrar.Text = "&Renombrar";
            // 
            // mfBtnEliminar
            // 
            this.mfBtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mfBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mfBtnEliminar.Name = "mfBtnEliminar";
            this.mfBtnEliminar.Size = new System.Drawing.Size(173, 24);
            this.mfBtnEliminar.Text = "&Eliminar";
            this.mfBtnEliminar.Click += new System.EventHandler(this.mfBtnEliminar_Click);
            // 
            // mfBtnEliminarTodo
            // 
            this.mfBtnEliminarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mfBtnEliminarTodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mfBtnEliminarTodo.Name = "mfBtnEliminarTodo";
            this.mfBtnEliminarTodo.Size = new System.Drawing.Size(173, 24);
            this.mfBtnEliminarTodo.Text = "Eliminar &Todo";
            this.mfBtnEliminarTodo.Click += new System.EventHandler(this.mfBtnEliminarTodo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // mfBtnMoveToReconocido
            // 
            this.mfBtnMoveToReconocido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mfBtnMoveToReconocido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mfBtnMoveToReconocido.Name = "mfBtnMoveToReconocido";
            this.mfBtnMoveToReconocido.Size = new System.Drawing.Size(173, 24);
            this.mfBtnMoveToReconocido.Text = "&Mover a Reconocido";
            this.mfBtnMoveToReconocido.Click += new System.EventHandler(this.mfBtnMoveToReconocido_Click);
            // 
            // mfBtnMoveToNoReconocido
            // 
            this.mfBtnMoveToNoReconocido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mfBtnMoveToNoReconocido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mfBtnMoveToNoReconocido.Name = "mfBtnMoveToNoReconocido";
            this.mfBtnMoveToNoReconocido.Size = new System.Drawing.Size(173, 24);
            this.mfBtnMoveToNoReconocido.Text = "M&over a No Reconocido";
            this.mfBtnMoveToNoReconocido.Click += new System.EventHandler(this.mfBtnMoveToNoReconocido_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // mfBtnAyuda
            // 
            this.mfBtnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("mfBtnAyuda.Image")));
            this.mfBtnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mfBtnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mfBtnAyuda.Name = "mfBtnAyuda";
            this.mfBtnAyuda.Size = new System.Drawing.Size(173, 24);
            this.mfBtnAyuda.Text = "&Ayuda";
            this.mfBtnAyuda.Click += new System.EventHandler(this.mfBtnAyuda_Click);
            // 
            // panelStatusBar
            // 
            this.panelStatusBar.Controls.Add(this.statusBarDigit);
            this.panelStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatusBar.Location = new System.Drawing.Point(4, 794);
            this.panelStatusBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStatusBar.Name = "panelStatusBar";
            this.panelStatusBar.Size = new System.Drawing.Size(1449, 28);
            this.panelStatusBar.TabIndex = 6;
            // 
            // statusBarDigit
            // 
            this.statusBarDigit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusBarDigit.Location = new System.Drawing.Point(0, 0);
            this.statusBarDigit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusBarDigit.Name = "statusBarDigit";
            this.statusBarDigit.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarLeft,
            this.statusBarCenterLeft,
            this.statusBarCenterRigth,
            this.statusBarRigth});
            this.statusBarDigit.ShowPanels = true;
            this.statusBarDigit.Size = new System.Drawing.Size(1449, 28);
            this.statusBarDigit.TabIndex = 1;
            this.statusBarDigit.Text = "Applicación de Digitalización...";
            // 
            // statusBarLeft
            // 
            this.statusBarLeft.Name = "statusBarLeft";
            this.statusBarLeft.Text = "Fecha: 28/09/2009";
            this.statusBarLeft.Width = 110;
            // 
            // statusBarCenterLeft
            // 
            this.statusBarCenterLeft.Name = "statusBarCenterLeft";
            this.statusBarCenterLeft.Text = "Hora: 23:30";
            this.statusBarCenterLeft.Width = 110;
            // 
            // statusBarCenterRigth
            // 
            this.statusBarCenterRigth.Name = "statusBarCenterRigth";
            this.statusBarCenterRigth.Width = 150;
            // 
            // statusBarRigth
            // 
            this.statusBarRigth.Name = "statusBarRigth";
            this.statusBarRigth.Text = "Status...";
            this.statusBarRigth.Width = 600;
            // 
            // grpDigitalizacion
            // 
            this.grpDigitalizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.grpDigitalizacion.Controls.Add(this.panelDocs);
            this.grpDigitalizacion.Controls.Add(this.panelBotonera);
            this.grpDigitalizacion.Controls.Add(this.panelImages);
            this.grpDigitalizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDigitalizacion.ForeColor = System.Drawing.Color.White;
            this.grpDigitalizacion.Location = new System.Drawing.Point(4, 4);
            this.grpDigitalizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDigitalizacion.Name = "grpDigitalizacion";
            this.grpDigitalizacion.Padding = new System.Windows.Forms.Padding(7, 0, 7, 6);
            this.grpDigitalizacion.Size = new System.Drawing.Size(1449, 818);
            this.grpDigitalizacion.TabIndex = 7;
            this.grpDigitalizacion.TabStop = false;
            // 
            // panelDocs
            // 
            this.panelDocs.Controls.Add(this.treeViewDocs);
            this.panelDocs.Controls.Add(this.label2);
            this.panelDocs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDocs.Location = new System.Drawing.Point(7, 106);
            this.panelDocs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDocs.Name = "panelDocs";
            this.panelDocs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDocs.Size = new System.Drawing.Size(319, 706);
            this.panelDocs.TabIndex = 12;
            // 
            // treeViewDocs
            // 
            this.treeViewDocs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.treeViewDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewDocs.ForeColor = System.Drawing.Color.White;
            this.treeViewDocs.FullRowSelect = true;
            this.treeViewDocs.ImageIndex = 0;
            this.treeViewDocs.ImageList = this.imageListGral;
            this.treeViewDocs.Location = new System.Drawing.Point(4, 33);
            this.treeViewDocs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewDocs.Name = "treeViewDocs";
            treeNode1.ForeColor = System.Drawing.Color.White;
            treeNode1.ImageIndex = 4;
            treeNode1.Name = "Reconocidos";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.SelectedImageIndex = 4;
            treeNode1.Text = "Reconocidos";
            treeNode2.ForeColor = System.Drawing.Color.White;
            treeNode2.ImageIndex = 4;
            treeNode2.Name = "NoReconocidos";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.SelectedImageIndex = 4;
            treeNode2.Text = "No Reconocidos";
            treeNode3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            treeNode3.ImageIndex = 4;
            treeNode3.Name = "Temporales";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode3.SelectedImageIndex = 4;
            treeNode3.Tag = "";
            treeNode3.Text = "Temporales";
            treeNode4.ForeColor = System.Drawing.Color.White;
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "DocumentosLocales";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Tag = "";
            treeNode4.Text = "Documentos Locales";
            this.treeViewDocs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeViewDocs.SelectedImageIndex = 0;
            this.treeViewDocs.ShowNodeToolTips = true;
            this.treeViewDocs.Size = new System.Drawing.Size(311, 669);
            this.treeViewDocs.TabIndex = 1;
            this.treeViewDocs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDocs_AfterSelect);
            this.treeViewDocs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewDocs_MouseDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Documentos Escaneados ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBotonera
            // 
            this.panelBotonera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotonera.Controls.Add(this.grpProgressBar);
            this.panelBotonera.Controls.Add(this.btnCancelar);
            this.panelBotonera.Controls.Add(this.btnDigitAuto);
            this.panelBotonera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonera.Location = new System.Drawing.Point(7, 15);
            this.panelBotonera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBotonera.Name = "panelBotonera";
            this.panelBotonera.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelBotonera.Size = new System.Drawing.Size(1435, 91);
            this.panelBotonera.TabIndex = 13;
            // 
            // grpProgressBar
            // 
            this.grpProgressBar.Controls.Add(this.chkDetectBlankPage);
            this.grpProgressBar.Controls.Add(this.ckkUsaDuplex);
            this.grpProgressBar.Controls.Add(this.labAccion);
            this.grpProgressBar.Controls.Add(this.pbDigit);
            this.grpProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProgressBar.Location = new System.Drawing.Point(146, 5);
            this.grpProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpProgressBar.Name = "grpProgressBar";
            this.grpProgressBar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpProgressBar.Size = new System.Drawing.Size(1143, 79);
            this.grpProgressBar.TabIndex = 18;
            this.grpProgressBar.TabStop = false;
            // 
            // chkDetectBlankPage
            // 
            this.chkDetectBlankPage.AutoSize = true;
            this.chkDetectBlankPage.Checked = true;
            this.chkDetectBlankPage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetectBlankPage.Location = new System.Drawing.Point(159, 17);
            this.chkDetectBlankPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDetectBlankPage.Name = "chkDetectBlankPage";
            this.chkDetectBlankPage.Size = new System.Drawing.Size(251, 21);
            this.chkDetectBlankPage.TabIndex = 19;
            this.chkDetectBlankPage.Text = "Habilita Detección Hojas en Blanco";
            this.chkDetectBlankPage.UseVisualStyleBackColor = true;
            this.chkDetectBlankPage.Visible = false;
            // 
            // ckkUsaDuplex
            // 
            this.ckkUsaDuplex.AutoSize = true;
            this.ckkUsaDuplex.Location = new System.Drawing.Point(8, 17);
            this.ckkUsaDuplex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckkUsaDuplex.Name = "ckkUsaDuplex";
            this.ckkUsaDuplex.Size = new System.Drawing.Size(136, 21);
            this.ckkUsaDuplex.TabIndex = 18;
            this.ckkUsaDuplex.Text = "Habilita DUPLEX";
            this.ckkUsaDuplex.UseVisualStyleBackColor = true;
            // 
            // labAccion
            // 
            this.labAccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labAccion.Location = new System.Drawing.Point(4, 42);
            this.labAccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAccion.Name = "labAccion";
            this.labAccion.Size = new System.Drawing.Size(1135, 18);
            this.labAccion.TabIndex = 17;
            this.labAccion.Text = "Información de ejecución...";
            // 
            // pbDigit
            // 
            this.pbDigit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.pbDigit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbDigit.Location = new System.Drawing.Point(4, 60);
            this.pbDigit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDigit.Name = "pbDigit";
            this.pbDigit.Size = new System.Drawing.Size(1135, 15);
            this.pbDigit.Step = 1;
            this.pbDigit.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDigit.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1289, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 79);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDigitAuto
            // 
            this.btnDigitAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.btnDigitAuto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDigitAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDigitAuto.Location = new System.Drawing.Point(5, 5);
            this.btnDigitAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDigitAuto.Name = "btnDigitAuto";
            this.btnDigitAuto.Size = new System.Drawing.Size(141, 79);
            this.btnDigitAuto.TabIndex = 15;
            this.btnDigitAuto.Text = "&Digitalizar";
            this.btnDigitAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDigitAuto.UseVisualStyleBackColor = false;
            this.btnDigitAuto.Click += new System.EventHandler(this.btnDigitAuto_Click);
            // 
            // panelImages
            // 
            this.panelImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImages.Controls.Add(this.grpViewer);
            this.panelImages.Controls.Add(this.grpBotonerTIFF);
            this.panelImages.Location = new System.Drawing.Point(325, 107);
            this.panelImages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(1117, 674);
            this.panelImages.TabIndex = 14;
            // 
            // grpViewer
            // 
            this.grpViewer.Controls.Add(this.axAcroPDFViewer);
            this.grpViewer.Controls.Add(this.scalablePicSelected);
            this.grpViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpViewer.Location = new System.Drawing.Point(0, 63);
            this.grpViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpViewer.Name = "grpViewer";
            this.grpViewer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpViewer.Size = new System.Drawing.Size(1115, 609);
            this.grpViewer.TabIndex = 0;
            this.grpViewer.TabStop = false;
            // 
            // axAcroPDFViewer
            // 
            this.axAcroPDFViewer.Enabled = true;
            this.axAcroPDFViewer.Location = new System.Drawing.Point(3, 17);
            this.axAcroPDFViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axAcroPDFViewer.Name = "axAcroPDFViewer";
            this.axAcroPDFViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFViewer.OcxState")));
            this.axAcroPDFViewer.Size = new System.Drawing.Size(1109, 561);
            this.axAcroPDFViewer.TabIndex = 0;
            // 
            // scalablePicSelected
            // 
            this.scalablePicSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.scalablePicSelected.Location = new System.Drawing.Point(4, 20);
            this.scalablePicSelected.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scalablePicSelected.Name = "scalablePicSelected";
            this.scalablePicSelected.Size = new System.Drawing.Size(1107, 558);
            this.scalablePicSelected.TabIndex = 1;
            // 
            // grpBotonerTIFF
            // 
            this.grpBotonerTIFF.Controls.Add(this.labTIFFMultipagina);
            this.grpBotonerTIFF.Controls.Add(this.btnAnterior);
            this.grpBotonerTIFF.Controls.Add(this.btnPrimera);
            this.grpBotonerTIFF.Controls.Add(this.btnNext);
            this.grpBotonerTIFF.Controls.Add(this.btnUltima);
            this.grpBotonerTIFF.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBotonerTIFF.Location = new System.Drawing.Point(0, 0);
            this.grpBotonerTIFF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBotonerTIFF.Name = "grpBotonerTIFF";
            this.grpBotonerTIFF.Padding = new System.Windows.Forms.Padding(1);
            this.grpBotonerTIFF.Size = new System.Drawing.Size(1115, 63);
            this.grpBotonerTIFF.TabIndex = 1;
            this.grpBotonerTIFF.TabStop = false;
            // 
            // labTIFFMultipagina
            // 
            this.labTIFFMultipagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.labTIFFMultipagina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTIFFMultipagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTIFFMultipagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTIFFMultipagina.ForeColor = System.Drawing.Color.White;
            this.labTIFFMultipagina.Location = new System.Drawing.Point(335, 16);
            this.labTIFFMultipagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTIFFMultipagina.Name = "labTIFFMultipagina";
            this.labTIFFMultipagina.Size = new System.Drawing.Size(445, 46);
            this.labTIFFMultipagina.TabIndex = 28;
            this.labTIFFMultipagina.Text = "Página 123 de 12902";
            this.labTIFFMultipagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnterior.Location = new System.Drawing.Point(168, 16);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Size = new System.Drawing.Size(167, 46);
            this.btnAnterior.TabIndex = 27;
            this.btnAnterior.Text = "&Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPrimera
            // 
            this.btnPrimera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.btnPrimera.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrimera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimera.Location = new System.Drawing.Point(1, 16);
            this.btnPrimera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimera.Name = "btnPrimera";
            this.btnPrimera.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimera.Size = new System.Drawing.Size(167, 46);
            this.btnPrimera.TabIndex = 26;
            this.btnPrimera.Text = "&Primera";
            this.btnPrimera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimera.UseVisualStyleBackColor = false;
            this.btnPrimera.Click += new System.EventHandler(this.btnPrimera_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(780, 16);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Size = new System.Drawing.Size(167, 46);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "&Siguiente";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnUltima
            // 
            this.btnUltima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.btnUltima.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUltima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltima.Location = new System.Drawing.Point(947, 16);
            this.btnUltima.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltima.Name = "btnUltima";
            this.btnUltima.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltima.Size = new System.Drawing.Size(167, 46);
            this.btnUltima.TabIndex = 24;
            this.btnUltima.Text = "&Ultima";
            this.btnUltima.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUltima.UseVisualStyleBackColor = false;
            this.btnUltima.Click += new System.EventHandler(this.btnUltima_Click);
            // 
            // grpConfigDigitalizador
            // 
            this.grpConfigDigitalizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConfigDigitalizador.Location = new System.Drawing.Point(4, 4);
            this.grpConfigDigitalizador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConfigDigitalizador.Name = "grpConfigDigitalizador";
            this.grpConfigDigitalizador.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConfigDigitalizador.Size = new System.Drawing.Size(1449, 818);
            this.grpConfigDigitalizador.TabIndex = 8;
            this.grpConfigDigitalizador.TabStop = false;
            // 
            // grpConfigSender
            // 
            this.grpConfigSender.Controls.Add(this.grpConfigSenderInterno);
            this.grpConfigSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConfigSender.Location = new System.Drawing.Point(4, 4);
            this.grpConfigSender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConfigSender.Name = "grpConfigSender";
            this.grpConfigSender.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConfigSender.Size = new System.Drawing.Size(1449, 818);
            this.grpConfigSender.TabIndex = 9;
            this.grpConfigSender.TabStop = false;
            // 
            // grpConfigSenderInterno
            // 
            this.grpConfigSenderInterno.Controls.Add(this.pictureBox3);
            this.grpConfigSenderInterno.Controls.Add(this.label38);
            this.grpConfigSenderInterno.Controls.Add(this.nUDSizeToSend);
            this.grpConfigSenderInterno.Controls.Add(this.label36);
            this.grpConfigSenderInterno.Controls.Add(this.label37);
            this.grpConfigSenderInterno.Controls.Add(this.label21);
            this.grpConfigSenderInterno.Controls.Add(this.txtTimeotWS);
            this.grpConfigSenderInterno.Controls.Add(this.label20);
            this.grpConfigSenderInterno.Controls.Add(this.btnOpenPathLogSender);
            this.grpConfigSenderInterno.Controls.Add(this.label18);
            this.grpConfigSenderInterno.Controls.Add(this.txtStrPathLogSender);
            this.grpConfigSenderInterno.Controls.Add(this.label33);
            this.grpConfigSenderInterno.Controls.Add(this.pictureBox12);
            this.grpConfigSenderInterno.Controls.Add(this.btnGrabarParamSender);
            this.grpConfigSenderInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConfigSenderInterno.ForeColor = System.Drawing.Color.Maroon;
            this.grpConfigSenderInterno.Location = new System.Drawing.Point(20, 27);
            this.grpConfigSenderInterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConfigSenderInterno.Name = "grpConfigSenderInterno";
            this.grpConfigSenderInterno.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConfigSenderInterno.Size = new System.Drawing.Size(804, 396);
            this.grpConfigSenderInterno.TabIndex = 91;
            this.grpConfigSenderInterno.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(19, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(97, 228);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(320, 20);
            this.label38.TabIndex = 104;
            this.label38.Text = "[El horario peak es de 9:00Hs a 14:00Hs]";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nUDSizeToSend
            // 
            this.nUDSizeToSend.Location = new System.Drawing.Point(443, 206);
            this.nUDSizeToSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nUDSizeToSend.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDSizeToSend.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDSizeToSend.Name = "nUDSizeToSend";
            this.nUDSizeToSend.Size = new System.Drawing.Size(145, 23);
            this.nUDSizeToSend.TabIndex = 103;
            this.nUDSizeToSend.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(593, 203);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(196, 25);
            this.label36.TabIndex = 102;
            this.label36.Text = "[En Mb de 1Mb hasta 10Mb]";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(21, 206);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(415, 25);
            this.label37.TabIndex = 101;
            this.label37.Text = "Tamaño máximo de envíos directos en horario peak :";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(571, 129);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 25);
            this.label21.TabIndex = 100;
            this.label21.Text = "[En milisegundos]";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeotWS
            // 
            this.txtTimeotWS.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtTimeotWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeotWS.Location = new System.Drawing.Point(419, 129);
            this.txtTimeotWS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimeotWS.Name = "txtTimeotWS";
            this.txtTimeotWS.Size = new System.Drawing.Size(144, 23);
            this.txtTimeotWS.TabIndex = 99;
            this.txtTimeotWS.Text = "30000";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(164, 129);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(247, 25);
            this.label20.TabIndex = 98;
            this.label20.Text = "Timeout del Web Service :";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOpenPathLogSender
            // 
            this.btnOpenPathLogSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(229)))), ((int)(((byte)(176)))));
            this.btnOpenPathLogSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPathLogSender.ForeColor = System.Drawing.Color.Black;
            this.btnOpenPathLogSender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenPathLogSender.Location = new System.Drawing.Point(747, 65);
            this.btnOpenPathLogSender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenPathLogSender.Name = "btnOpenPathLogSender";
            this.btnOpenPathLogSender.Size = new System.Drawing.Size(32, 30);
            this.btnOpenPathLogSender.TabIndex = 20;
            this.btnOpenPathLogSender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenPathLogSender.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(84, 14);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(513, 25);
            this.label18.TabIndex = 96;
            this.label18.Text = "Configurar parámetros de ejecución Sender...";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStrPathLogSender
            // 
            this.txtStrPathLogSender.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtStrPathLogSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrPathLogSender.Location = new System.Drawing.Point(352, 69);
            this.txtStrPathLogSender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStrPathLogSender.Name = "txtStrPathLogSender";
            this.txtStrPathLogSender.Size = new System.Drawing.Size(384, 23);
            this.txtStrPathLogSender.TabIndex = 1;
            this.txtStrPathLogSender.Text = "c:\\temp\\aa\\log";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(164, 69);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(180, 25);
            this.label33.TabIndex = 0;
            this.label33.Text = "Path Log Ejecución :";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(19, 65);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(125, 116);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 97;
            this.pictureBox12.TabStop = false;
            // 
            // btnGrabarParamSender
            // 
            this.btnGrabarParamSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(229)))), ((int)(((byte)(176)))));
            this.btnGrabarParamSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarParamSender.ForeColor = System.Drawing.Color.Black;
            this.btnGrabarParamSender.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabarParamSender.Image")));
            this.btnGrabarParamSender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabarParamSender.Location = new System.Drawing.Point(305, 302);
            this.btnGrabarParamSender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabarParamSender.Name = "btnGrabarParamSender";
            this.btnGrabarParamSender.Size = new System.Drawing.Size(169, 55);
            this.btnGrabarParamSender.TabIndex = 12;
            this.btnGrabarParamSender.Text = "&Grabar Parámetros";
            this.btnGrabarParamSender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabarParamSender.UseVisualStyleBackColor = false;
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.grpLogInterno);
            this.grpLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLog.Location = new System.Drawing.Point(4, 4);
            this.grpLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLog.Name = "grpLog";
            this.grpLog.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLog.Size = new System.Drawing.Size(1449, 818);
            this.grpLog.TabIndex = 10;
            this.grpLog.TabStop = false;
            this.grpLog.Visible = false;
            // 
            // grpLogInterno
            // 
            this.grpLogInterno.Controls.Add(this.grpLogBody);
            this.grpLogInterno.Controls.Add(this.grpLogFilter);
            this.grpLogInterno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLogInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogInterno.ForeColor = System.Drawing.Color.Maroon;
            this.grpLogInterno.Location = new System.Drawing.Point(4, 19);
            this.grpLogInterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogInterno.Name = "grpLogInterno";
            this.grpLogInterno.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogInterno.Size = new System.Drawing.Size(1441, 795);
            this.grpLogInterno.TabIndex = 91;
            this.grpLogInterno.TabStop = false;
            this.grpLogInterno.Text = "Log de Operaciones...";
            // 
            // grpLogBody
            // 
            this.grpLogBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpLogBody.Controls.Add(this.dataGrid1);
            this.grpLogBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLogBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogBody.ForeColor = System.Drawing.Color.Maroon;
            this.grpLogBody.Location = new System.Drawing.Point(4, 159);
            this.grpLogBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogBody.Name = "grpLogBody";
            this.grpLogBody.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogBody.Size = new System.Drawing.Size(1433, 632);
            this.grpLogBody.TabIndex = 92;
            this.grpLogBody.TabStop = false;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGrid1.CaptionVisible = false;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Black;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrid1.Location = new System.Drawing.Point(4, 20);
            this.dataGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGrid1.Size = new System.Drawing.Size(1425, 608);
            this.dataGrid1.TabIndex = 20;
            // 
            // grpLogFilter
            // 
            this.grpLogFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpLogFilter.Controls.Add(this.btnLogTodos);
            this.grpLogFilter.Controls.Add(this.pictureBox8);
            this.grpLogFilter.Controls.Add(this.btnLogBuscar);
            this.grpLogFilter.Controls.Add(this.label19);
            this.grpLogFilter.Controls.Add(this.dateHasta);
            this.grpLogFilter.Controls.Add(this.label23);
            this.grpLogFilter.Controls.Add(this.dateDesde);
            this.grpLogFilter.Controls.Add(this.comboLevel);
            this.grpLogFilter.Controls.Add(this.label24);
            this.grpLogFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLogFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogFilter.ForeColor = System.Drawing.Color.Maroon;
            this.grpLogFilter.Location = new System.Drawing.Point(4, 20);
            this.grpLogFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogFilter.Name = "grpLogFilter";
            this.grpLogFilter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogFilter.Size = new System.Drawing.Size(1433, 139);
            this.grpLogFilter.TabIndex = 91;
            this.grpLogFilter.TabStop = false;
            // 
            // btnLogTodos
            // 
            this.btnLogTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(229)))), ((int)(((byte)(176)))));
            this.btnLogTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogTodos.ForeColor = System.Drawing.Color.Black;
            this.btnLogTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogTodos.Location = new System.Drawing.Point(812, 36);
            this.btnLogTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogTodos.Name = "btnLogTodos";
            this.btnLogTodos.Size = new System.Drawing.Size(151, 76);
            this.btnLogTodos.TabIndex = 96;
            this.btnLogTodos.Text = "&Todos";
            this.btnLogTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogTodos.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(8, 23);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(109, 101);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 95;
            this.pictureBox8.TabStop = false;
            // 
            // btnLogBuscar
            // 
            this.btnLogBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(229)))), ((int)(((byte)(176)))));
            this.btnLogBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnLogBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogBuscar.Location = new System.Drawing.Point(653, 36);
            this.btnLogBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogBuscar.Name = "btnLogBuscar";
            this.btnLogBuscar.Size = new System.Drawing.Size(151, 78);
            this.btnLogBuscar.TabIndex = 12;
            this.btnLogBuscar.Text = "&Buscar";
            this.btnLogBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogBuscar.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(404, 85);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 25);
            this.label19.TabIndex = 25;
            this.label19.Text = "Hasta :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateHasta
            // 
            this.dateHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHasta.Location = new System.Drawing.Point(476, 86);
            this.dateHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateHasta.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(116, 23);
            this.dateHasta.TabIndex = 28;
            this.dateHasta.Value = new System.DateTime(2004, 8, 25, 0, 0, 0, 0);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(173, 85);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 25);
            this.label23.TabIndex = 24;
            this.label23.Text = "Desde :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateDesde
            // 
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDesde.Location = new System.Drawing.Point(276, 85);
            this.dateDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDesde.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(116, 23);
            this.dateDesde.TabIndex = 21;
            this.dateDesde.Value = new System.DateTime(2004, 8, 25, 0, 0, 0, 0);
            // 
            // comboLevel
            // 
            this.comboLevel.Items.AddRange(new object[] {
            "-- Todas --",
            "DEBUG",
            "INFO",
            "WARN",
            "ERROR",
            "FATAL"});
            this.comboLevel.Location = new System.Drawing.Point(276, 38);
            this.comboLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(116, 25);
            this.comboLevel.TabIndex = 22;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(192, 37);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 25);
            this.label24.TabIndex = 23;
            this.label24.Text = "Level :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picSelected
            // 
            this.picSelected.BackColor = System.Drawing.Color.Cornsilk;
            this.picSelected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSelected.Image = ((System.Drawing.Image)(resources.GetObject("picSelected.Image")));
            this.picSelected.InitialImage = ((System.Drawing.Image)(resources.GetObject("picSelected.InitialImage")));
            this.picSelected.Location = new System.Drawing.Point(31, 39);
            this.picSelected.Name = "picSelected";
            this.picSelected.Size = new System.Drawing.Size(100, 100);
            this.picSelected.TabIndex = 20;
            this.picSelected.TabStop = false;
            // 
            // frmScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1457, 826);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanner.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripMenuFlotante.ResumeLayout(false);
            this.toolStripMenuFlotante.PerformLayout();
            this.panelStatusBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarCenterLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarCenterRigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarRigth)).EndInit();
            this.grpDigitalizacion.ResumeLayout(false);
            this.panelDocs.ResumeLayout(false);
            this.panelBotonera.ResumeLayout(false);
            this.grpProgressBar.ResumeLayout(false);
            this.grpProgressBar.PerformLayout();
            this.panelImages.ResumeLayout(false);
            this.grpViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFViewer)).EndInit();
            this.grpBotonerTIFF.ResumeLayout(false);
            this.grpConfigSender.ResumeLayout(false);
            this.grpConfigSenderInterno.ResumeLayout(false);
            this.grpConfigSenderInterno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSizeToSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.grpLog.ResumeLayout(false);
            this.grpLogInterno.ResumeLayout(false);
            this.grpLogBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.grpLogFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListGral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpDigitalizacion;
        private System.Windows.Forms.Panel panelStatusBar;
        private System.Windows.Forms.StatusBar statusBarDigit;
        private System.Windows.Forms.StatusBarPanel statusBarLeft;
        private System.Windows.Forms.StatusBarPanel statusBarCenterLeft;
        private System.Windows.Forms.StatusBarPanel statusBarCenterRigth;
        private System.Windows.Forms.Panel panelDocs;
        private System.Windows.Forms.TreeView treeViewDocs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBotonera;
        private System.Windows.Forms.ProgressBar pbDigit;
        private System.Windows.Forms.Button btnDigitAuto;
        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.ToolStrip toolStripMenuFlotante;
        private System.Windows.Forms.StatusBarPanel statusBarRigth;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpViewer;
        private System.Windows.Forms.PictureBox picSelected;
        //private AxAcroPDFLib.AxAcroPDF axAcroPDFViewer;
        private System.Windows.Forms.GroupBox grpBotonerTIFF;
        private System.Windows.Forms.Label labTIFFMultipagina;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimera;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUltima;
 //       private QAlbum.ScalablePictureBox scalablePicSelected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mfBtnAyuda;
        private System.Windows.Forms.ToolStripButton mfBtnEliminar;
        private System.Windows.Forms.ToolStripButton mfBtnEliminarTodo;
        private System.Windows.Forms.ToolStripButton mfBtnBuscar;
        private System.Windows.Forms.ToolStripButton mfBtnRenombrar;
        private System.Windows.Forms.ToolStripButton mfBtnMoveToReconocido;
        private System.Windows.Forms.ToolStripButton mfBtnMoveToNoReconocido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mfBtnRefresh;
        private System.Windows.Forms.GroupBox grpConfigDigitalizador;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox grpProgressBar;
        private System.Windows.Forms.Label labAccion;
        private System.Windows.Forms.GroupBox grpConfigSenderInterno;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnOpenPathLogSender;
        private System.Windows.Forms.TextBox txtStrPathLogSender;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Button btnGrabarParamSender;
        private System.Windows.Forms.GroupBox grpConfigSender;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.GroupBox grpLogInterno;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.GroupBox grpLogFilter;
        private System.Windows.Forms.Button btnLogBuscar;
        private System.Windows.Forms.GroupBox grpLogBody;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button btnLogTodos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTimeotWS;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown nUDSizeToSend;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox ckkUsaDuplex;
        private System.Windows.Forms.CheckBox chkDetectBlankPage;
        private QAlbum.ScalablePictureBox scalablePicSelected;
        private AxAcroPDFLib.AxAcroPDF axAcroPDFViewer;
       
        //private QAlbum.ScalablePictureBox scalablePicSelected;


    }
}

