using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDA_DIDSlotLink
{
    public partial class frmDeleteDIDManual : Form
    {
        private string strSQL = "";
        SQLHelper sqlHelper = new SQLHelper();
        PlaySound playSound = new PlaySound();

        public frmDeleteDIDManual()
        {
            InitializeComponent();
        }

        private void frmDeleteDIDManual_Load(object sender, EventArgs e)
        {
            barCodeGetRackSN.EnableScanner = true;
            txtRackSN.Focus();            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtRackSN.Text = "";
            txtStoreID.Text = "";

            txtRackSN.Focus();
        }

        private void frmDeleteDIDManual_Closed(object sender, EventArgs e)
        {
            barCodeGetRackSN.EnableScanner = false;            
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtRackSN.Text == "" || txtStoreID.Text == "")
            {                
                MessageBox.Show("กรุณากรอกรายละเอียดให้ครบ");             
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("คุณต้องการยืนยันการลบใช่หรือไม่?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    //--Get Line, Side, Tab--
                    string strSide = "";
                    string strLine = "";
                    string strTab = "";

                    strLine = txtRackSN.Text.Trim().Substring(0, 3);
                    strSide = txtRackSN.Text.Trim().Substring(3, 1);
                    strTab = txtRackSN.Text.Trim().Substring(4, 1);

                    strSQL = "EXEC DeleteDIDByRackAndStore @RackSN='" + txtRackSN.Text.Trim() + "',@storeID='" + txtStoreID.Text.Trim() + "', @line='" + strLine + "', @side='" + strSide + "', @tab='" + strTab + "'";
                    DataSet dsUnLink = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
                    if (dsUnLink != null)
                    {
                        if (dsUnLink.Tables[0].Rows[0]["Result"].ToString() != "0")
                        {
                            //--NG--
                            MessageBox.Show("" + dsUnLink.Tables[0].Rows[0]["Msg"].ToString() + "");
                            txtRackSN.Text = "";
                            txtStoreID.Text = "";

                            txtRackSN.Focus();
                        }
                        else
                        {
                            //--OK--
                            MessageBox.Show("" + dsUnLink.Tables[0].Rows[0]["Msg"].ToString() + "");
                            txtRackSN.Text = "";
                            txtStoreID.Text = "";

                            txtRackSN.Focus();
                        }
                    }
                }
            }
        }

        private void barCodeGetRackSN_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (readerData.Text == "")
                return;

            if (txtRackSN.Text == "")
            {
                txtRackSN.Text = readerData.Text.Trim();
                txtStoreID.Focus();
            }
        }
    }
}