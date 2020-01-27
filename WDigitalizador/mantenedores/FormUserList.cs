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

namespace WConsultas.mantenedores
{
    public partial class FormUserList : Form
    {
        User[] miDirectorio;

        public FormUserList()
        {
            InitializeComponent();
            miDirectorio = FileSystemEntityChecker.getDirectorio();
            fillList();

        }


        void fillList() {


            listBoxUsuarios.Items.Clear();

            listBoxUsuarios.ValueMember ="userid";
            listBoxUsuarios.DisplayMember = "fullname";

            foreach (User u in miDirectorio)
            {

                listBoxUsuarios.Items.Add(u);

            }

        
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User usr = new User();

            FormUser frmUSer = new FormUser(usr);

            DialogResult dlgRst =  frmUSer.ShowDialog();

            if (dlgRst == DialogResult.OK)
            {

                User[] nuevoDirectorio = new User[miDirectorio.Length+1];
                Array.Copy(miDirectorio, nuevoDirectorio, miDirectorio.Length);
                nuevoDirectorio[miDirectorio.Length] = usr;
                miDirectorio = nuevoDirectorio;
                FileSystemEntityChecker.SaveUsersFile(miDirectorio);
                fillList();

            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            User usr = (User)listBoxUsuarios.SelectedItem;



            if (usr == null)
            {
                MessageBox.Show("Debe seleccionar un usuario", "Error", MessageBoxButtons.OK);
                return;
            
            }
            FormUser frmUSer = new FormUser(usr);

            DialogResult dlgRst = frmUSer.ShowDialog();

            if (dlgRst == DialogResult.OK)
            {

                FileSystemEntityChecker.SaveUsersFile(miDirectorio);
                fillList();
            }

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
