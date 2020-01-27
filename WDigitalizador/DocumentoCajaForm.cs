using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CatalogoDBLib.dbmanager;
using CatalogoDBLib.db;
using CatalogoDBLib;

namespace WConsultas
{
    public partial class DocumentoCajaForm : Form
    {


        static Entidad miEntidad;
        public Documento miDocumento;
        public DocumentoClsNivel miDcn;
        public DocumentoUnidad miDocumentoUnidad;
        public DocumentoClase miDocumentoClase;

        public DocumentoCajaForm(DocumentoClsNivel unDocumentoClsNivel)
        {
            InitializeComponent();
            miDocumento = unDocumentoClsNivel.MiDocumento;
            miDcn = unDocumentoClsNivel;
            getDocCls();
            fillForm();
            findUOPadre(miDcn.Ldn_id_uopadre);
            findUO(miDcn.Ldn_id_uo);
        }


        private void getDocCls()
        {
            PGEntityManager em = PGEntityManager.getInstance();
            miDocumentoClase = new DocumentoClase();
            miDocumentoClase.Id_doc = miDcn.MiDocumento.Id;
            em.getRecord(miDocumentoClase);



        }


        private void fillForm()
        {

            textBoxNro.Text         = miDocumento.Nro;
            dateTimePickerDoc.Value = miDocumento.Fecha;
            textBoxReferencia.Text = miDocumentoClase.Valor;
            checkBoxDesechado.Checked = miDocumento.Desechado == 1 ? true : false;
            fillComboNivel0();
            //fillComboTipoDoc();
            triggerComboNivel0Selected();
        
        }

        int findUOPadre(int idUO)
        {
            for (int i=0; i< comboBoxNivel0.Items.Count;i++ ){

                UnidadOrganizacional uo = (UnidadOrganizacional)comboBoxNivel0.Items[i];

                if (uo.Id == idUO)
                {
                    comboBoxNivel0.SelectedIndex = i;
                }
            }

            return 0;
        }

        int findUO(int idUO)
        {
            for (int i = 0; i < comboBoxNivelI.Items.Count; i++)
            {

                UnidadOrganizacional uo = (UnidadOrganizacional)comboBoxNivelI.Items[i];

                if (uo.Id == idUO)
                {
                    comboBoxNivelI.SelectedIndex = i;
                }
            }

            return 0;
        }


        int findReferencia()
        {

            return 0;
        }


