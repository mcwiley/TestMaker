using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TestMaker
{
    public static class General
    {
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        public static string Right(string param, int length)
        {
            string result = param.Substring(param.Length - length, length);
            return result;
        }
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        public static int Instr(string str, string srch, int strtpos)
        {
            int rtn = -1;
            rtn = str.IndexOf(srch, strtpos);
            return rtn;
        }

        public static string TS_SelectedTopic;
        public static string TS_SelectedSubTopic;
        public static string QTS_SelectedTopic;
        public static string QTS_SelectedSubTopic;
        public static string QTS_SelectedQuestion;

        public static string myDBConn = "Server=DESKTOP-BSFRLSL;Database=TestDB;Trusted_Connection=True;";

        public static DataSet GetData(string getSQL)
        {
            DataSet ds = new DataSet();

            SqlConnection connection = new SqlConnection(General.myDBConn);
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            command = new SqlCommand(getSQL, connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds,"Data_Table");

            return ds;
        }

        public static bool AddUpdate(string daSQL)
        {
            bool rslt = true;

            try
            {
                DataSet ds = new DataSet();
                SqlConnection connection = new SqlConnection(General.myDBConn);
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                command = new SqlCommand(daSQL, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                rslt = true;
            }
            catch
            {
                rslt = false;
            }
            return rslt;
        }

        public static string GetID(string sID)
        {
            string rtn = "";

            int a = Instr(sID, " : ", 0);

            rtn = Right(sID,(sID.Length-a)-3);

            return rtn;
        }

    }
}
