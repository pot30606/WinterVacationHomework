using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork08Sales
{
    class Product
    {
        public string P_Name { set; get; }
        public int P_Price { set; get; }
    }

    class Sales
    {
        public string SalesName { set; get; }
        public string P_Name { set; get; }
        public int P_Quantity { set; get; }

    }

    class SalesResult
    {
        public int P_Price { set; get; }
        public int P_Quantity { set; get; }

        public string SalesName { set; get; }
        public int SalesTotal
        {
            get { return P_Price * P_Quantity; }
        }

    }

    class ProductResult
    {
        public string P_Name { set; get; }
        public int ProductTotal { set; get; }

    }

    class BestProduct
    {
        public string P_Name { set; get; }

        public int TotalPrice { set; get; }
    }

    class BestSeller
    {
        public string SalesName { set; get; }

        public int TotalPrice { set; get; }
    }




}
