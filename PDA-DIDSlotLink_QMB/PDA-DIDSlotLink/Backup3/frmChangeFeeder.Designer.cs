namespace PDA_DIDSlotLink
{
    partial class frmChangeFeeder
    {
        /// <summary>
        /// 必需的设计器变量。

        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// 清理所有正在使用的资源。

        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。

        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewFeeder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldFeeder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barCodeFeeder = new Barcode.Barcode();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNewFeeder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtOldFeeder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 278);
            // 
            // txtNewFeeder
            // 
            this.txtNewFeeder.Location = new System.Drawing.Point(26, 191);
            this.txtNewFeeder.Name = "txtNewFeeder";
            this.txtNewFeeder.Size = new System.Drawing.Size(246, 23);
            this.txtNewFeeder.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(26, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.Text = "ปืนวัสดุใหม่(新料枪):";
            // 
            // txtOldFeeder
            // 
            this.txtOldFeeder.Location = new System.Drawing.Point(26, 126);
            this.txtOldFeeder.Name = "txtOldFeeder";
            this.txtOldFeeder.Size = new System.Drawing.Size(246, 23);
            this.txtOldFeeder.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.Text = "ปืนเก่า(旧料枪):";
            // 
            // txtDID
            // 
            this.txtDID.Location = new System.Drawing.Point(26, 62);
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(246, 23);
            this.txtDID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.Text = "DID:";
            // 
            // barCodeFeeder
            // 
            this.barCodeFeeder.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barCodeFeeder.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barCodeFeeder.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barCodeFeeder.DecoderParameters.CODABARParams.Redundancy = true;
            this.barCodeFeeder.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barCodeFeeder.DecoderParameters.CODE128Params.EAN128 = true;
            this.barCodeFeeder.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barCodeFeeder.DecoderParameters.CODE128Params.Other128 = true;
            this.barCodeFeeder.DecoderParameters.CODE128Params.Redundancy = false;
            this.barCodeFeeder.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barCodeFeeder.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barCodeFeeder.DecoderParameters.CODE39Params.Concatenation = false;
            this.barCodeFeeder.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barCodeFeeder.DecoderParameters.CODE39Params.FullAscii = false;
            this.barCodeFeeder.DecoderParameters.CODE39Params.Redundancy = false;
            this.barCodeFeeder.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barCodeFeeder.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barCodeFeeder.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barCodeFeeder.DecoderParameters.CODE93Params.Redundancy = false;
            this.barCodeFeeder.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barCodeFeeder.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barCodeFeeder.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barCodeFeeder.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barCodeFeeder.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barCodeFeeder.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeFeeder.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barCodeFeeder.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barCodeFeeder.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barCodeFeeder.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barCodeFeeder.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeFeeder.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barCodeFeeder.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barCodeFeeder.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barCodeFeeder.DecoderParameters.MSIParams.Redundancy = true;
            this.barCodeFeeder.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barCodeFeeder.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barCodeFeeder.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barCodeFeeder.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barCodeFeeder.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barCodeFeeder.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barCodeFeeder.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barCodeFeeder.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barCodeFeeder.DeviceName = null;
            this.barCodeFeeder.EnableScanner = true;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barCodeFeeder.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barCodeFeeder.ScanParameters.BeepFrequency = 2670;
            this.barCodeFeeder.ScanParameters.BeepTime = 200;
            this.barCodeFeeder.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barCodeFeeder.ScanParameters.LedTime = 3000;
            this.barCodeFeeder.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barCodeFeeder.ScanParameters.WaveFile = "";
            this.barCodeFeeder.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barCodeFeeder_OnRead);
            // 
            // frmChangeFeeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 285);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.Name = "frmChangeFeeder";
            this.Text = "更换料枪【1129】";
            this.Closed += new System.EventHandler(this.frmChangeFeeder_Closed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOldFeeder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewFeeder;
        private System.Windows.Forms.Label label3;
        private Barcode.Barcode barCodeFeeder;
    }
}