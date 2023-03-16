namespace PDA_DIDSlotLink
{
    partial class frmDIDStock
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
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTab = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSide = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnlink = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.barcodeDID = new Barcode.Barcode();
            this.btnRefreshLight = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mmuQuery = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.listViewDIDStock = new System.Windows.Forms.ListView();
            this.cboRack_SN = new System.Windows.Forms.ComboBox();
            this.chkUnlinkDID = new System.Windows.Forms.CheckBox();
            this.chkUnlinkRack = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtScanSLT = new System.Windows.Forms.TextBox();
            this.barcodeSLT = new Barcode.Barcode();
            this.SuspendLayout();
            // 
            // cboLine
            // 
            this.cboLine.Location = new System.Drawing.Point(260, 95);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(61, 23);
            this.cboLine.TabIndex = 54;
            this.cboLine.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(220, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.Text = "ไลน์:";
            this.label6.Visible = false;
            // 
            // cboTab
            // 
            this.cboTab.Location = new System.Drawing.Point(260, 94);
            this.cboTab.Name = "cboTab";
            this.cboTab.Size = new System.Drawing.Size(60, 23);
            this.cboTab.TabIndex = 57;
            this.cboTab.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(221, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.Text = "Tab:";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.Text = "Shelves:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.Text = "DID:";
            // 
            // txtDID
            // 
            this.txtDID.Location = new System.Drawing.Point(62, 61);
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(146, 23);
            this.txtDID.TabIndex = 3;
            this.txtDID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDID_KeyDown);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(220, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.Text = "โซน:";
            this.label4.Visible = false;
            // 
            // cboSide
            // 
            this.cboSide.Location = new System.Drawing.Point(260, 95);
            this.cboSide.Name = "cboSide";
            this.cboSide.Size = new System.Drawing.Size(61, 23);
            this.cboSide.TabIndex = 74;
            this.cboSide.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(11, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.Text = "Group:";
            // 
            // btnUnlink
            // 
            this.btnUnlink.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnUnlink.ForeColor = System.Drawing.Color.Black;
            this.btnUnlink.Location = new System.Drawing.Point(152, 3);
            this.btnUnlink.Name = "btnUnlink";
            this.btnUnlink.Size = new System.Drawing.Size(66, 23);
            this.btnUnlink.TabIndex = 10;
            this.btnUnlink.Text = "Unlink";
            this.btnUnlink.Visible = false;
            this.btnUnlink.Click += new System.EventHandler(this.btnUnlink_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnEnd.ForeColor = System.Drawing.Color.Black;
            this.btnEnd.Location = new System.Drawing.Point(15, 121);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(66, 23);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "Success";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnLink
            // 
            this.btnLink.ForeColor = System.Drawing.Color.Black;
            this.btnLink.Location = new System.Drawing.Point(62, 3);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(56, 23);
            this.btnLink.TabIndex = 9;
            this.btnLink.Text = "Link";
            this.btnLink.Visible = false;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblmsg.Location = new System.Drawing.Point(5, 149);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(317, 33);
            // 
            // btnRefreshLight
            // 
            this.btnRefreshLight.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnRefreshLight.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshLight.Location = new System.Drawing.Point(247, 3);
            this.btnRefreshLight.Name = "btnRefreshLight";
            this.btnRefreshLight.Size = new System.Drawing.Size(56, 23);
            this.btnRefreshLight.TabIndex = 93;
            this.btnRefreshLight.Text = "R(Light)";
            this.btnRefreshLight.Visible = false;
            this.btnRefreshLight.Click += new System.EventHandler(this.btnRefreshLight_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mmuQuery);
            // 
            // mmuQuery
            // 
            this.mmuQuery.MenuItems.Add(this.menuItem2);
            this.mmuQuery.MenuItems.Add(this.menuItem3);
            this.mmuQuery.Text = "Search";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Find the light indicator";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Save the light indicator";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(62, 90);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(146, 23);
            this.txtGroup.TabIndex = 4;
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnRefreshData.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshData.Location = new System.Drawing.Point(99, 121);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(67, 23);
            this.btnRefreshData.TabIndex = 8;
            this.btnRefreshData.Text = "Re scan";
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // listViewDIDStock
            // 
            this.listViewDIDStock.Location = new System.Drawing.Point(5, 185);
            this.listViewDIDStock.Name = "listViewDIDStock";
            this.listViewDIDStock.Size = new System.Drawing.Size(316, 107);
            this.listViewDIDStock.TabIndex = 134;
            // 
            // cboRack_SN
            // 
            this.cboRack_SN.Enabled = false;
            this.cboRack_SN.Location = new System.Drawing.Point(62, 32);
            this.cboRack_SN.Name = "cboRack_SN";
            this.cboRack_SN.Size = new System.Drawing.Size(146, 23);
            this.cboRack_SN.TabIndex = 1;
            this.cboRack_SN.SelectedIndexChanged += new System.EventHandler(this.cboRack_SN_SelectedIndexChanged_1);
            // 
            // chkUnlinkDID
            // 
            this.chkUnlinkDID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.chkUnlinkDID.Location = new System.Drawing.Point(247, 124);
            this.chkUnlinkDID.Name = "chkUnlinkDID";
            this.chkUnlinkDID.Size = new System.Drawing.Size(74, 20);
            this.chkUnlinkDID.TabIndex = 6;
            this.chkUnlinkDID.Text = "Unlink(D)";
            this.chkUnlinkDID.Click += new System.EventHandler(this.chkUnlinkDID_Click);
            // 
            // chkUnlinkRack
            // 
            this.chkUnlinkRack.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.chkUnlinkRack.Location = new System.Drawing.Point(172, 124);
            this.chkUnlinkRack.Name = "chkUnlinkRack";
            this.chkUnlinkRack.Size = new System.Drawing.Size(79, 20);
            this.chkUnlinkRack.TabIndex = 5;
            this.chkUnlinkRack.Text = "Unlink(R)";
            this.chkUnlinkRack.Click += new System.EventHandler(this.chkUnlinkRack_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(220, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.Text = "Side/Line/Tab:";
            // 
            // txtScanSLT
            // 
            this.txtScanSLT.Location = new System.Drawing.Point(221, 61);
            this.txtScanSLT.Name = "txtScanSLT";
            this.txtScanSLT.Size = new System.Drawing.Size(99, 23);
            this.txtScanSLT.TabIndex = 2;
            this.txtScanSLT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanSLT_KeyDown);
            // 
            // frmDIDStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(325, 295);
            this.Controls.Add(this.txtScanSLT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkUnlinkRack);
            this.Controls.Add(this.chkUnlinkDID);
            this.Controls.Add(this.cboRack_SN);
            this.Controls.Add(this.listViewDIDStock);
            this.Controls.Add(this.btnRefreshData);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.btnRefreshLight);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnUnlink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboSide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Menu = this.mainMenu1;
            this.Name = "frmDIDStock";
            this.Text = "DIDStock20210306";
            this.Load += new System.EventHandler(this.frmDIDStock_Load);
            this.ResumeLayout(false);
            // 
            // barcodeSLT
            // 
            this.barcodeSLT.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barcodeSLT_OnRead_1);
            this.barcodeSLT.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barcodeSLT.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barcodeSLT.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barcodeSLT.DecoderParameters.CODABARParams.Redundancy = true;
            this.barcodeSLT.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barcodeSLT.DecoderParameters.CODE128Params.EAN128 = true;
            this.barcodeSLT.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barcodeSLT.DecoderParameters.CODE128Params.Other128 = true;
            this.barcodeSLT.DecoderParameters.CODE128Params.Redundancy = false;
            this.barcodeSLT.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barcodeSLT.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barcodeSLT.DecoderParameters.CODE39Params.Concatenation = false;
            this.barcodeSLT.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barcodeSLT.DecoderParameters.CODE39Params.FullAscii = false;
            this.barcodeSLT.DecoderParameters.CODE39Params.Redundancy = false;
            this.barcodeSLT.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barcodeSLT.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barcodeSLT.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barcodeSLT.DecoderParameters.CODE93Params.Redundancy = false;
            this.barcodeSLT.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barcodeSLT.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barcodeSLT.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barcodeSLT.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barcodeSLT.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barcodeSLT.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barcodeSLT.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barcodeSLT.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barcodeSLT.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barcodeSLT.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barcodeSLT.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barcodeSLT.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barcodeSLT.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barcodeSLT.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barcodeSLT.DecoderParameters.MSIParams.Redundancy = true;
            this.barcodeSLT.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barcodeSLT.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barcodeSLT.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barcodeSLT.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barcodeSLT.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barcodeSLT.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barcodeSLT.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barcodeSLT.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barcodeSLT.DeviceName = null;
            this.barcodeSLT.EnableScanner = true;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barcodeSLT.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barcodeSLT.ScanParameters.BeepFrequency = 2670;
            this.barcodeSLT.ScanParameters.BeepTime = 200;
            this.barcodeSLT.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barcodeSLT.ScanParameters.LedTime = 3000;
            this.barcodeSLT.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barcodeSLT.ScanParameters.WaveFile = "";

            //barcodeDID
            this.barcodeDID.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barcodeDID.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barcodeDID.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barcodeDID.DecoderParameters.CODABARParams.Redundancy = true;
            this.barcodeDID.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barcodeDID.DecoderParameters.CODE128Params.EAN128 = true;
            this.barcodeDID.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barcodeDID.DecoderParameters.CODE128Params.Other128 = true;
            this.barcodeDID.DecoderParameters.CODE128Params.Redundancy = false;
            this.barcodeDID.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barcodeDID.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barcodeDID.DecoderParameters.CODE39Params.Concatenation = false;
            this.barcodeDID.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barcodeDID.DecoderParameters.CODE39Params.FullAscii = false;
            this.barcodeDID.DecoderParameters.CODE39Params.Redundancy = false;
            this.barcodeDID.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barcodeDID.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barcodeDID.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barcodeDID.DecoderParameters.CODE93Params.Redundancy = false;
            this.barcodeDID.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barcodeDID.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barcodeDID.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barcodeDID.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barcodeDID.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barcodeDID.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barcodeDID.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barcodeDID.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barcodeDID.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barcodeDID.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barcodeDID.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barcodeDID.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barcodeDID.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barcodeDID.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barcodeDID.DecoderParameters.MSIParams.Redundancy = true;
            this.barcodeDID.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barcodeDID.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barcodeDID.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barcodeDID.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barcodeDID.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barcodeDID.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barcodeDID.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barcodeDID.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barcodeDID.DeviceName = null;
            this.barcodeDID.EnableScanner = true;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barcodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barcodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barcodeDID.ScanParameters.BeepFrequency = 2670;
            this.barcodeDID.ScanParameters.BeepTime = 200;
            this.barcodeDID.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barcodeDID.ScanParameters.LedTime = 3000;
            this.barcodeDID.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barcodeDID.ScanParameters.WaveFile = "";
            this.barcodeDID.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barcodeDID_OnRead);

        }

        #endregion
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnlink;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Label lblmsg;
        private Barcode.Barcode barcodeDID;
        private System.Windows.Forms.Button btnRefreshLight;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mmuQuery;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.ListView listViewDIDStock;
        private System.Windows.Forms.ComboBox cboRack_SN;
        private System.Windows.Forms.CheckBox chkUnlinkDID;
        private System.Windows.Forms.CheckBox chkUnlinkRack;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtScanSLT;
        private Barcode.Barcode barcodeSLT;
    }
}