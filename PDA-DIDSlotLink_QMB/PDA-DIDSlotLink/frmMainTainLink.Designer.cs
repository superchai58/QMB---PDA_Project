namespace PDA_DIDSlotLink
{
    partial class frmMainTainLink
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
            this.dgvMainTainLink = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optLink = new System.Windows.Forms.RadioButton();
            this.optUnLink = new System.Windows.Forms.RadioButton();
            this.txtLineID = new System.Windows.Forms.TextBox();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.barCodeMainTain = new Barcode.Barcode();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgvMainTainLink
            // 
            this.dgvMainTainLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMainTainLink.BackColor = System.Drawing.Color.Red;
            this.dgvMainTainLink.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvMainTainLink.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
            this.dgvMainTainLink.Location = new System.Drawing.Point(4, 55);
            this.dgvMainTainLink.Name = "dgvMainTainLink";
            this.dgvMainTainLink.RowHeadersVisible = false;
            this.dgvMainTainLink.Size = new System.Drawing.Size(308, 208);
            this.dgvMainTainLink.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.Text = "LineID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(162, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.Text = "MachineID";
            // 
            // optLink
            // 
            this.optLink.Checked = true;
            this.optLink.Enabled = false;
            this.optLink.Location = new System.Drawing.Point(48, 6);
            this.optLink.Name = "optLink";
            this.optLink.Size = new System.Drawing.Size(45, 13);
            this.optLink.TabIndex = 5;
            this.optLink.Text = "Link";
            this.optLink.Click += new System.EventHandler(this.optLink_Click);
            // 
            // optUnLink
            // 
            this.optUnLink.Enabled = false;
            this.optUnLink.Location = new System.Drawing.Point(123, 6);
            this.optUnLink.Name = "optUnLink";
            this.optUnLink.Size = new System.Drawing.Size(77, 13);
            this.optUnLink.TabIndex = 6;
            this.optUnLink.Text = "UnLink";
            this.optUnLink.Click += new System.EventHandler(this.optUnLink_Click);
            // 
            // txtLineID
            // 
            this.txtLineID.Location = new System.Drawing.Point(57, 26);
            this.txtLineID.Name = "txtLineID";
            this.txtLineID.Size = new System.Drawing.Size(101, 23);
            this.txtLineID.TabIndex = 7;
            // 
            // txtMachineID
            // 
            this.txtMachineID.Location = new System.Drawing.Point(238, 25);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(67, 23);
            this.txtMachineID.TabIndex = 8;
            // 
            // barCodeMainTain
            // 
            
            this.barCodeMainTain.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barCodeMainTain.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barCodeMainTain.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barCodeMainTain.DecoderParameters.CODABARParams.Redundancy = true;
            this.barCodeMainTain.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barCodeMainTain.DecoderParameters.CODE128Params.EAN128 = true;
            this.barCodeMainTain.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barCodeMainTain.DecoderParameters.CODE128Params.Other128 = true;
            this.barCodeMainTain.DecoderParameters.CODE128Params.Redundancy = false;
            this.barCodeMainTain.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barCodeMainTain.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barCodeMainTain.DecoderParameters.CODE39Params.Concatenation = false;
            this.barCodeMainTain.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barCodeMainTain.DecoderParameters.CODE39Params.FullAscii = false;
            this.barCodeMainTain.DecoderParameters.CODE39Params.Redundancy = false;
            this.barCodeMainTain.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barCodeMainTain.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barCodeMainTain.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barCodeMainTain.DecoderParameters.CODE93Params.Redundancy = false;
            this.barCodeMainTain.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barCodeMainTain.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barCodeMainTain.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barCodeMainTain.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barCodeMainTain.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barCodeMainTain.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeMainTain.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barCodeMainTain.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barCodeMainTain.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barCodeMainTain.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barCodeMainTain.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeMainTain.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barCodeMainTain.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barCodeMainTain.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barCodeMainTain.DecoderParameters.MSIParams.Redundancy = true;
            this.barCodeMainTain.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barCodeMainTain.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barCodeMainTain.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barCodeMainTain.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barCodeMainTain.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barCodeMainTain.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barCodeMainTain.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barCodeMainTain.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barCodeMainTain.DeviceName = null;
            this.barCodeMainTain.EnableScanner = true;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barCodeMainTain.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barCodeMainTain.ScanParameters.BeepFrequency = 2670;
            this.barCodeMainTain.ScanParameters.BeepTime = 200;
            this.barCodeMainTain.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barCodeMainTain.ScanParameters.LedTime = 3000;
            this.barCodeMainTain.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barCodeMainTain.ScanParameters.WaveFile = "";
            this.barCodeMainTain.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barCodeMainTain_OnRead);
             
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(217, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(88, 21);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "Query";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // frmMainTainLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(318, 266);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtMachineID);
            this.Controls.Add(this.txtLineID);
            this.Controls.Add(this.optUnLink);
            this.Controls.Add(this.optLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMainTainLink);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainTainLink";
            this.Text = "frmMainTainLink";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMainTainLink_Load);
            this.Closed += new System.EventHandler(this.frmMainTainLink_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGrid dgvMainTainLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optLink;
        private System.Windows.Forms.TextBox txtLineID;
        private System.Windows.Forms.TextBox txtMachineID;
        private Barcode.Barcode barCodeMainTain;
        public System.Windows.Forms.RadioButton optUnLink;
        private System.Windows.Forms.Button btnQuery;

    }
}