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
    public partial class FormEntity : Form
    {

        UnidadOrganizacional _miUO = null;

        public FormEntity(UnidadOrganizacional UO)
        {
            InitializeComponent();
            _miUO = UO;
            fillForm();

        }

        public void fillForm() {

            if (_miUO.Id != null) {
                textBoxNombre.Text = _miUO.Nombre;
                textBoxPadre.Text = _miUO.IdPadre.ToString();
                comboBoxNivel.Items.Add(_miUO.Nivel.ToString());
                comboBoxNivel.SelectedIndex = 0;
            }

                
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();



        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            _miUO.Nombre = textBoxNombre.Text;
            _miUO.IdPadre = Convert.ToInt32(textBoxPadre.Text);
            _miUO.Nivel = Convert.ToInt16(comboBoxNivel.SelectedItem.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
