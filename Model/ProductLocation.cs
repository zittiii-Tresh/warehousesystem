using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehousesystem.Model
{
    public class ProductLocation
    {
        public string LocationID { get; set; }

        public string ProductID { get; set; }

        public class AisleLocation
        {
            public string Aisle { get; set; }
        }

        public class ContainerLocation
        {
            public string Container { get; set; }
        }

        public class ShelfLocation
        {
            public string Shelf { get; set; }
        }
    }
}
