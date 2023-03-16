namespace PDA_DIDSlotLink
{
    partial class frmScanDID
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldDID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewDID = new System.Windows.Forms.TextBox();
            this.cboLR = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.Text = "OldDID";
            // 
            // txtOldDID
            // 
            this.txtOldDID.Location = new System.Drawing.Point(101, 40);
            this.txtOldDID.Name = "txtOldDID";
            this.txtOldDID.Size = new System.Drawing.Size(164, 23);
            this.txtOldDID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.Text = "NewDID";
            // 
            // txtNewDID
            // 
            this.txtNewDID.Location = new System.Drawing.Point(101, 84);
            this.txtNewDID.Name = "txtNewDID";
            this.txtNewDID.Size = new System.Drawing.Size(164, 23);
            this.txtNewDID.TabIndex = 4;
            // 
            // cboLR
            // 
            this.cboLR.Items.Add("L");
            this.cboLR.Items.Add("R");
            this.cboLR.Location = new System.Drawing.Point(155, 127);
            this.cboLR.Name = "cboLR";
            this.cboLR.Size = new System.Drawing.Size(44, 23);
            this.cboLR.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(124, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.Text = "LR:";
            // 
            // frmScanDID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(322, 276);
            this.Controls.Add(this.cboLR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewDID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldDID);
            this.Controls.Add(this.label1);
            this.Name = "frmScanDID";
            this.Text = "frmScanDID";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldDID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewDID;
        private System.Windows.Forms.ComboBox cboLR;
        private System.Windows.Forms.Label label3;
    }
}