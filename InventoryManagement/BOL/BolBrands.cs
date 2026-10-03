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
    internal class BolBrands
    {
        public DataTable GetAllBrands()
        {
            DalBrands dal = new DalBrands();
            DataTable dt = dal.GetAllBrands();
            return dt;
        }

        public bool InsertBrand(Brand brand)
        {
            DalBrands dal = new DalBrands();
            bool status = dal.InsertBrand(brand);
            return status;
        }

        public bool UpdateBrand(Brand brand)
        {
            DalBrands dal = new DalBrands();
            bool status = dal.UpdateBrand(brand);
            return status;
        }

        public bool DeleteBrand(int id)
        {
            DalBrands dal = new DalBrands();
            bool status = dal.DeleteBrand(id);
            return status;
        }

        public DataTable GetBrandById(int Brandid)
        {
            DalBrands dal = new DalBrands();
            DataTable dt = dal.GetBrandById(Brandid);
            return dt;
        }

    }
}
