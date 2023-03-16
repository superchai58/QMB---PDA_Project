using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using NSIniFile;
//using Encryption;
using System.Xml;

namespace PDA_DIDSlotLink
{
    public partial class frmSelect : Form
    {
        string strSQL = "";
        SQLHelper sqlHelper = new SQLHelper();
        PlaySound playSound = new PlaySound();
        XmlDocument myConfig = new XmlDocument();

        public frmSelect()
        {
            InitializeComponent();
            readXML();
           
                
        }

        private void readXML()
        {
            string appName = System.Reflection.Assembly.GetCallingAssembly().GetName().CodeBase;
            string appPath = System.IO.Path.GetDirectoryName(appName);
            myConfig.Load(appPath + "\\config.xml");
            XmlNode xNode;
           // XmlElement xSMT, xQSMS, xChkFeederLine, xChkFirst, xChkPolar, xChkDispatchOrder, xErrorReconfirm, xChkDIDTime, xTimeSpan, xChkDIDTimeSec, xTimeSpanSec, xDoubleChkOldDid,xChkVendorPN; //,xChkMachine;    //(0001)
            XmlElement xSMT, xQSMS, xChkFeederLine, xChkFirst, xChkPolar, xChkDispatchOrder, xErrorReconfirm, xChkDIDTime, xTimeSpan, xChkDIDTimeSec, xTimeSpanSec, xDoubleChkOldDid, xChkVendorPN, xControlLight; //,xChkMachine;    //(0001)
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
            xChkVendorPN = (XmlElement)xNode.SelectSingleNode("ChkVendorPN");
            xControlLight = (XmlElement)xNode.SelectSingleNode("ControlLight");
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
            Parameter.strChkVendorPN = xChkVendorPN.InnerText.Trim().ToString();
            Parameter.ControlLight = xControlLight.InnerText.Trim().ToString();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Parameter.strChkMachine = "";
            //Parameter.strLine = cboLine.Text.ToString();
            Parameter.strSide = cboSide.Text.ToString();
            //Parameter.strLR = cboLR.Text.ToString();
            //Parameter.strLR1 = cboLR1.Text.ToString();
            strSQL = "select Machine from Machine where line in ('" + Parameter.strLine + "','ALL') and Side in ('" + Parameter.strSide + "','ALL')";
        
            DataTable dtGetMachine = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            DataRow dr = null;
            try
            {
                for (int i = 0; i < dtGetMachine.Rows.Count; i++)
                {
                    string k = "";
                    dr = dtGetMachine.Rows[i];
                    k = dr["Machine"].ToString();
                    k = k.Substring(k.Length - 1, 1);
                    Parameter.strChkMachine = Parameter.strChkMachine + Parameter.strLine + Parameter.strLR + k + ",";
                    Parameter.strChkMachine = Parameter.strChkMachine + Parameter.strLine + Parameter.strLR1 + k + ",";
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("ข้อผิดพลาดของโปรแกรมกรุณาโทร QMS(Program Error , Please Call QMS)");
                MessageBox.Show("Program Error , Please Call QMS");
                return;
            }
            this.Hide();
            frmNeedSpliced myFrmNeedSpliced = new frmNeedSpliced();
            myFrmNeedSpliced.Show();
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {
            #region// Check if the Program has been opened.
            //Process[] currentProcess = Process.GetProcesses();


            //int currentProCount = 0;

            //for (int i = 0; i < currentProcess.Length; i++)
            //{
            //    if (currentProcess[i].ProcessName.ToUpper() == Parameter.AppName.ToUpper() + ".EXE")
            //    {
            //        currentProcess[i].Kill();
            //        currentProCount = currentProCount + 1;
            //    }
            //}
            //if (currentProCount > 1)
            //{
            //    MessageBox.Show("程序已经运行,请检查！");
            //    this.Close();
            //}
            #endregion    

            //strSQL = "select distinct line from Routingline where line<>'' union select distinct Line from Application_List order by line";
            //DataTable dtGetLine = sqlHelper.getDataTable(strSQL, SQLHelper.strSMTDBName);
            //if (dtGetLine.Rows.Count != 0)
            //{
            //    for (int intR = 0; intR < dtGetLine.Rows.Count; intR++)
            //    {
            //        cboLine.Items.Add(dtGetLine.Rows[intR]["Line"].ToString());
            //    }
            //}
            //获取相关设置
            strSQL = "select * from QSMS_ProConfig where Station='DIDSlotLink' and line in ('" + Parameter.strLine + "','ALL') and [Session]='BASE'";
            DataTable dtGetSetting = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            DataRow dr = null;
            try
            {
                for (int i = 0; i < dtGetSetting.Rows.Count; i++)
                {
                    dr = dtGetSetting.Rows[i];
                    if (dr["Key"].ToString().ToUpper() == "CHECKSPLICEPN")
                    {
                        Parameter.strCheckSplicePN = dr["Value"].ToString();
                    }
                    if (dr["Key"].ToString().ToUpper() == "CHECKSPLICEREPLACEPN")
                    {
                        Parameter.strCheckSpliceReplacePN = dr["Value"].ToString();
                    }                    
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("ข้อผิดพลาดของโปรแกรมกรุณาโทร QMS(Program Error , Please Call QMS)");
                MessageBox.Show("Program Error , Please Call QMS");
                return;
            }
        }
    }

}