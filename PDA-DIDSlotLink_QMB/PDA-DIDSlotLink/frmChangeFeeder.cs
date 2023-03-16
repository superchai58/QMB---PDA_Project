using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDA_DIDSlotLink
{
    public partial class frmChangeFeeder : Form
    {
        private string strSQL = "";
        SQLHelper sqlHelper = new SQLHelper();
        PlaySound playSound = new PlaySound();

        public frmChangeFeeder()
        {
            InitializeComponent();
        }

        private void barCodeFeeder_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (readerData.Text == "")
                return;

            if (txtDID.Text == "")
            {
                txtDID.Text = readerData.Text;
                txtOldFeeder.Focus();
            }
            else if (txtOldFeeder.Text == "")
            {
                txtOldFeeder.Text = readerData.Text;
                txtNewFeeder.Focus();
            }
            else if (txtNewFeeder.Text == "")
            {
                txtNewFeeder.Text = readerData.Text;
                changeFeeder();
            }
        }

        private void changeFeeder()
        {
            if (txtOldFeeder.Text == txtNewFeeder.Text)
            {
                //MessageBox.Show("ปืนใหม่และเก่าไม่สามารถเหมือนกันได้(新旧料枪不能一样)！", "เปลี่ยน Feeder(Change Feeder)");
                MessageBox.Show("New and old materials can't be the same！", "Change Feeder");
                txtNewFeeder.Text = "";
                return;
            }

            strSQL = "EXEC ChangeFeederID @OFeederID='" + txtOldFeeder.Text.Trim().ToString() + "',@NFeederID='" + txtNewFeeder.Text.Trim().ToString() + "',@ChkFeederLine='" + Parameter.strChkFeederLine + "',@DID='" + txtDID.Text.Trim().ToString() + "'";
            DataSet dsChangeFeeder = sqlHelper.GetSqlDataSet(strSQL, "QSMS");
            if (dsChangeFeeder != null)
            {
                if (dsChangeFeeder.Tables[0].Rows[0]["Result"].ToString().Trim() != "OK")
                {
                    MessageBox.Show(dsChangeFeeder.Tables[0].Rows[0]["Result"].ToString(), "Change Feeder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtNewFeeder.Text = "";
                    return;
                }
                else
                {
                    //MessageBox.Show("เปลี่ยน Feeder OK(Change Feeder OK)", "เปลี่ยน Feeder(Change Feeder)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    MessageBox.Show("Change Feeder OK", "Change Feeder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtDID.Text = "";
                    txtOldFeeder.Text = "";
                    txtNewFeeder.Text = "";                    
                }
            }
        }

        private void frmChangeFeeder_Closed(object sender, EventArgs e)
        {
            barCodeFeeder.EnableScanner = false;
            this.Close();
        }
    }
}