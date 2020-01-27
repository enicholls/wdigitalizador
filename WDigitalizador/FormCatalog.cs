using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AxAcroPDFLib;
using WCatalogador.storage;
using CatalogoDBLib.db;
using CatalogoDBLib.dbmanager;
using log4net;
using WConsultas;

namespace WCatalogador
{
    public partial class FormCatalog : Form
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(FormCatalog));

        IStorageManager ism;

        public FormCatalog()
        {
            InitializeComponent();
            log.Info("Se llena lista de archivos");
            fillFileList();
            log.Info("Se llena combo Clase i");
            this.WindowState = FormWindowState.Maximized;
            fillComboClaseI();
            log.Info("Se llena combo nivel 0");
            fillComboNivel0();
            log.Info("Se llena combo nivel I");
            triggerComboNivel0Selected();
            log.Info("");

            ism = StorageManagerFactory.getStorageManager("");


        }

        private void triggerComboNivel0Selected()
        {
            ComboBox cBoxNivel0 = (ComboBox)splitContainer1.Panel2.Controls["comboBoxNivel0"];


            UnidadOrganizacional uo = (UnidadOrganizacional) cBoxNivel0.SelectedItem;

            if (uo != null) { 
                fillComboNivel1(uo.Id);

                triggerComboNivelISelected();
            }



        }


        private void triggerComboNivelISelected()
        {
            ComboBox cBoxNivelI = (ComboBox)splitContainer1.Panel2.Controls["comboBoxNivelI"];

            UnidadOrganizacional uo = (UnidadOrganizacional)cBoxNivelI.SelectedItem;

            if (uo != null) { fillComboTipoDoc(uo.Id); }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox lbFiles = (ListBox)splitContainer1.Panel2.Controls["listBoxFilesToClass"];

            int i = lbFiles.SelectedIndex;

            if (i >= 0) {

                lbFiles.ClearSelected();
                if (i == (lbFiles.Items.Count - 1))
                {
                    lbFiles.SelectedIndex = 0;
                }
                else
                {
                    lbFiles.SelectedIndex = ++i;

                }
            }


                 

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            try { 
            

                if (!validar())
                {
                    MessageBox.Show("Debe tener al menos Tipo o Número o Referencia. \n Verifique si escogió archivo.");
                    return;
                }


                ListBox lbFiles = (ListBox)splitContainer1.Panel2.Controls["listBoxFilesToClass"];
                string curItem = lbFiles.SelectedItem.ToString();
                string filename = Program.g_Config._PathArcClasificar + "\\" + curItem;
                string stoId = ism.save(filename);

                ComboBox cBoxTipoDoc    = (ComboBox)splitContainer1.Panel2.Controls["comboBoxTipoDoc"];
                Documento doc           = new Documento();
                TextBox txtBoxNro        = (TextBox)splitContainer1.Panel2.Controls["textBoxNro"];

                if (cBoxTipoDoc.SelectedItem != null && (((TipoDocumentoNivel)cBoxTipoDoc.SelectedItem).Id != -1)) doc.Id_tipo = Convert.ToInt32(((TipoDocumentoNivel)cBoxTipoDoc.SelectedItem).Id_tipodoc);
                doc.Stoid               = stoId;
                doc.Fecha               = dateTimePickerDoc.Value;
                doc.Codigobarra         = curItem;
                doc.Nro                 = txtBoxNro.Text;
                doc.Desechado           = (short)(checkBoxDesechado.Checked == true ? 1 : 0);
                doc.Estado              = 0;

                PGEntityManager em = PGEntityManager.getInstance();

                em.save(doc);


                ComboBox cBoxClaseI = (ComboBox)splitContainer1.Panel2.Controls["comboBoxClaseI"];

                if (cBoxClaseI.SelectedItem != null)
                {
                    DocumentoClase docClase = new DocumentoClase();
                    docClase.Id_dominio     = ((ValorDominio)cBoxClaseI.SelectedItem).Id_dominio;
                    docClase.Valor          = ((ValorDominio)cBoxClaseI.SelectedItem).Valor;
                    docClase.Id_doc         = em.getLastIdForDocument();
                    em.save(docClase);
                }


                if (textBoxReferencia.Text != String.Empty)
                {
                    DocumentoClase docClase = new DocumentoClase();
                    docClase.Id_dominio = 0;
                    docClase.Valor = textBoxReferencia.Text;
                    docClase.Id_doc = em.getLastIdForDocument();
                    em.save(docClase);
                }

            
                ComboBox cBoxNivelI = (ComboBox)splitContainer1.Panel2.Controls["comboBoxNivelI"];

                if (cBoxNivelI.SelectedItem != null)
                {
                    DocumentoUnidad docUnidad = new DocumentoUnidad();
                    docUnidad.Id_uo = ((UnidadOrganizacional)cBoxNivelI.SelectedItem).Id;
                    docUnidad.Nombre = ((UnidadOrganizacional)cBoxNivelI.SelectedItem).Nombre;
                    docUnidad.Id_doc = em.getLastIdForDocument();
                    em.save(docUnidad);
                }

            
                lbFiles.Items.Remove(curItem);
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
                log.Error(ex.StackTrace);

            }
        }


        private Boolean validar()
        {
            Boolean bres = false;

            ListBox lbFiles = (ListBox)splitContainer1.Panel2.Controls["listBoxFilesToClass"];
            String tipoDoc = String.Empty;
            String nroDoc = textBoxNro.Text;
            String refDoc  = textBoxReferencia.Text; 

            ComboBox cBoxTipoDoc = (ComboBox)splitContainer1.Panel2.Controls["comboBoxTipoDoc"];

            if (cBoxTipoDoc.SelectedItem != null && (((TipoDocumentoNivel)cBoxTipoDoc.SelectedItem).Id != -1))
            {
                TipoDocumentoNivel tdn = new TipoDocumentoNivel();
                tdn.Id_tipodoc = ((TipoDocumentoNivel)cBoxTipoDoc.SelectedItem).Id_tipodoc;
                tipoDoc = tdn.Id_tipodoc.ToString();

            }

            bres = (tipoDoc == String.Empty) && (nroDoc == String.Empty) && (refDoc == String.Empty);

            bres = !bres; 
            bres = bres    &&    (lbFiles.SelectedItem != null);

            return bres;

        }


        private void fillFileList() {

            try {

                DirectoryInfo DirTNReconocidos = new DirectoryInfo(Program.g_Config._PathArcClasificar);


                //Obtener documentos en carpeta  

                foreach (FileInfo file in DirTNReconocidos.GetFiles())
                {
                    ListBox lbFiles = (ListBox)splitContainer1.Panel2.Controls["listBoxFilesToClass"];
                    lbFiles.Items.Add(file.Name);
                }
            }
            catch(Exception ex){

                log.Error(ex.Message);
                log.Error(ex.StackTrace);
            
            }

        
        }

        private void listBoxFilesToClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListBox lbFiles = (ListBox)splitContainer1.Panel2.Controls["listBoxFilesToClass"];

            if (lbFiles.SelectedItem != null)
            {
                string curItem = lbFiles.SelectedItem.ToString();


                string extension = Path.GetExtension(curItem);

                if (extension.ToUpper().CompareTo(".PDF") == 0)
                {
                    labelActual.Visible = false;
                    labelNro.Visible    = false;
                    lblCurrPage.Visible = false;
                    lblNumPages.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;

                    AxAcroPDF ax = (AxAcroPDF)splitContainer1.Panel1.Controls["AxAcroPDF1"];
                    ax.BringToFront();
                    ax.LoadFile(Program.g_Config._PathArcClasificar + "\\" + curItem);
                }
                else if (extension.ToUpper().CompareTo(".TIF") == 0)
                {

                    labelActual.Visible = true;
                    labelNro.Visible    = true;
                    lblCurrPage.Visible = true;
                    lblNumPages.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    curFilename = Program.g_Config._PathArcClasificar + "\\" + curItem;
                    intCurrPage = 0;
                    RefreshImage();
                }
            }
        }


        String curFilename;
        private void fillComboClaseI()
        {
            PGEntityManager em = PGEntityManager.getInstance();
            ValorDominio vd        = new ValorDominio();
            vd.Id_dominio = 1;
            List<Entidad> lstVd = (List < Entidad >) em.getList(vd);
            ComboBox cBoxClaseI    = (ComboBox)splitContainer1.Panel2.Controls["comboBoxClaseI"];

            cBoxClaseI.DisplayMember = "Valor";
            cBoxClaseI.ValueMember = "Id";
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((ValorDominio)vdVar);
            }


        }


        private void fillComboTipoDoc()
        {
            PGEntityManager em = PGEntityManager.getInstance();
            ValorDominio vd = new ValorDominio();
            vd.Id_dominio = 2;
            List<Entidad> lstVd = (List<Entidad>)em.getList(vd);
            ComboBox cBoxClaseI = (ComboBox)splitContainer1.Panel2.Controls["comboBoxTipoDoc"];

            cBoxClaseI.DisplayMember = "Valor";
            cBoxClaseI.ValueMember = "Id";
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((ValorDominio)vdVar);
            }


        }


        private void fillComboNivel0()
        {
            PGEntityManager em      = PGEntityManager.getInstance();
            UnidadOrganizacional uo = new UnidadOrganizacional();
            uo.Nivel                = 0;

            List<Entidad> lstVd = (List<Entidad>)em.getListxNivel(uo);
            ComboBox cBoxClaseI = (ComboBox)splitContainer1.Panel2.Controls["comboBoxNivel0"];


            cBoxClaseI.Items.Clear();
            cBoxClaseI.DisplayMember = "Nombre";
            cBoxClaseI.ValueMember = "Id";
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);
            }

            if (cBoxClaseI.Items.Count >0) cBoxClaseI.SelectedIndex=0;

        }

        private void fillComboNivel1(int idPadre)
        {
            PGEntityManager em = PGEntityManager.getInstance();
            UnidadOrganizacional uo = new UnidadOrganizacional();
            uo.IdPadre = idPadre;

            List<Entidad> lstVd = (List<Entidad>)em.getListHijosxId(uo);
            ComboBox cBoxClaseI = (ComboBox)splitContainer1.Panel2.Controls["comboBoxNivelI"];

            cBoxClaseI.Items.Clear();
            cBoxClaseI.DisplayMember = "Nombre";
            cBoxClaseI.ValueMember = "Id";
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);
            }

            if (cBoxClaseI.Items.Count > 0)
            cBoxClaseI.SelectedIndex = 0;

        }

        private void fillComboTipoDoc(int idPadre)
        {

            ComboBox cBoxClaseTipoDoc = (ComboBox)splitContainer1.Panel2.Controls["comboBoxTipoDoc"];

            cBoxClaseTipoDoc.Items.Clear();
            cBoxClaseTipoDoc.DisplayMember  = "Nombre";
            cBoxClaseTipoDoc.ValueMember    = "Id";

            
            PGEntityManager em = PGEntityManager.getInstance();
            TipoDocumentoNivel tuo = new TipoDocumentoNivel();
            tuo.Id_uo = idPadre;

            List<Entidad> lstVd = (List<Entidad>)em.getListHijosTDxId(tuo);

            TipoDocumentoNivel tdn = new TipoDocumentoNivel();

            tdn.Id = -1;
            tdn.Nombre = "Seleccionar";
            cBoxClaseTipoDoc.Items.Add((TipoDocumentoNivel)tdn);
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseTipoDoc.Items.Add((TipoDocumentoNivel)vdVar);
            }

            if (cBoxClaseTipoDoc.Items.Count > 1)
                cBoxClaseTipoDoc.SelectedIndex = 1;
            else
                cBoxClaseTipoDoc.SelectedIndex = 0;

        }
       

        private int intCurrPage = 0; // defining the current page (its some sort of a counter)
        bool opened = false; // if an image was opened


        public void RefreshImage()
        {

            RefreshImage(curFilename);
        }


        public void RefreshImage(String filename)
        {
            Image myImg; // setting the selected tiff
            Image myBmp; // a new occurance of Image for viewing

            opened = true;
            myImg = System.Drawing.Image.FromFile(filename); // setting the image from a file

            int intPages = myImg.GetFrameCount(System.Drawing.Imaging.FrameDimension.Page); // getting the number of pages of this tiff
            intPages--; // the first page is 0 so we must correct the number of pages to -1

            Panel panelBoton = (Panel)splitContainer1.Panel1.Controls["panelConfig"];
            Label lblNumPages = (Label)panelBoton.Controls["lblNumPages"];
            Label lblCurrPage = (Label)panelBoton.Controls["lblCurrPage"];

            lblNumPages.Text = Convert.ToString(intPages); // showing the number of pages
            lblCurrPage.Text = Convert.ToString(intCurrPage); // showing the number of page on which we're on

            myImg.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Page, intCurrPage); // going to the selected page

            myBmp = new Bitmap(myImg, pictureBox1.Width, pictureBox1.Height); // setting the new page as an image
            // Description on Bitmap(SOURCE, X,Y)

            pictureBox1.Image = myBmp; // showing the page in the pictureBox1

            panelBoton.BringToFront();
            pictureBox1.BringToFront();

            myImg.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (opened) // the button works if the file is opened. you could go with button.enabled
            {
                if (intCurrPage == Convert.ToInt32(lblNumPages.Text)) // if you have reached the last page it ends here
                // the "-1" should be there for normalizing the number of pages
                { intCurrPage = Convert.ToInt32(lblNumPages.Text); }
                else
                {
                    intCurrPage++;
                    RefreshImage();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (opened) // the button works if the file is opened. you could go with button.enabled
            {
                if (intCurrPage == 0) // it stops here if you reached the bottom, the first page of the tiff
                { intCurrPage = 0; }
                else
                {
                    intCurrPage--; // if its not the first page, then go to the previous page
                    RefreshImage(); // refresh the image on the selected page
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConfig frmCfg = new FormConfig();
            frmCfg.ShowDialog();
        }

        private void comboBoxNivel0_SelectedIndexChanged(object sender, EventArgs e)
        {
            triggerComboNivel0Selected();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panelConfig_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxClaseI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxNivelI_SelectedIndexChanged(object sender, EventArgs e)
        {
            triggerComboNivelISelected();

        }

    
    }
}
