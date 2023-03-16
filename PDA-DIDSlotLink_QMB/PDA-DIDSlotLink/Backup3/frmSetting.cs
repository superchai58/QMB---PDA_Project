using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDA_DIDSlotLink
{
    public partial class frmSetting : Form
    {
        string strSQL = "";
        SQLHelper sqlHelper = new SQLHelper();

        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            //lstvMachine.Items.Clear();
            //lstvLine.Items.Clear();
            try
            {
                txtChkMachine.Text = RegeditManager.Read("ChkMachine");
            }
            catch
            {
            }            

            strSQL = "select distinct line from machine with(nolock) order by line";
            DataTable dtGetLine = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBCon);
            if (dtGetLine.Rows.Count != 0)
            {
                for (int intR = 0; intR < dtGetLine.Rows.Count; intR++)
                {
                    cboLine.Items.Add(dtGetLine.Rows[intR]["Line"].ToString());
                }
            }

            string[] strMachine = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N","O","P" ,"Q"};
            for (int intM = 0; intM < strMachine.Length; intM++)
            {
                ListViewItem item = new ListViewItem(strMachine[intM]);
                lstvLastMachine.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
       
            //frmNeedSpliced myFrmNeedSpliced = new frmNeedSpliced();
            //myFrmNeedSpliced.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {      
            Parameter.strChkMachine="";

            foreach (ListViewItem item in lstvMachine.Items)
            {
                Parameter.strChkMachine = Parameter.strChkMachine + item.Text.ToString() + ",";
            }
            RegeditManager.write("ChkMachine", Parameter.strChkMachine);
            //MessageBox.Show("การตั้งค่าเป็นปกติกรุณาคลิกที่ปุ่มรีเฟรชบนอินเทอร์เฟซเพื่อให้มีผล(设定已OK,请点击接料界面的刷新按钮后生效)!", "Setting", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            MessageBox.Show("The setting is normal, please click the refresh button on the interface to take effect !", "Setting", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            this.Close();
           
            //frmNeedSpliced myFrmNeedSpliced = new frmNeedSpliced();
            //myFrmNeedSpliced.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in lstvMachine.Items)
                {
                    if (item.Checked == true)
                    {                        
                        //ListViewItem item1 = new ListViewItem(item.Text.ToString());
                        //lstvMachine.Items.Remove(item1);
                        lstvMachine.Items.Remove(item);
                        lstvMachine.Refresh();
                    }
                }
            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvLastMachine.Items)
            {
                if (item.Checked == true)
                {                 
                    item.Checked = false;
                    //lstvMachine.Items.Add(item);
                    ListViewItem item1 = new ListViewItem(cboLine.Text.ToString() + cboLR.Text.ToString() + item.Text.ToString());
                    lstvMachine.Items.Add(item1);
                    lstvMachine.Refresh();
                }
            }
        }

        private void lstvLastMachine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtChkMachine_TextChanged(object sender, EventArgs e)
        {

        }
    }
}