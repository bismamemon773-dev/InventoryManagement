using InventoryManagement.DAL;
using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.BOL
{
    internal class BolItems
    {
        public DataTable GetAllItems()
        {
            DalItems item = new DalItems();
            DataTable dt = item.GetAllItems();
            return dt;
        }

        public bool InsertItem(Item item)
        {
            DalItems insert = new DalItems();
            bool status = insert.InsertItem(item);
            return status;
        }
        public bool UpateItem(Item item)
        {
            DalItems update = new DalItems();
            bool status = update.UpdateItem(item);
            return status;
        }
        public bool DeleteItem(int itemID)
        {
            DalItems Delete = new DalItems();
            bool status = Delete.DeleteItem(itemID);
            return status;
        }

        public DataTable GetItemById(int itemid)
        {
            DalItems dalitem = new DalItems();
            DataTable dt = dalitem.GetItemById(itemid);
            return dt;
        }

        public DataTable SearchItems(string itemName)
        {
            DalItems dalitem = new DalItems();
            DataTable dt = dalitem.SearchItems(itemName);
            return dt;
        }

        public DataTable GetItemsByBrandId(int brandId)
        {
            DalItems item = new DalItems();
            DataTable dt = item.GetItemsByBrandId(brandId);
            return dt;
        }

        public DataTable GetItemsByWarehouseId(int warehouseID)
        {
            DalItems item = new DalItems();
            DataTable dt = item.GetItemsByWarehouseId(warehouseID);
            return dt;
        }

        public DataTable GetItemsAboveSalePrice(decimal price)
        {
            DalItems item = new DalItems();
            DataTable dt = item.GetItemsAboveSalePrice(price);
            return dt;
        }
        public bool UpdateStock(int itemId, int stock)
        {
            DalItems item = new DalItems();
            bool status = item.UpdateStock(itemId,stock);
            return status;
        }

        public bool UpdateSalePrice(int itemId, decimal saleprice)
        {
            DalItems item = new DalItems();
            bool status = item.UpdateSalePrice(itemId, saleprice);
            return status;
        }

    }
}
