using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehousesystem.Model
{
    public class Product
    {
        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public int CategoryID { get; set; }
        public int StockQuantity { get; set; }

        public string StockStatus { get; set; }

        public int LowStockLevel { get; set; }

        public double ProductPrice { get; set; }

        public string SupplierName { get; set; }

        public string SupplierNo { get; set; }

        public string LocationID { get; set; }

        public string CategoryName { get; set; }
        public int QuantityPerShelf { get; set; }
    }
}
