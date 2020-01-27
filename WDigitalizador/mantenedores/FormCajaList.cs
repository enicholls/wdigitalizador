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
    public partial class FormCajaList : Form
    {
        public FormCajaList()
        {
            InitializeComponent();
            fillListBoxClaseI();
        }

        private void fillListBoxClaseI()
        {
            PGEntityManager em = PGEntityManager.getInstance();
            Caja caja = new Caja();

            List<Entidad> lstVd = (List<Entidad>)em.getList(caja);


            listBoxEntityList.Items.Clear();
            listBoxEntityList.DisplayMember = "Descripcion";


            foreach (Entidad vdVar in lstVd)
            {
                listBoxEntityList.Items.Add((Caja)vdVar);
            }



        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            Caja uo = (Caja)listBoxEntityList.SelectedItem;

            if (uo == null) {

                MessageBox.Show("Debe seleccionar una fila","Error",MessageBoxButtons.OK);

                return;
            
            }

            FormCaja frmEntity = new FormCaja(uo);

            frmEntity.ShowDialog();

            if (frmEntity.DialogResult == DialogResult.OK)
            {
                Console.WriteLine("");

                PGEntityManager em = PGEntityManager.getInstance();
                em.update(uo);
                listBoxEntityList.Items.Clear();
                fillListBoxClaseI();

            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Caja uo = new Caja();

            FormCaja frmCaja = new FormCaja(uo);

            frmCaja.ShowDialog();

            if (frmCaja.DialogResult == DialogResult.OK)
            {
                Console.WriteLine("");

                PGEntityManager em = PGEntityManager.getInstance();
                em.save(uo);
                listBoxEntityList.Items.Clear();
                fillListBoxClaseI();

            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            Caja uo = (Caja)listBoxEntityList.SelectedItem;

            if (uo == null)
            {

                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK);

                return;

            }

            uo.Vigencia = 0;
            PGEntityManager em = PGEntityManager.getInstance();
            em.update(uo);
            listBoxEntityList.Items.Clear();
            fillListBoxClaseI();


        }




    }
}
