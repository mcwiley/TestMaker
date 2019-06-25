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
        public static string myDBConn = "Server=DESKTOP-BSFRLSL;Database=TestDB;Trusted_Connection=True;";

        public static DataSet GetData(string getSQL)
        {
            DataSet ds = new DataSet();

            SqlConnection connection = new SqlConnection(General.myDBConn);
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            command = new SqlCommand(getSQL, connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds);

            return ds;
        }

    }
}
