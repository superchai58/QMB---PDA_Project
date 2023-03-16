namespace PDA_DIDSlotLink
{
    partial class frmSelect
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboSide = new System.Windows.Forms.ComboBox();
            //this.cboLine = new System.Windows.Forms.ComboBox();
            this.lblSide = new System.Windows.Forms.Label();
            //this.lblLine = new System.Windows.Forms.Label();
            //this.cboLR = new System.Windows.Forms.ComboBox();
            //this.label1 = new System.Windows.Forms.Label();
            //this.label2 = new System.Windows.Forms.Label();
            //this.cboLR1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(159, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 30);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(52, 201);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 30);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboSide
            // 
            this.cboSide.Items.Add("S");
            this.cboSide.Items.Add("C");
            this.cboSide.Location = new System.Drawing.Point(104, 70);
            this.cboSide.Name = "cboSide";
            this.cboSide.Size = new System.Drawing.Size(137, 23);
            this.cboSide.TabIndex = 31;
            // 
            // cboLine
            // 
            //this.cboLine.Location = new System.Drawing.Point(104, 20);
            //this.cboLine.Name = "cboLine";
            //this.cboLine.Size = new System.Drawing.Size(137, 23);
            //this.cboLine.TabIndex = 30;
            //this.cboLine.Visible = true;
            // 
            // lblSide
            // 
            this.lblSide.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.lblSide.Location = new System.Drawing.Point(16, 65);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(75, 28);
            this.lblSide.Text = "Side";
             
            // lblLine
            // 
            //this.lblLine.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            //this.lblLine.Location = new System.Drawing.Point(16, 15);
            //this.lblLine.Name = "lblLine";
            //this.lblLine.Size = new System.Drawing.Size(75, 28);
            //this.lblLine.Text = "Line";
            //this.lblLine.Visible = true;
            // 
            // cboLR
            // 
            //this.cboLR.Items.Add("1");
            //this.cboLR.Items.Add("2");
            //this.cboLR.Location = new System.Drawing.Point(104, 114);
            //this.cboLR.Name = "cboLR";
            //this.cboLR.Size = new System.Drawing.Size(137, 23);
            //this.cboLR.TabIndex = 37;
            //this.cboLR.Visible = true;
            // 
            // label1
            // 
            //this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            //this.label1.Location = new System.Drawing.Point(16, 109);
            //this.label1.Name = "label1";
            //this.label1.Size = new System.Drawing.Size(95, 28);
            //this.label1.Text = "Table1";
            //this.label1.Visible = true;
            // 
            // label2
            // 
            //this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            //this.label2.Location = new System.Drawing.Point(16, 154);
            //this.label2.Name = "label2";
            //this.label2.Size = new System.Drawing.Size(100, 31);
            //this.label2.Text = "Table2";
            // 
            // cboLR1
            // 
            //this.cboLR1.Items.Add("3");
            //this.cboLR1.Items.Add("4");
            //this.cboLR1.Location = new System.Drawing.Point(105, 162);
            //this.cboLR1.Name = "cboLR1";
            //this.cboLR1.Size = new System.Drawing.Size(136, 23);
            //this.cboLR1.TabIndex = 42;
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(282, 247);
            //this.Controls.Add(this.cboLR1);
            //this.Controls.Add(this.label2);
            //this.Controls.Add(this.cboLR);
            //this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboSide);
            //this.Controls.Add(this.cboLine);
            this.Controls.Add(this.lblSide);
            //this.Controls.Add(this.lblLine);
            this.Name = "frmSelect";
            this.Text = "Select【20191115】";
            this.Load += new System.EventHandler(this.frmSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboSide;
        //private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.Label lblSide;
        //private System.Windows.Forms.Label lblLine;
        //private System.Windows.Forms.ComboBox cboLR;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.ComboBox cboLR1;
    }
}

