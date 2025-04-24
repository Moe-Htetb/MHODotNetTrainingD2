using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHODotNetTrainingD4
{
    internal static class Data
    {
        public static int ProductId = 0;

        public static List<Product> Products = new List<Product>
        {
            new Product(1, "P001", "Apple", 1500m, 100, "Fruits"),
            new Product(2, "P002", "Banana", 500m, 150, "Fruits"),
            new Product(3, "P003", "Carrot", 600m, 200, "Vegetables"),
            new Product(4, "P004", "Potato", 200m, 250, "Vegetables"),
            new Product(5, "P005", "Chicken", 9000m, 50, "Meat")
        };
    }
}
