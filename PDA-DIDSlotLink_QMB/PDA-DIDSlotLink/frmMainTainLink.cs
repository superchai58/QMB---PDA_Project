using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDA_DIDSlotLink
{
    public partial class frmMainTainLink : Form
    {
        private string strSQL = "";
        private string strLinkFlag = "";
        SQLHelper sqlHelper = new SQLHelper();
        PlaySound playSound = new PlaySound();

        public frmMainTainLink()
        {
            InitializeComponent();
        }

        private void barCodeMainTain_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (readerData.Text == "")
                return;

            if (txtLineID.Text == "")
            {
                txtLineID.Text = readerData.Text;
                if (Parameter.strUnLink == "Y")
                {
                    maintainLink();
                    return;
                }
                txtMachineID.Focus();
            }
            else if (txtMachineID.Text == "")
            {
                txtMachineID.Text = readerData.Text;
                maintainLink();                
            }
        }

        private void maintainLink()
        {
            strSQL = "EXEC PDA_MainTainLinks @LineID='" + txtLineID.Text.Trim().ToString() + "',@MachineID='" + txtMachineID.Text.Trim().ToString() + "',@OPID='" + Parameter.strUserName + "',@LinkFlag='" + strLinkFlag.ToString() + "'";
            DataSet dsMainTainLink = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsMainTainLink != null)
            {
                if (dsMainTainLink.Tables[0].Rows[0]["Result"].ToString().Trim() != "OK")
                {
                    playSound.Play("\\Voice\\ERROR.WAV");
                    MessageBox.Show(dsMainTainLink.Tables[0].Rows[0]["Result"].ToString(), "MainTain Link", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMachineID.Text = "";
                    txtMachineID.Focus();
                    return;
                }
                else
                {
                    playSound.Play("\\Voice\\OK.WAV");
                    //MessageBox.Show("MainTain OK", "MainTain Link", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    refreshData();
                    txtMachineID.Text = "";
                    txtMachineID.Focus();
                }
            }
        }

        private void optLink_Click(object sender, EventArgs e)
        {
            if (optLink.Checked == true)
            {
                strLinkFlag = "Y";
                txtLineID.Focus();
            }
        }

        private void optUnLink_Click(object sender, EventArgs e)
        {
            if (optUnLink.Checked == true)
            {
                strLinkFlag = "N";
                txtLineID.Focus();
            }
        }

        private void frmMainTainLink_Closed(object sender, EventArgs e)
        {
            barCodeMainTain.EnableScanner = false;
            this.Close();
        }

        private void frmMainTainLink_Load(object sender, EventArgs e)
        {
            txtLineID.Focus();
            if (Parameter.strUnLink == "Y")
            {
                strLinkFlag = "N";
                optUnLink.Checked = true;
                optUnLink.Enabled = true;
            }
            else
            {
                strLinkFlag = "Y";
                optLink.Checked = true;
                optLink.Enabled = true;
            }
        }

        private void refreshData()
        {
            strSQL = "Exec PDA_GetMainTainLinkInfo @LineID='" + txtLineID.Text.Trim().ToString() + "',@MachineID='" + txtMachineID.Text.Trim().ToString() + "'";
            DataSet dsGetMainTainLinkInfo = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsGetMainTainLinkInfo != null)
            {
                dgvMainTainLink.TableStyles.Clear();
                dgvMainTainLink.DataSource = dsGetMainTainLinkInfo.Tables[0];

                #region //调整列宽
                DataView dv = dsGetMainTainLinkInfo.Tables[0].DefaultView;
                DataGridTableStyle dgts = new DataGridTableStyle();
                dgts.MappingName = dv.Table.TableName;
                DataGridTextBoxColumn dgcs;

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "Line";
                dgcs.HeaderText = "Line";
                dgcs.Width = 40;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "Side";
                dgcs.HeaderText = "Side";
                dgcs.Width = 40;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "Tab";
                dgcs.HeaderText = "Tab";
                dgcs.Width = 30;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "MachineID";
                dgcs.HeaderText = "MachineID";
                dgcs.Width = 90;
                dgts.GridColumnStyles.Add(dgcs);

                dgcs = new DataGridTextBoxColumn();
                dgcs.MappingName = "LinkFlag";
                dgcs.HeaderText = "LinkFlag";
                dgcs.Width = 80;
                dgts.GridColumnStyles.Add(dgcs);

                dgvMainTainLink.TableStyles.Add(dgts);
                dgvMainTainLink.Refresh();
                dgcs = null;
                dgts = null;
                #endregion
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            refreshData();
            txtLineID.Text = "";
            txtMachineID.Text = "";
        }
    }
}