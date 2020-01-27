using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CatalogoDBLib.db;
using CatalogoDBLib.dbmanager;

using System.IO;
using AxAcroPDFLib;
using CatalogoDBLib;
using WCatalogador;
using Digitalizador.gui;
using WConsultas.mantenedores;

using WConsultas.identity;

using log4net;

namespace WConsultas
{
    public partial class QueryForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(QueryForm));
        public QueryForm()
        {
            InitializeComponent();

            SetAutorizacion();

            this.WindowState = FormWindowState.Maximized;

            this.SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
            //listBoxQryDocRS.DoubleClick +=new EventHandler(listBoxQryDocRS_DoubleClick);
 
            fillComboNivel0();
            fillComboTipoDoc();
            triggerComboNivel0Selected();
            dateTimePickerIni.Value = DateTime.Now.AddDays(-30);
        }

        private void SetAutorizacion()
        {

            configurarToolStripMenuItem.Visible = AutorizacionAdmin.check(enumPermisos.permiso.configurar, Program.usuarioConectado) || AutorizacionAdmin.check(enumPermisos.permiso.escanear, Program.usuarioConectado);
            catalogarToolStripMenuItem.Visible = AutorizacionAdmin.check(enumPermisos.permiso.catalogar, Program.usuarioConectado);
            archivoToolStripMenuItem.Visible = AutorizacionAdmin.check(enumPermisos.permiso.escanear, Program.usuarioConectado);

            if (AutorizacionAdmin.check(enumPermisos.permiso.escanear, Program.usuarioConectado) && !AutorizacionAdmin.check(enumPermisos.permiso.configurar, Program.usuarioConectado))
            {
                departamentosToolStripMenuItem.Enabled = false;
                subDepartamentosToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
                tiposDeDocumentosPorUnidadToolStripMenuItem.Enabled = false;
                tiposDeDocumentosToolStripMenuItem.Enabled = false;
            }



        }

        private void QueryForm_Load(object sender, EventArgs e)
        {

        }


        //private void fillQryLst(int tipoDoc,int idDominio,String valor)
        //{


        //    IList<Documento> lstDocumentos = Documento.getListSelected(tipoDoc, idDominio, valor);
        //    ListBox lbQryDocLst = (ListBox)panelQry.Controls["listBoxQryDocRS"];

        //    lbQryDocLst.DataSource = null;
        //    lbQryDocLst.Items.Clear();
        //    lbQryDocLst.DataSource      = lstDocumentos;
        //    lbQryDocLst.DisplayMember   = "Stoid";

        //}

        private void fillComboTipoDoc()
        {
            PGEntityManager em  = PGEntityManager.getInstance();
            ValorDominio vd     = new ValorDominio();
            vd.Id_dominio       = Program.g_Config._DomTipoDoc;
            List<Entidad> lstVd = (List<Entidad>)em.getList(vd);
            ComboBox cBoxClaseI = (ComboBox)panelQry.Controls["comboBoxTipoDoc"];

            cBoxClaseI.DisplayMember = "Valor";
            cBoxClaseI.ValueMember = "Id";
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((ValorDominio)vdVar);
            }


        }

        public IList<Documento> lstDocumentos; 

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            int tipoDoc         = -1;
            String nroDoc       = "";
            String referencia = "";

            ComboBox cBoxTipoDoc = (ComboBox)panelQry.Controls["comboBoxTipoDoc"];
            ComboBox cBoxNivel0  = (ComboBox)panelQry.Controls["comboBoxNivel0"];
            ComboBox cBoxNivelI  = (ComboBox)panelQry.Controls["comboBoxNivelI"];

            DateTime dtIni = dateTimePickerIni.Value;
            DateTime dtFin = dateTimePickerFin.Value;


            if (textBoxNro.Text != String.Empty)
            {
                nroDoc = textBoxNro.Text;
            }


            if (textBoxRef.Text != String.Empty)
            {
                referencia = "%" + textBoxRef.Text.ToUpper() + "%";
            }


            if ((cBoxTipoDoc.SelectedItem != null) && (((TipoDocumentoNivel)cBoxTipoDoc.SelectedItem).Id != -1))
            {

                tipoDoc = Convert.ToInt32(((TipoDocumentoNivel)cBoxTipoDoc.SelectedItem).Id_tipodoc);
            }

            UnidadOrganizacional uoPadre;
            UnidadOrganizacional uoHijo;


            uoPadre = (UnidadOrganizacional) cBoxNivel0.SelectedItem;
            uoHijo  = (UnidadOrganizacional) cBoxNivelI.SelectedItem;
