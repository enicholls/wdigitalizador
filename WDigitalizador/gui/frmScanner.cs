/* ===================================================
 * Inicio documento
 *
 * Nombre: frmMain.cs
 * Titulo: frmMain 
 * Tipo: clase
 * URL:
 * Empresa (si es externa): Quintec
 * Autor: Sergio Campos
 * Email: scampos@idsoft.cl
 * Proyecto: 
 * Fecha de Creación: 17/03/2009
 * Tipo Codificación: C#
 * Descripción: Form principal para el digitalizador
 * Observaciones:
 * Anexos:
 *
 * ================================================== */

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
//using Digitalizador.mail;
using log4net;
using Vintasoft.Barcode;
using Vintasoft.Twain;
using WConsultas;
using BarcodeType = Vintasoft.Twain.BarcodeType;

namespace Digitalizador.gui
{
    /// <summary>
    /// Formulario principal de la aplicación
    /// </summary>
    public partial class frmScanner : Form
    {

        /// <summary>
        /// Generación de variable estática para escritura de Log, de acuerdo
        /// a la documentación de log4net.
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(Digitalizador.gui.frmScanner));

        //Variables globales para la digitalizacion
        //Para cancelar un escaneo
        private bool g_flagStopImageProcessing = false;

        //Images para viewer de TIFF Multipagina
        private Image currentImageTIFFMultiPagina;
        private Image currentHojaOfImageTIFFMultiPagina;

        //Para detectar hojas en blanco
        static float umbralNoiseLevel = 0.50f;

        /// <summary>
        /// Variables para manejo de escaner
        /// </summary>
        public static VSTwain VSTwainHScanner;
        /// <summary>
        /// Variables para reconocimiento de códigos de barras
        /// </summary>
        public BarcodeReader BarcodeReaderBC;

        public frmScanner()
        {
            //Inicializo componente con licencia respectiva.
            //TwainGlobalSettings tgs = new TwainGlobalSettings();
            //tgs.Register("Eric Nicholls",
            //             "ericnichollsv@gmail.com",
            //             "ZKAtxlkR8q4Hl71yPLw4UsNkJET8vQzAqSWVAK++xinFMmpG7Z4jruL0YV0/sixaKC7Xdd8n5wYrjm4o5UbbcIXRs0gD1jbyKQIZNQPIshEtxhxTiN0ZFLj9lQ3hjssAN6RZ5CXYi67gcENpbehw7h57+3ee+6VuBCd3iQX2FxUM");
            //"jtjIjlraUygTWrmZKmgJDA9pdyByEM1h9v6iDrVByN4foa5IFyIIIkp5MFQFXCZivsq9aM2D+49TtV6aWTGqpaKM7J64HleSgf4VNmyYlKAha4luKeFPKAsSvdvWmgYlU3NXRCAlt1U80LCkcKonNplcu7j5F6fmAJe28vtb6Nyw");

            //Inicializo Barcode
            BarcodeGlobalSettings bgs = new BarcodeGlobalSettings();
            bgs.Register("Eric Nicholls Vera",
                         "ericnichollsv@gmail.com",
                         "G8sIGlo5B1afq4rbDivEyMQi7nWEK3i9/jyp+gPVhrslwxcluOwZPvaDV9iCASh+GSDNOi0Q9XNKCJNfbMIaz6/VgADtg40yxYO2hK4NIIhj8tAdeObutyHW7YdX0EtWmjVps0sD0RN+jXT+olT5yY45N4QEXipl/Ad3pr5YOfGM");
            //"R+LEGlDlX9fjaXsWWAqcLaw0TEpkhCwHExO4xuctgW0jd9ThQGTi6UcX4F+mFodgu2WcbyajJUePmJq4tU65MAZ4+1R1rAxr1TpcU8cpCYxqocQt+B1IWQ/T6eMGetWXBE9L9OVLRSaPPj4+/T5NlQPGH/KvO7nBuTQl6xmccI4E");

            InitializeComponent();

            //Inicializa el escaner por default con sus CAPS
            InitScanner();

            //Inicializa reconocedor de codigos de barras
            InitCodeBarRecognize();

            //Llena formulario de configuraciones
            FillConfigForm();

            //Registro even
            VSTwainHScanner.ImageAcquired += new EventHandler(VSTwainHScanner_ImageAcquiredEvent);
            VSTwainHScanner.ScanCompleted += new EventHandler(VSTwainHScanner_ScanCompletedEvent);
            VSTwainHScanner.ProgressChanged += new VSTwain.ProgressChangedEventHandler(VSTwainHScanner_ProgressChanged);

            BringToFront();
            Select();
        }

        private void FillConfigForm()
        {
            return;
        }

