using InventoryManagement.Helper;
using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAL
{
    internal class DalWarehouses
    {
        public DataTable GetAllWarehouses()
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "select WarehouseID,WarehouseName,City,ContactNumber from Warehouses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

        }

        public bool Insert(WareHouse warehouse)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "insert into Warehouses values (@WarehouseName,@City,@Contact)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("WarehouseName",warehouse.WarehouseName);
            cmd.Parameters.AddWithValue("@City", warehouse.City);
            cmd.Parameters.AddWithValue("@Contact", warehouse.ContactNumber);

            conn.Open();
            int status = cmd.ExecuteNonQuery();
            conn.Close();
            return Convert.ToBoolean(status);
        }

        public bool Update(WareHouse warehouse)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "update Warehouses set WarehouseName=@WarehouseName ,City=@City ,ContactNumber=@Contact where WarehouseID =@ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID",warehouse.WarehouseId);
            cmd.Parameters.AddWithValue("WarehouseName", warehouse.WarehouseName);
            cmd.Parameters.AddWithValue("@City", warehouse.City);
            cmd.Parameters.AddWithValue("@Contact", warehouse.ContactNumber);
            conn.Open();
            int status = cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToBoolean(status);
        }

        public bool Delete (int id)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "delete from Warehouses where WarehouseID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", id);
 
            conn.Open();
            int status = cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToBoolean(status);
        }

        public DataTable GetWarehouseById(int warehouseId)
        {

            SqlConnection conn = ConnectionString.GetConnection();
            string query = "select WarehouseID,WarehouseName,City,ContactNumber from Warehouses where WarehouseID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID",warehouseId);

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

    }
}
