using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    internal class Items
    {
    }
    class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int BrandID { get; set; }
        public int WarehouseID { get; set; }
        public int PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Stock { get; set; }
        public string Description { get; set; }

        public Item()
        {
            this.ItemID = 0;
            this.ItemName = "N/A";
            this.BrandID = 0;
            this.WarehouseID = 0;
            this.PurchasePrice = 0;
            this.SalePrice = 0;
            this.Stock = 0;
            this.Description = "N/A";
        }
        public Item(int itemid,string itemname,int brandid,int warehouseid,int purchasePrice,int saleprice,int stock,string decs)
        {
            this.ItemID = itemid;
            this.ItemName = itemname;
            this.BrandID = brandid;
            this.WarehouseID = warehouseid;
            this.PurchasePrice = purchasePrice;
            this.SalePrice = saleprice;
            this.Stock = stock;
            this.Description = decs;

        }
    }
}
