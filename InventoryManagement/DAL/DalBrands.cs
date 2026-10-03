using InventoryManagement.Helper;
using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAL
{
    internal class DalBrands
    {
        public DataTable GetAllBrands()
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "select BrandID,BrandName,Country from Brands";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public bool InsertBrand(Brand brand)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "insert into Brands values (@BrandName,@Country)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@BrandName", brand.BrandName);
            cmd.Parameters.AddWithValue("@Country", brand.Country);
            conn.Open();
            int status = Convert.ToInt32(cmd.ExecuteNonQuery());
            conn.Close();
            return Convert.ToBoolean(status);
        }

        public bool UpdateBrand(Brand brand)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "update Brands set BrandName=@BrandName,Country=@Country where BrandID=@ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", brand.BrandID);
            cmd.Parameters.AddWithValue("@BrandName", brand.BrandName);
            cmd.Parameters.AddWithValue("@Country", brand.Country);
            conn.Open();
            int status = Convert.ToInt32(cmd.ExecuteNonQuery());
            conn.Close();
            return Convert.ToBoolean(status);
        }
        public bool DeleteBrand(int id)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "delete from Brands where BrandID =@ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", id);
            conn.Open();
            int status = Convert.ToInt32(cmd.ExecuteNonQuery());
            conn.Close();
            return Convert.ToBoolean(status);
        }

        public DataTable GetBrandById(int brandId)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "select BrandID,BrandName,Country from Brands where BrandID=@ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", brandId);

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }


    }
}
