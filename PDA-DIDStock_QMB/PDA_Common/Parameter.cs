using System;

using System.Collections.Generic;
using System.Text;

namespace PDA_DIDSlotLink
{
    class Parameter
    {
        public static string strLine = "";
        public static string strSide ="";
        public static string strLR = "";
        public static string strLR1 = "";
        public static string strUserRight = "";
        public static string strUserName = "";
        public static string strAccessFlag = "";
        public static string CheckBulk = "";
        public static string StrPU = "";
        public static bool PasswordKept = false;
        public static string strPassword = "";
        public static string strCheckSplicePN = "";
        public static string strNeedPassWord = "";
        public static string strCheckSpliceReplacePN="";
        public static string strChkFeederLine = "";
        public static string strChkFirst = "";
        public static string strChkMachine = "";
        public static string AppName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        public static string strUnLink = "";
        public static string strChkPolar = "";  //(0001)  
        public static string strChkDispatchOrder = "N";  //(0002)  
        public static string strErrorReconfirm = "N";//(0003)
        public static string strChkDIDTime = "N";//(0004)
        public static string strChkDIDTimeSec = "N";//(0005)
        public static double strTimeSpan = 60;
        public static double strTimeSpanSec = 60;
        public static string DoubleChkOldDid = "N";
        public static string strChkVendorPN = "N";
        public static string strServer = "";//    (0006)
        public static string strUserNameOPID = "";//    (0006)
    }
}
