namespace WConsultas.mantenedores
{
    partial class FormTipoDocXSubDepto
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
            this.comboBoxNivelI = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxNivel0 = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.listBoxTipoDoc = new System.Windows.Forms.ListBox();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxNivelI
            // 
            this.comboBoxNivelI.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxNivelI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivelI.FormattingEnabled = true;
            this.comboBoxNivelI.Location = new System.Drawing.Point(24, 81);
            this.comboBoxNivelI.Name = "comboBoxNivelI";
            this.comboBoxNivelI.Size = new System.Drawing.Size(452, 21);
            this.comboBoxNivelI.TabIndex = 26;
            this.comboBoxNivelI.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivelI_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Subdepartamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Departamento";
            // 
            // comboBoxNivel0
            // 
            this.comboBoxNivel0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivel0.FormattingEnabled = true;
            this.comboBoxNivel0.Location = new System.Drawing.Point(24, 34);
            this.comboBoxNivel0.Name = "comboBoxNivel0";
            this.comboBoxNivel0.Size = new System.Drawing.Size(452, 21);
            this.comboBoxNivel0.TabIndex = 23;
            this.comboBoxNivel0.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivel0_SelectedIndexChanged);
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(32, 32);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(331, 21);
            this.comboBoxTipoDoc.TabIndex = 22;
            // 
            // listBoxTipoDoc
            // 
            this.listBoxTipoDoc.FormattingEnabled = true;
            this.listBoxTipoDoc.Location = new System.Drawing.Point(24, 122);
            this.listBoxTipoDoc.Name = "listBoxTipoDoc";
            this.listBoxTipoDoc.Size = new System.Drawing.Size(452, 95);
            this.listBoxTipoDoc.TabIndex = 27;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Controls.Add(this.comboBoxTipoDoc);
            this.groupBoxAdd.Location = new System.Drawing.Point(24, 249);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(452, 110);
            this.groupBoxAdd.TabIndex = 28;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Tipo de Documento x Agregar";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.buttonAdd.Location = new System.Drawing.Point(364, 81);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormTipoDocXSubDepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(500, 437);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.listBoxTipoDoc);
            this.Controls.Add(this.comboBoxNivelI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxNivel0);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormTipoDocXSubDepto";
            this.Text = "FormTipoDocXSubDepto";
            this.Load += new System.EventHandler(this.FormTipoDocXSubDepto_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNivelI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxNivel0;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.ListBox listBoxTipoDoc;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAdd;
    }
}