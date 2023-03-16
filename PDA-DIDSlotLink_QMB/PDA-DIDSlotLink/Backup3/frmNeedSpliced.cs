using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PDA_DIDSlotLink
{
    public partial class frmNeedSpliced : Form
    {
        private string strSQL = "";
        private string strDiffVendor;
        private string strNoCheckReplacePNSplicing;
        private int k = 0;
        private string nextDID;
        private string nextDID2;
        private string SecondDID;
        private string CompPN = "";
        private DateTime oldDIDScanTime;
        private DateTime newDIDScanTime;
        private DateTime SecondoldDIDScanTime;

        private string old = "0"; //20201214 添加old参数判断是接料还是取料流程

        private string RackDID = "";
        private string StoreID = "";
        private string line = "";
        private string Slot = "";
        private string DID = "";

        private string TestStr = "";

        string[] strAlarmType;  //报警类型
        string[] strMulitLine;
        string[] strOldDID;
        string[] strJobPN;
        string[] strMachine;
        string[] strSlot;
        string[] strLR;
       

        SQLHelper sqlHelper = new SQLHelper();
        PlaySound playSound = new PlaySound();
        //frmOverTimeDID myfrmOverTimeDID = new frmOverTimeDID();

        public frmNeedSpliced()
        {
            InitializeComponent();
        }

        private void frmNeedSpliced_Load(object sender, EventArgs e)
        {
            refreshDatalv();
            txtOldDID.Focus();

            lvAlarmDID.FullRowSelect = true;
            lvAlarmDID.Columns.Add("  ", 20, HorizontalAlignment.Center);
            //lvAlarmDID.Columns.Add("เวลาที่เหลือ(剩余时间)", 80, HorizontalAlignment.Center);
            lvAlarmDID.Columns.Add("Remaining time.", 80, HorizontalAlignment.Center);

            //lvAlarmDID.Columns.Add("เครื่อง(机台)", 50, HorizontalAlignment.Center);
            lvAlarmDID.Columns.Add("Machine.", 50, HorizontalAlignment.Center);

            //lvAlarmDID.Columns.Add("สถานี(站位)", 50, HorizontalAlignment.Center);
            lvAlarmDID.Columns.Add("Station.", 50, HorizontalAlignment.Center);

            lvAlarmDID.Columns.Add("DID", 170, HorizontalAlignment.Center);
            
            //lvAlarmDID.Columns.Add("จำนวนชิ้นที่เหลือ(剩余片数)", 70, HorizontalAlignment.Center);
            lvAlarmDID.Columns.Add("Number of pieces remaining.", 70, HorizontalAlignment.Center);

            //lvAlarmDID.Columns.Add("ปริมาณที่เหลืออยู่(剩余数量)", 70, HorizontalAlignment.Center);
            lvAlarmDID.Columns.Add("Number of pieces remaining.", 70, HorizontalAlignment.Center);

            //lvAlarmDID.Columns.Add("อย่าใบหน้า(面别)", 40, HorizontalAlignment.Center);
            lvAlarmDID.Columns.Add("Do not face.", 40, HorizontalAlignment.Center);

            //lvAlarmDID.Columns.Add("จำนวนพระคาร์ดินัล(基数)", 40, HorizontalAlignment.Center);
            lvAlarmDID.Columns.Add("Cardinal number.", 40, HorizontalAlignment.Center);

            lvAlarmDID.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvAlarmDID.View = View.Details;       
            //DataGridTableStyle tableStyle = new DataGridTableStyle();
            //DataGridColumnStyle noColumnStyle = new DataGridTextBoxColumn();
            //noColumnStyle.MappingName = "DID";
            //noColumnStyle.HeaderText = "DID";
            //noColumnStyle.Width = 200;
            //tableStyle.GridColumnStyles.Add(noColumnStyle);
        }

        private void dgvAlarmDID_Click(object sender, EventArgs e)
        {
            //frmScanDID myScanDID = new frmScanDID();
            //myScanDID.Show();
        }

        private void barCodeDID_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (readerData.Text == "")
            {
                //MessageBox.Show("ไม่มีข้อมูลโปรดสแกนอีกครั้ง(No data,Please re-scan)!", "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                MessageBox.Show("No data,Please re-scan !", "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1); 
                return;
            }

            if (txtOldDID.Text == "")//1017
            {
                txtOldDID.Text = readerData.Text;
                checkOldDID(txtOldDID.Text);
                oldDIDScanTime = DateTime.Now;
                if (txtOldDID.Text != "" && CompPN == "")
                {
                    checkOverTimeDID(txtOldDID.Text);
                }
                this.ControlBox = false;

            }
           /* if (txtOldDID.Text == "")
            {
                oldDIDScanTime = DateTime.Now;
                txtOldDID.Text = readerData.Text;
                checkOverTimeDID(txtOldDID.Text);  //提示2天前未使用的DID               
                checkOldDID(txtOldDID.Text);
                this.ControlBox = false;
            }*/
            //else if (txtVendorPN.Text == "")
            //{
            //    if (Parameter.strChkVendorPN == "Y")
            //    {
            //        VendorPN = "";
            //        txtVendorPN.Text = readerData.Text;
            //        strVerdorPN = Regex.Split(txtVendorPN.Text, ";", RegexOptions.IgnoreCase);
            //        VendorPN = strVerdorPN[0];
            //    }
            //}
            else if (txtNewDID.Text=="")
            {
                newDIDScanTime = DateTime.Now;
                System.TimeSpan timeSpan = newDIDScanTime - oldDIDScanTime;
                double time = timeSpan.TotalSeconds;
                if (Parameter.strChkDIDTime== "Y")
                {
                    if (time < Parameter.strTimeSpan)
                    {
                        MessageBox.Show("The time span is less than " + Parameter.strTimeSpan.ToString() + " Seconds", "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        return;

                    }
                }
                txtNewDID.Text = readerData.Text;
               
                if (Parameter.DoubleChkOldDid != "Y")
                {
                    checkNewDID(txtNewDID.Text);
                }
                else
                {
                    if (CompPN == "")
                    {
                        //MessageBox.Show("กรุณาสแกน CompPN อีกครั้ง(Please Scan CompPN)", "Scan CompPN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        MessageBox.Show("Please Scan CompPN", "Scan CompPN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        CompPN = "";

                        checkNewDID(txtNewDID.Text);
                    }
                  //  MessageBox.Show("กรุณาสแกน OldDid อีกครั้ง(Please Scan OldDid Again)", "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

                }
            }
            //else if (txtOldDID.Text != "" && txtNewDID.Text != "" && Parameter.DoubleChkOldDid == "Y")
            else if (txtOldDID.Text != "" && txtNewDID.Text != "" && CompPN == "")
            {
                CompPN = "";
                SecondoldDIDScanTime = DateTime.Now;//(0005)
                System.TimeSpan timeSpanSeq = SecondoldDIDScanTime - newDIDScanTime;
                double time2 = timeSpanSeq.TotalSeconds;
                if (Parameter.strChkDIDTimeSec == "Y")
                {
                    if (time2 < Parameter.strTimeSpanSec)
                    {
                        MessageBox.Show("The time span is less than " + Parameter.strTimeSpanSec.ToString() + " Seconds", "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        return;

                    }
                }

                string GetCompPN = readerData.Text;
                CompPN = GetCompPN;
                //if (GetCompPN.Trim().Substring(0, 11) != txtOldDID.Text.Trim().Substring(0, 11) || GetCompPN.Trim().Substring(11, 1) != ";")
                if (GetCompPN.Trim().Substring(0, 11) != txtNewDID.Text.Trim().Substring(0, 11) || GetCompPN.Trim().Substring(11, 1) != ";")
                {
                    MessageBox.Show("Please scan correct CompPN :" + CompPN, "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    CompPN = "";
                    return;
                }
                else if (Parameter.ControlLight == "Y")//1017
                {
                    if (txtNewDID.Text != RackDID)
                    {
                        string strDIDtemp = RackDID + ";" + txtNewDID.Text.Trim().ToString();
                        strSQL = "Exec PDA_ControlLight @Type= 'SplicePNError',@DID='" + strDIDtemp + "',@Machine='',@line='',@Slot='',@LR='',@color='R',@uid='" + Parameter.strUserName + "'";
                        DataSet dsGetSocketLEDR = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
                        //if (dsGetSocketLEDR.Tables[0].Rows[0]["Result"].ToString().Trim() != "0")
                        //{
                        //    MessageBox.Show(dsGetSocketLEDR.Tables[0].Rows[0]["Msg"].ToString());
                        //}
                        //MessageBox.Show("新DID与料架亮灯DID不一致,请重新点击OldDID取料:");
                        MessageBox.Show("The new DID is inconsistent with the DID on the material rack, please click OldDID again to take the material:");
                        old = "0";
                        CompPN = "";
                        txtNewDID.Text = "";
                        txtOldDID.Text = "";
                        txtOldDID.Focus();
                        return;
                    }
                    //strSQL = "Exec PDA_ControlLight @Type= 'SplicePN',@DID='" + txtNewDID.Text.Trim().ToString() + "',@Machine='',@line='',@Slot='',@LR='',@color='D'";
                    //DataSet dsGetSocketLED = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
                    //if (dsGetSocketLED.Tables[0].Rows[0]["Result"].ToString().Trim() != "0")
                    //{
                    //    MessageBox.Show(dsGetSocketLED.Tables[0].Rows[0]["Msg"].ToString());
                    //    return;
                    //}
                }
                RackDID = "";
                StoreID = "";
                txtOldDID.Text = "";
                txtNewDID.Text = "";
                CompPN = GetCompPN;
                MessageBox.Show("Please scan OldDID to receive", "Scan OldDID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            else if (SecondDID == "")
            {
                SecondDID = readerData.Text;
                if (SecondDID == txtNewDID.Text.Trim())
                {
                    return;
                }
                else
                {
                    MessageBox.Show("NewDID :" + txtNewDID.Text.Trim() + " must be the same :" + SecondDID, "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    SecondDID = "";
                    return;
                }
            }
            else if (txtOldDID.Text != "" && txtNewDID.Text != "" && CompPN != "")
            {
                TestStr = TestStr + "OldDID=" + txtOldDID.Text + ";";
                string oldDIDTwice = readerData.Text;
                if (oldDIDTwice != txtOldDID.Text)
                {
                    MessageBox.Show("OldDID :" + oldDIDTwice.ToString() + " must be the same :" + txtOldDID.Text.ToString(), "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    CompPN = "";

                    checkNewDID(txtNewDID.Text);
                }
            }
        }

        private void refreshData()
        {
            strSQL = "Exec PDA_GetDIDUsageSQL '" + Parameter.strLine + "','" + Parameter.strSide + "','" + Parameter.strChkMachine + "','Alarm','" + Parameter.strLR + "'";
            DataSet dsGetAlarm = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsGetAlarm != null)
            {
                dgvAlarmDID.TableStyles.Clear();
                dgvAlarmDID.DataSource = dsGetAlarm.Tables[0];

                #region //调整列宽
                DataView dv=dsGetAlarm.Tables[0].DefaultView;
                DataGridTableStyle dgts = new DataGridTableStyle();
                dgts.MappingName = dv.Table.TableName;
                DataGridTextBoxColumn dgcs;
                
                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "R-Time";
                //dgcs.HeaderText = "剩余时间";
                dgcs.HeaderText = "R-Time";
                dgcs.Width = 80;
                dgts.GridColumnStyles.Add(dgcs);
                
                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "LAM";
                //dgcs.HeaderText = "线别";
                dgcs.HeaderText = "LAM";
                dgcs.Width = 40;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "SLR";
                //dgcs.HeaderText = "站位";
                dgcs.HeaderText = "SLR";
                dgcs.Width = 45;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "DID";
                dgcs.HeaderText = "DID";
                dgcs.Width = 180;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "PCBQty";
                //dgcs.HeaderText = "剩余片数";
                dgcs.HeaderText = "PCBQty";
                dgcs.Width = 70;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "RemainQty";
                dgcs.HeaderText = "RemainQty";
                dgcs.Width = 100;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "Side";
                dgcs.HeaderText = "Side";
                dgcs.Width = 40;
                dgts.GridColumnStyles.Add(dgcs);

                dgvAlarmDID.TableStyles.Add(dgts);
                dgvAlarmDID.Refresh();
                dgcs = null;
                dgts = null;
                #endregion

                int intRowCount = dsGetAlarm.Tables[0].Rows.Count;
                strAlarmType = new string[intRowCount];
                strMulitLine = new string[intRowCount];
                strOldDID = new string[intRowCount];
                strJobPN = new string[intRowCount];
                strMachine = new string[intRowCount];
                strSlot = new string[intRowCount];
                strLR = new string[intRowCount];

                for (int i = 0; i < intRowCount; i++)
                {
                    strAlarmType[i] = dsGetAlarm.Tables[0].Rows[i]["Flag"].ToString();
                    strMulitLine[i] = dsGetAlarm.Tables[0].Rows[i]["Line"].ToString();
                    strOldDID[i] = dsGetAlarm.Tables[0].Rows[i]["DID"].ToString();
                    strMachine[i] = dsGetAlarm.Tables[0].Rows[i]["Machine"].ToString();
                    strSlot[i] = dsGetAlarm.Tables[0].Rows[i]["Slot"].ToString();
                    strLR[i] = dsGetAlarm.Tables[0].Rows[i]["LR"].ToString();
                    strJobPN[i] = dsGetAlarm.Tables[0].Rows[i]["JobGroup"].ToString();                    
                }
            }
        }

        private void refreshDatalv()
        {
           
            strSQL = "Exec PDA_GetDIDUsageSQL '" + Parameter.strLine + "','" + Parameter.strSide + "','" + Parameter.strChkMachine + "','" + Parameter.strLR + "'";
            DataSet dsGetAlarm = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsGetAlarm != null)
            {
                lvAlarmDID.Items.Clear();

                //lvitem.SubItems.Clear();

                for (int i = 0; i < dsGetAlarm.Tables[0].Rows.Count; i++)
                {

                    ListViewItem lvitem = new ListViewItem();
                    
                    switch (dsGetAlarm.Tables[0].Rows[i]["Flag"].ToString())
                    {
                        case "InterLock":
                            lvitem.ImageIndex = 0;                            
                            break;
                        case "Alarm":
                            lvitem.ImageIndex = 1;
                            break;
                        case "Normal":
                            lvitem.ImageIndex = 2;
                            break;
                    }
                    lvitem.SubItems.Add(dsGetAlarm.Tables[0].Rows[i]["R-Time"].ToString());
                    lvitem.SubItems.Add(dsGetAlarm.Tables[0].Rows[i]["LAM"].ToString());
                    lvitem.SubItems.Add(dsGetAlarm.Tables[0].Rows[i]["SLR"].ToString());                    
                    lvitem.SubItems.Add(dsGetAlarm.Tables[0].Rows[i]["DID"].ToString());
                    lvitem.SubItems.Add(dsGetAlarm.Tables[0].Rows[i]["PCBQty"].ToString());
                    lvitem.SubItems.Add(dsGetAlarm.Tables[0].Rows[i]["RemainQty"].ToString());
                    lvitem.SubItems.Add(dsGetAlarm.Tables[0].Rows[i]["Side"].ToString());
                    lvitem.SubItems.Add(dsGetAlarm.Tables[0].Rows[i]["BaseQty"].ToString());
                    lvAlarmDID.Items.Add(lvitem);

                    //lvAlarmDID.BeginUpdate();                    
                    //lvAlarmDID.EndUpdate();
                }

                int intRowCount = dsGetAlarm.Tables[0].Rows.Count;
                strAlarmType = new string[intRowCount];
                strMulitLine = new string[intRowCount];
                strOldDID = new string[intRowCount];
                strJobPN = new string[intRowCount];
                strMachine = new string[intRowCount];
                strSlot = new string[intRowCount];
                strLR = new string[intRowCount];

                for (int i = 0; i < intRowCount; i++)
                {
                    strAlarmType[i] = dsGetAlarm.Tables[0].Rows[i]["Flag"].ToString();
                    strMulitLine[i] = dsGetAlarm.Tables[0].Rows[i]["Line"].ToString();
                    strOldDID[i] = dsGetAlarm.Tables[0].Rows[i]["DID"].ToString();
                    strMachine[i] = dsGetAlarm.Tables[0].Rows[i]["Machine"].ToString();
                    strSlot[i] = dsGetAlarm.Tables[0].Rows[i]["Slot"].ToString();
                    strLR[i] = dsGetAlarm.Tables[0].Rows[i]["LR"].ToString();
                    strJobPN[i] = dsGetAlarm.Tables[0].Rows[i]["JobGroup"].ToString();
                }
            }
            //InterLock报警显示红色字体
            for (int c = 0; c < strAlarmType.Length; c++)
            {
                if (strAlarmType[c].ToString() == "InterLock")
                {
                    lvAlarmDID.Items[c].ForeColor = System.Drawing.Color.Red;
                }
                else if (strAlarmType[c].ToString() == "Alarm")
                {
                    lvAlarmDID.Items[c].ForeColor = System.Drawing.Color.Blue;
                }
            }
        }

        private void checkOldDID(string DID)
        {

            if (DID.Length != 20)
            {
                txtOldDID.Text = "";
                txtOldDID.Focus();
                return;
            }

            if (Parameter.strChkFirst == "Y")
            {              

                //只能从第一个开始接
                k = 0;
                if (strOldDID[k] == DID)
                {
                    //dgvAlarmDID.Select(k);
                    txtNewDID.Focus();
                    return;
                }                
                MessageBox.Show("OldDID is wrong,you must scan the first one: " + strOldDID[k].Trim().ToString() + "!", "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1); 
            }
            else
            {
                //前5个站位可以任意接
                for (k = 0; k < strOldDID.Length; k++)
                {
                    if (strOldDID[k].Trim().ToString() == DID)
                    {
                        //dgvAlarmDID.Select(k);
                        lvAlarmDID.Items[k].BackColor = System.Drawing.Color.Salmon;
                        txtNewDID.Focus();
                        return;
                    }
                }
                //MessageBox.Show("ป้อน DID เก่าไม่ถูกต้องหรือไม่มีสัญญาณเตือนสำหรับ DID และไม่สามารถรับวัสดุได้(旧DID输入错误，或者该DID没有报警，不可以接料)!", "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                MessageBox.Show("The old DID was entered incorrectly or there was no alarm for the DID and material could not be received !", "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1); 
            }
            txtOldDID.Text = "";
        }

        private void checkNewDID(string DID)
        {
            if (DID.Length != 20)
            {
                txtNewDID.Text = "";
                txtNewDID.Focus();
                return;
            }
            if (Parameter.strChkDispatchOrder == "Y")
            {
                if (DID != nextDID && nextDID!=null)
                {
                    //MessageBox.Show("โปรดใช้ DID ก่อน(请优先使用DID):" + nextDID + "ประกบกัน(接料)", "OverTime DID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    MessageBox.Show("Please use DID first: " + nextDID + " together.", "OverTime DID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtNewDID.Text = "";
                    nextDID = "";
                    return;
                }
           
            }
            strSQL = "EXEC PDA_QSMSCheckPartChangeDID @OldDID='" + txtOldDID.Text.Trim().ToString() + "',@NewDID='" + txtNewDID.Text.Trim().ToString() + "',@Machine='" + strMachine[k].Trim().ToString() +
                    "',@JobGroup='" + strJobPN[k].Trim().ToString() + "',@CHKCompPN='',@ChkMachineSlotByDID='',@Slot='" + strSlot[k].Trim().ToString() + "'" + ", @Line='" + strMulitLine[k].Trim().ToString() +
                    "',@Side='" + Parameter.strSide +"'"; 
            DataSet dsCheckPartChangeDID = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsCheckPartChangeDID != null)
            {
                if (dsCheckPartChangeDID.Tables[0].Rows[0]["Result"].ToString().Substring(0, 4) != "PASS")
                {
                    //if (dsCheckPartChangeDID.Tables[0].Rows[0]["Result"].ToString().IndexOf("FAIL:请优先使用散料") > 0)
                    //{
                    //    MessageBox.Show(strOldDID[k].Trim().ToString() + ":" + dsCheckPartChangeDID.Tables[0].Rows[0]["Result"].ToString().Substring(5, dsCheckPartChangeDID.Tables[0].Rows[0]["Result"].ToString().Length - 5), "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

                    //}
                    //else
                    //{
                        txtNewDID.Text = "";
                        MessageBox.Show(strOldDID[k].Trim().ToString() + ":" + dsCheckPartChangeDID.Tables[0].Rows[0]["Result"].ToString().Substring(5, dsCheckPartChangeDID.Tables[0].Rows[0]["Result"].ToString().Length - 5), "Scan DID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

                        //(0003)
                        //if (Parameter.strErrorReconfirm == "Y" && dsCheckPartChangeDID.Tables[0].Rows[0]["Result"].ToString().Trim() != "FAIL:当前的DID在物料中心没有注册")
                        if (Parameter.strErrorReconfirm == "Y" && dsCheckPartChangeDID.Tables[0].Rows[0]["Result"].ToString().Trim() != "FAIL: The current DID is not registered in the material center")
                        {
                            Parameter.strUserRight = "ErrorReconfirm";
                            Parameter.strNeedPassWord = "Y";
                            frmLogin myfrmLogin = new frmLogin();
                            myfrmLogin.ShowDialog();
                        }
                        return;
                    //}
                   
                    
                }
                else
                {
                    //赋值判断是否是替代料

                    if (dsCheckPartChangeDID.Tables[0].Rows[0]["Result"].ToString() == "PASS:DIFFVendor")
                    {
                        strDiffVendor = "Y";
                    }
                    else
                    {
                        strDiffVendor = "N";
                    }
                    strNoCheckReplacePNSplicing = dsCheckPartChangeDID.Tables[0].Rows[0]["NoCheckReplacePNSplicing"].ToString();
                    if (dsCheckPartChangeDID.Tables[0].Rows[0]["FeederAlarm"].ToString() != "")
                    {
                        MessageBox.Show(dsCheckPartChangeDID.Tables[0].Rows[0]["FeederAlarm"].ToString(), "Feeder Alarm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                    
                }
            }

            //记录接料LOG--20130427 Ava 修改判断条件
            //if (Parameter.strCheckSpliceReplacePN == "Y" && strNoCheckReplacePNSplicing == "N" && ((txtNewDID.Text.ToString().Trim().Substring(0, txtNewDID.Text.IndexOf("-")) == txtOldDID.Text.ToString().Trim().Substring(0, txtNewDID.Text.IndexOf("-")) && strMachine[k].Trim().ToString().IndexOf("OTHERS") == 0) || strDiffVendor == "Y"))
            if (Parameter.strCheckSpliceReplacePN == "Y" && strNoCheckReplacePNSplicing == "N" && ((txtNewDID.Text.ToString().Trim().Substring(0, txtNewDID.Text.IndexOf("-")) != txtOldDID.Text.ToString().Trim().Substring(0, txtNewDID.Text.IndexOf("-")) && strMachine[k].Trim().ToString().IndexOf("OTHERS") == -1) || strDiffVendor == "Y"))
            {
                Parameter.strAccessFlag = "N";
                Parameter.strUserRight = "CheckSpliceReplacePN";
                Parameter.strNeedPassWord="Y";
                frmLogin myfrmLogin = new frmLogin();
                myfrmLogin.ShowDialog();
            }
            else if (Parameter.strCheckSplicePN == "Y")
            {
                Parameter.strAccessFlag = "N";
                Parameter.strUserRight = "CheckSplicePN";
                Parameter.strNeedPassWord = "N";
                frmLogin myfrmLogin = new frmLogin();
                myfrmLogin.ShowDialog();
                //if (Parameter.strUserRight == "CheckSplicePN" && Parameter.StrPU == "PU5")
                //{
                //    Parameter.strUserName = Parameter.strUserNameOPID;
                //    Parameter.strAccessFlag = "Y";
                //}
                //else
                //{
                    //frmLogin myfrmLogin = new frmLogin();
                    //myfrmLogin.ShowDialog();
                //}
            }

            //Parameter.strAccessFlag = "Y";
            if (Parameter.strAccessFlag == "Y")
            {
                try
                {
                    //if (Parameter.CheckBulk == "Y")
                    //{
                    //    strSQL = "EXEC PDA_QSMSCheckPartChangeDID_CheckBulk  @OldDID='" + txtOldDID.Text.Trim().ToString() + "',@NewDID='" + txtNewDID.Text.Trim().ToString() + "',@Machine='" + strMachine[k].Trim().ToString() +
                    //   "',@JobGroup='" + strJobPN[k].Trim().ToString() + "',@CHKCompPN='',@ChkMachineSlotByDID='',@Slot='" + strSlot[k].Trim().ToString() + "'" + ", @Line='" + strMulitLine[k].Trim().ToString() +
                    //   "',@Side='" + Parameter.strSide + "',@OPID='" + Parameter.strUserName + "'";
                    //   DataSet dsCheckBulk = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
                    //   //if (dsCheckBulk != null)
                    //   //{
                    //       if (dsCheckBulk.Tables[0].Rows[0]["Result"].ToString().Trim()!="PASS")
                    //       {
                    //           //strSQL = "insert into  QSMS_Log (System_Name ,Event_No ,DID,User_Name ,ReturnQty ,Trans_Date ) values('PDA_QSMSCheckPartChangeDID_CheckBulklog','" + txtOldDID.Text.Trim().ToString() + "';'" + txtNewDID.Text.Trim().ToString() + "';'" +dsCheckBulk.Tables[0].Rows[0]["Result"].ToString()+"','','','',dbo.formatDate(getdate(),'YYYYMMDDHHNNSS')";
            
                    //           MessageBox.Show(dsCheckBulk.Tables[0].Rows[0]["Result"].ToString());

                    //       }
                    //   //}
                    //}

                    strSQL = "EXEC PDA_QSMSPartsSpliced  @OldDID='" + txtOldDID.Text.Trim().ToString() + "',@NewDID='" + txtNewDID.Text.Trim().ToString() + "', @Line='" + strMulitLine[k].Trim().ToString() + "',@Side='" + Parameter.strSide + "',@Machine='" + strMachine[k].Trim().ToString() +
                            "',@Slot='" + strSlot[k].Trim().ToString() + "',@JobPN='" + strJobPN[k].Trim().ToString() + "',@SpliceType='" + Parameter.strUserRight + "',@OPID='" + Parameter.strUserName + "'";
                    sqlHelper.ExecSQL(strSQL, "QSMS");

                    lblMessage.Text = "Change OK:" + txtOldDID.Text + "-->" + txtNewDID.Text + "";
                    
                    playSound.Play("\\Voice\\OK.WAV");

                    //--Set control right--
                    strSQL = "Exec PDA_ControlLight @Type= 'SplicePN',@DID='" + txtNewDID.Text.Trim().ToString() + "',@Machine='',@line='',@Slot='',@LR='',@color='D'";
                    DataSet dsGetSocketLED = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
                    if (dsGetSocketLED.Tables[0].Rows[0]["Result"].ToString().Trim() != "0")
                    {
                        MessageBox.Show(dsGetSocketLED.Tables[0].Rows[0]["Msg"].ToString());
                        //return;
                    }
                    //--END Set control right--

                    txtOldDID.Text = "";
                    txtNewDID.Text = "";
                    this.ControlBox = true;
                    txtOldDID.Focus();
                    refreshDatalv();
                }
                catch (Exception)
                {
                    MessageBox.Show("Program Error , Please Call QMS)");
                    //MessageBox.Show("ข้อผิดพลาดของโปรแกรมกรุณาโทร QMS(Program Error , Please Call QMS)");
                    return;
                }
            }
            else
            {
                txtOldDID.Text = "";
                txtNewDID.Text = "";
                txtOldDID.Focus();
            }
        }

        private void checkOverTimeDID(string DID)
        {
            strSQL = "Exec PDA_GetOverTimeDID_New '" + Parameter.strChkMachine + "','" + Parameter.strSide + "','" + DID + "'";
            DataSet dsOverTimeDID = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsOverTimeDID.Tables[0].Rows[0]["Result"].ToString().Trim() != "0")
            {
                MessageBox.Show(dsOverTimeDID.Tables[0].Rows[0]["Msg"].ToString());
                txtOldDID.Text = "";
                txtOldDID.Focus();
                old = "0";
                return;
            }
            else
            {
                nextDID = dsOverTimeDID.Tables[0].Rows[0]["DID"].ToString();
                RackDID = dsOverTimeDID.Tables[0].Rows[0]["DID"].ToString();
                StoreID = dsOverTimeDID.Tables[0].Rows[0]["StoreID"].ToString();
                MessageBox.Show(dsOverTimeDID.Tables[0].Rows[0]["Msg"].ToString());
                txtNewDID.Focus();
                old = "1";
                return;
            }
            if (Parameter.strChkPolar == "Y")   //(0001)
            {
                if (dsOverTimeDID.Tables[1].Rows.Count > 0)
                {
                    //MessageBox.Show("此材料有极性限制，请再确认");
                    MessageBox.Show("This material has polarity restriction, please reconfirm");
                }

            }
            /*strSQL = "Exec PDA_GetOverTimeDID '" + Parameter.strChkMachine + "','" + Parameter.strSide + "','" + DID + "'";
            DataSet dsOverTimeDID = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsOverTimeDID.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("โปรดใช้ DID ก่อน(请优先使用DID):" + dsOverTimeDID.Tables[0].Rows[0]["DID"].ToString() + ",เวลาจัดส่ง(发料时间)：" + dsOverTimeDID.Tables[0].Rows[0]["DispatchTime"].ToString(), "OverTime DID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                //增加Flag:strChkDispatchOrder,判断是否必须按照发料顺序借料 Jerry 
                if (Parameter.strChkDispatchOrder == "Y" )
                {
                    
                    nextDID = dsOverTimeDID.Tables[0].Rows[0]["DID"].ToString();
                }
            }
            if (Parameter.strChkPolar == "Y")   //(0001)
            {
                if (dsOverTimeDID.Tables[1].Rows.Count > 0)
                {
                    MessageBox.Show("วัสดุนี้มีข้อ จำกัด ขั้วโปรดยืนยันอีกครั้ง(此材料有极性限制，请再确认)");
                }
              
            }
          */
        }

        private void timeRefresh_Tick(object sender, EventArgs e)
        {
            //if (dgvAlarmDID.CurrentRowIndex==-1)
            //{
                refreshDatalv();
            //}            
        }

        private void menuCompCompare_Click(object sender, EventArgs e)
        {
            barCodeDID.EnableScanner = false;
            frmCompCompare myFrmCompCompare = new frmCompCompare();
            myFrmCompCompare.ShowDialog();
        }

        private void frmNeedSpliced_Closed(object sender, EventArgs e)
        {            
            timeRefresh.Enabled = false;
            barCodeDID.EnableScanner = false;
            this.Close();
        }

        private void menuChangeFeeder_Click(object sender, EventArgs e)
        {
            barCodeDID.EnableScanner = false;
            frmChangeFeeder myChangeFeeder = new frmChangeFeeder();
            myChangeFeeder.ShowDialog();
        }

        private void frmNeedSpliced_Activated(object sender, EventArgs e)
        {
            barCodeDID.EnableScanner = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshDatalv();
            txtOldDID.Focus();
        }

        private void menuLink_Click(object sender, EventArgs e)
        {        
            Parameter.strAccessFlag = "N";
            Parameter.strUserRight = "MainTainLink";
            Parameter.strNeedPassWord = "Y";
            barCodeDID.EnableScanner = false;
            frmLogin myfrmLogin = new frmLogin();
            myfrmLogin.ShowDialog();
            if (Parameter.strAccessFlag == "Y")
            {
                Parameter.strUnLink = "N";
                barCodeDID.EnableScanner = false;   
                frmMainTainLink myMainTainLink = new frmMainTainLink();
                myMainTainLink.ShowDialog();
            }            
        }

        private void menuDistributeDID_Click(object sender, EventArgs e)
        {            
            Parameter.strAccessFlag = "N";
            Parameter.strUserRight = "DistributeDID";
            Parameter.strNeedPassWord = "Y";
            barCodeDID.EnableScanner = false;
            frmLogin myfrmLogin = new frmLogin();
            myfrmLogin.ShowDialog();
            if (Parameter.strAccessFlag == "Y")
            {
                barCodeDID.EnableScanner = false;
                frmDistributeDID myDistributeDID = new frmDistributeDID();
                myDistributeDID.ShowDialog();
            }
        }

        private void menuUnLink_Click(object sender, EventArgs e)
        {            
            Parameter.strAccessFlag = "N";
            Parameter.strUserRight = "MainTainUnLink";
            Parameter.strNeedPassWord = "Y";
            barCodeDID.EnableScanner = false;
            frmLogin myfrmLogin = new frmLogin();
            myfrmLogin.ShowDialog();
            if (Parameter.strAccessFlag == "Y")
            {                
                Parameter.strUnLink = "Y";
                barCodeDID.EnableScanner = false;
                frmMainTainLink myMainTainLink = new frmMainTainLink();
                myMainTainLink.ShowDialog();
            }   
        }

        private void menuSetting_Click(object sender, EventArgs e)
        {
            frmSetting mySetting = new frmSetting();
            mySetting.ShowDialog();
        }

        private void mniDeleteDID_Click(object sender, EventArgs e)
        {
            barCodeDID.EnableScanner = false;
            frmDeleteDIDManual oFrm = new frmDeleteDIDManual();
            oFrm.ShowDialog();
        }

        private void mniCheckDID_Click(object sender, EventArgs e)
        {
            barCodeDID.EnableScanner = false;
            frmRackInfoQuery oFrm = new frmRackInfoQuery();
            oFrm.ShowDialog();
        }
    }
}