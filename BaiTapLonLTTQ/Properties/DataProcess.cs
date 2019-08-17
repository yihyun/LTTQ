using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BanHang2017.Classes
{
    class DataProcess
    {
        public string connStr = "Data Source=DESKTOP-2AJI34A\\SQLEXPRESS;Database=QuanLyBanHang;Integrated Security=True";
        public SqlConnection sqlConn = null;
        public void OpenConnect()
        {
            sqlConn = new SqlConnection(connStr);
            if (sqlConn.State != ConnectionState.Open)
                sqlConn.Open();
        }
        public SqlConnection laycon()
        {
            sqlConn = new SqlConnection(connStr);
            return sqlConn;
        }
        public void CloseConnect()
        {
            if (sqlConn.State != ConnectionState.Closed)
                sqlConn.Close();
            sqlConn.Dispose();
        }
        public DataTable SelectTable(string sqlSelect)
        {
            DataTable dtResult = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConn);
            sqlData.Fill(dtResult);
            CloseConnect();
            sqlData.Dispose();
            return dtResult;
        }
        public void UpdateData(string sqlUpdates)
        {
            OpenConnect();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = sqlUpdates;
            sqlComm.ExecuteNonQuery();
            CloseConnect();
            sqlComm.Dispose();
        }
      

    }
}