        private void InitCodeBarRecognize()
        {

            //Init Objeto para reconocimeinto de Códigos de barra.
            try
            {
                // Create a BarcodeReader object 
                BarcodeReaderBC = new BarcodeReader();
                // Code 39, EAN and PDF417 barcodes are extracted 
                BarcodeReaderBC.Settings.ScanBarcodeTypes = Vintasoft.Barcode.BarcodeType.Code39;
                // Only horizontal barcodes are extracted 
                BarcodeReaderBC.Settings.ScanDirection = ScanDirection.LeftToRight |
                                                        ScanDirection.RightToLeft;
                // Pixels of every 5 row and column are analyzed 
                BarcodeReaderBC.Settings.ScanInterval = 5;
                // 10 first barcodes are extracted 
                BarcodeReaderBC.Settings.MaxBarcodes = 5;

                // Manual mode of threshold detection 
                BarcodeReaderBC.Settings.ThresholdMode = ThresholdMode.Automatic;
                // Number of steps between minimal and maximal threshold values 
                //barcodeReader.Settings.ThresholdIterations = 30;
                // Minimal threshold value 
                //barcodeReader.Settings.Threshold1D = 150;
                // Maximal threshold value 
                //barcodeReader.Settings.Threshold2D = 595;
                //BarcodeReaderBC.Settings.MinConfidence = 25;

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Inicializa scanner con valores por default y leidos desde config
        /// </summary>
        static public void InitScanner()
        {
            //Init Scanner Handler
            if (VSTwainHScanner != null) VSTwainHScanner.StopDevice();
            else VSTwainHScanner = new VSTwain();
            //VSTwainHScanner.IsTwain2Compatible = false;
            VSTwainHScanner.StartDevice();
            
            log.Debug("(InitScanner) Configurando Escaner para captura...");
            try
            {
                bool setted = false;
                for (int i = 0; i < VSTwainHScanner.SourcesCount; i++)
                {
                    if (Program.g_Config._Escaner.Equals(VSTwainHScanner.GetSourceProductName(i)))
                    {
                        log.Debug("     - VSTwainHScanner.SourceIndex = " +
                            i.ToString() + "[" + Program.g_Config._Escaner + "]");
                        setted = true;
                        VSTwainHScanner.SourceIndex = i;
                        break;
                    }
                }
                if (!setted)
                {
                    log.Debug("     - VSTwainHScanner.SourceIndex = " +
                            "NO PUDO SELECCIONAR escaner definido [" +
                              Program.g_Config._Escaner + "]");
                }

            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.SourceIndex", ex);
            }

            //VSTwainHScanner.StartDevice();
            try
            {

                VSTwainHScanner.OpenDataSource();

                PageSize[] ps = VSTwainHScanner.GetPageSizes();

                foreach (PageSize pgs in ps) {

                    log.Debug("     - VSTwainHScanner.PageSize = " + pgs.ToString());
                
                
                }

                log.Debug("     - VSTwainHScanner.OpenDataSource = OK");
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.OpenDataSource", ex);
            }

            VSTwainHScanner.ShowUI = false;
            log.Debug("     - VSTwainHScanner.ShowUI = false");
            VSTwainHScanner.ShowIndicators = false;
            log.Debug("     - VSTwainHScanner.ShowIndicators = false");

            int coeficiente = 11 - Program.g_Config._Brillo;
            try
            {
                VSTwainHScanner.Brightness = VSTwainHScanner.BrightnessMaxValue / coeficiente;
                log.Debug("     - VSTwainHScanner.Brightness = " +
                                    VSTwainHScanner.Brightness.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.Brightness", ex);
            }

            coeficiente = 11 - Program.g_Config._Contraste;

            try
            {
                VSTwainHScanner.Contrast = VSTwainHScanner.ContrastMaxValue / coeficiente;
                log.Debug("     - VSTwainHScanner.Contrast = " +
                                    VSTwainHScanner.Contrast.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.Contrast", ex);
            }


            try
            {
                umbralNoiseLevel = ((10f - (float)Program.g_Config._ContrasteDBP) / 10f);
                if (umbralNoiseLevel == 0) umbralNoiseLevel = 0.01f;
                log.Debug("     - umbralNoiseLevel = " + umbralNoiseLevel.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - umbralNoiseLevel", ex);
            }

            try
            {
                if (Program.g_Config._PageSize.Equals("Tarjeta"))
                {
                    VSTwainHScanner.PageSize = PageSize.BUSINESSCARD;
                }
                else if (Program.g_Config._PageSize.Equals("A4"))
                {
                    VSTwainHScanner.PageSize = PageSize.A4;
                }
                else if (Program.g_Config._PageSize.Equals("Legal"))
                {
                    VSTwainHScanner.PageSize = PageSize.USLEGAL;
                }
                else
                {
                    VSTwainHScanner.PageSize = PageSize.USLETTER;
                }
                log.Debug("     - VSTwainHScanner.PageSize = " +
                          VSTwainHScanner.PageSize.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.PageSize", ex);
            }


            try
            {
                if (Program.g_Config._PixelType.Equals("Color"))
                {
                    VSTwainHScanner.PixelType = PixelType.RGB;
                    VSTwainHScanner.PdfImageCompression = PdfImageCompression.JPEG;
                    VSTwainHScanner.TiffCompression = TiffCompression.LZW;
                }
                else if (Program.g_Config._PixelType.Equals("Grises"))
                {
                    VSTwainHScanner.PixelType = PixelType.GRAY;
                    VSTwainHScanner.PdfImageCompression = PdfImageCompression.LZW;
                    VSTwainHScanner.TiffCompression = TiffCompression.LZW;
                }
                else
                {
                    VSTwainHScanner.PixelType = PixelType.BW;
                    VSTwainHScanner.PdfImageCompression = PdfImageCompression.CcittFax;
                    VSTwainHScanner.TiffCompression = TiffCompression.CCITGroup4;
                }
                log.Debug("     - VSTwainHScanner.PixelType = " +
                                VSTwainHScanner.PixelType.ToString() +
                                " - VSTwainHScanner.PdfImageCompression = " +
                                VSTwainHScanner.PdfImageCompression.ToString() +
                                " - VSTwainHScanner.TiffCompression = " +
                                VSTwainHScanner.TiffCompression.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.PixelType/PdfImageCompression/TiffCompression", ex);
            }


            try
            {
                VSTwainHScanner.UnitOfMeasure = UnitOfMeasure.Inches;
                log.Debug("     - VSTwainHScanner.UnitOfMeasure = " +
                          VSTwainHScanner.UnitOfMeasure.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.UnitOfMeasure", ex);
            }

            try
            {
                VSTwainHScanner.Resolution = Program.g_Config._DPI; // Convert.ToInt32(this.txtResolution.Text);
                log.Debug("     - VSTwainHScanner.Resolution = " +
                          VSTwainHScanner.Resolution.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.Resolution", ex);
            }



            //if (VSTwainHScanner.Duplex != DuplexMode.None) VSTwainHScanner.DuplexEnabled = true;
            try
            {
                if (VSTwainHScanner.Duplex != DuplexMode.None)
                {
                    //if (ckkUsaDuplex.Checked)
                    //{
                    //    VSTwainHScanner.DuplexEnabled = true; 
                    //} else
                    //{
                    //    VSTwainHScanner.DuplexEnabled = false; 
                    //}
                }
                log.Debug("     - VSTwainHScanner.DuplexEnabled = " +
                          VSTwainHScanner.DuplexEnabled.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.DuplexEnabled", ex);
            }


            try
            {
                VSTwainHScanner.AutoCleanBuffer = true;
                log.Debug("     - VSTwainHScanner.AutoCleanBuffer = " +
                          VSTwainHScanner.AutoCleanBuffer.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.AutoCleanBuffer", ex);
            }

            try
            {
                VSTwainHScanner.MaxImages = 1;
                log.Debug("     - VSTwainHScanner.MaxImages = " +
                          VSTwainHScanner.MaxImages.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.MaxImages", ex);
            }


            if (VSTwainHScanner.FeederPresent)
            {
                log.Debug("     - VSTwainHScanner.FeederPresent = " +
                              VSTwainHScanner.FeederPresent.ToString());
                //Hago esto porque en algunos escaners, especialemtne los no ADF
                //da error este seteo.
                try
                {
                    VSTwainHScanner.FeederEnabled = true;
                    log.Debug("     - VSTwainHScanner.FeederEnabled = " +
                              VSTwainHScanner.FeederEnabled.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.FeederEnabled", ex);
                }

                try
                {
                    VSTwainHScanner.AutoFeed = true;
                    log.Debug("     - VSTwainHScanner.AutoFeed = " +
                              VSTwainHScanner.AutoFeed.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.AutoFeed", ex);
                }

                try
                {
                    VSTwainHScanner.XferCount = -1;
                    log.Debug("     - VSTwainHScanner.XferCount = " +
                              VSTwainHScanner.XferCount.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.XferCount", ex);
                }
            }
            else
            {
                log.Debug("     - VSTwainHScanner.FeederPresent = " +
                              VSTwainHScanner.FeederPresent.ToString());
            }

            try
            {
                VSTwainHScanner.FileFormat = FileFormat.Jpeg;
                log.Debug("     - VSTwainHScanner.FileFormat = " +
                              VSTwainHScanner.FileFormat.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.FileFormat", ex);
            }

            try
            {
                VSTwainHScanner.JpegQuality = Program.g_Config._DPI;
                log.Debug("     - VSTwainHScanner.JpegQuality = " +
                              VSTwainHScanner.JpegQuality.ToString());
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.JpegQuality", ex);
            }


            //Formato Final
            try
            {
                if (Program.g_Config._FinalType.Equals("PDF"))
                {
                    extensionFinal = ".pdf";
                    fformat = ImageFileFormat.PDF;  
                    //VSTwainHScanner.PdfDocumentInfo.Author = Program.g_CurrentUser.userid;
                    VSTwainHScanner.PdfDocumentInfo.CreationDate = DateTime.Now;
                    VSTwainHScanner.PdfDocumentInfo.Title = "Documento Digitalizado en OFP";
                    VSTwainHScanner.PdfDocumentInfo.Creator = "Digitalizador OFP";
                    log.Debug("     - Formato Final = " + extensionFinal);
                }
                else
                {
                    extensionFinal = ".tif";
                    fformat = ImageFileFormat.TIFF;
                    log.Debug("     - Formato Final = " + extensionFinal);
                }

            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.JpegQuality", ex);
            }

            //VSTwainHScanner.StartDevice();
            try
            {
                VSTwainHScanner.CloseDataSource();
                log.Debug("     - VSTwainHScanner.CloseDataSource = OK");
            }
            catch (Exception ex)
            {
                log.Error("btnDigitAuto_Click Error - VSTwainHScanner.CloseDataSource", ex);
            }

            log.Debug("(InitScanner) Fin Configuracion Escaner! ");

            //try
            //{
            //    for (int i = 0; i < VSTwainHScanner.SourcesCount; i++)
            //    {
            //        if (Program.g_Config._Escaner.Equals(VSTwainHScanner.GetSourceProductName(i)))
            //        {
            //            VSTwainHScanner.SourceIndex = i;
            //            break;
            //        }
            //    }

            //    VSTwainHScanner.OpenDataSource();
            //    int coeficiente = 11 - Program.g_Config._Brillo; 
            //    VSTwainHScanner.Brightness = VSTwainHScanner.BrightnessMaxValue / coeficiente;
            //    coeficiente = 11 - Program.g_Config._Contraste; 
            //    VSTwainHScanner.Contrast = coeficiente;

            //    if (Program.g_Config._PageSize.Equals("Tarjeta"))
            //    {
            //        VSTwainHScanner.PageSize = PageSize.BUSINESSCARD;
            //    }
            //    else if (Program.g_Config._PageSize.Equals("A4"))
            //    {
            //       VSTwainHScanner.PageSize = PageSize.A4;
            //    }
            //    else if (Program.g_Config._PageSize.Equals("Legal"))
            //    {
            //        VSTwainHScanner.PageSize = PageSize.USLEGAL;
            //    } else
            //    {
            //        VSTwainHScanner.PageSize = PageSize.USLETTER;
            //    }

            //    if (Program.g_Config._PixelType.Equals("Color"))
            //    {
            //        VSTwainHScanner.PixelType = PixelType.RGB;
            //    }
            //    else if (Program.g_Config._PixelType.Equals("Grises"))
            //    {
            //        VSTwainHScanner.PixelType = PixelType.GRAY;
            //    } else
            //    {
            //        VSTwainHScanner.PixelType = PixelType.BW;
            //    }

            //    //VSTwainHScanner.UnitOfMeasure = UnitOfMeasure.Pixels;
            //    VSTwainHScanner.Resolution = Program.g_Config._DPI; // Convert.ToInt32(this.txtResolution.Text);

            //    //for (int i = 0; i < VSTwainHScanner.SourcesCount; i++)
            //    //{
            //    //    if (Program.g_Config._Escaner.Equals(VSTwainHScanner.GetSourceProductName(i)))
            //    //    {
            //    //        VSTwainHScanner.SourceIndex = i;
            //    //    }
            //    //}

            //    VSTwainHScanner.AutoCleanBuffer = true;
            //    VSTwainHScanner.MaxImages = 1;

            //    if (VSTwainHScanner.FeederPresent)
            //    {
            //        //Hago esto porque en algunos escaners, especialemtne los no ADF
            //        //da error este seteo.
            //        try
            //        {
            //            VSTwainHScanner.FeederEnabled = true;
            //        }
            //        catch {}
            //        VSTwainHScanner.AutoFeed = true;
            //        VSTwainHScanner.XferCount = -1;
            //    }
            //    VSTwainHScanner.FileFormat = FileFormat.Jpeg;
            //    VSTwainHScanner.ShowUI = false;
            //    VSTwainHScanner.ShowIndicators = false;

            //    VSTwainHScanner.CloseDataSource();

            //    log.Info("Escaner Inicializado [" + VSTwainHScanner.GetSourceProductName(VSTwainHScanner.SourceIndex) + "]");
            //    statusBarRigth.Text = "Escaner Inicializado [" + VSTwainHScanner.GetSourceProductName(VSTwainHScanner.SourceIndex) + "]";
            //}
            //catch (Exception ex)
            //{
            //    log.Error("frmMain.InitScanner",ex);
            //    statusBarRigth.Text = "Error inicializando escaner [" + ex.Message + "]";
            //}  
        }


        #region Escanner TWAIN

        //Variables para manejo de dgitalizacion
        MemoryStream mem = null;
        bool firstImage = true;
        bool isScanning = false;
        string pathToSave = null;
        string pathCurrent = null;
        public static string extensionFinal = ".pdf";
        bool pageToDiscard = false;
        public static ImageFileFormat fformat = ImageFileFormat.PDF;

        /// <summary>
        /// Inicia el proceso de escaneo, reconociendo cada codigo de barras 
        /// y separando por ese reconocimeinto. Sino, almacena archivo con nombre 
        /// YYYYMMDDHHMMSS.<ext>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDigitAuto_Click(object sender, EventArgs e)
        {
            try
            {
                pbDigit.Value = pbDigit.Minimum;
                g_flagStopImageProcessing = false;
                btnDigitAuto.Enabled = false;
                this.btnCancelar.Enabled = true;

                firstImage = true;

                log.Debug("Configurando Escaner para captura...");
                try
                {
                    bool setted = false;
                    for (int i = 0; i < VSTwainHScanner.SourcesCount; i++)
                    {
                        if (Program.g_Config._Escaner.Equals(VSTwainHScanner.GetSourceProductName(i)))
                        {
                            log.Debug("     - VSTwainHScanner.SourceIndex = " +
                                i.ToString() + "[" + Program.g_Config._Escaner + "]");
                            setted = true;
                            VSTwainHScanner.SourceIndex = i;
                            break;
                        }
                    }
                    if (!setted)
                    {
                        log.Debug("     - VSTwainHScanner.SourceIndex = " +
                                "NO PUDO SELECCIONAR escaner definido [" +
                                  Program.g_Config._Escaner + "]");
                    }

                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.SourceIndex", ex);
                }

                //VSTwainHScanner.StartDevice();
                try
                {
                    VSTwainHScanner.OpenDataSource();
                    log.Debug("     - VSTwainHScanner.OpenDataSource = OK");
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.OpenDataSource", ex);
                }

                VSTwainHScanner.ShowUI = false;
                log.Debug("     - VSTwainHScanner.ShowUI = false");
                VSTwainHScanner.ShowIndicators = false;
                log.Debug("     - VSTwainHScanner.ShowIndicators = false");
                
                int coeficiente = 11 - Program.g_Config._Brillo;
                try
                {
                    VSTwainHScanner.Brightness = VSTwainHScanner.BrightnessMaxValue / coeficiente;
                    log.Debug("     - VSTwainHScanner.Brightness = " +
                                        VSTwainHScanner.Brightness.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.Brightness", ex);
                }

                coeficiente = 11 - Program.g_Config._Contraste;

                try
                {
                    VSTwainHScanner.Contrast = VSTwainHScanner.ContrastMaxValue / coeficiente;
                    log.Debug("     - VSTwainHScanner.Contrast = " +
                                        VSTwainHScanner.Contrast.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.Contrast", ex);
                }


                try
                {
                    umbralNoiseLevel = ((10f - (float)Program.g_Config._ContrasteDBP) / 10f);
                    if (umbralNoiseLevel == 0) umbralNoiseLevel = 0.01f;
                    log.Debug("     - umbralNoiseLevel = " + umbralNoiseLevel.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - umbralNoiseLevel", ex);
                }

                try
                {
                    if (Program.g_Config._PageSize.Equals("Tarjeta"))
                    {
                        VSTwainHScanner.PageSize = PageSize.BUSINESSCARD;
                    }
                    else if (Program.g_Config._PageSize.Equals("A4"))
                    {
                        VSTwainHScanner.PageSize = PageSize.A4;
                    }
                    else if (Program.g_Config._PageSize.Equals("Legal"))
                    {
                        VSTwainHScanner.PageSize = PageSize.USLEGAL;
                    }
                    else
                    {
                        VSTwainHScanner.PageSize = PageSize.USLETTER;
                    }
                    log.Debug("     - VSTwainHScanner.PageSize = " +
                              VSTwainHScanner.PageSize.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.PageSize", ex);
                }


                try
                {
                    if (Program.g_Config._PixelType.Equals("Color"))
                    {
                        VSTwainHScanner.PixelType = PixelType.RGB;
                        VSTwainHScanner.PdfImageCompression = PdfImageCompression.JPEG;
                        VSTwainHScanner.TiffCompression = TiffCompression.LZW;
                    }
                    else if (Program.g_Config._PixelType.Equals("Grises"))
                    {
                        VSTwainHScanner.PixelType = PixelType.GRAY;
                        VSTwainHScanner.PdfImageCompression = PdfImageCompression.LZW;
                        VSTwainHScanner.TiffCompression = TiffCompression.LZW;
                    }
                    else
                    {
                        VSTwainHScanner.PixelType = PixelType.BW;
                        VSTwainHScanner.PdfImageCompression = PdfImageCompression.CcittFax;
                        VSTwainHScanner.TiffCompression = TiffCompression.CCITGroup4;
                    }
                    log.Debug("     - VSTwainHScanner.PixelType = " +
                                    VSTwainHScanner.PixelType.ToString() +
                                    " - VSTwainHScanner.PdfImageCompression = " +
                                    VSTwainHScanner.PdfImageCompression.ToString() +
                                    " - VSTwainHScanner.TiffCompression = " +
                                    VSTwainHScanner.TiffCompression.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.PixelType/PdfImageCompression/TiffCompression", ex);
                }


                try
                {
                    VSTwainHScanner.UnitOfMeasure = UnitOfMeasure.Inches;
                    log.Debug("     - VSTwainHScanner.UnitOfMeasure = " +
                              VSTwainHScanner.UnitOfMeasure.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.UnitOfMeasure", ex);
                }

                try
                {
                    VSTwainHScanner.Resolution = Program.g_Config._DPI; // Convert.ToInt32(this.txtResolution.Text);
                    log.Debug("     - VSTwainHScanner.Resolution = " +
                              VSTwainHScanner.Resolution.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.Resolution", ex);
                }



                //if (VSTwainHScanner.Duplex != DuplexMode.None) VSTwainHScanner.DuplexEnabled = true;
                try
                {
                    if (VSTwainHScanner.Duplex != DuplexMode.None)
                        VSTwainHScanner.DuplexEnabled = this.ckkUsaDuplex.Checked;
                    log.Debug("     - VSTwainHScanner.DuplexEnabled = " +
                              VSTwainHScanner.DuplexEnabled.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.DuplexEnabled", ex);
                }


                try
                {
                    VSTwainHScanner.AutoCleanBuffer = true;
                    log.Debug("     - VSTwainHScanner.AutoCleanBuffer = " +
                              VSTwainHScanner.AutoCleanBuffer.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.AutoCleanBuffer", ex);
                }

                try
                {
                    VSTwainHScanner.MaxImages = 1;
                    log.Debug("     - VSTwainHScanner.MaxImages = " +
                              VSTwainHScanner.MaxImages.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.MaxImages", ex);
                }


                if (VSTwainHScanner.FeederPresent)
                {
                    log.Debug("     - VSTwainHScanner.FeederPresent = " +
                                  VSTwainHScanner.FeederPresent.ToString());
                    //Hago esto porque en algunos escaners, especialemtne los no ADF
                    //da error este seteo.
                    try
                    {
                        VSTwainHScanner.FeederEnabled = true;
                        log.Debug("     - VSTwainHScanner.FeederEnabled = " +
                                  VSTwainHScanner.FeederEnabled.ToString());
                    }
                    catch (Exception ex)
                    {
                        log.Error("btnDigitAuto_Click Error - VSTwainHScanner.FeederEnabled", ex);
                    }

                    try
                    {
                        VSTwainHScanner.AutoFeed = true;
                        log.Debug("     - VSTwainHScanner.AutoFeed = " +
                                  VSTwainHScanner.AutoFeed.ToString());
                    }
                    catch (Exception ex)
                    {
                        log.Error("btnDigitAuto_Click Error - VSTwainHScanner.AutoFeed", ex);
                    }

                    try
                    {
                        VSTwainHScanner.XferCount = -1;
                        log.Debug("     - VSTwainHScanner.XferCount = " +
                                  VSTwainHScanner.XferCount.ToString());
                    }
                    catch (Exception ex)
                    {
                        log.Error("btnDigitAuto_Click Error - VSTwainHScanner.XferCount", ex);
                    }
                }
                else
                {
                    log.Debug("     - VSTwainHScanner.FeederPresent = " +
                                  VSTwainHScanner.FeederPresent.ToString());
                }

                try
                {
                    VSTwainHScanner.FileFormat = FileFormat.Jpeg;
                    log.Debug("     - VSTwainHScanner.FileFormat = " +
                                  VSTwainHScanner.FileFormat.ToString());
                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.FileFormat", ex);
                }

                //try
                //{
                //    VSTwainHScanner.JpegQuality = Program.g_Config.;
                //    log.Debug("     - VSTwainHScanner.JpegQuality = " +
                //                  VSTwainHScanner.JpegQuality.ToString());
                //}
                //catch (Exception ex)
                //{
                //    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.JpegQuality", ex);
                //}


                //Formato Final
                try
                {
                    if (Program.g_Config._FinalType.Equals("PDF"))
                    {
                        extensionFinal = ".pdf";
                        fformat = ImageFileFormat.PDF;
                        //VSTwainHScanner.PdfDocumentInfo.Author = Program.g_CurrentUser.userid;
                        VSTwainHScanner.PdfDocumentInfo.CreationDate = DateTime.Now;
                        VSTwainHScanner.PdfDocumentInfo.Title = "Documento Digitalizado en OFP";
                        VSTwainHScanner.PdfDocumentInfo.Creator = "Digitalizador OFP";
                        //log.Debug("     - Formato Final = " + extensionFinal +
                        //                " - VSTwainHScanner.PdfDocumentInfo.Author = " +
                        //                VSTwainHScanner.PdfDocumentInfo.Author.ToString());
                    }
                    else if (Program.g_Config._FinalType.Equals("TIF"))
                    {
                        extensionFinal = ".tif";
                        fformat = ImageFileFormat.TIFF;
                        log.Debug("     - Formato Final = " + extensionFinal);
                    }
                    else if (Program.g_Config._FinalType.Equals("JPG"))
                    {
                        extensionFinal = ".jpg";
                        fformat = ImageFileFormat.JPEG;
                        log.Debug("     - Formato Final = " + extensionFinal);
                    }

                }
                catch (Exception ex)
                {
                    log.Error("btnDigitAuto_Click Error - VSTwainHScanner.JpegQuality", ex);
                }

                log.Debug("Fin Configuracion Escaner para captura! ");
                
                if (VSTwainHScanner.FeederLoaded){
                
                    log.Debug("Capturando...");
                    VSTwainHScanner.Acquire();
                }
                else{
                
                    log.Debug("No hay hojas en la bandeja [VSTwainHScanner.FeederLoaded = " +
                    VSTwainHScanner.FeederLoaded.ToString() + "]");
                    
                }
            }

            catch (TwainException ex)
            {
                log.Error("frmMain.btnDigitAuto_Click [TwainException]", ex);
                statusBarDigit.Panels[3].Text = "TwainException [" + ex.Message + "]";
            }
            catch (ImagingException ex)
            {
                log.Error("frmMain.btnDigitAuto_Click [ImagingException]", ex);
                statusBarDigit.Panels[3].Text = "ImagingException [" + ex.Message + "]";
            }
            
            catch (Exception ex)
            {
                log.Error("frmMain.btnDigitAuto_Click [Exception]", ex);
                statusBarDigit.Panels[3].Text = "Exception [" + ex.Message + "]";
            }

        }

        /// <summary>
        /// Actualiza progreso en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VSTwainHScanner_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (e.Action == Vintasoft.Twain.Action.Deskew) labAccion.Text = "Deskewing...";
                else if (e.Action == Vintasoft.Twain.Action.Despecle) labAccion.Text = "Despeckling...";
                else if (e.Action == Vintasoft.Twain.Action.BorderDetection) labAccion.Text = "Detectando bordes...";
                else if (e.Action == Vintasoft.Twain.Action.Rotation) labAccion.Text = "Rotando...";
                else if (e.Action == Vintasoft.Twain.Action.ImageScan) labAccion.Text = "Escaneando...";
                else if (e.Action == Vintasoft.Twain.Action.ImageSaving) labAccion.Text = "Grabando imágen a PDF/TIFF...";
                pbDigit.Value = (int)e.PercentComplete;
                e.Interrupt = g_flagStopImageProcessing;

                //if (pbDigit.Value == 100)
                //{
                //    pbDigit.Value = 0;
                //    statusBarRigth.Text = "";
                //}
            }
            catch (Exception ex)
            {
                //log.Error("frmMain.VSTwainHScanner_ProgressChanged", ex);
            }

        }

        /// <summary>
        /// Atiende evento de finalizacion de procesod e escaneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VSTwainHScanner_ScanCompletedEvent(object sender, EventArgs e)
        {
            if (VSTwainHScanner.ErrorCode != 0)
            {
                log.Error("frmMain.VSTwainHScanner_ScanCompletedEvent [VSTwain.ErrorCode=" +
                          VSTwainHScanner.ErrorString + "]");
                statusBarRigth.Text = "Error en proceso de escaneo [" + VSTwainHScanner.ErrorString + "]";
            }
            else
            {
                if (mem != null && mem.Length > 0)
                {
                    SaveDocumento(mem, pathCurrent);
                }
            }
            mfBtnRefresh_Click(null, null);
            VSTwainHScanner.CloseDataSource();
            pbDigit.Value = pbDigit.Maximum;
            labAccion.Text = "Proceso de escaneado Finalizado.";
            btnDigitAuto.Enabled = true;
            this.btnCancelar.Enabled = false;
            log.Debug("Fin de Captura! Ultimo archivo grabado = " + pathCurrent);

        }

        /// <summary>
        /// Atiende proceso de adquisicion de nueva imágen. Intenta reconocer BC, 
        /// y si lo hace, cierra el contenido hasta ese momento si existe, y genera 
        /// nuevo archivo con nombre igaul al BD reconocido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VSTwainHScanner_ImageAcquiredEvent(object sender, EventArgs e)
        {
            try
            {
                float currentNoiseLevel = 0;

                log.Debug("Antes de  obtener imagen " + DateTime.Now);

                Image image = VSTwainHScanner.GetCurrentImage();

                log.Debug("Despues de  obtener imagen " + DateTime.Now);

                if (chkDetectBlankPage.Checked)
                {
                    if (VSTwainHScanner.IsBlankImage(0, umbralNoiseLevel, ref currentNoiseLevel))
                    {
                        log.Debug("Pagina descartada con (umbralNoiseLevel=" +
                            umbralNoiseLevel.ToString() + "-currentNoiseLevel=" +
                            currentNoiseLevel.ToString());
                        return;  //Si esta habilitado el chequeo de deteccion de hojas en blanco
                        // y el chequeo supera el umbral definido => returna descartando
                        // la imágen tomada. Sino, sigue proceso normal.
                    }
                }


                IBarcodeInfo[] infos;
                //string resultString;
                // Extract barcodes 
                //log.Debug("Antes de  busca barra" + DateTime.Now);
                infos = BarcodeReaderBC.ReadBarcodes(image);
                //log.Debug("Despues de  busca barra" + DateTime.Now);
                //Si reconoce BC => Comienza uno nuevo
                if (infos != null && infos.Length != 0)
                {
                    log.Debug("Encontró barra" + DateTime.Now);

                    pageToDiscard = true && !Program.g_Config._saveCode;
                    //Si reconocio, pero no es first page, grabo lo 
                    //escaneado hasta ese momento, siempre que tenga 
                    //que grabar, porque puede ser reconocidas dos
                    //barcode seguidos, y no debería grabar nada en 
                    //ese caso.
                    if (!firstImage && mem != null)
                    {
                        //Grabo anterior imagen si existe
                        log.Debug("Grabo anterior imagen " + DateTime.Now);
                        SaveDocumento(mem, pathCurrent);
                    }
                    //Vuelvo a setear isFirst
                    firstImage = true;
                    pathCurrent = Program.g_Config._PathTmpLocal + "\\Reconocidos\\" +
//                                  Program.g_CurrentUser.userid + "_" +
                                  infos[0].Value.ToString() + extensionFinal;
                }
                else
                {
                    //Si no reconocio BC y es primera página, armo path para grabar
                    if (firstImage)
                    {
                        log.Debug("Es la primera imagen " + DateTime.Now);
                        pathCurrent = Program.g_Config._PathTmpLocal + "\\NoReconocidos\\" +
//                                      Program.g_CurrentUser.userid + "_" +
                                      DateTime.Now.ToString("yyyyMMddHHmmss") + extensionFinal;
                        while (File.Exists(pathCurrent))
                        {
                            pathCurrent = Program.g_Config._PathTmpLocal + "\\NoReconocidos\\" +
//                                          Program.g_CurrentUser.userid + "_" +
                                          DateTime.Now.ToString("yyyyMMddHHmmss") + extensionFinal;
                        }
                    }
                }

                if (firstImage)
                {
                    //Si reconocio codigo de barras => es colilla => descarta
                    if (!pageToDiscard)
                    {
                        log.Debug("Es la primera imagen y no se debe descartar " + DateTime.Now);
                        mem = VSTwainHScanner.GetImageAsStream(0, fformat);
                        firstImage = false;
                    }
                    else
                    {
                        pageToDiscard = false;
                    }
                    firstImage = false;
                }
                else
                {
                    //Chequeo que no sea la segunda hoja despues de un reconocimiento 
                    if (mem != null)
                    {
                        VSTwainHScanner.SaveImageToStream(0, mem, fformat);
                    }
                    else
                    {
                        mem = VSTwainHScanner.GetImageAsStream(0, fformat);
                    }



                }
            }
            catch (TwainException ex)
            {
                log.Error("frmMain.VSTwainHScanner_ImageAcquiredEvent [TwainException]", ex);
                statusBarDigit.Panels[3].Text = "TwainException [" + ex.Message + "]";
            }
            catch (ImagingException ex)
            {
                log.Error("frmMain.VSTwainHScanner_ImageAcquiredEvent [ImagingException]", ex);
                statusBarDigit.Panels[3].Text = "ImagingException [" + ex.Message + "]";
            }
            catch (Exception ex)
            {
                log.Error("frmMain.VSTwainHScanner_ImageAcquiredEvent [Exception]", ex);
                statusBarDigit.Panels[3].Text = "Exception [" + ex.Message + "]";
            }

            /*
             * 
                         try {
                float currentNoiseLevel = 0;
                
                if (!VSTwainHScanner.IsBlankImage(0, umbralNoiseLevel, ref currentNoiseLevel))
                {
                    Image image = VSTwainHScanner.GetCurrentImage();

                    IBarcodeInfo[] infos;
                    //string resultString;
                    // Extract barcodes 
                    infos = BarcodeReaderBC.ReadBarcodes(image);
                    //Si reconoce BC => Comienza uno nuevo
                    if (infos != null && infos.Length != 0)
                    {
                        pageToDiscard = true;
                        //Si reconocio, pero no es first page, grabo lo 
                        //escaneado hasta ese momento, siempre que tenga 
                        //que grabar, porque puede ser reconocidas dos
                        //barcode seguidos, y no debería grabar nada en 
                        //ese caso.
                        if (!firstImage && mem != null)
                        {
                            //Grabo anterior imagen si existe
                            SaveDocumento(mem, pathCurrent);
                        }
                        //Vuelvo a setear isFirst
                        firstImage = true;
                        pathCurrent = Program.g_Config._PathTmpLocal + "\\Reconocidos\\" +
                                      Program.g_CurrentUser.userid + "_" +
                                      infos[0].Value.ToString() + extensionFinal;
                    }
                    else
                    {
                        //Si no reconocio BC y es primera página, armo path para grabar
                        if (firstImage)
                        {
                            pathCurrent = Program.g_Config._PathTmpLocal + "\\NoReconocidos\\" +
                                          Program.g_CurrentUser.userid + "_" +
                                          DateTime.Now.ToString("yyyyMMddHHmmss") + extensionFinal;
                            while (File.Exists(pathCurrent))
                            {
                                pathCurrent = Program.g_Config._PathTmpLocal + "\\NoReconocidos\\" +
                                              Program.g_CurrentUser.userid + "_" +
                                              DateTime.Now.ToString("yyyyMMddHHmmss") + extensionFinal;
                            }
                        }
                    }

                    if (firstImage)
                    {
                        //Si reconocio codigo de barras => es colilla => descarta
                        if (!pageToDiscard)
                        {
                            mem = VSTwainHScanner.GetImageAsStream(0, fformat);
                            firstImage = false;
                        }
                        else
                        {
                            pageToDiscard = false;
                        }
                        firstImage = false;
                    }
                    else
                    {
                        //Chequeo que no sea la segunda hoja despues de un reconocimiento 
                        if (mem != null)
                        {
                            VSTwainHScanner.SaveImageToStream(0, mem, fformat);
                        }
                        else
                        {
                            mem = VSTwainHScanner.GetImageAsStream(0, fformat);
                        }
                    }
                }
            }
            catch (TwainException ex)
            {
                log.Error("frmMain.VSTwainHScanner_ImageAcquiredEvent [TwainException]", ex);
                statusBarDigit.Panels[3].Text = "TwainException [" + ex.Message + "]";
            }
            catch (ImagingException ex)
            {
                log.Error("frmMain.VSTwainHScanner_ImageAcquiredEvent [ImagingException]", ex);
                statusBarDigit.Panels[3].Text = "ImagingException [" + ex.Message + "]";
            }
            catch (Exception ex)
            {
                log.Error("frmMain.VSTwainHScanner_ImageAcquiredEvent [Exception]", ex);
                statusBarDigit.Panels[3].Text = "Exception [" + ex.Message + "]";
            }
             * 
             */

        }

        /// <summary>
        /// Metodo para almacenar archivo escaneado
        /// </summary>
        /// <param name="ms">Archivo a salvar</param>
        /// <param name="current">Path donde almacenar</param>
        private void SaveDocumento(MemoryStream ms, string current)
        {
            try
            {
                //Save ms is your memoryStream
                FileStream fs = File.OpenWrite(current);
                /* could replace with GetBuffer() if you don't mind the padding, or you
                could set Capacity of ms to Position to crop the padding out of the
                buffer.*/
                byte[] byMem = ms.ToArray();
                fs.Write(byMem, 0, byMem.Length);
                fs.Close();
                mem.Close();
                mem = null;
            }
            catch (Exception ex)
            {
                statusBarDigit.Panels[3].Text = "Error SaveDocumento [" + ex.Message + "]";
                log.Error("frmMain.SaveDocumento", ex);
            }
        }

        /// <summary>
        /// Cancela el proceso de escaneo en ejecución.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            g_flagStopImageProcessing = true;
            SetAccion("Proceso de escaneo cancelado!");
            btnDigitAuto.Enabled = true;
            btnCancelar.Enabled = false;
        }
        #endregion Escanner TWAIN

        #region TreeDocs Area

        /// <summary>
        /// Visualiza el documento seleccionado si es documento, o sino limpia 
        /// pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewDocs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewDocs.SelectedNode.Tag != null)
            {
                if (File.Exists((string)treeViewDocs.SelectedNode.Tag))
                {
                    ViewFile(treeViewDocs.SelectedNode.Tag);
                }
                else
                {
                    InitImages(0);
                }
            }
            else
            {
                InitImages(0);
            }
        }

        /// <summary>
        /// Inicializa pantalla, dependiendo de que operacion se 
        /// desea ejecutar.
        /// </summary>
        /// <param name="flag"></param>
        private void InitImages(int flag)
        {
            switch (flag)
            {
                case 1: //Es TIFF
                    labTIFFMultipagina.Text = "";
                    grpBotonerTIFF.Visible = true;
                    grpBotonerTIFF.Enabled = true;
                    //splitContainerImages.Panel1Collapsed = false;

                    //axAcroPDFViewer.Dispose();
                    axAcroPDFViewer.Visible = false;
                    axAcroPDFViewer.SendToBack();

                    //picSelected.Dispose();
                    scalablePicSelected.Picture = null;
                    scalablePicSelected.Visible = true;
                    scalablePicSelected.BringToFront();

                    picSelected.Image = null;
                    picSelected.Visible = true;
                    picSelected.BringToFront();
                    break;
                case 2: //Es PDF
                    labTIFFMultipagina.Text = "";
                    grpBotonerTIFF.Visible = false;
                    grpBotonerTIFF.Enabled = false;
                    //splitContainerImages.Panel1Collapsed = true;

                    //axAcroPDFViewer.Dispose();
                    axAcroPDFViewer.Visible = true;
                    axAcroPDFViewer.BringToFront();

                    //picSelected.Dispose();
                    scalablePicSelected.Picture = null;
                    scalablePicSelected.Visible = false;
                    scalablePicSelected.SendToBack();

                    picSelected.Image = null;
                    picSelected.Visible = false;
                    picSelected.SendToBack();
                    break;
                default:
                    labTIFFMultipagina.Text = "";
                    grpBotonerTIFF.Visible = false;
                    grpBotonerTIFF.Enabled = false;
                    //splitContainerImages.Panel1Collapsed = true;

                    axAcroPDFViewer.Visible = false;
                    //axAcroPDFViewer.Dispose();

                    //picSelected.Dispose();
                    currentImageTIFFMultiPagina = null;
                    currentHojaOfImageTIFFMultiPagina = null;
                    //if (scalablePicSelected.Picture != null) scalablePicSelected.Picture.Dispose();
                    scalablePicSelected.Picture = null;
                    scalablePicSelected.Visible = true;
                    scalablePicSelected.BringToFront();
                    picSelected.Visible = true;
                    picSelected.Image = null;
                    picSelected.BringToFront();

                    if (currentImageTIFFMultiPagina != null) currentImageTIFFMultiPagina.Dispose();
                    currentImageTIFFMultiPagina = null;
                    if (currentHojaOfImageTIFFMultiPagina != null) currentHojaOfImageTIFFMultiPagina.Dispose();
                    currentHojaOfImageTIFFMultiPagina = null;
                    break;
            }
        }

        private int intCurrPage = 1; // defining the current page (its some sort of a counter)
        private int intPages = 1; // defining the current page (its some sort of a counter)
        private string strCurrentPath = null;
        private FileStream fsCurrentTIFF = null;

        /// <summary>
        /// Visualiza un archivo TIFF o PDF dependiendo de su extensión.
        /// </summary>
        /// <param name="path">Path absoluto del archivoa  visualizar.</param>
        private void ViewFile(object path)
        {
            if (path != null)
            {
                string spath = (string)path;
                FileInfo fi = new FileInfo(spath);
                if (fi.Extension.ToUpper().Equals(".TIF") || fi.Extension.ToUpper().Equals(".TIFF"))
                {
                    InitImages(1);
                    //Seto 1ra pagina
                    intCurrPage = 1;
                    //Levanto TIFF
                    if (fsCurrentTIFF != null) fsCurrentTIFF.Close();
                    fsCurrentTIFF = new FileStream(@spath, FileMode.Open, FileAccess.Read);
                    //Bitmap bmp = new Bitmap(fs);
                    //fs.Close();

                    //currentImageTIFFMultiPagina = bmp; // Image.FromFile(@spath);
                    currentImageTIFFMultiPagina = Image.FromStream(fsCurrentTIFF);
                    ////Calculo cantidad total de páginas
                    intPages = currentImageTIFFMultiPagina.GetFrameCount(System.Drawing.Imaging.FrameDimension.Page);
                    //Resto uno para empezar desde 0
                    //intPages--;
                    strCurrentPath = (string)path;
                    RefreshImage();
                }
                else if (fi.Extension.ToUpper().Equals(".PDF"))
                {
                    InitImages(2);
                    axAcroPDFViewer.LoadFile(spath);
                }
                else
                {
                    InitImages(0);
                }
            }
            else
            {
                InitImages(0);
            }
        }

        /// <summary>
        /// Refresca la imágen del archivo TIFF seleccionado para visualizar.
        /// </summary>
        public void RefreshImage()
        {
            try
            {
                //Fromateo contador
                labTIFFMultipagina.Text = "Página " + Convert.ToString(intCurrPage) +
                                          " de " + Convert.ToString(intPages);
                //Selecciono la página
                currentImageTIFFMultiPagina.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Page, intCurrPage - 1); // going to the selected page
                //Extraigo hola seleccionada
                currentHojaOfImageTIFFMultiPagina = new Bitmap(currentImageTIFFMultiPagina); // setting the new page as an image
                //Muestro hoja
                scalablePicSelected.Picture = currentHojaOfImageTIFFMultiPagina;
            }
            catch (Exception ex)
            {
                log.Error("Error abriendo archivo TIFF.", ex);
                statusBarDigit.Panels[3].Text = ex.Message;
            }
            //scalablePicSelected.PerformAutoScale();
        }

        /// <summary>
        /// Visualiza la primera página del archivo TIFF selecionado para visualizar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrimera_Click(object sender, EventArgs e)
        {
            intCurrPage = 1;
            RefreshImage();
        }

        /// <summary>
        /// Visualiza la página anterior a la actual de un archivo TIFF seleccionado
        /// para visualizar. Si es la primra página, queda visualizando la misma página.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (intCurrPage == 1) // it stops here if you reached the bottom, the first page of the tiff
            { intCurrPage = 1; }
            else
            {
                intCurrPage--; // if its not the first page, then go to the previous page
                RefreshImage(); // refresh the image on the selected page
            }
        }

        /// <summary>
        /// Visualiza la siguiente página a la actual, de un archivo TIFF seleccionado para 
        /// visualizar. Si es la última, queda visualizando esa misma página.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (intCurrPage == intPages) // if you have reached the last page it ends here
            // the "-1" should be there for normalizing the number of pages
            { intCurrPage = intPages; }
            else
            {
                intCurrPage++;
                RefreshImage();
            }
        }

        /// <summary>
        /// Visualiza la última página de un archivo TIFF selecionado para 
        /// visualizar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUltima_Click(object sender, EventArgs e)
        {
            intCurrPage = intPages;
            RefreshImage();

        }

        /// <summary>
        /// Pemrite la visualización del menú flotante de acciones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewDocs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { //Check for right button click
                SetMenuFlotante(e.X, e.Y);
            }
            else
            {
                toolStripMenuFlotante.Visible = false;
            }
        }

        /// <summary>
        /// Muestra el menu flotante, con las acciones adecuadas dependiendo 
        /// del item seleccionado.
        /// </summary>
        /// <param name="x">Coordenada izquierda desde donde comienza a visualziarse el menu flotante</param>
        /// <param name="y">Coordenada superior desde donde comienza a visualziarse el menu flotante</param>
        private void SetMenuFlotante(int x, int y)
        {
            toolStripMenuFlotante.Left = x;
            toolStripMenuFlotante.Top = y;
            mfBtnBuscar.Visible = true;

            if (treeViewDocs.SelectedNode.Name.Equals("DocumentosLocales") ||
                treeViewDocs.SelectedNode.Name.Equals("Temporales"))
            {
                mfBtnEliminar.Visible = false;
                mfBtnEliminarTodo.Visible = true;
                mfBtnRenombrar.Visible = false;
                //mfBtnMoveToSend.Visible = false;
                mfBtnMoveToReconocido.Visible = false;
                mfBtnMoveToNoReconocido.Visible = false;
                //mfBtnSendToOFP.Visible = false;
                toolStripSeparator2.Visible = false;
            }
            else if (treeViewDocs.SelectedNode.Name.Equals("Reconocidos"))
            {
                mfBtnEliminar.Visible = false;
                mfBtnEliminarTodo.Visible = true;
                mfBtnRenombrar.Visible = false;
                //mfBtnMoveToSend.Visible = true;
                mfBtnMoveToReconocido.Visible = false;
                mfBtnMoveToNoReconocido.Visible = true;
                //mfBtnSendToOFP.Visible = false;
                toolStripSeparator2.Visible = true;
            }
            else if (treeViewDocs.SelectedNode.Name.Equals("NoReconocidos"))
            {
                mfBtnEliminar.Visible = false;
                mfBtnEliminarTodo.Visible = true;
                mfBtnRenombrar.Visible = false;
                //mfBtnMoveToSend.Visible = false;
                mfBtnMoveToReconocido.Visible = true;
                mfBtnMoveToNoReconocido.Visible = false;
                //mfBtnSendToOFP.Visible = false;
                toolStripSeparator2.Visible = true;
            }
            else if (treeViewDocs.SelectedNode.Name.Equals("ToSend"))
            {
                mfBtnEliminar.Visible = false;
                mfBtnEliminarTodo.Visible = true;
                mfBtnRenombrar.Visible = false;
                //mfBtnMoveToSend.Visible = false;
                mfBtnMoveToReconocido.Visible = true;
                mfBtnMoveToNoReconocido.Visible = true;
                //mfBtnSendToOFP.Visible = true;
                toolStripSeparator2.Visible = true;
            }
            else if (treeViewDocs.SelectedNode.Name.Equals("Sended"))
            {
                mfBtnEliminar.Visible = false;
                mfBtnEliminarTodo.Visible = true;
                mfBtnRenombrar.Visible = false;
                //mfBtnMoveToSend.Visible = false;
                mfBtnMoveToReconocido.Visible = false;
                mfBtnMoveToNoReconocido.Visible = false;
                //mfBtnSendToOFP.Visible = false;
                toolStripSeparator2.Visible = false;
            }
            else   //Es un item, un documento, no un directorio
            {
                TreeNode tn = treeViewDocs.SelectedNode;
                TreeNode padre = tn.Parent;

                mfBtnEliminar.Visible = true;
                mfBtnEliminarTodo.Visible = false;
                mfBtnBuscar.Visible = false;

                if (padre.Name.Equals("NoReconocidos"))
                {
                    mfBtnRenombrar.Visible = true;
                    //mfBtnMoveToSend.Visible = false;
                    mfBtnMoveToReconocido.Visible = true;
                    mfBtnMoveToNoReconocido.Visible = false;
                    //mfBtnSendToOFP.Visible = false;
                    toolStripSeparator2.Visible = true;
                }
                else
                {
                    mfBtnRenombrar.Visible = false;
                }

                if (padre.Name.Equals("Reconocidos"))
                {
                    //mfBtnMoveToSend.Visible = true;
                    mfBtnMoveToReconocido.Visible = false;
                    mfBtnMoveToNoReconocido.Visible = true;
                    toolStripSeparator2.Visible = true;
                    //mfBtnSendToOFP.Visible = false;
                }

                if (padre.Name.Equals("ToSend"))
                {
                    //mfBtnMoveToSend.Visible = false;
                    mfBtnMoveToReconocido.Visible = true;
                    mfBtnMoveToNoReconocido.Visible = true;
                    //mfBtnSendToOFP.Visible = false;
                    toolStripSeparator2.Visible = true;
                }

                if (padre.Name.Equals("Sended"))
                {
                    //mfBtnMoveToSend.Visible = false;
                    mfBtnMoveToReconocido.Visible = false;
                    mfBtnMoveToNoReconocido.Visible = false;
                    toolStripSeparator2.Visible = false;
                    //mfBtnSendToOFP.Visible = false;
                }
            }

            toolStripMenuFlotante.BringToFront();
            toolStripMenuFlotante.Visible = true;
        }

        //Variables de retorno desde form auxiliar para menu flotante
        public int rtaFromFormAux = 0;
        public string strFromFormAux = "";

        /// <summary>
        /// Elimina un archivo seleccionado en el arbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mfBtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode tn = treeViewDocs.SelectedNode;
                TreeNode padre = tn.Parent;
                if (MessageBox.Show("Está seguro de eliminar el documento " + tn.Name +
                                    " de la carpeta " + padre.Name + " ?",
                                    "Confirmación...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    if (fsCurrentTIFF != null) fsCurrentTIFF.Close();
                    File.Delete((string)tn.Tag);
                    padre.Nodes.Remove(tn);
                }
            }
            catch (Exception ex)
            {
                log.Error("Error elimianndo archivo", ex);
                this.statusBarDigit.Panels[3].Text = ex.Message;
            }
            toolStripMenuFlotante.Visible = false;

        }

        /// <summary>
        /// Refresca la estructura del arbol leyendo los archivos dentro de la 
        /// estructura de directorios definida en el configurador del digitalizador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mfBtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //Elimino lo actual
                TreeNode TNRoot = treeViewDocs.Nodes.Find("DocumentosLocales", true)[0];
                TreeNode TNNode = TNRoot.Nodes.Find("Reconocidos", true)[0];
                TNNode.Nodes.Clear();
                TNNode = TNRoot.Nodes.Find("Reconocidos", true)[0];
                TNNode.Nodes.Clear();
                TNNode = TNRoot.Nodes.Find("NoReconocidos", true)[0];
                TNNode.Nodes.Clear();
                //TNNode = TNRoot.Nodes.Find("ToSend", true)[0];
                //TNNode.Nodes.Clear();
                //TNNode = TNRoot.Nodes.Find("Sended", true)[0];
                //TNNode.Nodes.Clear();

                //Cargo de nuevo
                CargarDocsTmp();
            }
            catch (Exception ex)
            {
                log.Error("Error refresacando documentos", ex);
                //this.statusBarDigit.Panels[3].Text = ex.Message;
            }
            //Oculto Menu Flotante
            toolStripMenuFlotante.Visible = false;

        }

        /// <summary>
        /// Busca un archivo dentro del subarbol seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void mfBtnBuscar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        TreeNode TRoot = treeViewDocs.SelectedNode;
        //        //TreeNode padre = tn.Parent;

        //        ShowFormAux(sender, 2, null);
        //        if (rtaFromFormAux != 0)  //Si no canceló
        //        {

        //            //Cargo documentos reconocidos.
        //            TreeNode[] TNNodeBuscado = TRoot.Nodes.Find(strFromFormAux, true);

        //            if (TNNodeBuscado.Length == 0)
        //            {
        //                statusBarDigit.Panels[3].Text = "No existe documento con el nombre " +
        //                                                strFromFormAux + " enb la carpeta " +
        //                                                TRoot.Name;
        //            }
        //            else
        //            {
        //                treeViewDocs.HideSelection = false;
        //                treeViewDocs.SelectedNode = TNNodeBuscado[0];
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("Error buscando dcumento", ex);
        //        statusBarDigit.Panels[3].Text = ex.Message;
        //    }
        //    //Oculto Menu Flotante
        //    toolStripMenuFlotante.Visible = false;
        //}

        /// <summary>
        /// Renombra un archivo seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void mfBtnRenombrar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        TreeNode tn = treeViewDocs.SelectedNode;
        //        TreeNode padre = tn.Parent;

        //        ShowFormAux(sender, 1, tn.Name.Split('.')[0]);
        //        if (rtaFromFormAux != 0)  //Si no canceló
        //        {
        //            FileInfo fi = new FileInfo((string)tn.Tag);
        //            if (File.Exists(fi.Directory + "\\" + this.strFromFormAux))
        //            {
        //                MessageBox.Show("El archivo " + fi.Directory + "\\" + this.strFromFormAux +
        //                                " ya existe. Seleccione otro nombre...", "Atención...",
        //                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        //            }
        //            else
        //            {
        //                if (fsCurrentTIFF != null) fsCurrentTIFF.Close();
        //                fi.MoveTo(fi.Directory + "\\" + this.strFromFormAux + fi.Extension);
        //                tn.Name = strFromFormAux + fi.Extension;
        //                tn.Tag = fi.Directory + "\\" + this.strFromFormAux + fi.Extension;
        //                mfBtnRefresh_Click(null, null);
        //                treeViewDocs.SelectedNode = treeViewDocs.Nodes.Find(this.strFromFormAux + fi.Extension, true)[0];
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("Error renombrando archivo", ex);
        //        this.statusBarDigit.Panels[3].Text = ex.Message;
        //    }

        //    toolStripMenuFlotante.Visible = false;
        //}

        ///// <summary>
        ///// Muestra ventana de ingreso de datos para algunas acciones como renombrar
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="flag"></param>
        //private void ShowFormAux(object sender, int flag, string txtInit)
        //{
        //    rtaFromFormAux = 0;
        //    strFromFormAux = "";

        //    frmAuxMenuFlotante frmAux = new frmAuxMenuFlotante();
        //    frmAux.flag = flag;
        //    frmAux.formPrincipal = this;
        //    frmAux.txtInit = txtInit;
        //    frmAux.ShowDialog(this);
        //}

        /// <summary>
        /// Elimina todos los archivos de un subarbol seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mfBtnEliminarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                SetAccion("Elimiando todos los documentos...");
                TreeNode TRoot = treeViewDocs.SelectedNode;
                treeViewDocs.SelectedNode = treeViewDocs.Nodes[0];
                //TreeNode padre = TRoot.Parent;
                if (MessageBox.Show("Está seguro de eliminar todos los documentos" +
                                    " de la carpeta " + TRoot.Name + " ?",
                                    "Confirmación...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    if (fsCurrentTIFF != null) fsCurrentTIFF.Close();
                    EliminaDocumentosInSubFolder(TRoot);
                    mfBtnRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                log.Error("Error elimanndo todos los documentos", ex);
                this.statusBarDigit.Panels[3].Text = ex.Message;
            }

            SetAccion("Eliminación de todos los documentos Finalizada.");
            //Oculto Menu Flotante
            toolStripMenuFlotante.Visible = false;

        }

        /// <summary>
        /// Rutina recursiva que elimina docuemtnos dentro de una carpeta 
        /// y dentro de sus subcarpetas.
        /// </summary>
        /// <param name="root">Nodo inicial</param>
        private void EliminaDocumentosInSubFolder(TreeNode root)
        {
            try
            {
                foreach (TreeNode TNItem in root.Nodes)
                {
                    if (TNItem.ImageIndex != 4) //Si es distinto de carpeta
                    {
                        if (TNItem.Tag != null)
                        {
                            FileInfo fi = new FileInfo(((string)TNItem.Tag));
                            UpdateAccion("Eliminando " + fi.Name + "...", 1);
                            fi.Delete();
                        }
                        //root.Nodes.Remove(TNItem);
                    }
                    else
                    {
                        EliminaDocumentosInSubFolder(TNItem);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Error elimando todos los documentos", ex);
                this.statusBarDigit.Panels[3].Text = ex.Message;
            }
        }

        /// <summary>
        /// Mueve el archivo o todos (si es un durectorio el nodo seleccionado)
        /// al directorio de Reconocidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mfBtnMoveToReconocido_Click(object sender, EventArgs e)
        {
            try
            {
                SetAccion("Moviendo documentos...");
                TreeNode TRoot = treeViewDocs.SelectedNode;
                treeViewDocs.SelectedNode = treeViewDocs.Nodes[0];
                //TreeNode padre = TRoot.Parent;
                if (MessageBox.Show("Está seguro de mover el/los documento/s" +
                                    " a la carpeta de Reconocidos ?",
                                    "Confirmación...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    if (fsCurrentTIFF != null) fsCurrentTIFF.Close();
                    if (MoveDocumentosTo(TRoot, Program.g_Config._PathTmpLocal + "\\Reconocidos"))
                    {
                        MessageBox.Show(
                            "Algunos documentos no pudieron moverse. Verifique el log de operaciones para mas detalles...",
                            "Confirmación...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    mfBtnRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                log.Error("Error Moviendo documento/s a carpeta de Reconocidos", ex);
                this.statusBarDigit.Panels[3].Text = ex.Message;
            }
            SetAccion("Movimieno de documentos Finalizado.");
            //Oculto Menu Flotante
            toolStripMenuFlotante.Visible = false;

        }

        /// <summary>
        /// Rutinas auxiliares para mostrar avance en los procesos
        /// </summary>
        /// <param name="smsg"></param>
        private void SetAccion(string smsg)
        {
            labAccion.Text = smsg;
            labAccion.Refresh();
            pbDigit.Minimum = 1;
            pbDigit.Maximum = 10;
            pbDigit.Value = 1;
            //countAccion = 1;
            pbDigit.Step = 1;
            pbDigit.Refresh();
        }

        /// <summary>
        /// Rutinas auxiliares para mostrar avance en los procesos
        /// </summary>
        /// <param name="smsg"></param>
        /// <param name="cant"></param>
        private void UpdateAccion(string smsg, int cant)
        {
            if (smsg != null)
            {
                labAccion.Text = smsg;
                labAccion.Refresh();
            }
            pbDigit.Maximum += cant;
            pbDigit.Increment(1);
            pbDigit.Refresh();
        }

        /// <summary>
        /// Mueve un documento de un directorio a otro
        /// </summary>
        /// <param name="root">Archivo origen a mover</param>
        /// <param name="carpeta">Carpeta destino donde se movera el archivo</param>
        /// <returns></returns>
        private bool MoveDocumentosTo(TreeNode root, string carpeta)
        {
            bool bHayErrores = false;
            FileInfo fiaux = null;
            string filenameoriginal = null;
            try
            {
                if (root.ImageIndex != 4) //Si es distinto de carpeta
                {
                    if (root.Tag != null)
                    {
                        FileInfo fi = new FileInfo((string)root.Tag);
                        try
                        {
                            UpdateAccion("Moviendo " + fi.Name + "...", 1);
                            //Copio con marca de semaforo apra evitar problemas por si ejecuta el sender
                            filenameoriginal = fi.Name;
                            fi.MoveTo(carpeta + "\\" + fi.Name + ".sem");
                            //Renombro porque termino de copiar
                            fiaux = new FileInfo(carpeta + "\\" + fi.Name);
                            fiaux.MoveTo(carpeta + "\\" + filenameoriginal);
                        }
                        catch (Exception e)
                        {
                            log.Error("Error moviendo archivo " + fi.Name + " a carpeta " + carpeta, e);
                            bHayErrores = true;
                        }
                    }
                }
                else
                {
                    foreach (TreeNode TNItem in root.Nodes)
                    {
                        if (TNItem.ImageIndex != 4) //Si es distinto de carpeta
                        {
                            if (TNItem.Tag != null)
                            {
                                FileInfo fi = new FileInfo((string)TNItem.Tag);
                                try
                                {
                                    UpdateAccion("Moviendo " + fi.Name + "...", 1);
                                    //Copio con marca de semaforo apra evitar problemas por si ejecuta el sender                                    
                                    filenameoriginal = fi.Name;
                                    fi.MoveTo(carpeta + "\\" + fi.Name + ".sem");
                                    //Renombro porque termino de copiar
                                    fiaux = new FileInfo(carpeta + "\\" + fi.Name);
                                    fiaux.MoveTo(carpeta + "\\" + filenameoriginal);
                                }
                                catch (Exception e)
                                {
                                    log.Error("Error moviendo archivo " + fi.Name + " a carpeta " + carpeta, e);
                                    bHayErrores = true;
                                }
                            }
                        }
                        else
                        {
                            bHayErrores = bHayErrores || MoveDocumentosTo(TNItem, carpeta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Error moviendo el/los documento/s a carpeta " + carpeta, ex);
                statusBarDigit.Panels[3].Text = ex.Message;
            }
            return bHayErrores;
        }

  
        // Ejemplo             "ORD 3187 S"

        //private String getDataForSql(String filename){
        
        //    String[] sAux = filename.Split(' ');

        //    //            String sres = sAux[0] + "|" + sAux[1] + "|" + "2010";
            
        //    String codTipoDoc = DBAdmin.getInstance().getCodTipoDoc(sAux[0]);
        //    String sres = codTipoDoc + "|" + sAux[1] + "|" + "2010";
        //    return sres;
        
        //}

        //private String getAlfrescoFilePath(String sParamSQL)
        //{

        //    String[] sAux = sParamSQL.Split('|');
        //    String sRes = "";
            
        //    DocPreingresado docpre = new DocPreingresado();
            
        //    docpre.TipoDoc = sAux[0];
        //    docpre.NroDoc  = sAux[1];
        //    DocFileAlfresco docalf = new DocFileAlfresco();
            
        //    DBAdmin db = DBAdmin.getInstance();
            
        //    docalf = db.getDocFileAlf(docpre);
            
        //    if (docalf != null)
        //        sRes = docalf.PathDoc; 
        //    return sRes;

        //}


        /// <summary>
        /// Mueve el archivo o todos (si es un durectorio el nodo seleccionado)
        /// al directorio de NO Reconocidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mfBtnMoveToNoReconocido_Click(object sender, EventArgs e)
        {
            try
            {
                SetAccion("Moviendo documentos...");
                TreeNode TRoot = treeViewDocs.SelectedNode;
                treeViewDocs.SelectedNode = treeViewDocs.Nodes[0];
                //TreeNode padre = TRoot.Parent;
                if (MessageBox.Show("Está seguro de mover el/los documento/s" +
                                    " a la carpeta de No Reconocidos ?",
                                    "Confirmación...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    if (fsCurrentTIFF != null) fsCurrentTIFF.Close();
                    if (MoveDocumentosTo(TRoot, Program.g_Config._PathTmpLocal + "\\NoReconocidos"))
                    {
                        MessageBox.Show(
                            "Algunos documentos no pudieron moverse. Verifique el log de operaciones para mas detalles...",
                            "Confirmación...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    mfBtnRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                log.Error("Error Moviendo documento/s a carpeta de No Reconocidos", ex);
                this.statusBarDigit.Panels[3].Text = ex.Message;
            }
            SetAccion("Movimiento de documentos Finalizado.");

            //Oculto Menu Flotante
            toolStripMenuFlotante.Visible = false;
        }

        /// <summary>
        /// Mueve el archivo o todos (si es un directorio el nodo seleccionado)
        /// al directorio de archivo LOCAL a Enviar a OFP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mfBtnMoveToSend_Click(object sender, EventArgs e)
        {
            try
            {
                SetAccion("Moviendo documentos...");
                TreeNode TRoot = treeViewDocs.SelectedNode;
                treeViewDocs.SelectedNode = treeViewDocs.Nodes[0];
                //TreeNode padre = TRoot.Parent;
                if (MessageBox.Show("Está seguro de mover el/los documento/s" +
                                    " a la carpeta de Documentos a Enviar a OFP ?",
                                    "Confirmación...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    if (fsCurrentTIFF != null) fsCurrentTIFF.Close();
                    if (MoveDocumentosTo(TRoot, Program.g_Config._PathToSend))
                    {
                        MessageBox.Show(
                            "Algunos documentos no pudieron moverse. Verifique el log de operaciones para mas detalles...",
                            "Confirmación...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    mfBtnRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                log.Error("Error Moviendo documento/s a carpeta para Enviar a OFP", ex);
                this.statusBarDigit.Panels[3].Text = ex.Message;
            }
            SetAccion("Movimiento de documentos Finalizado.");

            //Oculto Menu Flotante
            toolStripMenuFlotante.Visible = false;
        }

        /// <summary>
        /// Mueve el archivo o todos (si es un directorio el nodo seleccionado)
        /// al directorio de archivo REMOTO a Enviar a OFP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mfBtnMoveToSendRed_Click(object sender, EventArgs e)
        {
            try
            {
                SetAccion("Moviendo documentos a directorio remoto...");
                TreeNode TRoot = treeViewDocs.SelectedNode;
                treeViewDocs.SelectedNode = treeViewDocs.Nodes[0];
                //TreeNode padre = TRoot.Parent;
                if (MessageBox.Show("Está seguro de mover el/los documento/s" +
                                    " a la carpeta de Documentos a Enviar a OFP Remoto ?",
                                    "Confirmación...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    if (fsCurrentTIFF != null) fsCurrentTIFF.Close();
                    //if (MoveDocumentosToEXEDOC(TRoot, Program.g_Config._PathToSendNetwork))
                    //{
                    //    MessageBox.Show(
                    //        "Algunos documentos no pudieron moverse. Verifique el log de operaciones para mas detalles...",
                    //        "Confirmación...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    log.Info("Algunos documentos no pudieron moverse.");
                    //}
                    //mfBtnRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                log.Error("Error Moviendo documento/s a carpeta para Enviar a OFP Remoto", ex);
                this.statusBarDigit.Panels[3].Text = ex.Message;
            }
            SetAccion("Movimiento de documentos a directorio remoto Finalizado.");

            //Oculto Menu Flotante
            toolStripMenuFlotante.Visible = false;
        }

        /// <summary>
        /// Abre el manual del usuario en pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mfBtnAyuda_Click(object sender, EventArgs e)
        {
            try
            {
                //frmHelp frmh = new frmHelp();
                //frmh.ShowDialog(this);
            }
            catch (Exception ex)
            {
                log.Error("Error mostrando Ayuda", ex);
                this.statusBarDigit.Panels[3].Text = ex.Message;
            }
            //Oculto Menu Flotante
            toolStripMenuFlotante.Visible = false;
        }

        /// <summary>
        /// Envía el documento seleccionado o todos los de la carpeta si se está parado
        /// encima de la carpeta de envio, al sistema de OFP. Utiliza la misma rutina
        /// que el proceso barch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void mfBtnSendToOFPViaFileCopy_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SetAccion("Enviando documentos a OFP...");
        //        TreeNode TRoot = treeViewDocs.SelectedNode;
        //        treeViewDocs.SelectedNode = treeViewDocs.Nodes[0];
        //        //TreeNode padre = TRoot.Parent;
        //        if (MessageBox.Show("Está seguro de enviar el/los documento/s" +
        //                            " al sistema de Oficina de Partes ? (Puede congestionar la red!)",
        //                            "Confirmación...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        //            == System.Windows.Forms.DialogResult.Yes)
        //        {
        //            if (fsCurrentTIFF != null) fsCurrentTIFF.Close();
        //            string pathlog = null;
        //            if (Digitalizador.sender.sender.SendToOFPA(this.pbDigit, out pathlog))
        //            {
        //                MessageBox.Show("Envío realizado con éxito!!", "Confirmación...",
        //                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                log.Info("Envío de " + Program.g_CurrentUser.userid + " realizado con éxito!!");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Existieron errores en el procveso de envío. Verifique en el resúmen de operación ubicado en: " +
        //                                pathlog + " para mas detalles.", "Atención...",
        //                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                log.Info("Existieron errores en el procveso de envío de " + Program.g_CurrentUser.userid +
        //                         ". Verifique en el resúmen de operación ubicado en: " +
        //                         pathlog + " para mas detalles.");
        //            }
        //            mfBtnRefresh_Click(null, null);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("Error enviando documento/s al sistema de OFP", ex);
        //        this.statusBarDigit.Panels[3].Text = ex.Message;
        //    }
        //    SetAccion("Envío de documentos Finalizado.");

        //    //Oculto Menu Flotante
        //    toolStripMenuFlotante.Visible = false;
        //}
        
        //private void mfBtnSendToOFPViaWs_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SetAccion("Enviando documentos a OFP...");
        //        TreeNode TRoot = treeViewDocs.SelectedNode;
        //        treeViewDocs.SelectedNode = treeViewDocs.Nodes[0];
        //        //TreeNode padre = TRoot.Parent;
        //        if (MessageBox.Show("Está seguro de enviar el/los documento/s" +
        //                            " al sistema de Oficina de Partes ? (Puede congestionar la red!)",
        //                            "Confirmación...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        //            == System.Windows.Forms.DialogResult.Yes)
        //        {
        //            if (fsCurrentTIFF != null) fsCurrentTIFF.Close();
        //            string pathlog = null;
        //            if (Digitalizador.sender.sender.SendToOFPA(this.pbDigit, out pathlog))
        //            {
        //                MessageBox.Show("Envío realizado con éxito!!", "Confirmación...",
        //                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                log.Info("Envío de " + Program.g_CurrentUser.userid + " realizado con éxito!!");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Existieron errores en el procveso de envío. Verifique en el resúmen de operación ubicado en: " +
        //                                pathlog + " para mas detalles.", "Atención...",
        //                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                log.Info("Existieron errores en el procveso de envío de " + Program.g_CurrentUser.userid +
        //                         ". Verifique en el resúmen de operación ubicado en: " +
        //                         pathlog + " para mas detalles.");
        //            }
        //            mfBtnRefresh_Click(null, null);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("Error enviando documento/s al sistema de OFP", ex);
        //        this.statusBarDigit.Panels[3].Text = ex.Message;
        //    }
        //    SetAccion("Envío de documentos Finalizado.");

        //    //Oculto Menu Flotante
        //    toolStripMenuFlotante.Visible = false;
        //}


        #endregion TreeDocs Area

        #region Formulario
        private void frmMain_Load(object sender, EventArgs e)
        {
            CargarDocsTmp();

            CenterGRP(grpDigitalizacion);
            //CenterGRP(grpConfigDigit);
            //CenterGRP(grpConfigSenderInterno);

            statusBarLeft.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
            //statusBarCenterRigth.Text = "Usuario: " + Program.g_CurrentUser.nombre + " " +
            //                            Program.g_CurrentUser.apellido;

            statusBarCenterLeft.Text = "Hora: " + DateTime.Now.ToString("HH:mm");
            timer1.Enabled = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VSTwainHScanner != null)
                VSTwainHScanner.StopDevice();
        }

        private void CargarDocsTmp()
        {
            //treeViewDocs.Nodes.Clear();
            treeViewDocs.HideSelection = false;

            //Agregar un nodo principal  

            TreeNode TNRoot = treeViewDocs.Nodes.Find("DocumentosLocales", true)[0];

            //Cargo documentos reconocidos.
            TreeNode TNReconocidos = TNRoot.Nodes.Find("Reconocidos", true)[0];
            //Chequeo si existe, sino lo creo.
            if (!Directory.Exists(Program.g_Config._PathTmpLocal + "\\Reconocidos"))
            {
                Directory.CreateDirectory(Program.g_Config._PathTmpLocal + "\\Reconocidos");
            }
            DirectoryInfo DirTNReconocidos = new DirectoryInfo(Program.g_Config._PathTmpLocal + "\\Reconocidos");
            //Obtener documentos en carpeta  
            int indexImg = 0;
            foreach (FileInfo file in DirTNReconocidos.GetFiles())
            {
                if (file.Extension.ToUpper().Equals(".TIF") || file.Extension.ToUpper().Equals(".TIFF"))
                {
                    indexImg = 3;
                }
                else if (file.Extension.ToUpper().Equals(".PDF"))
                {
                    indexImg = 5;
                }
                else
                {
                    indexImg = 0;
                }
                if (indexImg > 0)
                {
                    TreeNode NFile = new TreeNode(file.Name, indexImg, indexImg);
                    NFile.Name = file.Name;
                    NFile.Tag = file.FullName;
                    NFile.ToolTipText = "Tamaño = " + (file.Length / 1024).ToString() + "Kb";
                    TNReconocidos.Nodes.Add(NFile);
                }
            }

            //Cargo documentos NO reconocidos.
            TreeNode TNNoReconocidos = TNRoot.Nodes.Find("NoReconocidos", true)[0];
            //Chequeo si existe, sino lo creo.
            if (!Directory.Exists(Program.g_Config._PathTmpLocal + "\\NoReconocidos"))
            {
                Directory.CreateDirectory(Program.g_Config._PathTmpLocal + "\\NoReconocidos");
            }
            DirectoryInfo DirTNNoReconocidos = new DirectoryInfo(Program.g_Config._PathTmpLocal + "\\NoReconocidos");
            //Obtener documentos en carpeta  
            indexImg = 0;
            foreach (FileInfo file in DirTNNoReconocidos.GetFiles())
            {
                if (file.Extension.ToUpper().Equals(".TIF") || file.Extension.ToUpper().Equals(".TIFF"))
                {
                    indexImg = 3;
                }
                else if (file.Extension.ToUpper().Equals(".PDF"))
                {
                    indexImg = 5;
                }
                else
                {
                    indexImg = 0;
                }
                if (indexImg > 0)
                {
                    TreeNode NFile = new TreeNode(file.Name, indexImg, indexImg);
                    NFile.Name = file.Name;
                    NFile.Tag = file.FullName;
                    NFile.ToolTipText = "Tamaño = " + (file.Length / 1024).ToString() + "Kb";
                    TNNoReconocidos.Nodes.Add(NFile);
                }
            }

            //Cargo documentos en ToSend.
            //TreeNode TNToSend = TNRoot.Nodes.Find("ToSend", true)[0];
            ////Chequeo si existe, sino lo creo.
            //if (!Directory.Exists(Program.g_Config._PathToSend))
            //{
            //    Directory.CreateDirectory(Program.g_Config._PathToSend);
            //}
            //DirectoryInfo DirTNToSend = new DirectoryInfo(Program.g_Config._PathToSend);
            ////Obtener documentos en carpeta  
            //indexImg = 0;
            //foreach (FileInfo file in DirTNToSend.GetFiles())
            //{
            //    if (file.Extension.ToUpper().Equals(".TIF") || file.Extension.ToUpper().Equals(".TIFF"))
            //    {
            //        indexImg = 3;
            //    }
            //    else if (file.Extension.ToUpper().Equals(".PDF"))
            //    {
            //        indexImg = 5;
            //    }
            //    else
            //    {
            //        indexImg = 0;
            //    }
            //    if (indexImg > 0)
            //    {
            //        TreeNode NFile = new TreeNode(file.Name, indexImg, indexImg);
            //        NFile.Name = file.Name;
            //        NFile.Tag = file.FullName;
            //        NFile.ToolTipText = "Tamaño = " + (file.Length / 1024).ToString() + "Kb";
            //        TNToSend.Nodes.Add(NFile);
            //    }
            //}

            ////Cargo documentos en Sended.
            //TreeNode TNSended = TNRoot.Nodes.Find("Sended", true)[0];
            ////Chequeo si existe, sino lo creo.
            //if (!Directory.Exists(Program.g_Config._PathSended))
            //{
            //    Directory.CreateDirectory(Program.g_Config._PathSended);
            //}
            //DirectoryInfo DirTNSended = new DirectoryInfo(Program.g_Config._PathSended);
            ////Obtener documentos en carpeta  
            //indexImg = 0;
            //foreach (FileInfo file in DirTNSended.GetFiles())
            //{
            //    if (file.Extension.ToUpper().Equals(".TIF") || file.Extension.ToUpper().Equals(".TIFF"))
            //    {
            //        indexImg = 3;
            //    }
            //    else if (file.Extension.ToUpper().Equals(".PDF"))
            //    {
            //        indexImg = 5;
            //    }
            //    else
            //    {
            //        indexImg = 0;
            //    }
            //    if (indexImg > 0)
            //    {
            //        TreeNode NFile = new TreeNode(file.Name, indexImg, indexImg);
            //        NFile.Name = file.Name;
            //        NFile.Tag = file.FullName;
            //        NFile.ForeColor = Color.Gray;
            //        NFile.ToolTipText = "Tamaño = " + (file.Length / 1024).ToString() + "Kb";
            //        TNSended.Nodes.Add(NFile);
            //    }
            //}

            //Expandir el nodo Raiz  
            treeViewDocs.Nodes[0].ExpandAll();

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            //CenterGRP(grpConfigDigit);
            //CenterGRP(grpConfigSenderInterno);
            CenterGRP(grpDigitalizacion);
        }

        private void CenterGRP(GroupBox grp)
        {
            int left = panel1.Left + ((panel1.Width - grp.Width) / 2);
            int top = panel1.Top + ((panel1.Height - grp.Height) / 2);
            grp.Location = new Point(left, top);
            Refresh();
        }

        private void cboScanner_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboTamanioHoja_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBarCenterLeft.Text = "Hora: " + DateTime.Now.ToString("HH:mm");
        }

        #endregion Formulario

        #region Menu Principal

        /// <summary>
        /// Visualiza la pantalla de digitalizacion desde el menu principal superior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DigitAuto_Click(object sender, EventArgs e)
        {
            grpDigitalizacion.Visible = true;
            grpConfigDigitalizador.Visible = false;

            //CenterGRP(grpConfigDigit);
            //Ocultar el resto cuando exista
        }

        /// <summary>
        /// Visualiza la pantalla de Acerca de desde emnu superior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void AcercaDe_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        frmAcercaDe frmAD = new frmAcercaDe();
        //        frmAD.ShowDialog(this);
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("Error mostrando Acerca De...", ex);
        //        statusBarDigit.Panels[3].Text = ex.Message;
        //    }
        //}

        /// <summary>
        /// Visualiza el manual del usuario desde el menu principal superior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                //frmHelp frmh = new frmHelp();
                //frmh.ShowDialog(this);
            }
            catch (Exception ex)
            {
                log.Error("Error mostrando Ayuda", ex);
                statusBarDigit.Panels[3].Text = ex.Message;
            }
        }

        /// <summary>
        /// Visualiza la pantalla de configuracion desde el menu principal superior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigDigit_Click(object sender, EventArgs e)
        {
            grpDigitalizacion.Visible = false;
            grpConfigDigitalizador.Visible = true;
            grpConfigSender.Visible = false;
        }

        /// <summary>
        /// Visualiza la pantalla de configuracion del Sender desde el menu principal superior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigSender_Click(object sender, EventArgs e)
        {
            grpDigitalizacion.Visible = false;
            grpConfigDigitalizador.Visible = false;
            grpConfigSender.Visible = true;

        }

        #endregion Menu Principal


        #region Administracion
        /// <summary>
        /// Tomando como referencia los valores ingresados en la ventana:<br></br>  
        /// <img src="images/Configuracion.bmp" width="600" height="400"></img><br></br>
        /// realiza un test de envío de mail, informando el resultado y dejando 
        /// registrado en el log de operaciones cualquier error que se produzca.
        /// </summary>
        /// <param name="sender">Generado automáticamente, y NO utilizado aquí.</param>
        /// <param name="e">Generado automáticamente, y NO utilizado aquí.</param>
        //private void btnTestMail_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string logmail = "";
        //        MailSMTP oSMTP = new MailSMTP();
        //        oSMTP.Send(txtMailServer.Text,
        //                   Convert.ToInt32(this.txtPort.Text),
        //                   "Prueba de envio de mail desde Digitalizador",
        //                   txtMailUser.Text,
        //                   txtMailClave.Text,
        //                   txtMailTo.Text,
        //                   txtMailFrom.Text,
        //                   "Prueba de envo de mail desde Digitalizador - Mensaje automatico",
        //                   ref logmail);
        //        MessageBox.Show("Se envió el mail sin problemas! Chequee su casilla.",
        //                        "Atención...", MessageBoxButtons.OK,
        //                        MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error probando envío de mail [" + ex.Message + "]",
        //            "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //    }
        //}

        private void ViewLog_Click(object sender, EventArgs e)
        {

        }

        private void DigitManual_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Graba parametros de ejecucion del Sender en archivo de configuracion XML 
        /// en el mismo directorio de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnGrabarParamSender_Click(object sender, EventArgs e)
        //{
        //    btnGrabaParametros_Click(sender, e);
        //}

        #endregion Administracion

      

    }
}