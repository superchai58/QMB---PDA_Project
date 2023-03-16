namespace PDA_DIDSlotLink
{
    partial class frmDistributeDID
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
            this.palDistributeDIDByPosition = new System.Windows.Forms.Panel();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagByDID = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabPagByGroup = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboGroupID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.txtDIDByGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barCodeDistributeDID = new Barcode.Barcode();
            this.palDistributeDIDByPosition.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPagByDID.SuspendLayout();
            this.tabPagByGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // palDistributeDIDByPosition
            // 
            this.palDistributeDIDByPosition.Controls.Add(this.txtMachineID);
            this.palDistributeDIDByPosition.Controls.Add(this.label2);
            this.palDistributeDIDByPosition.Controls.Add(this.txtDID);
            this.palDistributeDIDByPosition.Controls.Add(this.label1);
            this.palDistributeDIDByPosition.Location = new System.Drawing.Point(3, 14);
            this.palDistributeDIDByPosition.Name = "palDistributeDIDByPosition";
            this.palDistributeDIDByPosition.Size = new System.Drawing.Size(301, 155);
            // 
            // txtMachineID
            // 
            this.txtMachineID.Location = new System.Drawing.Point(14, 104);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(270, 23);
            this.txtMachineID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.Text = "MachineID:";
            // 
            // txtDID
            // 
            this.txtDID.Location = new System.Drawing.Point(14, 40);
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(270, 23);
            this.txtDID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.Text = "DID:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagByDID);
            this.tabControl.Controls.Add(this.tabPagByGroup);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(315, 289);
            this.tabControl.TabIndex = 17;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPagByDID
            // 
            this.tabPagByDID.Controls.Add(this.lblStatus);
            this.tabPagByDID.Controls.Add(this.palDistributeDIDByPosition);
            this.tabPagByDID.Location = new System.Drawing.Point(4, 25);
            this.tabPagByDID.Name = "tabPagByDID";
            this.tabPagByDID.Size = new System.Drawing.Size(307, 260);
            this.tabPagByDID.Text = "ห่อ(分组)";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(4, 174);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(296, 67);
            this.lblStatus.Text = "ไม่มีข้อมูลลิงก์สถานีที่เกี่ยวข้อง(无对应站位Link信息)";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPagByGroup
            // 
            this.tabPagByGroup.Controls.Add(this.panel1);
            this.tabPagByGroup.Location = new System.Drawing.Point(4, 25);
            this.tabPagByGroup.Name = "tabPagByGroup";
            this.tabPagByGroup.Size = new System.Drawing.Size(307, 260);
            this.tabPagByGroup.Text = "กลุ่มย่อย(分Group)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboGroupID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboLine);
            this.panel1.Controls.Add(this.lblLine);
            this.panel1.Controls.Add(this.txtDIDByGroup);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 195);
            // 
            // cboGroupID
            // 
            this.cboGroupID.Location = new System.Drawing.Point(122, 71);
            this.cboGroupID.Name = "cboGroupID";
            this.cboGroupID.Size = new System.Drawing.Size(165, 23);
            this.cboGroupID.TabIndex = 36;
            this.cboGroupID.SelectedIndexChanged += new System.EventHandler(this.cboGroupID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.Text = "GroupID:";
            // 
            // cboLine
            // 
            this.cboLine.Location = new System.Drawing.Point(122, 20);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(165, 23);
            this.cboLine.TabIndex = 32;
            this.cboLine.SelectedIndexChanged += new System.EventHandler(this.cboLine_SelectedIndexChanged);
            // 
            // lblLine
            // 
            this.lblLine.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblLine.ForeColor = System.Drawing.Color.Red;
            this.lblLine.Location = new System.Drawing.Point(16, 20);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(75, 28);
            this.lblLine.Text = "Line:";
            // 
            // txtDIDByGroup
            // 
            this.txtDIDByGroup.Location = new System.Drawing.Point(77, 122);
            this.txtDIDByGroup.Name = "txtDIDByGroup";
            this.txtDIDByGroup.Size = new System.Drawing.Size(210, 23);
            this.txtDIDByGroup.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(18, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.Text = "DID:";
            // 
            // barCodeDistributeDID
            // 
            this.barCodeDistributeDID.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barCodeDistributeDID.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barCodeDistributeDID.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barCodeDistributeDID.DecoderParameters.CODABARParams.Redundancy = true;
            this.barCodeDistributeDID.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDistributeDID.DecoderParameters.CODE128Params.EAN128 = true;
            this.barCodeDistributeDID.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barCodeDistributeDID.DecoderParameters.CODE128Params.Other128 = true;
            this.barCodeDistributeDID.DecoderParameters.CODE128Params.Redundancy = false;
            this.barCodeDistributeDID.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDistributeDID.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barCodeDistributeDID.DecoderParameters.CODE39Params.Concatenation = false;
            this.barCodeDistributeDID.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barCodeDistributeDID.DecoderParameters.CODE39Params.FullAscii = false;
            this.barCodeDistributeDID.DecoderParameters.CODE39Params.Redundancy = false;
            this.barCodeDistributeDID.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barCodeDistributeDID.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barCodeDistributeDID.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barCodeDistributeDID.DecoderParameters.CODE93Params.Redundancy = false;
            this.barCodeDistributeDID.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barCodeDistributeDID.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barCodeDistributeDID.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDistributeDID.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDistributeDID.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barCodeDistributeDID.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDistributeDID.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barCodeDistributeDID.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barCodeDistributeDID.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barCodeDistributeDID.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barCodeDistributeDID.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDistributeDID.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barCodeDistributeDID.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barCodeDistributeDID.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barCodeDistributeDID.DecoderParameters.MSIParams.Redundancy = true;
            this.barCodeDistributeDID.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barCodeDistributeDID.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barCodeDistributeDID.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barCodeDistributeDID.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barCodeDistributeDID.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDistributeDID.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barCodeDistributeDID.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barCodeDistributeDID.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barCodeDistributeDID.DeviceName = null;
            this.barCodeDistributeDID.EnableScanner = true;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barCodeDistributeDID.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barCodeDistributeDID.ScanParameters.BeepFrequency = 2670;
            this.barCodeDistributeDID.ScanParameters.BeepTime = 200;
            this.barCodeDistributeDID.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barCodeDistributeDID.ScanParameters.LedTime = 3000;
            this.barCodeDistributeDID.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barCodeDistributeDID.ScanParameters.WaveFile = "";
            this.barCodeDistributeDID.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barCodeDistributeDID_OnRead);
            
            // 
            // frmDistributeDID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.tabControl);
            this.Name = "frmDistributeDID";
            this.Text = "frmDistributeDID【0406A】";
            this.Load += new System.EventHandler(this.frmDistributeDID_Load);
            this.Closed += new System.EventHandler(this.frmDistributeDID_Closed);
            this.palDistributeDIDByPosition.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPagByDID.ResumeLayout(false);
            this.tabPagByGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palDistributeDIDByPosition;
        private System.Windows.Forms.TextBox txtMachineID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagByDID;
        private System.Windows.Forms.TabPage tabPagByGroup;
        private Barcode.Barcode barCodeDistributeDID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDIDByGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGroupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblStatus;

    }
}