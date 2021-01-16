using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.ProductName = "Helva";
            product1.CategoryName = "GIDA";
            product1.Price = 60;

            Product product2 = new Product();

            product2.Id = 2;
            product2.ProductName = "Khilios Olive Box Mink";
            product2.CategoryName = "DEKORASYON";
            product2.Price = 130;

            Product[] products = new[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Id + " : " + product.ProductName + " : " + product.CategoryName + " : " + product.Price);
            }
        }
    }


    class Product
    {
        
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public double Price { get; set; }
    }

}
