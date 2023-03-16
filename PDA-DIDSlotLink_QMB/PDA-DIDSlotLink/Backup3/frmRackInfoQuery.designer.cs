namespace PDA_DIDSlotLink
{
    partial class frmRackInfoQuery
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
            this.dgvMainTainLink = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optRackID = new System.Windows.Forms.RadioButton();
            this.optDID = new System.Windows.Forms.RadioButton();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.barcodeRackQuery = new Barcode.Barcode();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRack_SN = new System.Windows.Forms.TextBox();
            this.optGroup = new System.Windows.Forms.RadioButton();
            this.btnEnd = new System.Windows.Forms.Button();
            this.optHisTime = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dgvMainTainLink
            // 
            this.dgvMainTainLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMainTainLink.BackColor = System.Drawing.Color.Red;
            this.dgvMainTainLink.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvMainTainLink.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
            this.dgvMainTainLink.Location = new System.Drawing.Point(3, 89);
            this.dgvMainTainLink.Name = "dgvMainTainLink";
            this.dgvMainTainLink.RowHeadersVisible = false;
            this.dgvMainTainLink.Size = new System.Drawing.Size(308, 174);
            this.dgvMainTainLink.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(109, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.Text = "Line";
            // 
            // optRackID
            // 
            this.optRackID.Checked = true;
            this.optRackID.Location = new System.Drawing.Point(3, 4);
            this.optRackID.Name = "optRackID";
            this.optRackID.Size = new System.Drawing.Size(69, 17);
            this.optRackID.TabIndex = 1;
            this.optRackID.TabStop = false;
            this.optRackID.Text = "Rack";
            this.optRackID.Click += new System.EventHandler(this.optRackID_Click);
            // 
            // optDID
            // 
            this.optDID.Location = new System.Drawing.Point(61, 6);
            this.optDID.Name = "optDID";
            this.optDID.Size = new System.Drawing.Size(77, 13);
            this.optDID.TabIndex = 2;
            this.optDID.TabStop = false;
            this.optDID.Text = "DID";
            this.optDID.Click += new System.EventHandler(this.optDID_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(266, 27);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(45, 21);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "Query";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboLine
            // 
            this.cboLine.Location = new System.Drawing.Point(42, 58);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(61, 23);
            this.cboLine.TabIndex = 7;
            this.cboLine.SelectedIndexChanged += new System.EventHandler(this.cboLine_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(109, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.Text = "Group";
            // 
            // cboGroup
            // 
            this.cboGroup.Items.Add("ALL");
            this.cboGroup.Items.Add("1");
            this.cboGroup.Items.Add("2");
            this.cboGroup.Items.Add("3");
            this.cboGroup.Items.Add("4");
            this.cboGroup.Location = new System.Drawing.Point(157, 60);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(103, 23);
            this.cboGroup.TabIndex = 8;
            this.cboGroup.Tag = "F12200004";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(139, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 23);
            this.txtID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.Text = "Rack";
            // 
            // txtRack_SN
            // 
            this.txtRack_SN.Location = new System.Drawing.Point(42, 25);
            this.txtRack_SN.Name = "txtRack_SN";
            this.txtRack_SN.Size = new System.Drawing.Size(61, 23);
            this.txtRack_SN.TabIndex = 5;
            // 
            // optGroup
            // 
            this.optGroup.Location = new System.Drawing.Point(109, 3);
            this.optGroup.Name = "optGroup";
            this.optGroup.Size = new System.Drawing.Size(69, 17);
            this.optGroup.TabIndex = 3;
            this.optGroup.TabStop = false;
            this.optGroup.Text = "Group";
            this.optGroup.Click += new System.EventHandler(this.optGroup_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(266, 60);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(45, 21);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "End";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // optHisTime
            // 
            this.optHisTime.Location = new System.Drawing.Point(176, 3);
            this.optHisTime.Name = "optHisTime";
            this.optHisTime.Size = new System.Drawing.Size(84, 19);
            this.optHisTime.TabIndex = 4;
            this.optHisTime.TabStop = false;
            this.optHisTime.Text = "HisTime";
            this.optHisTime.CheckedChanged += new System.EventHandler(this.optHisTime_CheckedChanged);
            // 
            // frmRackInfoQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(318, 266);
            this.Controls.Add(this.optHisTime);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.optGroup);
            this.Controls.Add(this.txtRack_SN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboLine);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.optDID);
            this.Controls.Add(this.optRackID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMainTainLink);
            this.Name = "frmRackInfoQuery";
            this.Text = "Query20210306";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmRackInfoQuery_Load);
            this.Closed += new System.EventHandler(this.frmRackInfoQuery_Closed);
            this.ResumeLayout(false);
            //
            //
            // barcodeRackQuery
            // 
            this.barcodeRackQuery.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barcodeRackQuery.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barcodeRackQuery.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barcodeRackQuery.DecoderParameters.CODABARParams.Redundancy = true;
            this.barcodeRackQuery.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barcodeRackQuery.DecoderParameters.CODE128Params.EAN128 = true;
            this.barcodeRackQuery.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barcodeRackQuery.DecoderParameters.CODE128Params.Other128 = true;
            this.barcodeRackQuery.DecoderParameters.CODE128Params.Redundancy = false;
            this.barcodeRackQuery.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barcodeRackQuery.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barcodeRackQuery.DecoderParameters.CODE39Params.Concatenation = false;
            this.barcodeRackQuery.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barcodeRackQuery.DecoderParameters.CODE39Params.FullAscii = false;
            this.barcodeRackQuery.DecoderParameters.CODE39Params.Redundancy = false;
            this.barcodeRackQuery.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barcodeRackQuery.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barcodeRackQuery.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barcodeRackQuery.DecoderParameters.CODE93Params.Redundancy = false;
            this.barcodeRackQuery.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barcodeRackQuery.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barcodeRackQuery.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barcodeRackQuery.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barcodeRackQuery.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barcodeRackQuery.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barcodeRackQuery.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barcodeRackQuery.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barcodeRackQuery.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barcodeRackQuery.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barcodeRackQuery.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barcodeRackQuery.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barcodeRackQuery.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barcodeRackQuery.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barcodeRackQuery.DecoderParameters.MSIParams.Redundancy = true;
            this.barcodeRackQuery.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barcodeRackQuery.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barcodeRackQuery.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barcodeRackQuery.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barcodeRackQuery.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barcodeRackQuery.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barcodeRackQuery.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barcodeRackQuery.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barcodeRackQuery.DeviceName = null;
            this.barcodeRackQuery.EnableScanner = true;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barcodeRackQuery.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barcodeRackQuery.ScanParameters.BeepFrequency = 2670;
            this.barcodeRackQuery.ScanParameters.BeepTime = 200;
            this.barcodeRackQuery.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barcodeRackQuery.ScanParameters.LedTime = 3000;
            this.barcodeRackQuery.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barcodeRackQuery.ScanParameters.WaveFile = "";
            this.barcodeRackQuery.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barcodeRackQuery_OnRead);

        }

        #endregion

        public System.Windows.Forms.DataGrid dgvMainTainLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optRackID;
        public System.Windows.Forms.RadioButton optDID;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGroup;
        private Barcode.Barcode barcodeRackQuery;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRack_SN;
        private System.Windows.Forms.RadioButton optGroup;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.RadioButton optHisTime;

    }
}