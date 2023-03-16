using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDA_DIDSlotLink
{
    public partial class frmLightLog : Form
    {
        private string strSQL = "";
        SQLHelper sqlHelper = new SQLHelper();

        public frmLightLog()
        {
            InitializeComponent();
        }

        private void frmLightLog_Load(object sender, EventArgs e)
        {
            strSQL = "EXEC QSMS_Rack_QryDetail @Line='',@Side='',@Tab='',@Rack_SN='',@Type='RackLightLogType'";
            DataTable dtGetType = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dtGetType.Rows.Count != 0)
            {
                for (int intR = 0; intR < dtGetType.Rows.Count; intR++)
                {
                    cboType.Items.Add(dtGetType.Rows[intR]["Type"].ToString());
                }
            }
            cboType.SelectedIndex = 0;
            txtRack_SN.Focus();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (cboType.Text == "")
            {
                txtRack_SN.Text = "";
                MessageBox.Show("请选择Type");
                return;
            }
            strSQL = "EXEC QSMS_Rack_QryDetail @Line='',@Side='',@Tab='',@Rack_SN='" + txtRack_SN.Text + "',@Type='" + cboType.Text.ToString().Trim() + "'";
            DataTable dtGetInfo = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            if (dtGetInfo.Rows.Count != 0)
            {
                dgvdata.TableStyles.Clear();
                dgvdata.DataSource = dtGetInfo;
            }
            txtRack_SN.Text = "";
            txtRack_SN.Focus();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRack_SN.Text = "";
            txtRack_SN.Focus();
        }

        private void frmLightLog_Closed(object sender, EventArgs e)
        {
            barcodeLightLog.EnableScanner = false;
            this.Close();
        }

        private void barcodeLightLog_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (readerData.Text == "")
            {
                return;
            }
            if (txtRack_SN.Text == "")
            {
                txtRack_SN.Text = readerData.Text;
                btnQuery_Click(null, null);
            }
        }
    }
}