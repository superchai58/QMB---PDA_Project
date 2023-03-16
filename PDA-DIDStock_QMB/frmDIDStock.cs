using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PDA_DIDSlotLink
{
    public partial class frmDIDStock : Form
    {
        string strSQL = "";
        string RackSN = "";

        string strSide = "";
        string strLine = "";
        string strTab = "";
        string strFix = "";

        SQLHelper sqlHelper = new SQLHelper();
        PlaySound playSound = new PlaySound();

        //string strBeginDT = "";
        //string strEndDT = "";
        //string strBeginDTA = "";
        //string strEndDTA = "";

        public frmDIDStock()
        {
            InitializeComponent();
            barcodeSLT.EnableScanner = true;
            barcodeDID.EnableScanner = false;
        }

        private void frmDIDStock_Load(object sender, EventArgs e)
        {
            listViewDIDStock.FullRowSelect = true;
            listViewDIDStock.Columns.Add("", 10, HorizontalAlignment.Center);
            listViewDIDStock.Columns.Add("Rack_SN", 60, HorizontalAlignment.Center);
            listViewDIDStock.Columns.Add("StoreID", 60, HorizontalAlignment.Center);
            listViewDIDStock.Columns.Add("DID", 160, HorizontalAlignment.Center);
            listViewDIDStock.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewDIDStock.View = View.Details;
          
            //strSQL = "EXEC QSMS_Rack_QryDetail @Line='',@Side='',@Tab='',@Rack_SN='',@Type='GetLine'";
            //DataTable dtGetLine = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            //if (dtGetLine.Rows.Count != 0)
            //{
            //    for (int intR = 0; intR < dtGetLine.Rows.Count; intR++)
            //    {
            //        cboLine.Items.Add(dtGetLine.Rows[intR]["Line"].ToString());
            //    }
            //}
            //cboTab.Items.Add("");
            //cboTab.Items.Add("1");
            //cboTab.Items.Add("2");
            //cboTab.Items.Add("3");
            //cboTab.Items.Add("4");
            //cboSide.Items.Add("");
            //cboSide.Items.Add("S");
            //cboSide.Items.Add("C");
           // cboGroup.Items.Add("");
            RefreshRackSN();            
            txtDID.Text = "";
            cboRack_SN.Text = "";
            //txtDID.Focus();
            txtScanSLT.Focus();
            btnLink.Visible = false;

        }

        //private void cboRack_SN_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //strSQL = "EXEC QSMS_Rack_QryDetail @Line='" + cboLine.Text.ToString() + "',@Side='',@Tab='" + cboTab.Text.ToString() + "',@Rack_SN='" + cboRack_SN.Text.ToString() + "',@Type='QueryByRack_SN'";
        //    //DataSet dsGetInfo = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
        //    //if (dsGetInfo != null)
        //    //{
        //    //    dg_result.DataSource = dsGetInfo.Tables[0];
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("No Data!");
        //    //    return;
        //    //}
        //    RackSN = cboRack_SN.Text;
        //    txtScanSLT.Focus();
        //    //txtDID.Focus();
        //}

        //private void cboTab_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cboRack_SN.Items.Clear();
        //    strSQL = "EXEC QSMS_Rack_QryDetail @Line='" + cboLine.Text.ToString() + "',@Side='',@Tab='" + cboTab.Text.ToString() + "',@Rack_SN='',@Type='GetRackSNByTab'";
        //    DataTable dtRackSN = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
        //    if (dtRackSN.Rows.Count != 0)
        //    {
        //        for (int intR = 0; intR < dtRackSN.Rows.Count; intR++)
        //        {
        //            cboRack_SN.Items.Add(dtRackSN.Rows[intR]["Rack_SN"].ToString());
        //        }
        //    }
        //    cboRack_SN.Text = RackSN;
        //}

        private void btnUnlink_Click(object sender, EventArgs e)
        {
            //barcodeDID.EnableScanner = false;

            Parameter.strUserRight = "UnlinkLogin";
            frmLogin frmlogin = new frmLogin();
            if (frmlogin.ShowDialog() != DialogResult.OK)
            {
                txtDID.Text = "";
                txtDID.Focus();
                barcodeDID.EnableScanner = true;
                txtDID_KeyDown(null, null);
            }
            if (chkUnlinkDID.Checked == true && txtDID.Text.Length>3)
            {
                cboRack_SN.Text = "";
            }
            //barcodeDID.EnableScanner = true;
            SubStringLineSideTab();
            //strSQL = "EXEC QSMS_Rack_Setting @DID='" + txtDID.Text.Trim().ToUpper().ToString() + "',@Line='" + cboLine.Text.ToString() +
            //    "',@Side='" + cboSide.Text.ToString() + "',@Tab='" + cboTab.Text.ToString() + "',@Rack_SN='" + cboRack_SN.Text.ToString() +
            //    "',@GroupID='" + txtGroup.Text.ToString() + "',@UID='" + Parameter.strUserNameOPID.ToString() +
            //    "',@UserRight='" + Parameter.strUserRight.ToString() + "',@Type='UnLink'";

            strSQL = "EXEC QSMS_Rack_Setting_Test @DID='" + txtDID.Text.Trim().ToUpper().ToString() + "',@Line='" + strLine +
                "',@Side='" + strSide + "',@Tab='" + strTab + "',@Rack_SN='" + cboRack_SN.Text.ToString() +
                "',@GroupID='" + txtGroup.Text.ToString() + "',@UID='" + Parameter.strUserNameOPID.ToString() +
                "',@UserRight='" + Parameter.strUserRight.ToString() + "',@Type='UnLink'";
            DataSet dsUnLink = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsUnLink != null)
            {
                if (dsUnLink.Tables[0].Rows[0]["Result"].ToString() != "0")
                {
                    lblmsg.BackColor = Color.Red;
                    lblmsg.Text = dsUnLink.Tables[0].Rows[0]["Msg"].ToString();
                    txtDID.Text = "";
                    txtScanSLT.Text = "";

                    txtScanSLT.Focus();
                    barcodeSLT.EnableScanner = true;
                    //txtScanSLT_KeyDown(null, null);
                    txtScanSLT_KeyDown(null, new KeyEventArgs(Keys.Cancel)); 
                }
                else
                {
                    lblmsg.BackColor = Color.GreenYellow;
                    lblmsg.Text = dsUnLink.Tables[0].Rows[0]["Msg"].ToString();
                    txtDID.Text = "";
                    txtScanSLT.Text = "";

                    txtScanSLT.Focus();
                    barcodeSLT.EnableScanner = true;
                    //txtScanSLT_KeyDown(null, null);
                    txtScanSLT_KeyDown(null, new KeyEventArgs(Keys.Cancel)); 
                }
            }
        }

        //private void cboSide_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboLine.Text != "" && cboSide.Text != "")
        //    {
        //        cboGroup.Items.Clear();
        //        strSQL = "EXEC QSMS_Rack_QryDetail @Line='" + cboLine.Text.ToString() + "',@Side='',@Tab='" + cboTab.Text.ToString() + "',@Rack_SN='',@Type='GetGroupID'";
        //        DataTable dtGroupID = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
        //        if (dtGroupID.Rows.Count != 0)
        //        {
        //            for (int intR = 0; intR < dtGroupID.Rows.Count; intR++)
        //            {
        //                cboGroup.Items.Add(dtGroupID.Rows[intR]["GroupID"].ToString());
        //            }
        //        }
        //    }
        //}

        //private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboLine.Text != "" && cboSide.Text != "")
        //    {
        //        cboGroup.Items.Clear();
        //        strSQL = "EXEC QSMS_Rack_QryDetail @Line='" + cboLine.Text.ToString() + "',@Side='',@Tab='" + cboTab.Text.ToString() + "',@Rack_SN='',@Type='GetGroupID'";
        //        DataTable dtGroupID = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
        //        if (dtGroupID.Rows.Count != 0)
        //        {
        //            for (int intR = 0; intR < dtGroupID.Rows.Count; intR++)
        //            {
        //                cboGroup.Items.Add(dtGroupID.Rows[intR]["GroupID"].ToString());
        //            }
        //        }
        //    }
        //}

        private void btnEnd_Click(object sender, EventArgs e)
        {
            barcodeDID.EnableScanner = false;
            barcodeSLT.EnableScanner = false;

            SubStringLineSideTab();
             //strSQL = "EXEC QSMS_Rack_Setting @DID='" + txtDID.Text + "',@Line='" + cboLine.Text +
             //         "',@Side='" + cboSide.Text + "',@Tab='" + cboTab.Text + "',@Rack_SN='" + cboRack_SN.Text +
             //         "',@GroupID='" + txtGroup.Text + "',@UID='" + Parameter.strUserName + "',@UserRight='',@Type='InitCheck'";
             strSQL = "EXEC QSMS_Rack_Setting_Test @DID='" + txtDID.Text + "',@Line='" + strLine +
                       "',@Side='" + strSide + "',@Tab='" + strTab + "',@Rack_SN='" + cboRack_SN.Text +
                       "',@GroupID='" + txtGroup.Text + "',@UID='" + Parameter.strUserName + "',@UserRight='',@Type='InitCheck'";
            DataTable dt = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dt.Rows[0]["Result"].ToString() != "0")
            {
                MessageBox.Show(dt.Rows[0]["Msg"].ToString());
            }
            //strSQL = "EXEC QSMS_Rack_Setting @DID='" + txtDID.Text + "',@Line='" + cboLine.Text +
            //         "',@Side='" + cboSide.Text + "',@Tab='" + cboTab.Text + "',@Rack_SN='" + cboRack_SN.Text +
            //         "',@GroupID='" + txtGroup.Text + "',@UID='" + Parameter.strUserName + "',@UserRight='',@Type='Init'";
            strSQL = "EXEC QSMS_Rack_Setting_Test @DID='" + txtDID.Text + "',@Line='" + strLine +
                     "',@Side='" + strSide + "',@Tab='" + strTab + "',@Rack_SN='" + cboRack_SN.Text +
                     "',@GroupID='" + txtGroup.Text + "',@UID='" + Parameter.strUserName + "',@UserRight='',@Type='Init'";
            dt = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dt.Rows[0]["Result"].ToString() != "0")
            {
                lblmsg.BackColor = Color.Red;
                lblmsg.Text = dt.Rows[0]["Msg"].ToString();
                playSound.Play("\\Voice\\ERROR.WAV");
                txtDID.Text = "";
                txtScanSLT.Text = "";
                cboRack_SN.Text = "";

                txtScanSLT.Focus();
                barcodeSLT.EnableScanner = true;
                return;
            }
            else
            {
                lblmsg.BackColor = Color.GreenYellow;
                lblmsg.Text = dt.Rows[0]["Msg"].ToString();
                //cboRack_SN.Items.Clear();
                cboRack_SN.Text = "";
                playSound.Play("\\Voice\\OK.WAV");
                txtDID.Text="";
                txtScanSLT.Text = "";

                txtScanSLT.Focus();
                barcodeSLT.EnableScanner = true;
                return;
            }
        }

        //-----BarcodeDID-----
        private void barcodeDID_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            //barcodeDID.EnableScanner = true;
            if (readerData.Text == "")
                return;

            //MessageBox.Show(readerData.Text);
            //if (readerData.Text.Trim().Length == 6)
            //{
            //    //cboRack_SN.Focus();
            //    cboRack_SN.Text = readerData.Text;
            //    RackSN = readerData.Text;
            //    txtDID.Text = "";
            //    txtDID.Focus();
            //    return;
            //}
            if (txtDID.Text == "" && txtDID.Focused == true)
            {
                txtDID.Text = readerData.Text;
                txtDID_KeyDown(null, new KeyEventArgs(Keys.Enter));                 
            }
            //else if (cboRack_SN.Text == "")
            //{
            //    cboRack_SN.Text = readerData.Text;
            //    txtDID.Focus();
            //}
        }

        private void txtDID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtDID.Text != "")
            {
                int _flage = 0;
                barcodeDID.EnableScanner = false;
                
                //--Unlink--
                //--Check DID == Tab--
                strSQL = "EXEC QSMS_GetTabByDID @DID='" + txtDID.Text + "'";
                DataTable dtTab = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
                if (dtTab.Rows.Count == 0) //Rack_SN
                {                                        
                    if (chkUnlinkRack.Checked == true || chkUnlinkDID.Checked == true)
                    {
                        _flage = 1;
                    }
                    else
                    {
                        if (MessageBox.Show("DID not found", "ERROR") == DialogResult.OK)
                        {
                            barcodeDID.EnableScanner = true;
                            txtDID.Text = "";
                            txtDID.Focus();
                            txtDID_KeyDown(null, null);
                        }
                    }                   
                }
                else //DID
                {
                    //--Link--
                    if (dtTab.Rows[0]["Tab"].ToString().Trim().Equals(txtScanSLT.Text.Trim().Substring(4, 1)))
                    {
                        //--END Check DID == Tab--
                        //barcodeDID.EnableScanner = false;
                        //if (txtDID.Text.Trim().Length == 6)
                        //{
                        //    cboRack_SN.Text = txtDID.Text;
                        //    RackSN = cboRack_SN.Text;
                        //    txtDID.Text = "";
                        //    //txtDID.Focus();
                        //    //return;
                        //}
                        //if (cboRack_SN.Text == "")
                        //{
                        //    btnUnlink.Focus();
                        //}
                        checkDID();
                    }
                    else
                    {
                        if (MessageBox.Show("Tab numbers do not match.", "ERROR") == DialogResult.OK)
                        {
                            barcodeDID.EnableScanner = true;
                            txtDID.Text = "";
                            txtDID.Focus();
                            txtDID_KeyDown(null, null);
                        }
                    }
                    //--END Link--
                }


                if (_flage == 1) //Rack_SN
                {
                    //cboRack_SN.Text = txtScanSLT.Text;                                        
                    if (txtDID.Text.Trim().Substring(4, 1).Equals(txtScanSLT.Text.Trim().Substring(4, 1)))
                    {
                        //--END Check DID == Tab--
                        //barcodeDID.EnableScanner = false;
                        //if (txtDID.Text.Trim().Length == 6)
                        //{
                        //    cboRack_SN.Text = txtDID.Text;
                        //    RackSN = cboRack_SN.Text;
                        //    txtDID.Text = "";
                        //    //txtDID.Focus();
                        //    //return;
                        //}
                        //if (cboRack_SN.Text == "")
                        //{
                        //    btnUnlink.Focus();
                        //}
                        checkDID();
                    }
                    else
                    {
                        if (MessageBox.Show("Tab numbers do not match.", "ERROR") == DialogResult.OK)
                        {
                            barcodeDID.EnableScanner = true;
                            txtDID.Text = "";
                            txtDID.Focus();
                            txtDID_KeyDown(null, null);
                        }
                    }    
                }                                    
                //--END Unlink--
            }            
        }
        //-----END BarcodeDID-----

        private void btnLink_Click(object sender, EventArgs e)
        {                        
            //if (cboLine.Text == "" || cboSide.Text == "" || cboTab.Text == "" || txtGroup.Text == "" || txtDID.Text == "")
            //{
            //    lblmsg.BackColor = Color.Red;
            //    lblmsg.Text = "DID/Line/Side/Table/GroupID不能为空！";
            //    return;
            //}
            SubStringLineSideTab();
            //strSQL = "EXEC QSMS_Rack_Setting @DID='" + txtDID.Text + "',@Line='" + strLine +
            //       "',@Side='" + strSide + "',@Tab='" + strTab + "',@Rack_SN='" + cboRack_SN.Text +
            //       "',@GroupID='" + txtGroup.Text + "',@UID='" + Parameter.strUserName + "',@UserRight='',@Type='Link'";
            strSQL = "EXEC QSMS_Rack_Setting_Test @DID='" + txtDID.Text + "',@Line='" + strLine +
                   "',@Side='" + strSide + "',@Tab='" + strTab + "',@Rack_SN='" + cboRack_SN.Text +
                   "',@GroupID='" + txtGroup.Text + "',@UID='" + Parameter.strUserName + "',@UserRight='',@Type='Link'";
            DataTable dtLink = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dtLink.Rows[0]["Result"].ToString() != "0")
            {
                lblmsg.BackColor = Color.Red;
                lblmsg.Text = dtLink.Rows[0]["Msg"].ToString();
                playSound.Play("\\Voice\\ERROR.WAV");
                RackSN = cboRack_SN.Text;
                txtDID.Text = "";
                txtDID.Focus();
                //txtScanSLT.Text = "";
                //txtScanSLT.Focus();                                
                barcodeDID.EnableScanner = true;
                txtDID_KeyDown(null, null);
                
            }
            else
            {
                lblmsg.BackColor = Color.GreenYellow;
                lblmsg.Text = dtLink.Rows[0]["Msg"].ToString();
                RackSN = cboRack_SN.Text;

                //txtScanSLT.Text = dtLink.Rows[0]["Line"].ToString().Trim() + dtLink.Rows[0]["Side"].ToString().Trim() + dtLink.Rows[0]["Tab"].ToString().Trim();
                //cboSide.Text = dtLink.Rows[0]["Side"].ToString().Trim();
                //cboLine.Text = dtLink.Rows[0]["Line"].ToString().Trim();
                //cboTab.Text = dtLink.Rows[0]["Tab"].ToString().Trim();
                txtGroup.Text = dtLink.Rows[0]["GroupID"].ToString().Trim();

                txtDID.Text = "";
                txtDID.Focus();
                barcodeDID.EnableScanner = true;
                txtDID_KeyDown(null, null);
                //txtScanSLT.Text = "";                                
                //txtScanSLT.Focus();                
                //barcodeSLT.EnableScanner = true;
            }
        }


        //-----Line, Side, Tab-----
        public void SubStringLineSideTab()
        {
            strSide = "";
            strLine = "";
            strTab = "";

            if (txtScanSLT.Text.Trim() != "")
            {
                strLine = txtScanSLT.Text.Trim().Substring(0, 3);
                strSide = txtScanSLT.Text.Trim().Substring(3, 1);
                strTab = txtScanSLT.Text.Trim().Substring(4, 1);
            }            
        }
        //-----END Line, Side, Tab-----

        private void RefreshRackSN()
        {
            cboRack_SN.Items.Clear();
            cboRack_SN.Items.Add("");
            SubStringLineSideTab();

            RackSN = txtScanSLT.Text.Trim();
            strSQL = "EXEC QSMS_Rack_QryDetail @Line='" + strLine + "',@Side='" + strSide + "',@Tab='" + strTab + "',@Rack_SN='" + RackSN + "',@Type='GetRackSN'";
            DataTable dtRackSN = new DataTable();
            try
            {
                dtRackSN = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            }
            catch (Exception)
            {
                MessageBox.Show("Datatable Catch");
            }
            if (dtRackSN.Rows.Count != 0)
            {
                for (int intR = 0; intR < dtRackSN.Rows.Count; intR++)
                {
                    cboRack_SN.Items.Add(dtRackSN.Rows[intR]["Rack_SN"].ToString());
                }
            }
            cboRack_SN.Text = RackSN;
        }

        private void RefreshData()
        {
            barcodeDID.EnableScanner = false;
            barcodeSLT.EnableScanner = false;
            SubStringLineSideTab();
            strSQL = "EXEC QSMS_Rack_QryDetail @Line='" + strLine + "',@Side='" + strSide + "',@Tab='" + strTab + "',@Rack_SN='" + RackSN + "',@Type='Query'";
            DataTable dtGetInfo = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dtGetInfo.Rows.Count != 0)
            {
                listViewDIDStock.Items.Clear();
                for (int i = 0; i < dtGetInfo.Rows.Count; i++)
                {
                    ListViewItem lvitem = new ListViewItem();
                    lvitem.SubItems.Add(dtGetInfo.Rows[i]["Rack_SN"].ToString());
                    lvitem.SubItems.Add(dtGetInfo.Rows[i]["StoreID"].ToString());
                    lvitem.SubItems.Add(dtGetInfo.Rows[i]["DID"].ToString());
                    listViewDIDStock.Items.Add(lvitem);
                }
                //dgvDIDStock.TableStyles.Clear();
                //dgvDIDStock.DataSource = dtGetInfo;
            }
            txtDID.Text = "";
            txtScanSLT.Text = "";
            cboRack_SN.Text = "";
            txtScanSLT.Focus();
            barcodeSLT.EnableScanner = true;
        }

        private void btnRefreshLight_Click(object sender, EventArgs e)
        {

            SubStringLineSideTab();
            strSQL = "EXEC QSMS_Rack_Setting @DID='" + txtDID.Text + "',@Line='" + strLine +
                   "',@Side='" + strSide + "',@Tab='" + strTab + "',@Rack_SN='" + cboRack_SN.Text +
                   "',@GroupID='" + txtGroup.Text + "',@UID='" + Parameter.strUserName + "',@UserRight='',@Type='Refresh'";
            DataTable dtLink = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dtLink.Rows[0]["Result"].ToString() != "0")
            {
                lblmsg.BackColor = Color.Red;
                lblmsg.Text = dtLink.Rows[0]["Msg"].ToString();
                playSound.Play("\\Voice\\ERROR.WAV");
                txtDID.Text = "";
                txtScanSLT.Text = "";
                cboRack_SN.Text = "";
                txtScanSLT.Focus();
                return;
            }
            else
            {
                lblmsg.BackColor = Color.GreenYellow;
                lblmsg.Text = dtLink.Rows[0]["Msg"].ToString();
                playSound.Play("\\Voice\\OK.WAV");
                txtDID.Text = "";
                txtScanSLT.Text = "";
                cboRack_SN.Text = "";
                txtScanSLT.Focus();
                return;
            }
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void checkDID()
        {
            int _chkUnlinkDID = 0, _chkUnlinkRack = 0;
            //--Delete by DID--
            if (chkUnlinkDID.Checked == true && txtDID.Text != "" && txtDID.Text.Trim() != cboRack_SN.Text.Trim() && (txtDID.Text.Length == 20 || txtDID.Text.Length == 27))
            {
                _chkUnlinkDID = 1;
                btnUnlink.Focus();
                btnUnlink_Click(null, null);
                return;
            }

            if (_chkUnlinkDID == 0 && chkUnlinkDID.Checked == true)
            {
                if (MessageBox.Show("You scan DID incorrectly.", "ERROR") == DialogResult.OK)
                {
                    barcodeDID.EnableScanner = true;                    
                    txtDID.Text = "";                    
                    txtDID.Focus();
                    txtDID_KeyDown(null, null);
                }                 
            }            
            //--END Delete by DID--

            //--Delete by Rack_SN--
            if (chkUnlinkRack.Checked == true && cboRack_SN.Text != "" && txtDID.Text.Trim() == cboRack_SN.Text.Trim() && txtDID.Text.Length == 6)
            {
                _chkUnlinkRack = 1;
                btnUnlink.Focus();
                btnUnlink_Click(null, null);
                return;
            }

            if (_chkUnlinkRack == 0 && chkUnlinkRack.Checked == true)
            {
                if (MessageBox.Show("You scan Rack_SN incorrectly.", "ERROR") == DialogResult.OK)
                {
                    barcodeDID.EnableScanner = true;
                    txtDID.Text = "";
                    txtDID.Focus();
                    txtDID_KeyDown(null, null);
                }
            }            
            //--END Delete by Rack_SN--

            if (txtDID.Text == "")
            {
                txtDID.Focus();
                barcodeDID.EnableScanner = true;
                return;
            }
            btnLink_Click(null, null);
            //strBeginDT = "GetDIDInfo S:"+DateTime.Now.ToString();
            //strSQL = "EXEC QSMS_Rack_Setting @DID='" + txtDID.Text + "',@Line='" + cboLine.Text +
            //        "',@Side='" + cboSide.Text + "',@Tab='" + cboTab.Text + "',@Rack_SN='" + cboRack_SN.Text +
            //        "',@GroupID='" + txtGroup.Text + "',@UID='" + Parameter.strUserName + "',@UserRight='',@Type='GetDIDInfo'";
            //DataTable dt = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            //if (dt.Rows.Count == 0)
            //{
            //    lblmsg.BackColor = Color.Red;
            //    lblmsg.Text = "该DID没有发料记录！";
            //    playSound.Play("\\Voice\\ERROR.WAV");
            //    txtDID.Text = "";
            //    txtDID.Focus();
            //    return;
            //}
            //else
            //{
            //    strEndDT = "GetDIDInfo E:" + DateTime.Now.ToString();
            //    cboSide.Text = dt.Rows[0]["Side"].ToString().Trim();
            //    cboLine.Text = dt.Rows[0]["Line"].ToString().Trim();
            //    cboTab.Text = dt.Rows[0]["Tab"].ToString().Trim();
            //    txtGroup.Text = dt.Rows[0]["GroupID"].ToString().Trim();
            //    //cboRack_SN.Text = RackSN;
            //    btnLink_Click(null, null);
            //}
            //SaveLog(strBeginDT +";"+ strEndDT + ";"+strBeginDTA +";"+ strEndDTA);
        }

        

        //private void cboRack_SN_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        RackSN = cboRack_SN.Text;
        //        checkDID();
        //    }
        //}

        private void SaveLog(string strdata)
        {
            try
            {
                //MessageBox.Show(strdata);
                //return;
                string appName = System.Reflection.Assembly.GetCallingAssembly().GetName().CodeBase;
                string file = System.IO.Path.GetDirectoryName(appName) + "\\DIDStocklog.txt";
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                File.Create(file);
                System.IO.StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(strdata);
                sw.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            barcodeDID.EnableScanner = false;
            barcodeSLT.EnableScanner = false;
            frmRackInfoQuery RackInfoQuery = new frmRackInfoQuery();
            RackInfoQuery.ShowDialog();
            //barcodeDID.EnableScanner = true;
            
            txtDID.Text = "";
            txtScanSLT.Text = "";
            txtScanSLT.Focus();
            barcodeSLT.EnableScanner = true;
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            barcodeDID.EnableScanner = false;
            barcodeSLT.EnableScanner = false;
            frmLightLog LightLog = new frmLightLog();
            LightLog.ShowDialog();
            //barcodeDID.EnableScanner = true;
            
            txtDID.Text = "";
            txtScanSLT.Text = "";
            txtScanSLT.Focus();
            barcodeSLT.EnableScanner = true;
        }

        private void cboRack_SN_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //RackSN = cboRack_SN.Text;            
            //txtScanSLT.Focus();
        }

        //-----BarcodeSLT-----
        private void barcodeSLT_OnRead_1(object sender, Symbol.Barcode.ReaderData readerData)
        {            
            if (readerData.Text == "")
                return;

            if (txtScanSLT.Text == "" && txtScanSLT.Focused == true)
            {
                txtScanSLT.Text = "";
                txtScanSLT.Text = readerData.Text;
                txtScanSLT_KeyDown(null, new KeyEventArgs(Keys.Enter)); 
            }
        }

        private void txtScanSLT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtScanSLT.Text!="")
            {
                barcodeSLT.EnableScanner = false;
                try
                {
                    SubStringLineSideTab();
                    RackSN = txtScanSLT.Text.Trim();
                    strSQL = "EXEC QSMS_Rack_QryDetail @Line='" + strLine + "',@Side='" + strSide + "',@Tab='" + strTab + "',@Rack_SN='" + RackSN + "',@Type='GetRackSN'";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query SQL Catch");
                }
                DataTable dtRackSN = new DataTable();
                try
                {
                    dtRackSN = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Datatable Catch");
                }
                int _flage = 0;
                if (dtRackSN.Rows.Count != 0)
                {
                    for (int intR = 0; intR < dtRackSN.Rows.Count; intR++)
                    {
                        if (txtScanSLT.Text == dtRackSN.Rows[intR]["Rack_SN"].ToString().Trim())
                        {
                            cboRack_SN.Text = txtScanSLT.Text;
                            _flage = 1;                            
                            txtDID.Focus();
                            barcodeDID.EnableScanner = true;
                            break;
                        }
                    }
                }                               
                
                if (_flage == 0)
                {                    
                    if (MessageBox.Show("Rack_SN Not Found, Plase new scan.", "ERROR") == DialogResult.OK)
                    {
                        barcodeSLT.EnableScanner = true;
                        txtScanSLT.Text = "";
                        txtScanSLT.Focus();
                        txtScanSLT_KeyDown(null, null);
                    }                    
                }
            }
            
        }
        //-----END BarcodeSLT-----        

        private void chkUnlinkRack_Click(object sender, EventArgs e)
        {
            if (chkUnlinkDID.Checked == true)
            {
                chkUnlinkDID.Checked = false;
                chkUnlinkRack.Checked = true;
            }                
        }

        private void chkUnlinkDID_Click(object sender, EventArgs e)
        {        
            if (chkUnlinkRack.Checked == true)
            {
                chkUnlinkRack.Checked = false;
                chkUnlinkDID.Checked = true;
            }            
        }
    }
}