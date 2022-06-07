using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLySuaChuaXeMay
{
    internal class Functions
    {
        public static SqlConnection Conn;  //Khai báo đối tượng kết nối
        public static string connString;   //Khai báo biến chứa chuỗi kết nối

        public static void Connect()
        {

            try
            {
                //Thiết lập giá trị cho chuỗi kết nối
                connString = "Data Source=DESKTOP-EH2F7BB\\SQLEXPRESS;" + "Initial Catalog=quanlyxemay;" + "Integrated Security=True";
                Conn = new SqlConnection();                 //Cấp phát đối tượng
                Conn.ConnectionString = connString;         //Kết nối
                Conn.Open();                                //Mở kết nối
                MessageBox.Show("Ket noi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }


        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();   	//Đóng kết nối
                Conn.Dispose();     //Giải phóng tài nguyên
                Conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            return table;
        }
        public static bool CheckKey(string sql)
        {
            SqlCommand myCommand = new SqlCommand(sql, con);
            SqlDataReader myReader = myCommand.ExecuteReader();
            if (myReader.HasRows)
                return true;
            else
                return false;
        }
    }
}
       
