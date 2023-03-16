using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDA_DIDSlotLink
{
    public partial class frmDistributeDID : Form
    {
        private string strSQL = "";
        SQLHelper sqlHelper = new SQLHelper();
        PlaySound playSound = new PlaySound();

        public frmDistributeDID()
        {
            InitializeComponent();
        }

        private void barCodeDistributeDID_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (tabControl.SelectedIndex == 0)
            {
                //触发分组
                if (readerData.Text == "")
                    return;

                if (txtDID.Text == "")
                {
                    txtDID.Text = readerData.Text;
                    showPosition(txtDID.Text.ToString().Trim());
                    //txtMachineID.Focus();
                }
                else if (txtMachineID.Text == "")
                {
                    txtMachineID.Text = readerData.Text;
                    chkDistributeDID();
                }
            }
            else
            {
                //触发分GROUP
                if (readerData.Text == "")
                    return;

                if (txtDIDByGroup.Text == "")
                {
                    txtDIDByGroup.Text = readerData.Text;
                    chkDistributeGroup();
                }
            }
        }

        private void chkDistributeDID()
        {
            strSQL = "EXEC PDA_ChkDistributeDID @DID='" + txtDID.Text.Trim().ToString() + "',@MachineID='" + txtMachineID.Text.Trim().ToString() + "',@OPID='" + Parameter.strUserName + "',@Type='ByDID'";
            DataSet dsChkDistributeDID = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsChkDistributeDID != null)
            {
                if (dsChkDistributeDID.Tables[0].Rows[0]["Result"].ToString().Trim() != "OK")
                {
                    playSound.Play("\\Voice\\ERROR.WAV");
                    MessageBox.Show(dsChkDistributeDID.Tables[0].Rows[0]["Result"].ToString(), "MainTain Link", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtDID.Text = "";
                    txtMachineID.Text = "";
                    txtDID.Focus();
                    return;
                }
                else
                {
                    playSound.Play("\\Voice\\OK.WAV");
                    //MessageBox.Show("MainTain OK", "MainTain Link", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtDID.Text = "";
                    txtMachineID.Text = "";
                    txtDID.Focus();
                }
            }
        }

        private void chkDistributeGroup()
        {
            strSQL = "EXEC PDA_ChkDistributeDID @DID='" + txtDIDByGroup.Text.Trim().ToString() + "',@ScanLine='" + cboLine.Text.Trim().ToString() + "',@ScanGroupID='" + cboGroupID.Text.Trim().ToString() + "',@OPID='" + Parameter.strUserName + "',@Type='ByGroup'";
            DataSet dsChkDistributeDID = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsChkDistributeDID != null)
            {
                if (dsChkDistributeDID.Tables[0].Rows[0]["Result"].ToString().Trim() != "OK")
                {
                    playSound.Play("\\Voice\\ERROR.WAV");
                    MessageBox.Show(dsChkDistributeDID.Tables[0].Rows[0]["Result"].ToString(), "MainTain Link", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtDIDByGroup.Text = "";
                    txtDIDByGroup.Focus();
                    return;
                }
                else
                {
                    playSound.Play("\\Voice\\OK.WAV");
                    //MessageBox.Show("MainTain OK", "MainTain Link", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtDIDByGroup.Text = "";
                    txtDIDByGroup.Focus();
                }
            }
        }

        private void showPosition(string DID)
        {
            strSQL = "EXEC PDA_ChkDistributeDID @DID='" + txtDID.Text.Trim().ToString() + "',@Type='ShowPOS'";
            DataSet dsShowPOS = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsShowPOS != null)
            {
                if (dsShowPOS.Tables[0].Rows[0]["Result"].ToString().Trim() != "OK")
                {
                    playSound.Play("\\Voice\\ERROR.WAV");
                    lblStatus.Text = dsShowPOS.Tables[0].Rows[0]["Position"].ToString();                    
                    txtDID.Text = "";
                    txtDID.Focus();
                    return;
                }
                else
                {
                    lblStatus.Text = dsShowPOS.Tables[0].Rows[0]["Position"].ToString();
                    txtMachineID.Focus();
                }                
            }
        }

        private void frmDistributeDID_Load(object sender, EventArgs e)
        {
            txtDID.Focus();
            strSQL = "select distinct line from Routingline where line<>'' union select distinct Line from Application_List order by line";
            DataTable dtGetLine = sqlHelper.getDataTable(strSQL, "SMT");
            if (dtGetLine.Rows.Count != 0)
            {
                for (int intR = 0; intR < dtGetLine.Rows.Count; intR++)
                {
                    cboLine.Items.Add(dtGetLine.Rows[intR]["Line"].ToString());
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                txtDID.Focus();
            }
            else
            {
                txtDIDByGroup.Focus();
            }
        }

        private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGroupID.Items.Clear();
            strSQL = "Exec PDA_GetGroupID '" + cboLine.Text.ToString().Trim() + "'";
            DataSet dsGetGroupID = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsGetGroupID.Tables[0].Rows.Count > 0)
            {
                int intRowCount = dsGetGroupID.Tables[0].Rows.Count;
                for (int i = 0; i < intRowCount; i++)
                {
                    cboGroupID.Items.Add(dsGetGroupID.Tables[0].Rows[i]["GroupID"].ToString());
                }
            }
            cboGroupID.Focus();
        }

        private void cboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDIDByGroup.Focus();
        }

        private void frmDistributeDID_Closed(object sender, EventArgs e)
        {
            barCodeDistributeDID.EnableScanner = false;
            this.Close();
        }
    }
}