using InventoryManagement.Helper;
using InventoryManagement.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAL
{
    internal class DalItems
    {
        public DataTable GetAllItems()
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "select ItemID,ItemName,BrandID,WarehouseID,PurchasePrice,SalePrice,Stock,Description from Items";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public bool InsertItem(Item item)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "insert into Items values(@ItemName,@BrandID,@WarehouseID, @PurchasePrice, @SalePrice, @Stock, @Description)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ItemName", item.ItemName);
            cmd.Parameters.AddWithValue("BrandID", item.BrandID);
            cmd.Parameters.AddWithValue("WarehouseID", item.WarehouseID);
            cmd.Parameters.AddWithValue("PurchasePrice", item.PurchasePrice);
            cmd.Parameters.AddWithValue("SalePrice", item.SalePrice);
            cmd.Parameters.AddWithValue("Stock", item.Stock);
            cmd.Parameters.AddWithValue("Description", item.Description);
            conn.Open();
            int status = cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToBoolean(status);
        }

        public bool UpdateItem(Item item)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "update Items set ItemName=@ItemName ,BrandID=@BrandID ,WarehouseID=@WarehouseID ,PurchasePrice=@PurchasePrice ,SalePrice=@SalePrice ,Stock=@Stock , Description=@Desc where ItemID = @ItemID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ItemID", item.ItemID);
            cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
            cmd.Parameters.AddWithValue("@BrandID", item.BrandID);
            cmd.Parameters.AddWithValue("@WarehouseID", item.WarehouseID);
            cmd.Parameters.AddWithValue("@PurchasePrice", item.PurchasePrice);
            cmd.Parameters.AddWithValue("@SalePrice", item.SalePrice);
            cmd.Parameters.AddWithValue("@Stock", item.Stock);
            cmd.Parameters.AddWithValue("@Desc", item.Description);
            conn.Open();
            int status = cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToBoolean(status);
        }

        public bool DeleteItem(int itemid)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "delete from Items where ItemID = @ItemID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ItemID",itemid);
            conn.Open();
            int status = cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToBoolean(status);
        }

        public DataTable GetItemById(int itemId)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "select ItemID,ItemName,BrandID,WarehouseID,PurchasePrice,SalePrice,Stock,Description from Items where ItemID = @ItemID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ItemID", itemId);
            conn.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            conn.Close();

            return dt;
        }
        
        public DataTable SearchItems(string itemName)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "select ItemID,ItemName,BrandID,WarehouseID,PurchasePrice,SalePrice,Stock,Description from Items where ItemName like @ItemName + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ItemName", itemName);
            conn.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            conn.Close();

            return dt;
        }

        public DataTable GetItemsByBrandId(int brandId)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "select ItemID,ItemName,BrandID,WarehouseID,PurchasePrice,SalePrice,Stock,Description from Items where BrandID= @BrandID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@BrandID", brandId);
            conn.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            conn.Close();

            return dt;
        }

        public DataTable GetItemsByWarehouseId(int warehouseId)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "select ItemID,ItemName,BrandID,WarehouseID,PurchasePrice,SalePrice,Stock,Description from Items where WarehouseID= @WarehouseID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@WarehouseID", warehouseId);
            conn.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            conn.Close();

            return dt;
        }

        public DataTable GetItemsAboveSalePrice(decimal price)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "SELECT ItemID,ItemName,BrandID,WarehouseID,PurchasePrice,SalePrice,Stock,Description FROM Items WHERE SalePrice > @SalePrice";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@SalePrice", price);
            conn.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            conn.Close();

            return dt;
        }

        public bool UpdateStock(int itemId, int stock)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "update Items set Stock =@Stock where ItemID =@ItemID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ItemID", itemId);
            cmd.Parameters.AddWithValue("@Stock", stock);
            conn.Open();
            int status = cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToBoolean(status);
        }

        public bool UpdateSalePrice(int itemId, decimal salePrice)
        {
            SqlConnection conn = ConnectionString.GetConnection();
            string query = "update Items set SalePrice =@SalePrice where ItemID =@ItemID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ItemID", itemId);
            cmd.Parameters.AddWithValue("@SalePrice", salePrice);
            conn.Open();
            int status = cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToBoolean(status);
        }


    }
}
