using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;



namespace PDA_DIDSlotLink
{
    public partial class frmLogin : Form
    {
        string strSQL = "";
        
        SQLHelper sqlHelper = new SQLHelper();
        PlaySound playSound = new PlaySound();
        XmlDocument myConfig = new XmlDocument();
        //CDealFile CDFile = new CDealFile();
        public frmLogin()
        {
            InitializeComponent();
            //readXML();
           
        }
        private void readXML()
        {
            string appName = System.Reflection.Assembly.GetCallingAssembly().GetName().CodeBase;
            string appPath = System.IO.Path.GetDirectoryName(appName);
            myConfig.Load(appPath + "\\config.xml");
            XmlNode xNode;
            XmlElement xCheckBulk, xSMT, xQSMS, xChkFeederLine, xChkFirst, xChkPolar, xChkDispatchOrder, xErrorReconfirm, xChkDIDTime, xTimeSpan, xChkDIDTimeSec, xTimeSpanSec, xDoubleChkOldDid, xChkVendorPN; //,xChkMachine;    //(0001)
            xNode = myConfig.SelectSingleNode("config");
            xSMT = (XmlElement)xNode.SelectSingleNode("SMT");
            xQSMS = (XmlElement)xNode.SelectSingleNode("QSMS");
            xChkFeederLine = (XmlElement)xNode.SelectSingleNode("ChkFeederLine");
            xChkFirst = (XmlElement)xNode.SelectSingleNode("ChkFirst");
            xChkPolar = (XmlElement)xNode.SelectSingleNode("ChkPolar"); //(0001)
            xChkDispatchOrder = (XmlElement)xNode.SelectSingleNode("ChkDispatchOrder");
            xErrorReconfirm = (XmlElement)xNode.SelectSingleNode("ErrorReconfirm"); //(0003)
            xChkDIDTime = (XmlElement)xNode.SelectSingleNode("ChkDIDTime");
            xTimeSpan = (XmlElement)xNode.SelectSingleNode("TimeSpan");
            xChkDIDTimeSec = (XmlElement)xNode.SelectSingleNode("ChkDIDTimeSec");
            xTimeSpanSec = (XmlElement)xNode.SelectSingleNode("TimeSpanSec");//(0005)
            xDoubleChkOldDid = (XmlElement)xNode.SelectSingleNode("DoubleChkOldDid");
            xCheckBulk = (XmlElement)xNode.SelectSingleNode("CheckBulk");
            //xChkVendorPN = (XmlElement)xNode.SelectSingleNode("ChkVendorPN");
            //xChkMachine = (XmlElement)xNode.SelectSingleNode("ChkMachine");

            SQLHelper.strSMTDBCon = xSMT.InnerText + "password=is6<2g;Persist Security Info=True";
            SQLHelper.strQSMSDBCon = xQSMS.InnerText + "password=is6<2g;Persist Security Info=True";
            Parameter.strChkFeederLine = xChkFeederLine.InnerText.Trim().ToString();
            Parameter.strChkFirst = xChkFirst.InnerText.Trim().ToString();
            Parameter.strChkPolar = xChkPolar.InnerText.Trim().ToString(); //(0001)
            Parameter.strChkDispatchOrder = xChkDispatchOrder.InnerText.Trim().ToString(); //(0002)
            Parameter.strErrorReconfirm = xErrorReconfirm.InnerText.Trim().ToString();//(0003)
            Parameter.strChkDIDTime = xChkDIDTime.InnerText.Trim().ToString();
            Parameter.strTimeSpan = double.Parse(xTimeSpan.InnerText.Trim().ToString());
            Parameter.strChkDIDTimeSec = xChkDIDTimeSec.InnerText.Trim().ToString();
            Parameter.strTimeSpanSec = double.Parse(xTimeSpanSec.InnerText.Trim().ToString());//(0005)
            Parameter.DoubleChkOldDid = xDoubleChkOldDid.InnerText.Trim().ToString();
            Parameter.strServer = xSMT.InnerText.Trim().Substring(8, 11);
            Parameter.CheckBulk = xCheckBulk.InnerText.Trim().ToString();
            //Parameter.strChkVendorPN = xChkVendorPN.InnerText.Trim().ToString();
            //Parameter.strChkMachine = xChkMachine.InnerText.Trim().ToString();
            try
            {
                Parameter.strChkMachine = RegeditManager.Read("ChkMachine");
            }
            catch
            {
            }
        }
            
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" && Parameter.strNeedPassWord.Trim()=="Y")
            {
                playSound.Play("\\Voice\\ERROR.wav");
                MessageBox.Show("Please input PassWord!");
            }             
        
