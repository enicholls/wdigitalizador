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

namespace WConsultas.mantenedores
{
    public partial class FormSubEntityList : Form
    {
        public FormSubEntityList()
        {
            InitializeComponent();
            fillComboNivel0();
        }

        private void fillComboNivel0()
        {
            PGEntityManager em = PGEntityManager.getInstance();
            UnidadOrganizacional uo = new UnidadOrganizacional();
            uo.Nivel = 0;

            List<Entidad> lstVd = (List<Entidad>)em.getListxNivel(uo);
            ComboBox cBoxClaseI = comboBoxDepartamentos;


            cBoxClaseI.Items.Clear();
            cBoxClaseI.DisplayMember = "Nombre";
            cBoxClaseI.ValueMember = "Id";


            foreach (Entidad vdVar in lstVd)
            {
                cBoxClaseI.Items.Add((UnidadOrganizacional)vdVar);
            }

            cBoxClaseI.SelectedIndex = 0;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        private void triggerComboNivel0Selected()
        {
            ComboBox cBoxNivel0 = comboBoxDepartamentos;


            UnidadOrganizacional uo = (UnidadOrganizacional)cBoxNivel0.SelectedItem;

            if (uo != null) { fillComboNivel1(uo.Id); }
        }





        private void buttonModify_Click(object sender, EventArgs e)
        {
            UnidadOrganizacional uo = (UnidadOrganizacional)listBoxEntityList.SelectedItem;

            FormSubdepartamento frmEntity = new FormSubdepartamento(uo);

            frmEntity.ShowDialog();

            if (frmEntity.DialogResult == DialogResult.OK)
            {
                Console.WriteLine("");

                PGEntityManager em = PGEntityManager.getInstance();
                em.update(uo);
                listBoxEntityList.Items.Clear();
                fillComboNivel0();

            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {


            ComboBox cBoxNivel0 = comboBoxDepartamentos;


            UnidadOrganizacional uoPadre = (UnidadOrganizacional)cBoxNivel0.SelectedItem;
            
            UnidadOrganizacional uo = new UnidadOrganizacional();

            uo.IdPadre = uoPadre.Id;
            uo.Nivel = 1;

            FormSubdepartamento frmEntity = new FormSubdepartamento(uo);

            frmEntity.ShowDialog();

            if (frmEntity.DialogResult == DialogResult.OK)
            {
                Console.WriteLine("");

                PGEntityManager em = PGEntityManager.getInstance();
                em.save(uo);
                listBoxEntityList.Items.Clear();
                fillComboNivel0();

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            triggerComboNivel0Selected();

        }

        private void fillComboNivel1(int idPadre)
        {
            PGEntityManager em = PGEntityManager.getInstance();
            UnidadOrganizacional uo = new UnidadOrganizacional();
            uo.IdPadre = idPadre;

            List<Entidad> lstVd = (List<Entidad>)em.getListHijosxId(uo);
            ListBox listBoxSubDeptos = listBoxEntityList;

            listBoxSubDeptos.Items.Clear();
            listBoxSubDeptos.DisplayMember = "Nombre";
            listBoxSubDeptos.ValueMember = "Id";


            foreach (Entidad vdVar in lstVd)
            {
                listBoxSubDeptos.Items.Add((UnidadOrganizacional)vdVar);
            }

            if (listBoxSubDeptos.Items.Count >0) listBoxSubDeptos.SelectedIndex = 0;

        }

 


    }
}
