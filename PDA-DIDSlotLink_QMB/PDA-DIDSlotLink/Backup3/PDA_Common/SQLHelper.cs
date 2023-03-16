using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PDA_DIDSlotLink
{    
    class SQLHelper
    {
        //////public static string strQSMSDBCon = "data source=10.18.3.25;initial catalog=QSMS;user id=sa;password=East#86;persist security info=True";
        //////public static string strSMTDBCon = "data source=10.18.3.21;initial catalog=SMT;user id=sa;password=East#86;persist security info=True";
        //public static string strSMTDBCon = "server = 10.18.3.25;database=SMT;user id = sa; password=East#86;Persist Security Info=True";
        //public static string strQSMSDBCon = "server = 10.18.3.21;database=QSMS;user id = sa; password=East#86;Persist Security Info=True";

        public static string strSMTDBCon = "";
        public static string strQSMSDBCon = "";
        //public static string strSMTDBCon = "server = 10.18.3.21;database=SMT;user id = sa; password=East#86;Persist Security Info=True";
        //public static string strQSMSDBCon = "server = 10.18.3.25;database=QSMS;user id = sa; password=East#86;Persist Security Info=True";

        public string DBconnstr = "";
        public static string strSMTDBName = "SMT";
        public static string strQSMSDBName = "QSMS";
        public static string strVersion = "1.0.0.1";
        SqlConnection conn = null;

        public string setDBconn(string strDatabase)
        {
            if (strDatabase == "QSMS")
            {
                return strQSMSDBCon; 
            }
            else
            {
                return strSMTDBCon;
            }
        }
        public DataSet GetSqlDataSet(string strSQLstmt, string strDatabase)
        {
            try
            {
                DBconnstr = setDBconn(strDatabase);
                conn = new SqlConnection(DBconnstr);
                conn.Open();
                SqlDataAdapter Adap = new SqlDataAdapter(strSQLstmt, conn);
                DataSet ds = new DataSet();
                Adap.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getDataTable(string strSQLstmt, string strDatabase)
        {
            try
            {
                DBconnstr = setDBconn(strDatabase);
                conn = new SqlConnection(DBconnstr);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlDataAdapter Adap = new SqlDataAdapter(strSQLstmt, conn);
                DataSet ds = new DataSet();
                Adap.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetFieldValue(string strSQLstmt, string strDatabase)
        {
            string fieldValue = "";
            DBconnstr = setDBconn(strDatabase);
            conn = new SqlConnection(DBconnstr);
            if (conn.State == ConnectionState.Closed)
            {                
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }
            using (SqlCommand sqlCommand = new SqlCommand(strSQLstmt, conn))
            {
                try
                {
                    object objFieldValue = sqlCommand.ExecuteScalar();
                    if (objFieldValue != null)
                    {
                        fieldValue = objFieldValue.ToString();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }

                return fieldValue;
            }
        }
        public bool ExecSQL(string strSQLstmt, string strDatabase)
        {
            DBconnstr = setDBconn(strDatabase);
            conn = new SqlConnection(DBconnstr);
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }
            bool result = false;
            using (SqlCommand sqlcommand = new SqlCommand(strSQLstmt, conn))
            {
                try
                {
                    sqlcommand.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
                return result;
            }
        }
    }
}