            Parameter.strUserName = txtUserName.Text.Trim();
            //strSQL = "select PU from site";
            //DataSet dsCheckPU = sqlHelper.GetSqlDataSet(strSQL, "SMT");
            //Parameter.StrPU = dsCheckPU.Tables[0].Rows[0]["PU"].ToString();
            
            strSQL = "EXEC PDA_AuthorityCheck @UserName='" + txtUserName.Text.Trim() + "',@PassWord='" + txtPassword.Text.Trim() + "',@AppName='DIDSlotLink',@UserRight='" + Parameter.strUserRight.Trim() + "',@NeedPassWord='" + Parameter.strNeedPassWord.Trim() + "'";

            DataSet dsCheckLogin = sqlHelper.GetSqlDataSet(strSQL, "SMT");
            if (dsCheckLogin.Tables[0].Rows[0]["Result"].ToString() == "0")
            {
                if (chkPassword.Checked)
                {
                    Parameter.PasswordKept = true;
                    Parameter.strPassword = txtPassword.Text.Trim().ToString();
                }
                else
                {
                    Parameter.PasswordKept = false;
                }
                //(0003)
                if (Parameter.strUserRight != "ErrorReconfirm")
                {
                    Parameter.strAccessFlag = "Y";
                }
                barCodeLogin.EnableScanner = false;

                //if (Parameter.strUserRight.Trim() == "CheckSplicePN" && Parameter.StrPU=="PU5")
                //{

                //    Parameter.strUserNameOPID = txtUserName.Text;                   
                //    barCodeLogin.EnableScanner = false;
                //    this.DialogResult = DialogResult.OK;         
                //    this.Close();                 

                //}
                //else
                //{
                    this.Close();                 
                   
                //}

            }
            else
            {
                MessageBox.Show("'" + dsCheckLogin.Tables[0].Rows[0]["Description"].ToString() + "'");
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            barCodeLogin.EnableScanner = false;
            this.Close();
          
             //Application.Exit();          
        }

        private void frmLogin_Closed(object sender, EventArgs e)
        {
            barCodeLogin.EnableScanner = false;
            this.Close();
           
            //if (chkPassword.Checked)
            //{                 
            //    CDFile.WriteRegKey("PAL_WHStock_PDA_Password", txtPassword.Text.Trim().ToString());            
            //}
            //else
            //{

            //    CDFile.WriteRegKey("PAL_WHStock_PDA_Password", "");
            //}       
            //Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            if (Parameter.strUserRight.Trim() == "CheckSplicePN")
            {
                txtPassword.Visible = false;
                lblPassWord.Visible = false;
                //this.Text = "OP ยืนยัน(OP确认)";
                this.Text = "OP confirm.";
            }
            else if (Parameter.strUserRight.Trim() == "ErrorReconfirm")  //(0003)
            {
                this.ControlBox = false;
                //this.Text = "หัวหน้ากลุ่มยืนยัน(组长确认)";
                this.Text = "Confirmation group leader.";
            }
            else if (Parameter.strUserRight.Trim() == "CheckSpliceReplacePN")
            {
                //this.Text = "การยืนยันทางวิศวกรรม(工程确认)";
                this.Text = "Engineering confirmation.";
            }
            //#region//Get the password from Register
            ////txtPassword.Text = CDFile.ReadRegKey("PAL_WHStock_PDA_Password");
            ////if (txtPassword.Text != "")
            ////{
            ////    Parameter.PasswordKept = true;
            ////    chkPassword.Checked = true;
            ////}
            //#endregion
        }

        private void barCodeLogin_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (readerData.Text == "")
                return;

            if (txtUserName.Text == "")
            {
                txtUserName.Text = readerData.Text;
                if (Parameter.strUserRight.Trim() == "CheckSplicePN")
                {
                    btnOK_Click(null, null);
                }
                else
                {
                    txtPassword.Focus();
                }
            }
            else if (txtPassword.Text == "")
            {
                txtPassword.Text = readerData.Text;
                btnOK_Click(null, null);
            }   
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            SendKey(e.KeyData);
        }

        private void SendKey(Keys keydata)
        {
            switch (keydata)
            {
                case Keys.Enter:
                    {
                        if (txtUserName.Text != "")
                        {
                            if (txtPassword.Text != "")
                            {
                                btnOK_Click(null, null);
                            }
                            else if (Parameter.strUserRight.Trim() == "CheckSplicePN")
                            {
                                btnOK_Click(null, null);
                            }
                        }
                        break;
                    }
                case Keys.F1:
                    MessageBox.Show("You Key the F1");
                    break;
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            SendKey(e.KeyData);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            SendKey(e.KeyData);
        }
    }
}