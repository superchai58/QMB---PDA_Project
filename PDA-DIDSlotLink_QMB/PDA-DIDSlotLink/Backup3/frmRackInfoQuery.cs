using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDA_DIDSlotLink
{
    public partial class frmRackInfoQuery : Form
    {
        private string strSQL = "";
        SQLHelper sqlHelper = new SQLHelper();
        PlaySound playSound = new PlaySound();

        public frmRackInfoQuery()
        {
            InitializeComponent();
        }

        private void frmRackInfoQuery_Load(object sender, EventArgs e)
        {
            cboGroup.Enabled = false;
            cboLine.Enabled = false;
            strSQL = "EXEC QSMS_Rack_QryDetail @Line='',@Side='',@Tab='',@Rack_SN='',@Type='GetLine'";
            DataTable dtGetLine = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dtGetLine.Rows.Count != 0)
            {
                for (int intR = 0; intR < dtGetLine.Rows.Count; intR++)
                {
                    cboLine.Items.Add(dtGetLine.Rows[intR]["Line"].ToString());
                }
            }
            txtRack_SN.Focus();
        }

        private void optDID_Click(object sender, EventArgs e)
        {
            cboGroup.Enabled = false;
            cboLine.Enabled = false;
            txtID.Enabled = true;
            txtRack_SN.Enabled = false;
            barcodeRackQuery.EnableScanner = true;
            cboLine.Text = "";
            cboGroup.Text = "";
            txtRack_SN.Text = "";
            txtID.Focus();
            dgvMainTainLink.DataSource = null;
        }

        private void optRackID_Click(object sender, EventArgs e)
        {
            cboGroup.Enabled = false;
            cboLine.Enabled = false;
            txtRack_SN.Enabled = true;
            txtID.Enabled = true;
            barcodeRackQuery.EnableScanner = true;
            cboLine.Text = "";
            cboGroup.Text = "";
            txtRack_SN.Focus();
            dgvMainTainLink.DataSource = null;
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            string type = "";
            if (optRackID.Checked == true)
            {
                type = "GetNoUseStore";
                strSQL = "EXEC QSMS_Rack_QryDetail @Line='',@Side='" + txtRack_SN.Text + "',@Tab='',@Rack_SN='" + txtID.Text + "',@Type='" + type + "'";
            }
            else if (optDID.Checked == true)
            {
                type = "GetlinkDatabyDID";
                strSQL = "EXEC QSMS_Rack_QryDetail @Line='',@Side='" + txtRack_SN.Text + "',@Tab='',@Rack_SN='" + txtID.Text + "',@Type='" + type + "'";
            }
            else if (optHisTime.Checked == true)
            {
                type = "GetHisTime";
                strSQL = "EXEC QSMS_Rack_QryDetail @Line='',@Side='" + txtRack_SN.Text.Trim() + "',@Tab='',@Rack_SN='" + txtID.Text.Trim() + "',@Type='" + type + "'";
            }
            else
            {
                if (txtRack_SN.Text == ""||cboGroup.Text=="")
                {
                    MessageBox.Show("Rack_SN or GroupID can not be empty");
                    return;
                }
                type = "LightbyGroup";
                strSQL = "EXEC QSMS_Rack_QryDetail @Line='" + cboGroup.Text.Trim() + "',@Side='',@Tab='',@Rack_SN='" + txtRack_SN.Text + "',@Type='" + type + "'";
            }

            DataTable dtGetInfo = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dtGetInfo.Rows.Count != 0)
            {
                dgvMainTainLink.TableStyles.Clear();
                dgvMainTainLink.DataSource = dtGetInfo;
            }
            if (optRackID.Checked == true)
            {
                txtRack_SN.Text = "";
                txtID.Text = "";
                txtRack_SN.Focus();
            }
            else if (optDID.Checked == true)
            {
                txtRack_SN.Text = "";
                txtID.Text = "";
                txtID.Focus();
            }
            else if (optHisTime.Checked == true)
            {
                txtRack_SN.Text = "";
                txtID.Text = "";
                txtRack_SN.Focus();
            }
        }

        private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLine.Text != "" )
            {
                cboGroup.Enabled = true;
                cboGroup.Items.Clear();
                strSQL = "EXEC QSMS_Rack_QryDetail @Line='" + cboLine.Text.ToString() + "',@Side='',@Tab='',@Rack_SN='',@Type='GetGroupIDByLine'";
                DataTable dtGroupID = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
                if (dtGroupID.Rows.Count != 0)
                {
                    for (int intR = 0; intR < dtGroupID.Rows.Count; intR++)
                    {
                        cboGroup.Items.Add(dtGroupID.Rows[intR]["GroupID"].ToString());
                    }
                }
            }
        }

        private void frmRackInfoQuery_Closed(object sender, EventArgs e)
        {
            barcodeRackQuery.EnableScanner = false;
            this.Close();
        }

        private void barcodeRackQuery_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (readerData.Text == "")
            {
                return;
            }
            if (optRackID.Checked == true)
            {
                txtRack_SN.Text = readerData.Text;
                txtID.Focus();
                return;
            }
            else if (optGroup.Checked == true)
            {
                txtRack_SN.Text = readerData.Text;
                cboLine.Focus();
                return;
            }
            else if (optHisTime.Checked == true && txtRack_SN.Text.Trim() == "")
            {
                txtRack_SN.Text = readerData.Text;
                //txtID.Text = readerData.Text;
                //MessageBox.Show(txtID.Text.ToString());
                btnQuery_Click(null, null);
            }            
            else if (txtID.Text == "")
            {
                txtID.Text = readerData.Text;
                //MessageBox.Show(txtID.Text.ToString());
                btnQuery_Click(null, null);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (optGroup.Checked == true)
            {
                if (cboGroup.Text != ""&&txtRack_SN.Text!="")
                {
                    strSQL = "EXEC QSMS_Rack_QryDetail @Line='" + cboGroup.Text + "',@Side='',@Tab='',@Rack_SN='" + txtRack_SN.Text.Trim() + "',@Type='LightOffbyGroup'";
                    DataTable dtGetInfo = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
                }
                else
                {
                    MessageBox.Show("Please chose GroupID & Rack_SN");
                }
                return;
            }
            else if (optRackID.Checked == true)
            {
                strSQL = "EXEC QSMS_Rack_QryDetail @Line='',@Side='" + txtRack_SN.Text + "',@Tab='',@Rack_SN='" + txtID.Text + "',@Type='LightOffbyRack'";
                DataTable dtGetInfo = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
                optRackID.Checked = false;
            }
        }

        private void optGroup_Click(object sender, EventArgs e)
        {
            txtRack_SN.Enabled = true;
            cboLine.Enabled = true;
            cboGroup.Enabled = false;
        }

        private void optHisTime_CheckedChanged(object sender, EventArgs e)
        {
            cboGroup.Enabled = false;
            cboLine.Enabled = false;
            txtID.Enabled = true;
            txtRack_SN.Enabled = true;
            barcodeRackQuery.EnableScanner = true;
            cboLine.Text = "";
            cboGroup.Text = "";
            txtRack_SN.Focus();           
            dgvMainTainLink.DataSource = null;
        }

    }
}