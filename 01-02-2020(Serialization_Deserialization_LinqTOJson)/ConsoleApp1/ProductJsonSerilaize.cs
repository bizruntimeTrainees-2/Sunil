using System;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class ProductJsonSerilaize
    {
       public void productSerilaize()
        {
            ProductDetails product = new ProductDetails();
            product.Name = "Apple";
            product.Price = 10;
            product.ExpireDate = "10-02-2020";

            string JsonData = JsonConvert.SerializeObject(product);
            Console.Write(JsonData);
        }
       
    }
}
