using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.Pattern._1
{
    public class OrderDetailsRepository: Repository<OrderDetailsEntity>
    {
        public override OrderDetailsEntity GetById(int id)
        {
            Console.WriteLine("--> Fetching Order Details " + id);
            return new OrderDetailsEntity()
            {
                Name = "Name-" + Convert.ToString(id),
                Price = 10
            };
        }
    }
}
