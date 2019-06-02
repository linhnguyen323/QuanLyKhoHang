using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBconnection
    {
        public SqlConnection connection;
        public string Conn = @"Data Source=DESKTOP-IPE3AH4\SQLEXPRE;Initial Catalog=QuanLyKho;Integrated Security=True";
        public SqlCommand command = new SqlCommand();

        //kiểm tra kết nối
        public bool isConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                return true;
            }
            else return false;
        }

        //hàm khởi tạo
        public DBconnection()
        {
            try
            {
                if (connection != null && connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                else
                {
                    if (connection == null)
                    {
                        connection = new SqlConnection();
                        connection.ConnectionString = Conn;
                        connection.Open();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write("Lỗi " + ex.Message);
            }
        }

        public DBconnection(string strConnection)
        {
            try
            {
                if (connection != null)
                    connection.Close();
                connection = new SqlConnection();
                connection.ConnectionString = strConnection;
                connection.Open();
            }
            catch (Exception ex)
            {

            }
        }

        //hàm trả về table
        public DataTable GetTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            DataTable dt = new DataTable();
            try
            {

                if (connection.State != ConnectionState.Open)
                    connection.Open();

                da.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        //public DataTable GetComboBox(string query)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter(query, Conn);
        //    DataTable dt = new DataTable();

        //    try
        //    {

        //        if (connection.State != ConnectionState.Open)
        //            connection.Open();

        //        da.Fill(dt);
        //    }
        //    catch (Exception ex)
        //    {
                
        //    }
        //    return dt;
        //}

        public int ExecuteSPNoneQuery(string strCode)
        {
            // Trả vể số lượng bản ghi thực hiện được khi thực thi câu lệnh. 
            int result = 0;
            if (strCode != "")
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strCode;
                result = cmd.ExecuteNonQuery();

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return result;
        }

        public string string_ExecuteScalarQuery(string strCode)
        {
            string result = "";
            // Mở kết nối. 
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            // Khởi tạo đối tượng sqlCommand. 
            command = new SqlCommand(strCode, connection);
            command.CommandType = CommandType.Text;
            result = command.ExecuteScalar().ToString();
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return result;
        }

        public int int_ExecuteScalarQuery(string strCode)
        {
            int result = 0;
            // Mở kết nối. 
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            // Khởi tạo đối tượng sqlCommand. 
            command = new SqlCommand(strCode, connection);
            command.CommandType = CommandType.Text;
            result = Convert.ToInt32( command.ExecuteScalar());
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return result;
        }
    }
}

