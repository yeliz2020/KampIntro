using System;

namespace day2Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            string pname = " Name: ";
            string price = " Price: ";
            string color = " Color: ";

            Product product1 = new Product();
            product1.PruductName = "Apple Watch6";
            product1.ProductPrice = 3799.99;
            product1.ProductColor = "Gold";

            Product product2 = new Product();
            product2.PruductName = "Galaxy Watch3";
            product2.ProductPrice = 2499.99;
            product2.ProductColor = "Mystic Bronze";

            Product product3 = new Product();
            product3.PruductName = "Huawei Watch GT2 Pro";
            product3.ProductPrice = 2299.99;
            product3.ProductColor = "Black";

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(pname + product.PruductName + price + product.ProductPrice + color + product.ProductColor);
            }

            Console.WriteLine(" ");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(pname + products[i].PruductName + price + products[i].ProductPrice + color + products[i].ProductColor);
            }

            Console.WriteLine(" ");

            int j = 0;
            while (j<products.Length)
            {
                Console.WriteLine(pname + products[j].PruductName + price + products[j].ProductPrice + color + products[j].ProductColor);
                j++;
            }
        }
           
    }

    class Product
    {
        public string PruductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductColor { get; set; }
    }
}
