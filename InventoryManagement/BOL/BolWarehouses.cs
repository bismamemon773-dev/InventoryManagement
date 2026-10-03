using InventoryManagement.DAL;
using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.BOL
{
    internal class BolWarehouses
    {
        public DataTable GetAllWarehouses()
        {
            DalWarehouses dal = new DalWarehouses();
            DataTable dt = dal.GetAllWarehouses();
            return dt;
        }

        public bool Insert(WareHouse warehouse)
        {
            DalWarehouses dal = new DalWarehouses();
            bool status = dal.Insert(warehouse);
            return status;
        }
        public bool Update(WareHouse warehouse)
        {
            DalWarehouses dal = new DalWarehouses();
            bool status = dal.Update(warehouse);
            return status;
        }

        public bool Delete(int id)
        {
            DalWarehouses dal = new DalWarehouses();
            bool status = dal.Delete(id);
            return status;
        }
        public DataTable GetWarehouseById(int warehouseId)
        {
            DalWarehouses dal = new DalWarehouses();
            DataTable dt = dal.GetWarehouseById(warehouseId);
            return dt;
        }
    }
}
