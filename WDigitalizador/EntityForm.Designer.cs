namespace WConsultas
{
    partial class EntityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityForm));
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxNivelI = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxNivel0 = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDoc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReferencia = new System.Windows.Forms.TextBox();
            this.checkBoxDesechado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(308, 254);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(389, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxNivelI
            // 
            this.comboBoxNivelI.FormattingEnabled = true;
            this.comboBoxNivelI.Location = new System.Drawing.Point(12, 84);
            this.comboBoxNivelI.Name = "comboBoxNivelI";
            this.comboBoxNivelI.Size = new System.Drawing.Size(452, 21);
            this.comboBoxNivelI.TabIndex = 32;
            this.comboBoxNivelI.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivelI_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Subdepartamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Departamento";
            // 
            // comboBoxNivel0
            // 
            this.comboBoxNivel0.FormattingEnabled = true;
            this.comboBoxNivel0.Location = new System.Drawing.Point(12, 37);
            this.comboBoxNivel0.Name = "comboBoxNivel0";
            this.comboBoxNivel0.Size = new System.Drawing.Size(452, 21);
            this.comboBoxNivel0.TabIndex = 29;
            this.comboBoxNivel0.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivel0_SelectedIndexChanged);
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(129, 138);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(214, 21);
            this.comboBoxTipoDoc.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tipo Documento";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerDoc
            // 
            this.dateTimePickerDoc.Location = new System.Drawing.Point(129, 183);
            this.dateTimePickerDoc.Name = "dateTimePickerDoc";
            this.dateTimePickerDoc.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerDoc.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNro
            // 
            this.textBoxNro.Location = new System.Drawing.Point(129, 116);
            this.textBoxNro.Name = "textBoxNro";
            this.textBoxNro.Size = new System.Drawing.Size(214, 20);
            this.textBoxNro.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nro.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Referencia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxReferencia
            // 
            this.textBoxReferencia.Location = new System.Drawing.Point(129, 159);
            this.textBoxReferencia.Name = "textBoxReferencia";
            this.textBoxReferencia.Size = new System.Drawing.Size(214, 20);
            this.textBoxReferencia.TabIndex = 21;
            // 
            // checkBoxDesechado
            // 
            this.checkBoxDesechado.AutoSize = true;
            this.checkBoxDesechado.ForeColor = System.Drawing.Color.White;
            this.checkBoxDesechado.Location = new System.Drawing.Point(384, 116);
            this.checkBoxDesechado.Name = "checkBoxDesechado";
            this.checkBoxDesechado.Size = new System.Drawing.Size(81, 17);
            this.checkBoxDesechado.TabIndex = 33;
            this.checkBoxDesechado.Text = "Desechado";
            this.checkBoxDesechado.UseVisualStyleBackColor = true;
            // 
            // EntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(485, 305);
            this.Controls.Add(this.checkBoxDesechado);
            this.Controls.Add(this.comboBoxNivelI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxNivel0);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerDoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxReferencia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntityForm";
            this.Text = "Documento";
            this.Load += new System.EventHandler(this.EntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxNivelI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxNivel0;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReferencia;
        private System.Windows.Forms.CheckBox checkBoxDesechado;
    }
}