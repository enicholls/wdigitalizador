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
    public partial class FormTipoDocList : Form
    {
        public FormTipoDocList()
        {
            InitializeComponent();
            fillListBoxClaseI();
        }

        private void fillListBoxClaseI()
        {
            PGEntityManager em = PGEntityManager.getInstance();
            ValorDominio vd = new ValorDominio();
            vd.Id_dominio = 2;
            List<Entidad> lstVd = (List<Entidad>)em.getList(vd);


            listBoxEntityList.Items.Clear();
            listBoxEntityList.DisplayMember = "Valor";


            foreach (Entidad vdVar in lstVd)
            {
                listBoxEntityList.Items.Add((ValorDominio)vdVar);
            }



        }


        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            ValorDominio uo = (ValorDominio)listBoxEntityList.SelectedItem;

            FormTipoDoc frmEntity = new FormTipoDoc(uo);

            frmEntity.ShowDialog();

            if (frmEntity.DialogResult == DialogResult.OK)
            {

                PGEntityManager em = PGEntityManager.getInstance();
                em.update(uo);
                listBoxEntityList.Items.Clear();
                fillListBoxClaseI() ;

            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ValorDominio uo = new ValorDominio();

            uo.Id_dominio = 2;



            FormTipoDoc frmEntity = new FormTipoDoc(uo);

            frmEntity.ShowDialog();

            if (frmEntity.DialogResult == DialogResult.OK)
            {
                Console.WriteLine("");

                PGEntityManager em = PGEntityManager.getInstance();
                em.save(uo);
                listBoxEntityList.Items.Clear();
                fillListBoxClaseI();

            }

        }

        private void FormEntityList_Load(object sender, EventArgs e)
        {

        }

        private void listBoxEntityList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
