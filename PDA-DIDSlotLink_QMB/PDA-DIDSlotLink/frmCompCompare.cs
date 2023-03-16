using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDA_DIDSlotLink
{
    public partial class frmCompCompare : Form
    {
        string strSQL = "";
        string tempDID = "";
        string tempCompPN = "";
        //string tempSlot = "";
        //string tempLR = "";

        string[] strMulitLine;
        string[] strCSlot;
        string[] strCLR;
        string[] strCompPN;
        string[] strCheckComp;
        string[] strCheckDID;
        string[] strDID;
        string[] strNewDID;
        string[] strScanDID;
        SQLHelper sqlHelper = new SQLHelper();
        PlaySound playSound = new PlaySound();
        DataTable myTable = new DataTable();

        public frmCompCompare()
        {
            InitializeComponent();
        }

        private void frmCompCompare_Load(object sender, EventArgs e)
        {
            chkDID.Checked = true;
            strSQL = "select distinct left(a,3) as Line from dbo.func_split( '"+ Parameter.strChkMachine +"',',')";
            DataTable dtGetLine = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dtGetLine.Rows.Count != 0)
            {
                for (int intR = 0; intR < dtGetLine.Rows.Count; intR++)
                {
                    cboLine.Items.Add(dtGetLine.Rows[intR]["Line"].ToString());
                }
            }
        }

        private void cboTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData();
            txtDID.Focus();
        }
        private void refreshData()
        {
            try
            {
                string strChkSlot = "";
                cboSlot.Items.Clear();
                strSQL = "Exec PDA_GetCompCompareInfo '" + cboLine.Text.Trim().ToString() + "','" + Parameter.strSide + "','" + cboMachine.Text.ToString().Trim() + "','" + cboTable.Text.ToString().Trim() + "'";
                DataSet dsGetCompCompareInfo = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
                if (dsGetCompCompareInfo.Tables[0].Rows.Count > 0)
                {
                    myTable = dsGetCompCompareInfo.Tables[0];   //赋给临时表


                    #region //调整列宽
                    DataView dv = dsGetCompCompareInfo.Tables[0].DefaultView;
                    dgvCompareDID.TableStyles.Clear();
                    dgvCompareDID.DataSource = dsGetCompCompareInfo.Tables[0];

                    DataGridTableStyle dgts = new DataGridTableStyle();
                    dgts.MappingName = dv.Table.TableName;
                    DataGridTextBoxColumn dgcs;

                    dgcs = new DataGridTextBoxColumn();
                    dgcs.MappingName = "ChkCompResult";
                    dgcs.HeaderText = "ChkCompResult";
                    dgcs.Width = 70;
                    dgts.GridColumnStyles.Add(dgcs);

                    dgcs = new DataGridTextBoxColumn();
                    dgcs.MappingName = "ChkDIDResult";
                    dgcs.HeaderText = "ChkDIDResult";
                    dgcs.Width = 60;
                    dgts.GridColumnStyles.Add(dgcs);

                    dgcs = new DataGridTextBoxColumn();
                    dgcs.MappingName = "Slot";
                    dgcs.HeaderText = "Slot";
                    dgcs.Width = 40;
                    dgts.GridColumnStyles.Add(dgcs);

                    dgcs = new DataGridTextBoxColumn();
                    dgcs.MappingName = "LR";
                    dgcs.HeaderText = "LR";
                    dgcs.Width = 30;
                    dgts.GridColumnStyles.Add(dgcs);

                    dgcs = new DataGridTextBoxColumn();
                    dgcs.MappingName = "DID";
                    dgcs.HeaderText = "DID";
                    dgcs.Width = 170;
                    dgts.GridColumnStyles.Add(dgcs);

                    dgcs = new DataGridTextBoxColumn();
                    dgcs.MappingName = "CompPN";
                    dgcs.HeaderText = "CompPN";
                    dgcs.Width = 170;
                    dgts.GridColumnStyles.Add(dgcs);

                    dgvCompareDID.TableStyles.Add(dgts);
                    dgvCompareDID.Refresh();
                    dgcs = null;
                    dgts = null;
                    #endregion

                    int intRowCount = dsGetCompCompareInfo.Tables[0].Rows.Count;
                    strMulitLine = new string[intRowCount];
                    strCSlot = new string[intRowCount];
                    strCLR = new string[intRowCount];
                    strCompPN = new string[intRowCount];
                    strCheckComp = new string[intRowCount];
                    strCheckDID = new string[intRowCount];
                    strDID = new string[intRowCount];
                    strNewDID = new string[intRowCount];
                    strScanDID = new string[intRowCount];

                    for (int i = 0; i < intRowCount; i++)
                    {
                        if (strChkSlot != dsGetCompCompareInfo.Tables[0].Rows[i]["Slot"].ToString())
                        {
                            cboSlot.Items.Add(dsGetCompCompareInfo.Tables[0].Rows[i]["Slot"].ToString());
                            strChkSlot = dsGetCompCompareInfo.Tables[0].Rows[i]["Slot"].ToString();
                        }

                        strCSlot[i] = dsGetCompCompareInfo.Tables[0].Rows[i]["Slot"].ToString();
                        strCLR[i] = dsGetCompCompareInfo.Tables[0].Rows[i]["LR"].ToString();
                        strCompPN[i] = dsGetCompCompareInfo.Tables[0].Rows[i]["CompPN"].ToString();
                        strCheckComp[i] = dsGetCompCompareInfo.Tables[0].Rows[i]["ChkCompResult"].ToString();
                        strCheckDID[i] = dsGetCompCompareInfo.Tables[0].Rows[i]["ChkDIDResult"].ToString();
                        strDID[i] = dsGetCompCompareInfo.Tables[0].Rows[i]["DID"].ToString();
                        strNewDID[i] = dsGetCompCompareInfo.Tables[0].Rows[i]["NewDID"].ToString();
                        strScanDID[i] = dsGetCompCompareInfo.Tables[0].Rows[i]["ScanDID"].ToString();
                    }
                    cboSlot.Text = strCSlot[0];
                    cboLR.Text = strCLR[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program Error , Please Call QMS"+ex);
                return;
            }
        }

        private void barCodeCheckDID_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (readerData.Text == "")
                return;

            if (txtDID.Text == "")
            {
                txtDID.Text = readerData.Text;
                checkDIDCompare(txtDID.Text);
            }
        }

        private void checkDIDCompare(string DID)
        {
            if (DID.Length != 11)
            {
                if (DID.IndexOf("-") <= 0)
                {
                    //MessageBox.Show("DID ไม่สมประกอบ(DID 格式错误)!");
                    MessageBox.Show("Misformed DID !");
                    txtDID.Text = "";
                    txtDID.Focus();
                    return;
                }

                strSQL = "select * from qsms_did where did='" + txtDID.Text.ToString().Trim() + "'";
                DataSet dsGetDIDInfo = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
                if (dsGetDIDInfo.Tables[0].Rows.Count>0)
                {
                    tempDID = dsGetDIDInfo.Tables[0].Rows[0]["DID"].ToString();
                    tempCompPN = dsGetDIDInfo.Tables[0].Rows[0]["CompPN"].ToString();
                }
                else
                {
                    //MessageBox.Show("ไม่พบ DID(找不到该DID)!");
                    MessageBox.Show("Misformed DID !");
                    txtDID.Text = "";
                    txtDID.Focus();
                    return;
                }
            }
            else
            {
                tempCompPN = txtDID.Text.ToString().Trim();
            }

            int j = 0;
            //for (int i = 0; i < strCheckComp.Length; i++)
            //{
            //    if (cboSlot.Text == strCSlot[i] && cboLR.Text == strCLR[i])
            //    {
            //        tempSlot = strCSlot[i];
            //        tempLR = strCLR[i];
            //        j = i;
            //        break;
            //    }
            //}

            for (int i = 0; i < strCheckComp.Length; i++)
            {
                if(cboSlot.Text==strCSlot[i].Trim().ToString() && cboLR.Text==strCLR[i].Trim().ToString())
                {
                    if (chkDID.Checked == true)
                    {
                        j = i+1;
                        strScanDID[i] = tempDID;
                        if ((tempDID == strDID[i].Trim().ToString() && strNewDID[i].Trim().ToString() == "") || (tempDID == strNewDID[i].Trim().ToString() && strNewDID[i].Trim().ToString() != "") || tempCompPN == strCompPN[i].Trim().ToString())
                        {
                            strCheckComp[i] = "Y";
                            strCheckDID[i] = "Y";                            
                            myTable.Rows[i][0] = "Y";
                            myTable.Rows[i][1] = "Y";
                        }
                        else
                        {
                            strCheckDID[i] = "N";
                            myTable.Rows[i][1] = "N";
                            if (tempCompPN == strCompPN[i].Trim().ToString())   //增加ChkNextResult
                            {
                                strCheckComp[i] = "Y";
                                myTable.Rows[i][0] = "Y";
                            }
                            else
                            {
                                strCheckComp[i] = "N";
                                myTable.Rows[i][0] = "N";
                            }
                        }

                        strSQL = "EXEC PDA_QSMSCheckCompLog  @Machine='" + cboMachine.Text.ToString() + "',@Tab='" + cboTable.Text.ToString() + "', @Slot='" + strCSlot[i].Trim().ToString() + "',@LR='" + strCLR[i].Trim().ToString() + "',@ScanDID='" + strScanDID[i].Trim().ToString() +
                                "',@OldDID='" + strDID[i].Trim().ToString() + "',@NewDID='" + strNewDID[i].Trim().ToString() + "',@CheckResult='" + strCheckDID[i].Trim().ToString() + "',@Desc='',@Line='" + cboLine.Text.Trim().ToString() + "',@OPID='" + Parameter.strUserName + "',@CheckType='1'";
                        sqlHelper.ExecSQL(strSQL, "QSMS");

                        if (tempDID != "" && strCheckDID[i] == "N")
                        {
                            playSound.Play("\\Voice\\ERROR.WAV");
                        }
                        else
                        {
                            playSound.Play("\\Voice\\OK.WAV");
                        }
                    }
                    else
                    {
                        j = i+1;
                        strScanDID[i] = tempCompPN;
                        if (tempCompPN == strCompPN[i].Trim().ToString())   //增加ChkNextResult
                        {
                            strCheckComp[i] = "Y";
                            strCheckDID[i] = "N";
                            myTable.Rows[i][0] = "Y";
                            myTable.Rows[i][1] = "N";                          
                            playSound.Play("\\Voice\\OK.WAV");
                        }
                        else
                        {
                            strCheckComp[i] = "N";
                            strCheckDID[i] = "N";
                            myTable.Rows[i][0] = "N";
                            myTable.Rows[i][1] = "N";                               
                            playSound.Play("\\Voice\\ERROR.WAV");
                        }
                    }
                }

                #region //调整列宽
                DataView dv = myTable.DefaultView;
                dgvCompareDID.TableStyles.Clear();
                dgvCompareDID.DataSource = dv;

                DataGridTableStyle dgts = new DataGridTableStyle();
                dgts.MappingName = dv.Table.TableName;
                DataGridTextBoxColumn dgcs;

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "ChkCompResult";
                dgcs.HeaderText = "ChkCompResult";
                dgcs.Width = 70;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "ChkDIDResult";
                dgcs.HeaderText = "ChkDIDResult";
                dgcs.Width = 60;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "Slot";
                dgcs.HeaderText = "Slot";
                dgcs.Width = 40;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "LR";
                dgcs.HeaderText = "LR";
                dgcs.Width = 30;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "DID";
                dgcs.HeaderText = "DID";
                dgcs.Width = 170;
                dgts.GridColumnStyles.Add(dgcs);

                dgvCompareDID.TableStyles.Add(dgts);
                dgvCompareDID.Refresh();
                dgcs = null;
                dgts = null;
                #endregion
            }
            
            if (j >= strCheckComp.Length)
            {
                txtDID.Text = "";
                //MessageBox.Show("การจับคู่วัสดุเสร็จสมบูรณ์โปรดคลิกปุ่มตรวจสอบ(对料完成，请点击Check按钮)!");
                MessageBox.Show("The material matching is complete, please click the Check button !");
            }
            else
            {
                cboSlot.Items.Add(strCSlot[j].ToString().Trim());
                cboLR.Items.Add(strCLR[j].ToString().Trim());
                cboSlot.Text = strCSlot[j].ToString().Trim();
                cboLR.Text = strCLR[j].ToString().Trim();

                txtDID.Text = "";
                txtDID.Focus();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string chkFlag = "Y";
            string strDesc = "";
            try
            {
                for (int k = 0; k < strCheckComp.Length; k++)
                {
                    if (strCheckDID[k].Trim().ToString() == "")
                    {
                        //strDesc = "ไม่สแกน DID หรือ CompPN ใด ๆ(Not Scan any DID or CompPN)";
                        strDesc = "Not Scan any DID or CompPN";
                    }
                    else
                    {
                        if (strCheckDID[k].Trim().ToString() == "N")
                        {
                            strDesc = strDesc + "Slot: " + strCSlot[k].Trim().ToString() + ",LR: " + strCLR[k].Trim().ToString() + " Check compPN not match!!";
                            chkFlag = "N";
                        }
                    }
                }

                if (strDesc == "")
                {
                    strDesc = "PASS";
                }
                strSQL = "EXEC PDA_QSMSCheckCompLog  @Machine='" + cboMachine.Text.ToString() + "',@Tab='" + cboTable.Text.ToString() + "',@CheckResult='" + chkFlag + "',@Desc='" + strDesc + "',@OPID='" + Parameter.strUserName + "',@CheckType='2'";
                sqlHelper.ExecSQL(strSQL, "QSMS");

                if (strDesc == "PASS")
                {
                    //MessageBox.Show("ตรวจสอบองค์ประกอบตกลง(Check component OK)!");
                    MessageBox.Show("Check component OK !");
                }
                else
                {
                    //MessageBox.Show("ตรวจสอบ DID Fail(Check DID Fail)!");
                    MessageBox.Show("Check DID Fail !");
                }
                cboTable_SelectedIndexChanged(null, null);
            }
            catch (Exception)
            {
                //MessageBox.Show("ข้อผิดพลาดของโปรแกรมกรุณาโทร QMS(Program Error, Please Call QMS)");
                MessageBox.Show("Program Error, Please Call QMS");
                return;
            }
        }

        private void frmCompCompare_Closed(object sender, EventArgs e)
        {
            barCodeCheckDID.EnableScanner = false;
            this.Close();
        }

        private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        {            
            //cboMachine.DataBindings.Clear();
            cboMachine.Items.Clear();
            strSQL = "select distinct Machine from qsms_feederdid_current with(nolock) where Line = '" + cboLine.Text.Trim().ToString() + "' order by machine";
            DataTable dtGetMachine = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dtGetMachine.Rows.Count != 0)
            {
                for (int intR = 0; intR < dtGetMachine.Rows.Count; intR++)
                {
                    cboMachine.Items.Add(dtGetMachine.Rows[intR]["Machine"].ToString());
                }
            }
        }
    }
}