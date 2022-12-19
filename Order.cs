using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Order
    {
        public double Price{ get; set; }
        public DateTime Date { get; set; }
        public Order(DateTime date,int price)
        {
            Date = date;
            Price = price;

        }
    }
}