//            fillQryLst(tipoDoc, idDominio, valor);

            short desechado =  (short) (checkBoxDesechado.Checked == true ?1:0);
            short estado    = -1;

            fillQryLst(tipoDoc, nroDoc, dtIni,dtFin,uoPadre.Id,uoHijo.Id,referencia,desechado,estado);


            labelCount.Text = "Se recuperaron " + listBoxQryDocRS.Items.Count.ToString() + " registros."; 
   
        }

        private void fillQryLst(int tipoDoc, String nroDoc, DateTime dtIni, DateTime dtFin, int idUoPadre, int idUoHijo, String referencia,short desechado,short estado)
        {
            IList<DocumentoClsNivel> lstDocumentos = Documento.getListSelected(tipoDoc, nroDoc, dtIni, dtFin, idUoPadre, idUoHijo, referencia,desechado,estado);
            ListBox lbQryDocLst = (ListBox)panelQry.Controls["listBoxQryDocRS"];

            lbQryDocLst.DataSource = null;
            lbQryDocLst.Items.Clear();
            lbQryDocLst.DataSource = lstDocumentos;
            lbQryDocLst.DisplayMember = "StoId";
        }

        String curFilename;


        public void RefreshImage()
        {

            RefreshImage(curFilename);
        }



        private int intCurrPage = 0; // defining the current page (its some sort of a counter)
        bool opened = false; // if an image was opened

        public void RefreshImage(String filename)
        {
            Image myImg; // setting the selected tiff
            Image myBmp; // a new occurance of Image for viewing

            opened = true;
            try
            {


                myImg = System.Drawing.Image.FromFile(filename); // setting the image from a file
                int intPages = myImg.GetFrameCount(System.Drawing.Imaging.FrameDimension.Page); // getting the number of pages of this tiff
                intPages--; // the first page is 0 so we must correct the number of pages to -1

                Panel panelBoton = (Panel)panelQry.Controls["panelConfig"];
                Label lblNumPages = (Label)panelQry.Controls["lblNumPages"];
                Label lblCurrPage = (Label)panelQry.Controls["lblCurrPage"];

                lblNumPages.Text = Convert.ToString(intPages); // showing the number of pages
                lblCurrPage.Text = Convert.ToString(intCurrPage); // showing the number of page on which we're on

                lblNumPages.Visible = true;
                lblCurrPage.Visible = true;

                label4.Visible = true;
                label6.Visible = true;

                button2.Visible = true;
                button3.Visible = true;

                myImg.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Page, intCurrPage); // going to the selected page

                myBmp = new Bitmap(myImg, pictureBoxSelectedDoc.Width, pictureBoxSelectedDoc.Height); // setting the new page as an image
                // Description on Bitmap(SOURCE, X,Y)
                
                pictureBoxSelectedDoc.Image = myBmp; // showing the page in the pictureBox1

                pictureBoxSelectedDoc.BringToFront();

                myImg.Dispose();

                

            }
            catch (Exception ex) {

                MessageBox.Show("No se puede ver el archivo: " + filename);
                log.Error("No se puede ver el archivo: "+filename);
                log.Error(ex.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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


        private void button3_Click_1(object sender, EventArgs e)
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

        private void listBoxQryDocRS_DoubleClick(object sender, System.EventArgs e)
        {
            // Get the name of the file to open from the ListBox.
            
        }

        private void listBoxQryDocRS_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lbFiles = (ListBox)panelQry.Controls["listBoxQryDocRS"];

            if (lbFiles.SelectedItem != null)
            {
                string curItem = ((DocumentoClsNivel)lbFiles.SelectedItem).MiDocumento.Stoid;
                string extension = Path.GetExtension(curItem);


                bool autorizado = Program.usuarioConectado.CheckPermiso((DocumentoClsNivel)lbFiles.SelectedItem);

                if (autorizado == false)
                {

                    MessageBox.Show("No está autorizado para revisar el documento.", "Atencion", MessageBoxButtons.OK);
                    return;
                }


                if (File.Exists(curItem) == false) {

                    MessageBox.Show("Archivo no existe.", "Atención.", MessageBoxButtons.OK);

                    return;
                }

                if (extension.ToUpper().CompareTo(".PDF") == 0)
                {
                    AxAcroPDF ax = (AxAcroPDF)panelQry.Controls["axAcroPDFDocSelected"];
                    ax.BringToFront();
                    ax.LoadFile(curItem);

                    lblNumPages.Visible = false;
                    lblCurrPage.Visible = false;

                    label4.Visible = false;
                    label6.Visible = false;

                    button2.Visible = false;
                    button3.Visible = false;

                }
                else if (extension.ToUpper().CompareTo(".TIF") == 0)
                {
                    AxAcroPDF ax = (AxAcroPDF)panelQry.Controls["axAcroPDFDocSelected"];
                    ax.SendToBack();
                    curFilename = curItem;
                    intCurrPage = 0;
                    RefreshImage();
                }
                else if (extension.ToUpper().CompareTo(".JPG") == 0)
                {
                    AxAcroPDF ax = (AxAcroPDF)panelQry.Controls["axAcroPDFDocSelected"];
                    ax.SendToBack();
                    curFilename = curItem;
                    intCurrPage = 0;
                    RefreshImage();
                }
            }

        }


        private void fillComboNivel0()
        {
            PGEntityManager em = PGEntityManager.getInstance();
            UnidadOrganizacional uo = new UnidadOrganizacional();
            uo.Nivel = 0;

            List<Entidad> lstVd = (List<Entidad>)em.getListxNivel(uo);
            ComboBox cBoxClaseI = (ComboBox)panelQry.Controls["comboBoxNivel0"];


            cBoxClaseI.Items.Clear();
            cBoxClaseI.DisplayMember = "Nombre";
            cBoxClaseI.ValueMember = "Id";

            UnidadOrganizacional uoaux = new UnidadOrganizacional();

            uoaux.Id = -1;
            uoaux.Nombre = "Seleccionar";

            cBoxClaseI.Items.Add(uoaux);

            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);
            }

            cBoxClaseI.SelectedIndex = 0;

        }

        private void fillComboNivel1(int idPadre)
        {
            PGEntityManager em = PGEntityManager.getInstance();
            UnidadOrganizacional uo = new UnidadOrganizacional();
            uo.IdPadre = idPadre;

            List<Entidad> lstVd = (List<Entidad>)em.getListHijosxId(uo);
            ComboBox cBoxClaseI = (ComboBox)panelQry.Controls["comboBoxNivelI"];

            cBoxClaseI.Items.Clear();
            cBoxClaseI.DisplayMember = "Nombre";
            cBoxClaseI.ValueMember = "Id";

            UnidadOrganizacional uoaux = new UnidadOrganizacional();

            uoaux.Id = -1;
            uoaux.Nombre = "Seleccionar";

            cBoxClaseI.Items.Add(uoaux);
            
            
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);
            }


            cBoxClaseI.SelectedIndex = 0;

        }

        private void triggerComboNivel0Selected()
        {
            ComboBox cBoxNivel0 = (ComboBox)panelQry.Controls["comboBoxNivel0"];


            UnidadOrganizacional uo = (UnidadOrganizacional)cBoxNivel0.SelectedItem;

            if (uo != null) { fillComboNivel1(uo.Id); }
        }

        private void comboBoxNivel0_SelectedIndexChanged(object sender, EventArgs e)
        {
            triggerComboNivel0Selected();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelQry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCfg_Click(object sender, EventArgs e){
            FormConfig frmCfg = new FormConfig();
            frmCfg.ShowDialog();
            frmCfg.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNro_TextChanged(object sender, EventArgs e)
        {

        }


        private void fillComboTipoDoc(int idPadre)
        {

            ComboBox cBoxClaseTipoDoc = (ComboBox)panelQry.Controls["comboBoxTipoDoc"];

            cBoxClaseTipoDoc.Items.Clear();
            cBoxClaseTipoDoc.DisplayMember = "Nombre";
            cBoxClaseTipoDoc.ValueMember = "Id";


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

        private void comboBoxNivelI_SelectedIndexChanged(object sender, EventArgs e)
        {
            triggerComboNivelISelected();

        }


        private void triggerComboNivelISelected()
        {
            ComboBox cBoxNivelI = (ComboBox)panelQry.Controls["comboBoxNivelI"];

            UnidadOrganizacional uo = (UnidadOrganizacional)cBoxNivelI.SelectedItem;

            if (uo != null) { fillComboTipoDoc(uo.Id); }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ListBox lbFiles = (ListBox)panelQry.Controls["listBoxQryDocRS"];

            if (lbFiles.SelectedItem != null)
            {
                string curItem = ((DocumentoClsNivel)lbFiles.SelectedItem).MiDocumento.Stoid;

                DocumentoClsNivel unDocumento = (DocumentoClsNivel)lbFiles.SelectedItem;

                Boolean autorizado = false;

                autorizado = Program.usuarioConectado.CheckPermiso(unDocumento);

                if (autorizado == false)
                {

                    MessageBox.Show("No está autorizado para revisar el documento.", "Atencion", MessageBoxButtons.OK);

                }
                else {
                    EntityForm ef = new EntityForm(unDocumento);

                    if (ef.ShowDialog(this) == DialogResult.OK)
                    {

                        this.buttonBuscar_Click(null, null);

                    }

                    ef.Dispose();
                
                
                }
            }

        }

        private void catalogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCatalog frmCatalog = new FormCatalog();

            frmCatalog.Show();
        }


        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScanner unfrmScanner = new frmScanner();

            unfrmScanner.Show();

        }

        private void configurarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConfig frmCfg = new FormConfig();
            frmCfg.ShowDialog();
            frmCfg.Dispose();

        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntityList frm = new FormEntityList();
            frm.Show();

        }

        private void subDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubEntityList frm = new FormSubEntityList();
            frm.Show();

        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoDocList frm = new FormTipoDocList();
            frm.Show();
        }

        private void tiposDeDocumentosPorUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoDocXSubDepto frm = new FormTipoDocXSubDepto();
            frm.Show();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserList frm = new FormUserList();
            frm.Show();
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCajaList frm = new FormCajaList();
            frm.Show();
 
        }

        private void pictureBoxSelectedDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
