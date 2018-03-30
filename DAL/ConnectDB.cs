using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ConnectDB
    {

        public static string connectionString = @"Data Source=PHUCCOI\PHUCCOI;Initial Catalog=THIB2;user=sa;pwd=123456";
        public static DataTable execAdapter(string sqlcmd)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sqlcmd, ConnectDB.connectionString);
            DataTable ds = new DataTable();
            try
            {
                adap.Fill(ds);
                return ds;
            }
            catch { return ds; }

        }
        public static int ExecuteNonQuery(String sqlcmd)
        {

            SqlConnection dbConn = new SqlConnection(connectionString);
            try
            {
                dbConn.Open();

            }
            catch
            {
                //  MessageBox.Show("Lỗi thêm thí sinh. Hãy kiểm tra kết nối với máy chủ", "Thông báo");

                return -1;
            }
            SqlCommand dbCmd = new SqlCommand(sqlcmd, dbConn);
            try
            {
                dbCmd.ExecuteNonQuery();
                dbConn.Close();
                return 1;
            }
            catch
            {
                dbConn.Close();
                return 0;
            }


        }
    }
}
