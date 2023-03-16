namespace PDA_DIDSlotLink
{
    partial class frmSetting
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
            this.lstvMachine = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstvLastMachine = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboLR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChkMachine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstvMachine
            // 
            this.lstvMachine.CheckBoxes = true;
            this.lstvMachine.Location = new System.Drawing.Point(179, 38);
            this.lstvMachine.Name = "lstvMachine";
            this.lstvMachine.Size = new System.Drawing.Size(136, 149);
            this.lstvMachine.TabIndex = 19;
            this.lstvMachine.View = System.Windows.Forms.View.List;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(179, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 30);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(68, 202);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 30);
            this.btnOK.TabIndex = 34;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboLine
            // 
            this.cboLine.Location = new System.Drawing.Point(75, 9);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(73, 23);
            this.cboLine.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.Text = "Line";
            // 
            // lstvLastMachine
            // 
            this.lstvLastMachine.CheckBoxes = true;
            this.lstvLastMachine.Location = new System.Drawing.Point(3, 40);
            this.lstvLastMachine.Name = "lstvLastMachine";
            this.lstvLastMachine.Size = new System.Drawing.Size(120, 150);
            this.lstvLastMachine.TabIndex = 44;
            this.lstvLastMachine.View = System.Windows.Forms.View.List;
            this.lstvLastMachine.SelectedIndexChanged += new System.EventHandler(this.lstvLastMachine_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(135, 132);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 32);
            this.btnRemove.TabIndex = 46;
            this.btnRemove.Text = "<";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = ">";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboLR
            // 
            this.cboLR.Items.Add("1");
            this.cboLR.Items.Add("2");
            this.cboLR.Items.Add("3");
            this.cboLR.Items.Add("4");
            this.cboLR.Location = new System.Drawing.Point(233, 9);
            this.cboLR.Name = "cboLR";
            this.cboLR.Size = new System.Drawing.Size(66, 23);
            this.cboLR.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.Text = "Table";
            // 
            // txtChkMachine
            // 
            this.txtChkMachine.AcceptsReturn = true;
            this.txtChkMachine.AcceptsTab = true;
            this.txtChkMachine.BackColor = System.Drawing.SystemColors.Control;
            this.txtChkMachine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChkMachine.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtChkMachine.ForeColor = System.Drawing.Color.Red;
            this.txtChkMachine.Location = new System.Drawing.Point(6, 236);
            this.txtChkMachine.Multiline = true;
            this.txtChkMachine.Name = "txtChkMachine";
            this.txtChkMachine.ReadOnly = true;
            this.txtChkMachine.Size = new System.Drawing.Size(306, 56);
            this.txtChkMachine.TabIndex = 50;
            this.txtChkMachine.TextChanged += new System.EventHandler(this.txtChkMachine_TextChanged);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.txtChkMachine);
            this.Controls.Add(this.cboLR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstvLastMachine);
            this.Controls.Add(this.cboLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstvMachine);
            this.Name = "frmSetting";
            this.Text = "ตั้งค่า(设置)";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvMachine;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstvLastMachine;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboLR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChkMachine;
    }
}