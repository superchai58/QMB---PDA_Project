using System;

using System.Collections.Generic;
using System.Windows.Forms;

namespace PDA_DIDSlotLink
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。

        /// QMS     Ava         2013/10/30      添加check极性材料       (0001)  
        /// QMS     Ava         2013/12/19      PDA接料报错再确认       (0003) 
        /// QMS     Crystal     2019/07/02      PDA接料修改为在登录时输入OPID       (0006) 
        /// </summary>
        [MTAThread]
        static void Main()
        {
            string text;
            string text2;
            text2 = "Server=10.18.8.11;database=SMT;uid=sa;pwd=East#86;Connect Timeout=30";
            text = EncryptStr.EncryptDES(text2, "1234ABCD");
            text = EncryptStr.DecryptDES(text, "1234ABCD");
           
            //Parameter.strUserRight = "CheckSplicePN";
            

            //frmLogin frmlogin = new frmLogin();           
            //if (frmlogin.ShowDialog() != DialogResult.OK)
            //{
            //    return;
            //}           
            Application.Run(new frmSelect());
           
        }
    }
}