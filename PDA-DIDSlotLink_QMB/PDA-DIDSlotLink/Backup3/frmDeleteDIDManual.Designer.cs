namespace PDA_DIDSlotLink
{
    partial class frmDeleteDIDManual
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRackSN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.barCodeGetRackSN = new Barcode.Barcode();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(-6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.Text = "Rack_SN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRackSN
            // 
            this.txtRackSN.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.txtRackSN.Location = new System.Drawing.Point(102, 24);
            this.txtRackSN.Name = "txtRackSN";
            this.txtRackSN.Size = new System.Drawing.Size(180, 32);
            this.txtRackSN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(-6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.Text = "StoreID: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtStoreID
            // 
            this.txtStoreID.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.txtStoreID.Location = new System.Drawing.Point(102, 68);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(180, 32);
            this.txtStoreID.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStoreID);
            this.panel1.Controls.Add(this.txtRackSN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 258);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.btnRefresh.Location = new System.Drawing.Point(8, 186);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(274, 43);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "คืนค่า";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.btnConfirm.Location = new System.Drawing.Point(8, 131);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(274, 43);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "ยืนยัน";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // barCodeGetRackSN
            // 
            this.barCodeGetRackSN.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barCodeGetRackSN.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barCodeGetRackSN.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barCodeGetRackSN.DecoderParameters.CODABARParams.Redundancy = true;
            this.barCodeGetRackSN.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barCodeGetRackSN.DecoderParameters.CODE128Params.EAN128 = true;
            this.barCodeGetRackSN.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barCodeGetRackSN.DecoderParameters.CODE128Params.Other128 = true;
            this.barCodeGetRackSN.DecoderParameters.CODE128Params.Redundancy = false;
            this.barCodeGetRackSN.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barCodeGetRackSN.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barCodeGetRackSN.DecoderParameters.CODE39Params.Concatenation = false;
            this.barCodeGetRackSN.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barCodeGetRackSN.DecoderParameters.CODE39Params.FullAscii = false;
            this.barCodeGetRackSN.DecoderParameters.CODE39Params.Redundancy = false;
            this.barCodeGetRackSN.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barCodeGetRackSN.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barCodeGetRackSN.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barCodeGetRackSN.DecoderParameters.CODE93Params.Redundancy = false;
            this.barCodeGetRackSN.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barCodeGetRackSN.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barCodeGetRackSN.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barCodeGetRackSN.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barCodeGetRackSN.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barCodeGetRackSN.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeGetRackSN.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barCodeGetRackSN.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barCodeGetRackSN.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barCodeGetRackSN.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barCodeGetRackSN.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeGetRackSN.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barCodeGetRackSN.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barCodeGetRackSN.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barCodeGetRackSN.DecoderParameters.MSIParams.Redundancy = true;
            this.barCodeGetRackSN.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barCodeGetRackSN.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barCodeGetRackSN.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barCodeGetRackSN.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barCodeGetRackSN.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barCodeGetRackSN.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barCodeGetRackSN.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barCodeGetRackSN.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barCodeGetRackSN.DeviceName = null;
            this.barCodeGetRackSN.EnableScanner = true;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barCodeGetRackSN.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barCodeGetRackSN.ScanParameters.BeepFrequency = 2670;
            this.barCodeGetRackSN.ScanParameters.BeepTime = 200;
            this.barCodeGetRackSN.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barCodeGetRackSN.ScanParameters.LedTime = 3000;
            this.barCodeGetRackSN.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barCodeGetRackSN.ScanParameters.WaveFile = "";
            this.barCodeGetRackSN.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barCodeGetRackSN_OnRead);
            // 
            // frmDeleteDIDManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 285);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmDeleteDIDManual";
            this.Text = "ลบ DID Manual";
            this.Load += new System.EventHandler(this.frmDeleteDIDManual_Load);
            this.Closed += new System.EventHandler(this.frmDeleteDIDManual_Closed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRackSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConfirm;
        private Barcode.Barcode barCodeGetRackSN;
    }
}