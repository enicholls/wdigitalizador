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

namespace WConsultas.mantenedores
{
    public partial class FormCaja : Form
    {

        Caja _miCaja = null;

        public FormCaja(Caja caja)
        {
            InitializeComponent();
            _miCaja = caja;
            fillForm();
            //findUOPadre(miDcn.Ldn_id_uopadre);
            //findUO(miDcn.Ldn_id_uo);

        }

        public void fillForm() {


            fillComboNivel0();
            setNivel0Selected();
            //fillComboTipoDoc();
            //triggerComboNivel0Selected();
            if (_miCaja.Id != null)
            {

                textBoxDescripcion.Text = _miCaja.Descripcion;
                textBoxDesde.Text = _miCaja.Folio_inicial;
                textBoxHasta.Text = _miCaja.Folio_final;
                textBoxNro.Text = _miCaja.Nro;



                //textBoxNombre.Text = _miUO.Nombre;
                //textBoxPadre.Text = _miUO.IdPadre.ToString();
                //comboBoxNivel.Items.Add(_miUO.Nivel.ToString());
                //comboBoxNivel.SelectedIndex = 0;

            }

                
        }

        private void setNivel0Selected()
        {

//            comboBoxNivel0
        
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


            int i = 0;
            int indexSelected = 0;
            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);

                i++;
                if (((UnidadOrganizacional)vdVar).Id == _miCaja.Id_uo_padre)
                {
                    indexSelected = i;

                }


            }

            cBoxClaseI.SelectedIndex = indexSelected;

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


            int i = 0;

            int selIndex = 0;

            if (lstVd.Count == 0)
            {

                cBoxClaseI.SelectedIndex = 0;

            }
            else {

                foreach (Entidad vdVar in lstVd)
                {
                    cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);

                    i++;
                    if (((UnidadOrganizacional)vdVar).Id == _miCaja.Id_uo)
                    {
                        selIndex = i;

                    }
                }
            
            }

            cBoxClaseI.SelectedIndex = selIndex;


        }





        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();



        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            _miCaja.Descripcion = textBoxDescripcion.Text;
            _miCaja.Estado = 0;
            _miCaja.Folio_final = textBoxDesde.Text;
            _miCaja.Folio_inicial = textBoxHasta.Text;
            _miCaja.Id_uo = ((UnidadOrganizacional)comboBoxNivelI.SelectedItem).Id;
            _miCaja.Id_uo_padre = ((UnidadOrganizacional)comboBoxNivel0.SelectedItem).Id;
            _miCaja.Nro = textBoxNro.Text;
            _miCaja.Vigencia = 1;
            _miCaja.IdTipoDoc = ((TipoDocumentoNivel)comboBoxTipoDoc.SelectedItem).Id_tipodoc;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void FormCaja_Load(object sender, EventArgs e)
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


        private void triggerComboNivelISelected()
        {
            ComboBox cBoxNivelI = comboBoxNivelI;

            UnidadOrganizacional uo = (UnidadOrganizacional)cBoxNivelI.SelectedItem;

            if (uo != null) { fillComboTipoDoc(uo.Id); }
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

            //if (cBoxClaseTipoDoc.Items.Count > 1)
            //    cBoxClaseTipoDoc.SelectedIndex = 1;
            //else
            //    cBoxClaseTipoDoc.SelectedIndex = 0;

            int i = 0;


            if (lstVd.Count == 0) {

                cBoxClaseTipoDoc.SelectedIndex = 0;
            }
            else 
            {
                foreach (Entidad vdVar in lstVd)
                {
                    i++;
                    cBoxClaseTipoDoc.Items.Add((TipoDocumentoNivel)vdVar);

                    if (((TipoDocumentoNivel)vdVar).Id_tipodoc == _miCaja.IdTipoDoc)
                    {
                        cBoxClaseTipoDoc.SelectedIndex = i;

                    }

                }
            }


        }




    }
}
