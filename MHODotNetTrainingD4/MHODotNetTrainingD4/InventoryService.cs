using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHODotNetTrainingD4
{
    internal class InventoryService
    {
        public void CreateProduct()
        {
            Console.WriteLine("Inventory Management System");
            Console.Write("Input Product Name:");


            string productName = Console.ReadLine()!;


        BeforePrice:
            Console.Write("Input Product Price:");
            string productPrice = Console.ReadLine()!;

            decimal price = 0;

            bool isDecimal = decimal.TryParse(productPrice, out price);

            if (!isDecimal)
            {
                Console.WriteLine("Invalid price format. Please enter a valid decimal number.");
                goto BeforePrice;
            }


        BeforeQuantity:
            Console.Write("Input Product Quantity:");
            string productQuantity = Console.ReadLine()!;

            int Quantity = 0;

            bool isInteger = int.TryParse(productQuantity, out Quantity);

            if (!isInteger)
            {
                Console.WriteLine("Invalid Quantity format. Please enter a valid Integer number.");
                goto BeforeQuantity;
            }


            //Data.ProductId++;
            int no = Data.Products.Max(x => x.Id) + 1;
            Data.ProductId = no;

            string productCode = "P" + Data.ProductId.ToString().PadLeft(3, '0');


            Product product = new Product(Data.ProductId, productCode, productName, price, Quantity, "Fruits");

            Data.Products.Add(product);

            Console.WriteLine("Product added successfully!");
        }
        public void ViewProduct()
        {

            Console.WriteLine("Product List:");
            foreach (var item in Data.Products)
            {
                Console.WriteLine($"ID: {item.Id}, Code: {item.Code}, Name: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}, Category: {item.Category}");
            }


        }

        public void UpdateProduct()
        {
        BeforeInputCode:
            Console.WriteLine("Enter the product code to update:");
            string code = Console.ReadLine()!;

            var product = Data.Products.FirstOrDefault(p => p.Code == code);

            if (product is null)
            {
                Console.WriteLine("Product code cannot be null.");
                goto BeforeInputCode;
            }


            Console.WriteLine("Product Found");
            Console.WriteLine($" Code: {product.Code}, Name: {product.Name}, Quantity: {product.Quantity}");

        BeforeInputQuantity:
            Console.WriteLine("Enter the new quantity:");
            string newQuantity = Console.ReadLine()!;
            int quantity = 0;
            bool isInteger = int.TryParse(newQuantity, out quantity);
            if (!isInteger)
            {
                Console.WriteLine("Invalid quantity format. Please enter a valid integer number.");
                goto BeforeInputQuantity;
            }
            product.Quantity = quantity;


        }

        public void DeleteProduct()
        {
        BeforeInputCode:
            Console.WriteLine("Enter the product code to delete:");
            string code = Console.ReadLine()!;
            var product = Data.Products.FirstOrDefault(p => p.Code == code);
            if (product is null)
            {
                Console.WriteLine("Product code cannot be null.");
                goto BeforeInputCode;
            }

            Console.WriteLine("Are you sure to delete? Y/N ");
            string ans = Console.ReadLine()!;
           if(ans.ToUpper() == "Y")
            {
                Data.Products.Remove(product);
                Console.WriteLine("Product deleted successfully!");
            }
           
        }
    }
   
}
