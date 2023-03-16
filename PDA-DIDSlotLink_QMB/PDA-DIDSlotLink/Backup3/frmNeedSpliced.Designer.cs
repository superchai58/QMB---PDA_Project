namespace PDA_DIDSlotLink
{
    partial class frmNeedSpliced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNeedSpliced));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuCompCompare = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuChangeFeeder = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mniDID = new System.Windows.Forms.MenuItem();
            this.mniDeleteDID = new System.Windows.Forms.MenuItem();
            this.mniCheckDID = new System.Windows.Forms.MenuItem();
            this.menuSetting = new System.Windows.Forms.MenuItem();
            this.menuDistributeDID = new System.Windows.Forms.MenuItem();
            this.menuLink = new System.Windows.Forms.MenuItem();
            this.menuUnLink = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvAlarmDID = new System.Windows.Forms.ListView();
            this.imglst = new System.Windows.Forms.ImageList();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvAlarmDID = new System.Windows.Forms.DataGrid();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtNewDID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldDID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barCodeDID = new Barcode.Barcode();
            this.timeRefresh = new System.Windows.Forms.Timer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuCompCompare);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.mniDID);
            this.mainMenu1.MenuItems.Add(this.menuSetting);
            // 
            // menuCompCompare
            // 
            resources.ApplyResources(this.menuCompCompare, "menuCompCompare");
            this.menuCompCompare.Click += new System.EventHandler(this.menuCompCompare_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuChangeFeeder);
            resources.ApplyResources(this.menuItem2, "menuItem2");
            // 
            // menuChangeFeeder
            // 
            resources.ApplyResources(this.menuChangeFeeder, "menuChangeFeeder");
            this.menuChangeFeeder.Click += new System.EventHandler(this.menuChangeFeeder_Click);
            // 
            // menuItem1
            // 
            resources.ApplyResources(this.menuItem1, "menuItem1");
            // 
            // mniDID
            // 
            this.mniDID.MenuItems.Add(this.mniDeleteDID);
            this.mniDID.MenuItems.Add(this.mniCheckDID);
            resources.ApplyResources(this.mniDID, "mniDID");
            // 
            // mniDeleteDID
            // 
            resources.ApplyResources(this.mniDeleteDID, "mniDeleteDID");
            this.mniDeleteDID.Click += new System.EventHandler(this.mniDeleteDID_Click);
            // 
            // mniCheckDID
            // 
            resources.ApplyResources(this.mniCheckDID, "mniCheckDID");
            this.mniCheckDID.Click += new System.EventHandler(this.mniCheckDID_Click);
            // 
            // menuSetting
            // 
            resources.ApplyResources(this.menuSetting, "menuSetting");
            this.menuSetting.Click += new System.EventHandler(this.menuSetting_Click);
            // 
            // menuDistributeDID
            // 
            resources.ApplyResources(this.menuDistributeDID, "menuDistributeDID");
            this.menuDistributeDID.Click += new System.EventHandler(this.menuDistributeDID_Click);
            // 
            // menuLink
            // 
            resources.ApplyResources(this.menuLink, "menuLink");
            this.menuLink.Click += new System.EventHandler(this.menuLink_Click);
            // 
            // menuUnLink
            // 
            resources.ApplyResources(this.menuUnLink, "menuUnLink");
            this.menuUnLink.Click += new System.EventHandler(this.menuUnLink_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvAlarmDID);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.dgvAlarmDID);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.txtNewDID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOldDID);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lvAlarmDID
            // 
            resources.ApplyResources(this.lvAlarmDID, "lvAlarmDID");
            this.lvAlarmDID.Name = "lvAlarmDID";
            this.lvAlarmDID.SmallImageList = this.imglst;
            this.imglst.Images.Clear();
            this.imglst.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.imglst.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            this.imglst.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvAlarmDID
            // 
            resources.ApplyResources(this.dgvAlarmDID, "dgvAlarmDID");
            this.dgvAlarmDID.BackColor = System.Drawing.Color.Red;
            this.dgvAlarmDID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvAlarmDID.Name = "dgvAlarmDID";
            this.dgvAlarmDID.RowHeadersVisible = false;
            this.dgvAlarmDID.Click += new System.EventHandler(this.dgvAlarmDID_Click);
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            // 
            // txtNewDID
            // 
            resources.ApplyResources(this.txtNewDID, "txtNewDID");
            this.txtNewDID.Name = "txtNewDID";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // txtOldDID
            // 
            resources.ApplyResources(this.txtOldDID, "txtOldDID");
            this.txtOldDID.Name = "txtOldDID";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // barCodeDID
            // 
            this.barCodeDID.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barCodeDID.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barCodeDID.DecoderParameters.CODABARParams.Redundancy = true;
            this.barCodeDID.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.CODE128Params.EAN128 = true;
            this.barCodeDID.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barCodeDID.DecoderParameters.CODE128Params.Other128 = true;
            this.barCodeDID.DecoderParameters.CODE128Params.Redundancy = false;
            this.barCodeDID.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barCodeDID.DecoderParameters.CODE39Params.Concatenation = false;
            this.barCodeDID.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barCodeDID.DecoderParameters.CODE39Params.FullAscii = false;
            this.barCodeDID.DecoderParameters.CODE39Params.Redundancy = false;
            this.barCodeDID.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barCodeDID.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barCodeDID.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.DecoderParameters.CODE93Params.Redundancy = false;
            this.barCodeDID.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barCodeDID.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barCodeDID.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barCodeDID.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barCodeDID.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barCodeDID.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barCodeDID.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barCodeDID.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barCodeDID.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barCodeDID.DecoderParameters.MSIParams.Redundancy = true;
            this.barCodeDID.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barCodeDID.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barCodeDID.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barCodeDID.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barCodeDID.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barCodeDID.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barCodeDID.DeviceName = null;
            this.barCodeDID.EnableScanner = true;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ScanParameters.BeepFrequency = 2670;
            this.barCodeDID.ScanParameters.BeepTime = 200;
            this.barCodeDID.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barCodeDID.ScanParameters.LedTime = 3000;
            this.barCodeDID.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barCodeDID.ScanParameters.WaveFile = "";
            this.barCodeDID.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barCodeDID_OnRead);
            // 
            // timeRefresh
            // 
            this.timeRefresh.Enabled = true;
            this.timeRefresh.Interval = 60000;
            this.timeRefresh.Tick += new System.EventHandler(this.timeRefresh_Tick);
            // 
            // frmNeedSpliced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.Name = "frmNeedSpliced";
            this.Load += new System.EventHandler(this.frmNeedSpliced_Load);
            this.Closed += new System.EventHandler(this.frmNeedSpliced_Closed);
            this.Activated += new System.EventHandler(this.frmNeedSpliced_Activated);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dgvAlarmDID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldDID;
        private System.Windows.Forms.TextBox txtNewDID;
        private Barcode.Barcode barCodeDID;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timeRefresh;
        private System.Windows.Forms.MenuItem menuCompCompare;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuChangeFeeder;
        private System.Windows.Forms.Button btnRefresh;
        //private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuDistributeDID;
        private System.Windows.Forms.MenuItem menuLink;
        private System.Windows.Forms.MenuItem menuUnLink;
        private System.Windows.Forms.ImageList imglst;
        private System.Windows.Forms.ListView lvAlarmDID;
        private System.Windows.Forms.MenuItem menuSetting;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mniDID;
        private System.Windows.Forms.MenuItem mniDeleteDID;
        private System.Windows.Forms.MenuItem mniCheckDID;


    }
}