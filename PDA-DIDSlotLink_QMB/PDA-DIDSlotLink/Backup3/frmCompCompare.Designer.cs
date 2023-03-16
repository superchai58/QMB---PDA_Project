namespace PDA_DIDSlotLink
{
    partial class frmCompCompare
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
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSlot = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCompareDID = new System.Windows.Forms.DataGrid();
            this.btnCheck = new System.Windows.Forms.Button();
            this.chkDID = new System.Windows.Forms.CheckBox();
            this.cboMachine = new System.Windows.Forms.ComboBox();
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barCodeCheckDID = new Barcode.Barcode();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboLine);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboLR);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboSlot);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvCompareDID);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.chkDID);
            this.panel1.Controls.Add(this.cboMachine);
            this.panel1.Controls.Add(this.cboTable);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.txtDID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 267);
            // 
            // cboLine
            // 
            this.cboLine.Location = new System.Drawing.Point(40, 5);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(60, 23);
            this.cboLine.TabIndex = 38;
            this.cboLine.SelectedIndexChanged += new System.EventHandler(this.cboLine_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.Text = "Line(线别):";
            // 
            // cboLR
            // 
            this.cboLR.Items.Add("0");
            this.cboLR.Items.Add("1");
            this.cboLR.Items.Add("2");
            this.cboLR.Location = new System.Drawing.Point(259, 59);
            this.cboLR.Name = "cboLR";
            this.cboLR.Size = new System.Drawing.Size(51, 23);
            this.cboLR.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(219, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.Text = "Left&Right(左右):";
            // 
            // cboSlot
            // 
            this.cboSlot.Location = new System.Drawing.Point(259, 30);
            this.cboSlot.Name = "cboSlot";
            this.cboSlot.Size = new System.Drawing.Size(51, 23);
            this.cboSlot.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(218, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.Text = "Slot(站位):";
            // 
            // dgvCompareDID
            // 
            this.dgvCompareDID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCompareDID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvCompareDID.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
            this.dgvCompareDID.Location = new System.Drawing.Point(-1, 91);
            this.dgvCompareDID.Name = "dgvCompareDID";
            this.dgvCompareDID.RowHeadersVisible = false;
            this.dgvCompareDID.Size = new System.Drawing.Size(313, 170);
            this.dgvCompareDID.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Location = new System.Drawing.Point(120, 63);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 19;
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // chkDID
            // 
            this.chkDID.ForeColor = System.Drawing.Color.Red;
            this.chkDID.Location = new System.Drawing.Point(16, 63);
            this.chkDID.Name = "chkDID";
            this.chkDID.Size = new System.Drawing.Size(92, 26);
            this.chkDID.TabIndex = 18;
            this.chkDID.Text = "Check DID(比对DID)";
            // 
            // cboMachine
            // 
            this.cboMachine.Location = new System.Drawing.Point(136, 5);
            this.cboMachine.Name = "cboMachine";
            this.cboMachine.Size = new System.Drawing.Size(76, 23);
            this.cboMachine.TabIndex = 16;
            // 
            // cboTable
            // 
            this.cboTable.Items.Add("ALL");
            this.cboTable.Items.Add("1");
            this.cboTable.Items.Add("2");
            this.cboTable.Items.Add("3");
            this.cboTable.Items.Add("4");
            this.cboTable.Location = new System.Drawing.Point(259, 5);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(51, 23);
            this.cboTable.TabIndex = 14;
            this.cboTable.SelectedIndexChanged += new System.EventHandler(this.cboTable_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(212, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.Text = "Table:";
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(5, 241);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(303, 18);
            // 
            // txtDID
            // 
            this.txtDID.Location = new System.Drawing.Point(47, 34);
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(165, 23);
            this.txtDID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.Text = "DID:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(98, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.Text = "Machine(机台):";
            // 
            // barCodeCheckDID
            // 
            this.barCodeCheckDID.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barCodeCheckDID.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barCodeCheckDID.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barCodeCheckDID.DecoderParameters.CODABARParams.Redundancy = true;
            this.barCodeCheckDID.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barCodeCheckDID.DecoderParameters.CODE128Params.EAN128 = true;
            this.barCodeCheckDID.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barCodeCheckDID.DecoderParameters.CODE128Params.Other128 = true;
            this.barCodeCheckDID.DecoderParameters.CODE128Params.Redundancy = false;
            this.barCodeCheckDID.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barCodeCheckDID.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barCodeCheckDID.DecoderParameters.CODE39Params.Concatenation = false;
            this.barCodeCheckDID.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barCodeCheckDID.DecoderParameters.CODE39Params.FullAscii = false;
            this.barCodeCheckDID.DecoderParameters.CODE39Params.Redundancy = false;
            this.barCodeCheckDID.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barCodeCheckDID.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barCodeCheckDID.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barCodeCheckDID.DecoderParameters.CODE93Params.Redundancy = false;
            this.barCodeCheckDID.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barCodeCheckDID.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barCodeCheckDID.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barCodeCheckDID.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barCodeCheckDID.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barCodeCheckDID.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeCheckDID.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barCodeCheckDID.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barCodeCheckDID.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barCodeCheckDID.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barCodeCheckDID.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeCheckDID.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barCodeCheckDID.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barCodeCheckDID.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barCodeCheckDID.DecoderParameters.MSIParams.Redundancy = true;
            this.barCodeCheckDID.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barCodeCheckDID.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barCodeCheckDID.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barCodeCheckDID.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barCodeCheckDID.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barCodeCheckDID.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barCodeCheckDID.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barCodeCheckDID.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barCodeCheckDID.DeviceName = null;
            this.barCodeCheckDID.EnableScanner = true;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barCodeCheckDID.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barCodeCheckDID.ScanParameters.BeepFrequency = 2670;
            this.barCodeCheckDID.ScanParameters.BeepTime = 200;
            this.barCodeCheckDID.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barCodeCheckDID.ScanParameters.LedTime = 3000;
            this.barCodeCheckDID.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barCodeCheckDID.ScanParameters.WaveFile = "";
            this.barCodeCheckDID.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barCodeCheckDID_OnRead);
            
            // 
            // frmCompCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 275);
            this.Controls.Add(this.panel1);
            this.Name = "frmCompCompare";
            this.Text = "Match(对料)【0710】";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCompCompare_Load);
            this.Closed += new System.EventHandler(this.frmCompCompare_Closed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dgvCompareDID;
        private System.Windows.Forms.ComboBox cboMachine;
        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDID;
        private System.Windows.Forms.Button btnCheck;
        private Barcode.Barcode barCodeCheckDID;
        private System.Windows.Forms.ComboBox cboLR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSlot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.Label label6;

    }
}