using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductBook
{
    internal class Product:Bookstore
    {
        public double VAT = 0.14;
        public override double CalculatePrice()
        {
            return productPrice + (productPrice * VAT);
        }
    }
}
