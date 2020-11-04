using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Class
{
    static class Product
    {
        public static int ProductId;
        public static string ProductName;
        public static double ProductPrice;

        static Product()
        {
            ProductId = 10;
            ProductName = "Camera";
            ProductPrice = 20000;
        }
        public static void getProductDetails()
        {
            Console.WriteLine($"Product Id = {ProductId}");
            Console.WriteLine($"Product Name = {ProductName}");
            Console.WriteLine($"Product Price = {ProductPrice}");
        }
        public static void getProductDiscount()
        {
            var d_product = ProductPrice / 10.0;
            Console.WriteLine($"Product Discount = {d_product}");
            Console.WriteLine("Total Cost of Prosuct is: {0}",(ProductPrice - d_product));
        }
    }
    
}