        private void fillComboNivel0()
        {
            PGEntityManager em = PGEntityManager.getInstance();
            UnidadOrganizacional uo = new UnidadOrganizacional();
            uo.Nivel = 0;

            List<Entidad> lstVd = (List<Entidad>)em.getListxNivel(uo);
            ComboBox cBoxClaseI = comboBoxNivel0;


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



        private void EntityForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            //if (!validar())
            //{
            //    MessageBox.Show("Debe tener al menos Tipo o Número o Referencia. \n Verifique si escogió archivo.");
            //    return;
            //}


            //string curItem = lbFiles.SelectedItem.ToString();
            //string filename = Program.g_Config._PathTmpLocal + "\\" + curItem;
            //string stoId = ism.save(filename);

            ComboBox cBoxTipoDoc = (ComboBox)comboBoxTipoDoc;
            Documento doc = new Documento();
            TextBox txtBoxNro = (TextBox)textBoxNro;

            if (cBoxTipoDoc.SelectedItem != null && (((TipoDocumentoNivel)cBoxTipoDoc.SelectedItem).Id != -1)) doc.Id_tipo = Convert.ToInt32(((TipoDocumentoNivel)cBoxTipoDoc.SelectedItem).Id_tipodoc);
            doc.Stoid = miDocumento.Stoid;
            doc.Fecha = dateTimePickerDoc.Value;
            doc.Codigobarra = miDocumento.Codigobarra;
            doc.Nro = txtBoxNro.Text;
            doc.Estado = 0;
            doc.Desechado = (short)(checkBoxDesechado.Checked == true ? 1 : 0);


            PGEntityManager em = PGEntityManager.getInstance();
            doc.Id = miDocumento.Id;
            em.update(doc);


            //ComboBox cBoxClaseI = (ComboBox)comboBoxClaseI;

            //if (cBoxClaseI.SelectedItem != null)
            //{
            //    DocumentoClase docClase = new DocumentoClase();
            //    docClase.Id_dominio = ((ValorDominio)cBoxClaseI.SelectedItem).Id_dominio;
            //    docClase.Valor = ((ValorDominio)cBoxClaseI.SelectedItem).Valor;
            //    docClase.Id_doc = em.getLastIdForDocument();
            //    em.save(docClase);
            //}


            if (textBoxReferencia.Text != String.Empty && miDocumentoClase.Id !=0)
            {
                DocumentoClase docClase = new DocumentoClase();
                docClase.Id_dominio = 0;
                docClase.Valor = textBoxReferencia.Text;
                docClase.Id_doc = miDocumento.Id;
                em.update(docClase);
            }

            if (textBoxReferencia.Text != String.Empty && miDocumentoClase.Id == 0)
            {
                DocumentoClase docClase = new DocumentoClase();
                docClase.Id_dominio = 0;
                docClase.Valor = textBoxReferencia.Text;
                docClase.Id_doc = miDocumento.Id;
                em.save(docClase);
            }


            ComboBox cBoxNivelI = (ComboBox)comboBoxNivelI;

            if (cBoxNivelI.SelectedItem != null)
            {
                DocumentoUnidad docUnidad = new DocumentoUnidad();
                docUnidad.Id_uo = ((UnidadOrganizacional)cBoxNivelI.SelectedItem).Id;
                docUnidad.Nombre = ((UnidadOrganizacional)cBoxNivelI.SelectedItem).Nombre;
                docUnidad.Id_doc = miDocumento.Id;
                em.update(docUnidad);
            }

            this.DialogResult = DialogResult.OK;
            this.Close(); 



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void triggerComboNivel0Selected()
        {
            ComboBox cBoxNivel0 = comboBoxNivel0;


            UnidadOrganizacional uo = (UnidadOrganizacional)cBoxNivel0.SelectedItem;

            if (uo != null) { fillComboNivel1(uo.Id); }
        }


        private void fillComboNivel1(int idPadre)
        {
            PGEntityManager em = PGEntityManager.getInstance();
            UnidadOrganizacional uo = new UnidadOrganizacional();
            uo.IdPadre = idPadre;

            List<Entidad> lstVd = (List<Entidad>)em.getListHijosxId(uo);
            ComboBox cBoxClaseI = comboBoxNivelI;

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

        private void comboBoxNivel0_SelectedIndexChanged(object sender, EventArgs e)
        {
            triggerComboNivel0Selected();

        }

        private void fillComboTipoDoc()
        {
            PGEntityManager.sConnStr = Program.g_Config._BaseDeDatosCon;

            PGEntityManager em = PGEntityManager.getInstance();
            ValorDominio vd = new ValorDominio();
            vd.Id_dominio = Program.g_Config._DomTipoDoc;
            List<Entidad> lstVd = (List<Entidad>)em.getList(vd);
            ComboBox cBoxClaseI = comboBoxTipoDoc;

            cBoxClaseI.DisplayMember = "Valor";
            cBoxClaseI.ValueMember = "Id";
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((ValorDominio)vdVar);
            }


        }

        private void comboBoxNivelI_SelectedIndexChanged(object sender, EventArgs e)
        {
            triggerComboNivelISelected();

        }


        private void fillComboTipoDoc(int idPadre)
        {

            ComboBox cBoxClaseTipoDoc = comboBoxTipoDoc;

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


        private void fillComboCajas(int idUoPadre,int idUo, int idTipoDoc)
        {

            ComboBox cBoxCajas = comboBoxCajas;

            cBoxCajas.Items.Clear();
            cBoxCajas.DisplayMember = "Nombre";
            cBoxCajas.ValueMember = "Id";


            PGEntityManager em = PGEntityManager.getInstance();
            //TipoDocumentoNivel tuo = new TipoDocumentoNivel();
            //= idPadre;

            //List<Entidad> lstVd = (List<Entidad>)em.getListHijosTDxId(tuo);

            //TipoDocumentoNivel tdn = new TipoDocumentoNivel();

            //tdn.Id = -1;
            //tdn.Nombre = "Seleccionar";
            //cBoxCajas.Items.Add((TipoDocumentoNivel)tdn);
            //foreach (Entidad vdVar in lstVd)
            //{
            //    cBoxCajas.Items.Add((TipoDocumentoNivel)vdVar);
            //}

            //if (cBoxCajas.Items.Count > 1)
            //    cBoxCajas.SelectedIndex = 1;
            //else
            //    cBoxCajas.SelectedIndex = 0;

        }


        private void triggerComboNivelISelected()
        {
            ComboBox cBoxNivelI = comboBoxNivelI;

            UnidadOrganizacional uo = (UnidadOrganizacional)cBoxNivelI.SelectedItem;

            if (uo != null) { fillComboTipoDoc(uo.Id); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
