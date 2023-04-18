using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductBook
{
    internal abstract class Bookstore:IBooks
    {
        public string bookTitle { get; set; }

        public string productTitle { get; set; }

        public double bookPrice { get; set; }

        public double productPrice { get; set; }

        public string bookPublisher { get; set; }

        public string productPublisher { get; set; }

        public abstract double CalculatePrice();
    }
}
