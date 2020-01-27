using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CatalogoDBLib.db;

namespace WConsultas.mantenedores
{
    public partial class FormTipoDoc : Form
    {

        ValorDominio _miVD = null;

        public FormTipoDoc(ValorDominio UO)
        {
            InitializeComponent();
            _miVD = UO;
            fillForm();

        }

        public void fillForm() {

            if (_miVD.Id != null) {
                textBoxNombre.Text = _miVD.Valor;
            }

                
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();



        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            _miVD.Valor = textBoxNombre.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
