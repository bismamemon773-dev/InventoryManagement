using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    internal class Warehouses
    {
    }
    class WareHouse
    {
        public int WarehouseId { get; set; }
        public string WarehouseName {  get; set; }
        public string City {  get; set; }
        public string ContactNumber { get; set; }

        public WareHouse()
        {
            this.WarehouseId = 0;
            this.WarehouseName = "N/A";
            this.City = "N/A";
            this.ContactNumber = "N/A";
        }
        public WareHouse(int warehouseid,string name, string city, string contactnumber)
        {
            this.WarehouseId = warehouseid;
            this.WarehouseName = name;
            this.City = city;
            this.ContactNumber = contactnumber;
        }
    }
}
