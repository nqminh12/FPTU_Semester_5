using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Q1
{
    /// <summary>
    /// Chứa những hàm xử lý database chung cho tất cả kết nối
    /// </summary>
    public class DataProvider
    {
        //Khai bao cac thanh phan ket noi va xu ly DB
        SqlConnection cnn; //Ket noi DB
        SqlDataAdapter da; //Xu ly cac cau lenh SQL: Select
        SqlCommand cmd; //Thuc thi cau lenh select, insert,update,delete

        public DataProvider()
        {
            connect();
        }

        /// <summary>
        /// Hàm đọc ConnectionString trong file appsettings.json
        /// </summary>
        /// <returns>connectionString</returns>
        private string getConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            connectionString = config["ConnectionStrings:MyCnn"];
            return connectionString;
        }

        /// <summary>
        /// Hàm kết nối đến DB
        /// </summary>
        private void connect()
        {
            try
            {
                string strCnn = getConnectionString();
                cnn = new SqlConnection(strCnn);
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                //MessageBox.Show("Connect success!","Notification",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi:" + ex.Message);
            }
        }

        /// <summary>
        /// Hàm execute 1 câu lệnh select (Cách 1)
        /// </summary>
        /// <param name="strSelect"></param>
        /// <returns></returns>
        /// lưu vào bộ nhớ r hiển thị, chỉ cần lưu 1 lần r xử lí không cần phải mở và kéo dài kết nối gay xung đột
        public DataTable executeQuery(string strSelect)
        {
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(strSelect, cnn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Execute fail:" + ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// Hàm execute câu lệnh insert,update,delete
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public bool executeNonQuery(string commandText, params SqlParameter[] parameters)
        {
            try
            {
                var command = new SqlCommand(commandText, cnn);
                command.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert/Update/Delete error:" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Hàm execute 1 câu lệnh select (Cách 2)
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// hiển thị trực tiếp không cần lưu vào bộ nhớ nào cả nhưng phải mở kết nối dài hơn
        public IDataReader executeQuery2(string commandText,params SqlParameter[] parameters)
        {
            IDataReader reader = null;
            try
            {
                cmd = new SqlCommand(commandText, cnn);
                cmd.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return reader;
        }
    }
}
