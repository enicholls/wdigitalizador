using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using login;
using WConsultas.identity;
using CatalogoDBLib.dbmanager;
using CatalogoDBLib.db;

namespace WConsultas.mantenedores
{
    public partial class FormUser : Form
    {

        User _user;

        public FormUser(User usuario)
        {
            InitializeComponent();
            _user = usuario;
            fillUserGUI();
        }

        private void fillDepto()
        {
            PGEntityManager em = PGEntityManager.getInstance();
            UnidadOrganizacional uo = new UnidadOrganizacional();
            uo.Nivel = 0;

            List<Entidad> lstVd = (List<Entidad>)em.getListxNivel(uo);
            ComboBox cBoxClaseI = comboBoxDepto;


            cBoxClaseI.Items.Clear();
            cBoxClaseI.DisplayMember = "Nombre";
            cBoxClaseI.ValueMember = "Id";

            int i=0,sel = 0;

            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);

                if ( _user!= null &&  ((UnidadOrganizacional)vdVar).Id == _user.Iddepto) {

                    sel = i;
                }

                i++;
            }


            if (cBoxClaseI.Items.Count > 0) cBoxClaseI.SelectedIndex = sel;

            triggerComboNivel0Selected();

        }


        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            _user.ApellidoPaterno = textBoxAP.Text;
            _user.ApellidoMaterno = textBoxAM.Text;
            _user.clave = textBoxPwd.Text;
            _user.nombre = textBoxNombres.Text;
            _user.nroid = textBoxRUT.Text;
            _user.tipoid = "1";
            _user.clave = textBoxPwd.Text;
            _user.userid = textBoxUserid.Text ;
            _user.Iddepto = ((UnidadOrganizacional)comboBoxDepto.SelectedItem).Id;

            foreach (enumPermisos.permiso MyEnum in Enum.GetValues(typeof(enumPermisos.permiso)))
            {

                _user.Permisos[(int)MyEnum] = checkedListBoxPermisos.GetItemChecked((int)MyEnum)?"1":"0";
                    


            }

            int i=0,count=0;

            _user.Subdeptos = new int[checkedListBoxSubDeptos.Items.Count];

            foreach (UnidadOrganizacional uo in checkedListBoxSubDeptos.Items){

                if (checkedListBoxSubDeptos.GetItemChecked(i) == true)
                { 
                

                    _user.Subdeptos[count] = ((UnidadOrganizacional)checkedListBoxSubDeptos.Items[i]).Id;
                    count++;
                
                }
            
                i++;
            }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void fillUserGUI() {

            if (_user.userid != null)
            {   
                textBoxAP.Text = _user.ApellidoPaterno;
                textBoxAM.Text = _user.ApellidoMaterno;
                textBoxPwd.Text = _user.clave;
                textBoxNombres.Text = _user.nombre;
                textBoxRUT.Text = _user.nroid;
                textBoxPwd.Text = _user.clave;
                textBoxUserid.Text = _user.userid;
 
            }

            fillDepto();
            fillPermisosList();

        }




        private void fillPermisosList() {


            if (_user.Permisos == null)
            {
                _user.Permisos = new string[Enum.GetValues(typeof(enumPermisos.permiso)).Length];

                foreach (enumPermisos.permiso MyEnum in Enum.GetValues(typeof(enumPermisos.permiso)))
                {

                    _user.Permisos[(int)MyEnum] = "0";


                }
                
                
            }

            foreach(enumPermisos.permiso MyEnum  in Enum.GetValues(typeof(enumPermisos.permiso))){

                checkedListBoxPermisos.Items.Add(enumPermisos.getNombre(MyEnum), _user.Permisos[(int)MyEnum].CompareTo("1") == 0);


            }

      
        }


  
        private void triggerComboNivel0Selected()
        {
            ComboBox cBoxNivel1 = comboBoxDepto;


            UnidadOrganizacional uo = (UnidadOrganizacional)cBoxNivel1.SelectedItem;

            if (uo != null)
            {
                fillSubDeptos(uo.Id);
                findUO(uo.Id);

//                triggerComboNivelISelected();
            }



        }


        private void fillSubDeptos(int idPadre)
        {

            PGEntityManager em = PGEntityManager.getInstance();
            UnidadOrganizacional uo = new UnidadOrganizacional();
            uo.IdPadre = idPadre;
            List<Entidad> lstVd = (List<Entidad>)em.getListHijosxId(uo);
            
            CheckedListBox cBoxClaseI = checkedListBoxSubDeptos;
            cBoxClaseI.Items.Clear();
            cBoxClaseI.DisplayMember = "Nombre";
            cBoxClaseI.ValueMember = "Id";

            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);
            }



            if (_user.Subdeptos == null)
            {
                _user.Subdeptos = new int[cBoxClaseI.Items.Count];

            }
            else {

                
                for (int i=0;i < cBoxClaseI.Items.Count;i++)
                    
                {
                    UnidadOrganizacional uoAux = (UnidadOrganizacional)cBoxClaseI.Items[i];
                    foreach (int idSubDepto in _user.Subdeptos)
                    {

                        if (idSubDepto == uoAux.Id)
                        {

                            cBoxClaseI.SetItemChecked(i, true);
                            
                            break;
                        }


                    }

                
                }
            }



            
        }


        private void comboBoxDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            triggerComboNivel0Selected();
        }



        int findUOPadre(int idUO)
        {
            for (int i = 0; i < comboBoxDepto.Items.Count; i++)
            {

                UnidadOrganizacional uo = (UnidadOrganizacional)comboBoxDepto.Items[i];

                if (uo.Id == idUO)
                {
                    comboBoxDepto.SelectedIndex = i;
                }
            }

            return 0;
        }

        int findUO(int idUO)
        {
            for (int i = 0; i < checkedListBoxSubDeptos.Items.Count; i++)
            {

                UnidadOrganizacional uo = (UnidadOrganizacional)checkedListBoxSubDeptos.Items[i];

                if (uo.Id == idUO)
                {
                    checkedListBoxSubDeptos.SelectedIndex = i;
                }
            }

            return 0;
        }





    }
}
