using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace project7
{
    class Program
    {
        public static void In(Dictionary<int, Product> products){
            foreach(var kv in products) {
                int k = kv.Key;
                Product p = kv.Value;
                Console.WriteLine("Product id {0} have Name {1}",k,p.Name);
            }
        }
        static void Main(string[] args)
        {

            Product pro1 = new Product("sp", 1);
            Product pro2 = new Product("sp2", 2);
            // Product pro1 = Product.setPros();
            // Product pro2 = Product.setPros();
            Dictionary<int, Product> products = new Dictionary<int, Product>();
            products[pro1.Id] = pro1;
            products[pro2.Id] = pro2;
            In(products);

            Console.WriteLine("Prod have id 1 is " + products[1].Name);
            // Product[] prodDemos = products.Values.ToArray();
            Product[] prodDemos = products.Values.ToArray().Where(x => x.Name=="Demo").ToArray();
            if (prodDemos.Length == 0) {
                Console.WriteLine("No product name Demo");
            } else {
                Console.WriteLine("Have product name Demo " + prodDemos[0].Name);
            }

            products.Remove(2);
            Console.WriteLine("Print after remove product 2");
            In(products);
        }
    }
}
