namespace PDA_DIDSlotLink
{
    partial class frmLightLog
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.dgvdata = new System.Windows.Forms.DataGrid();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtRack_SN = new System.Windows.Forms.TextBox();
            this.barcodeLightLog = new Barcode.Barcode();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvdata.Location = new System.Drawing.Point(3, 69);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(309, 174);
            this.dgvdata.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.ForeColor = System.Drawing.Color.Black;
            this.btnQuery.Location = new System.Drawing.Point(237, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Query";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(3, 11);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(219, 23);
            this.cboType.TabIndex = 1;
            // 
            // txtRack_SN
            // 
            this.txtRack_SN.Location = new System.Drawing.Point(3, 40);
            this.txtRack_SN.Name = "txtRack_SN";
            this.txtRack_SN.Size = new System.Drawing.Size(309, 23);
            this.txtRack_SN.TabIndex = 2;
            // 
            // frmLightLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 257);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtRack_SN);
            this.MaximizeBox = false;
            this.Name = "frmLightLog";
            this.Text = "Light stand record 20210306";
            this.Load += new System.EventHandler(this.frmLightLog_Load);
            this.Closed += new System.EventHandler(this.frmLightLog_Closed);
            this.ResumeLayout(false);
            // 
            // barcodeLightLog
            // 
            this.barcodeLightLog.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barcodeLightLog.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barcodeLightLog.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barcodeLightLog.DecoderParameters.CODABARParams.Redundancy = true;
            this.barcodeLightLog.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barcodeLightLog.DecoderParameters.CODE128Params.EAN128 = true;
            this.barcodeLightLog.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barcodeLightLog.DecoderParameters.CODE128Params.Other128 = true;
            this.barcodeLightLog.DecoderParameters.CODE128Params.Redundancy = false;
            this.barcodeLightLog.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barcodeLightLog.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barcodeLightLog.DecoderParameters.CODE39Params.Concatenation = false;
            this.barcodeLightLog.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barcodeLightLog.DecoderParameters.CODE39Params.FullAscii = false;
            this.barcodeLightLog.DecoderParameters.CODE39Params.Redundancy = false;
            this.barcodeLightLog.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barcodeLightLog.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barcodeLightLog.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barcodeLightLog.DecoderParameters.CODE93Params.Redundancy = false;
            this.barcodeLightLog.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barcodeLightLog.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barcodeLightLog.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barcodeLightLog.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barcodeLightLog.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barcodeLightLog.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barcodeLightLog.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barcodeLightLog.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barcodeLightLog.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barcodeLightLog.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barcodeLightLog.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barcodeLightLog.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barcodeLightLog.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barcodeLightLog.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barcodeLightLog.DecoderParameters.MSIParams.Redundancy = true;
            this.barcodeLightLog.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barcodeLightLog.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barcodeLightLog.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barcodeLightLog.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barcodeLightLog.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barcodeLightLog.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barcodeLightLog.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barcodeLightLog.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barcodeLightLog.DeviceName = null;
            this.barcodeLightLog.EnableScanner = true;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barcodeLightLog.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barcodeLightLog.ScanParameters.BeepFrequency = 2670;
            this.barcodeLightLog.ScanParameters.BeepTime = 200;
            this.barcodeLightLog.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barcodeLightLog.ScanParameters.LedTime = 3000;
            this.barcodeLightLog.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barcodeLightLog.ScanParameters.WaveFile = "";
            this.barcodeLightLog.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barcodeLightLog_OnRead);

        }

        #endregion

        private System.Windows.Forms.DataGrid dgvdata;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtRack_SN;
        private Barcode.Barcode barcodeLightLog;
    }
}