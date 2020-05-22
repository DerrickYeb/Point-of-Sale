using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSale.Models
{
   public class ProductModel
    {
        public int Code { get; set; }
      
        public string Name { get; set; }
        public string Category { get; set; }

        public int StockQty { get; set; }

        public decimal StockAmount { get; set; }

        public Decimal SalePrice { get; set; }

        public Decimal PurchasePrice { get; set; }

        public int PurchaseUnit { get; set; }

        public string Description { get; set; }

    }
}
