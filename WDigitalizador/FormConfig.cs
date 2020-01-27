using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Digitalizador.gui;
using Vintasoft.Twain;
using System.IO;
using log4net;
using WConsultas.identity;
using login;
using System.Collections;

namespace WConsultas
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            FillValues();
            
        }

        private static readonly ILog log = LogManager.GetLogger(typeof(FormConfig));


        private void FillValues()
        {
            textBoxConnStr.Text         = Program.g_Config._BaseDeDatosCon;
            textBoxPathTmp.Text         = Program.g_Config._PathTmpLocal ;
            textBoxPathStorage.Text     = Program.g_Config._PathTmpStorage ;
            textBoxIdDomRef.Text        = Program.g_Config._DomReferencia.ToString();
            textBoxIdDomTipoDoc.Text    = Program.g_Config._DomTipoDoc.ToString();
            textBoxDirClasificar.Text   = Program.g_Config._PathArcClasificar.ToString();

            frmScanner.InitScanner();

            FillConfigForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
//                //Chequeo paths

                //User[] _directorioUsuarios = new User[1];
                
                //User user = new User();


                //user.clave  = "sa";
                //user.userid = "sa";
                //user.Permisos = new string[6];
                //user.Permisos[0] = "1";
                //user.Permisos[1] = "1";
                //user.Permisos[2] = "1";
                //user.Permisos[3] = "1";
                //user.Permisos[4] = "1";
                //user.Permisos[5] = "1";


                //_directorioUsuarios[0] = user;

                //FileSystemEntityChecker.SaveUsersFile(_directorioUsuarios);
                //FileSystemEntityChecker.SavePermisos(user);


                if (!Directory.Exists(textBoxPathTmp.Text))
                {
                    MessageBox.Show("El directorio [" + textBoxPathTmp.Text + "] no existe. Corríjalo y reintente...",
                                    "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (!Directory.Exists(textBoxPathStorage.Text))
                {
                    MessageBox.Show("El directorio [" + textBoxPathStorage.Text + "] no existe. Corríjalo y reintente...",
                                    "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                Program.g_Config._BaseDeDatosCon    = textBoxConnStr.Text;
                Program.g_Config._PathTmpLocal      = textBoxPathTmp.Text;
                Program.g_Config._PathTmpStorage = textBoxPathStorage.Text;
                Program.g_Config._DomReferencia = Convert.ToInt32(textBoxIdDomRef.Text);
                Program.g_Config._DomTipoDoc = Convert.ToInt32(textBoxIdDomTipoDoc.Text);
                Program.g_Config._PathArcClasificar = textBoxDirClasificar.Text;


                
                //                //Paso controles, entonces lleno variable g_Config y grabo
                Program.g_Config._DPI = Convert.ToInt32(cboCalidad.SelectedItem.ToString());
                Program.g_Config._Escaner = cboScanner.SelectedItem.ToString();
                Program.g_Config._FinalType = rbPDF.Checked ? "PDF" : "TIF";
                switch (cboColor.SelectedIndex)
                {
                    case 0:
                        Program.g_Config._PixelType = "BW";
                        break;
                    case 1:
                        Program.g_Config._PixelType = "Grises";
                        break;
                    case 2:
                        Program.g_Config._PixelType = "Color";
                        break;
                    default:
                        Program.g_Config._PixelType = "Grises";
                        break;
                }
                Program.g_Config._Contraste = trackBarContraste.Value;
                Program.g_Config._Brillo = trackBarBrillo.Value;
                Program.g_Config._ContrasteDBP = trackBarContrastDetectBP.Value;
                Program.g_Config._PageSize = (string)cboTamanioHoja.SelectedItem;
                //switch (cboTamanioHoja.SelectedIndex)
                //{
                //    case 0:
                //        Program.g_Config._PixelType = "BW";
                //        break;
                //    case 1:
                //        Program.g_Config._PixelType = "Grises";
                //        break;
                //    case 2:
                //        Program.g_Config._PixelType = "Color";
                //        break;
                //    default:
                //        Program.g_Config._PixelType = "Grises";
                //        break;
                //}




//                //Paths
//                Program.g_Config._PathTmpLocal = txtStrPathTemp.Text;
//                Program.g_Config._PathToSend = txtStrPathToSend.Text;
//                Program.g_Config._PathSended = txtStrPathSended.Text;
//                //Program.g_Config._PathToSendNetwork = txtStrPathSendedRed.Text;



                Program.g_Config._saveCode = checkBoxIncluyeCodigo.Checked;

                Config.SaveConfigFile(Program.g_Config);

                log.Info("Usuario " + " modificó los parámetros :" +
                    Program.g_Config.ToString());
                //labAccion.Text = "Parámetros actualizados!.";
                //statusBarRigth.Text = "Parámetros actualizados!.";

                frmScanner.InitScanner();

            }
            catch (Exception ex)
            {
                log.Info("Error grabando parámetros. Usuario " + " intentó modificarlos.", ex);
                //labAccion.Text = "Error grabando parámetros [" + ex.Message + "]";
                //statusBarRigth.Text = "Error grabando parámetros [" + ex.Message + "]";
            }

            Config.SaveConfigFile(Program.g_Config);

            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog frmDirPath = new FolderBrowserDialog();

            frmDirPath.Description = "hoka";
            frmDirPath.SelectedPath = Program.g_Config._PathTmpLocal;

            DialogResult dr = frmDirPath.ShowDialog();

            if (dr == DialogResult.OK)
            {

                textBoxPathTmp.Text = frmDirPath.SelectedPath;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.FolderBrowserDialog frmDirPath = new FolderBrowserDialog();

            frmDirPath.Description = "hoka";
            frmDirPath.SelectedPath = Program.g_Config._PathTmpStorage;

            DialogResult dr = frmDirPath.ShowDialog();

            if (dr == DialogResult.OK)
            {

                textBoxPathStorage.Text = frmDirPath.SelectedPath;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void FillConfigForm()
        {
            //Cargo datos de config a grp de config
            //Scanners conectados
            cboScanner.Items.Clear();
            //if (frmScanner.VSTwainHScanner == null)
            //{

            //    frmScanner.VSTwainHScanner = new VSTwain();
            //}
            //else {

            //    frmScanner.VSTwainHScanner.StopDevice();
            
            //}

            //frmScanner.VSTwainHScanner.StartDevice();

 


            for (int i = 0; i < frmScanner.VSTwainHScanner.SourcesCount; i++)
            {
                cboScanner.Items.Add(frmScanner.VSTwainHScanner.GetSourceProductName(i));
                if (Program.g_Config._Escaner.Equals(frmScanner.VSTwainHScanner.GetSourceProductName(i)))
                {
                    cboScanner.SelectedIndex = cboScanner.Items.Count - 1;
                }
            }

            //Guarda Codigo
            try
            {
                checkBoxIncluyeCodigo.Checked = Program.g_Config._saveCode;
            }
            catch
            {
                checkBoxIncluyeCodigo.Checked = false;
            }


            //Color imagen
            if (Program.g_Config._PixelType.Equals("BW"))
            {
                cboColor.SelectedIndex = 0;
            }
            else if (Program.g_Config._PixelType.Equals("Grises"))
            {
                cboColor.SelectedIndex = 1;
            }
            else
            {
                cboColor.SelectedIndex = 2;
            }

            //DPI
            switch (Program.g_Config._DPI)
            {
                case 150:
                    cboCalidad.SelectedIndex = 0;
                    break;
                case 300:
                    cboCalidad.SelectedIndex = 1;
                    break;
                case 600:
                    cboCalidad.SelectedIndex = 2;
                    break;
                case 1200:
                    cboCalidad.SelectedIndex = 3;
                    break;
                default:
                    cboCalidad.SelectedIndex = 0;
                    break;

            }

            //Formato Final
            if (Program.g_Config._FinalType.Equals("PDF"))
            {
                frmScanner.extensionFinal = ".pdf";
                frmScanner.fformat = ImageFileFormat.PDF;
                rbPDF.Checked = true;
                rbTIFF.Checked = false;
            }
            else
            {
                frmScanner.extensionFinal = ".tif";
                frmScanner.fformat = ImageFileFormat.TIFF;
                rbPDF.Checked = false;
                rbTIFF.Checked = true;
            }



            //Tamaño imagen
            if (Program.g_Config._PageSize.Equals("Tarjeta"))
            {
                cboTamanioHoja.SelectedIndex = 3;
            }
            else if (Program.g_Config._PageSize.Equals("Legal"))
            {
                cboTamanioHoja.SelectedIndex = 1;
            }
            else if (Program.g_Config._PageSize.Equals("A4"))
            {
                cboTamanioHoja.SelectedIndex = 2;
            }
            else //Carta Default
            {
                cboTamanioHoja.SelectedIndex = 0;
            }
            trackBarContraste.Value = Program.g_Config._Contraste;
            trackBarBrillo.Value = Program.g_Config._Brillo;
            trackBarContrastDetectBP.Value = Program.g_Config._ContrasteDBP;

        }


        private void buttonExpClasificar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog frmDirPath = new FolderBrowserDialog();

            frmDirPath.Description = "";
            frmDirPath.SelectedPath = Program.g_Config._PathArcClasificar;

            DialogResult dr = frmDirPath.ShowDialog();

            if (dr == DialogResult.OK)
            {

                textBoxDirClasificar.Text = frmDirPath.SelectedPath;
            }



        }



    }
}
