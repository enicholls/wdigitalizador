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
using log4net;

namespace WConsultas.mantenedores
{
    public partial class FormTipoDocXSubDepto : Form
    {


        private static readonly ILog log = LogManager.GetLogger(typeof(FormTipoDocXSubDepto));


        public FormTipoDocXSubDepto()
        {
            InitializeComponent();
            log.Info("Se llena combo nivel 0");
            fillComboNivel0();
            log.Info("Se llena combo nivel I");
            triggerComboNivel0Selected();
            log.Info("");
            fillComboBoxTipoDoc();


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
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);
            }

            cBoxClaseI.SelectedIndex = 1;

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
        
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);
            }

            if (cBoxClaseI.Items.Count > 0) cBoxClaseI.SelectedIndex = 0;

        }

        private void triggerComboNivel0Selected()
        {
            ComboBox cBoxNivel0 = comboBoxNivel0;


            UnidadOrganizacional uo = (UnidadOrganizacional)cBoxNivel0.SelectedItem;

            if (uo != null)
            {
                fillComboNivel1(uo.Id);
                triggerComboNivelISelected();
            }
            else { 
            
                
            }



        }


        private void triggerComboNivelISelected()
        {
            ComboBox cBoxNivelI = comboBoxNivelI;

            UnidadOrganizacional uo = (UnidadOrganizacional)cBoxNivelI.SelectedItem;

            if (uo != null)
            {
                //fillComboTipoDoc(uo.Id);
                fillListBoxTipoDoc(uo.Id);
            }
            else {

                listBoxTipoDoc.Items.Clear();            
            }

            fillComboBoxTipoDoc();
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

        List<Int32> lstIdTipoDocxUO = new List<Int32>();
        private void fillListBoxTipoDoc(int idPadre)
        {
            listBoxTipoDoc.Items.Clear();
            listBoxTipoDoc.DisplayMember = "Nombre";
            listBoxTipoDoc.ValueMember = "Id";


            PGEntityManager em = PGEntityManager.getInstance();
            TipoDocumentoNivel tuo = new TipoDocumentoNivel();
            tuo.Id_uo = idPadre;

            List<Entidad> lstVdxUO = (List<Entidad>)em.getListHijosTDxId(tuo);

            //TipoDocumentoNivel tdn = new TipoDocumentoNivel();

            //tdn.Id = -1;
            //tdn.Nombre = "Seleccionar";

            //listBoxTipoDoc.Items.Add((TipoDocumentoNivel)tdn);

            lstIdTipoDocxUO.Clear();
            foreach (Entidad vdVar in lstVdxUO)
            {
                listBoxTipoDoc.Items.Add((TipoDocumentoNivel)vdVar);
                lstIdTipoDocxUO.Add(((TipoDocumentoNivel)vdVar).Id_tipodoc);

            }

            //if (listBoxTipoDoc.Items.Count > 1)
            //    listBoxTipoDoc.SelectedIndex = 1;
            //else
            //    listBoxTipoDoc.SelectedIndex = 0;

        }





        private void FormTipoDocXSubDepto_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxNivel0_SelectedIndexChanged(object sender, EventArgs e)
        {
            triggerComboNivel0Selected();

        }

        private void comboBoxNivelI_SelectedIndexChanged(object sender, EventArgs e)
        {
            triggerComboNivelISelected();

        }

        private void fillComboBoxTipoDoc()
        {
            PGEntityManager em = PGEntityManager.getInstance();
            ValorDominio vd = new ValorDominio();
            vd.Id_dominio = 2;
            List<Entidad> lstVd = (List<Entidad>)em.getList(vd);


            comboBoxTipoDoc.Items.Clear();
            comboBoxTipoDoc.DisplayMember = "Valor";


            foreach (Entidad vdVar in lstVd)
            {
                if (lstIdTipoDocxUO.Contains( Convert.ToInt32( ((ValorDominio)vdVar).Id)) != true)
                    comboBoxTipoDoc.Items.Add((ValorDominio)vdVar);
            }

            if (comboBoxTipoDoc.Items.Count > 0) comboBoxTipoDoc.SelectedIndex = 0;


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            ValorDominio vd = (ValorDominio)comboBoxTipoDoc.SelectedItem;
            UnidadOrganizacional uo = (UnidadOrganizacional)comboBoxNivelI.SelectedItem;
            TipoDocumentoNivel tdn = new TipoDocumentoNivel();

            tdn.Id_tipodoc = vd.Id;
            tdn.Id_uo = uo.Id;
            tdn.Nombre = vd.Valor;

            PGEntityManager em = PGEntityManager.getInstance();
            em.save(tdn);

            triggerComboNivelISelected();
        }



    }
}
