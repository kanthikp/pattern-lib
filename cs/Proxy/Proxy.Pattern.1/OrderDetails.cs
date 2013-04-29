using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.Pattern._1
{
    public class OrderDetails
    {
        private readonly int _id;
        public OrderDetails() { }
        public OrderDetails(int id)
        {
            _id = id;
            var orderDetailsEntity = new OrderDetailsRepository().GetById(id);
            this.Name = orderDetailsEntity.Name;
            this.Price = orderDetailsEntity.Price;        
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
