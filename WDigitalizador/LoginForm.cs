using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using login;


namespace WConsultas
{
    public partial class LoginForm : Form
    {

        User myUser;
        public LoginForm(User usr) 
        {
            InitializeComponent();
            myUser = usr;

        }

        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            myUser.userid = textBoxUsuario.Text;
            myUser.clave = textBoxPAssword.Text;

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
 
        }



    }
}
