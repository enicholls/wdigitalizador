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
    public partial class FormEntityList : Form
    {
        public FormEntityList()
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


            listBoxEntityList.Items.Clear();
            listBoxEntityList.DisplayMember = "Nombre";

            UnidadOrganizacional uoaux = new UnidadOrganizacional();

            uoaux.Id = -1;
            uoaux.Nombre = "Seleccionar";
            listBoxEntityList.Items.Add(uoaux);
            foreach (Entidad vdVar in lstVd)
            {
                listBoxEntityList.Items.Add((UnidadOrganizacional)vdVar);
            }

           listBoxEntityList.SelectedIndex = 0;

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            UnidadOrganizacional uo = (UnidadOrganizacional)listBoxEntityList.SelectedItem;

            FormEntity frmEntity = new FormEntity(uo);

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
            UnidadOrganizacional uo = new UnidadOrganizacional();

            FormEntity frmEntity = new FormEntity(uo);

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }




    }
}
