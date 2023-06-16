using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Product
    {
        //Create class Product with code,name & price , accept the data & print it

        public int productcode;
        public string productname;
        public int productprice;

        public void ProductData(int id, string name, int price)
        {
            productcode = id;
            productname = name;
            productprice = price;
        }

        public string PrintData()
        {
            return $"Product code: {productcode}\nProduct Name: {productname}\nProduct Price: {productprice}\n";
        }

        public int GetProductcode()
        {
            return productcode;
        }

        public string GetProductNmae()
        {
            return productname;
        }

        public double GetProductPrice()
        {
            return productprice;
        }






    }
}
