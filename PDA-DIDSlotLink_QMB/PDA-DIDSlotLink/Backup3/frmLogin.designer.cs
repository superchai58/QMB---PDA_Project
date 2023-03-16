namespace PDA_DIDSlotLink
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.barCodeLogin = new Barcode.Barcode();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(113, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(26, 126);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 30);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPassWord
            // 
            this.lblPassWord.Location = new System.Drawing.Point(17, 68);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(82, 20);
            this.lblPassWord.Text = "Pass Word :";
            // 
            // chkPassword
            // 
            this.chkPassword.Location = new System.Drawing.Point(48, 94);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(129, 26);
            this.chkPassword.TabIndex = 17;
            this.chkPassword.Text = "Keep PassWord";
            this.chkPassword.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(96, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 23);
            this.txtUserName.TabIndex = 21;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(17, 32);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 20);
            this.lblUserName.Text = "User Name :";
            // 
            // barCodeLogin
            // 
            this.barCodeLogin.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barCodeLogin.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barCodeLogin.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barCodeLogin.DecoderParameters.CODABARParams.Redundancy = true;
            this.barCodeLogin.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barCodeLogin.DecoderParameters.CODE128Params.EAN128 = true;
            this.barCodeLogin.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barCodeLogin.DecoderParameters.CODE128Params.Other128 = true;
            this.barCodeLogin.DecoderParameters.CODE128Params.Redundancy = false;
            this.barCodeLogin.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barCodeLogin.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barCodeLogin.DecoderParameters.CODE39Params.Concatenation = false;
            this.barCodeLogin.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barCodeLogin.DecoderParameters.CODE39Params.FullAscii = false;
            this.barCodeLogin.DecoderParameters.CODE39Params.Redundancy = false;
            this.barCodeLogin.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barCodeLogin.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barCodeLogin.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barCodeLogin.DecoderParameters.CODE93Params.Redundancy = false;
            this.barCodeLogin.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barCodeLogin.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barCodeLogin.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barCodeLogin.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barCodeLogin.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barCodeLogin.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeLogin.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barCodeLogin.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barCodeLogin.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barCodeLogin.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barCodeLogin.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeLogin.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barCodeLogin.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barCodeLogin.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barCodeLogin.DecoderParameters.MSIParams.Redundancy = true;
            this.barCodeLogin.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barCodeLogin.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barCodeLogin.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barCodeLogin.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barCodeLogin.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barCodeLogin.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barCodeLogin.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barCodeLogin.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barCodeLogin.DeviceName = null;
            this.barCodeLogin.EnableScanner = true;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barCodeLogin.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barCodeLogin.ScanParameters.BeepFrequency = 2670;
            this.barCodeLogin.ScanParameters.BeepTime = 200;
            this.barCodeLogin.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barCodeLogin.ScanParameters.LedTime = 3000;
            this.barCodeLogin.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barCodeLogin.ScanParameters.WaveFile = "";
            this.barCodeLogin.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barCodeLogin_OnRead);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(229, 100);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.chkPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassWord);
            this.Menu = this.mainMenu1;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Closed += new System.EventHandler(this.frmLogin_Closed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private Barcode.Barcode barCodeLogin;
    }
}

