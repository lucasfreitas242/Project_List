using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectList.Models.Orders
{
    public class Orders
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double Total { get; set; }

        public string Details { get; set; }

        public Orders()
        {
            
            Description = "Alvejante";
            Quantity = 3;
            Price = 2.50;
            Total = 7.50;
            Details = "Alvejante: R$2.50 x 3 UN = R$7.50";

        }
    }
}
