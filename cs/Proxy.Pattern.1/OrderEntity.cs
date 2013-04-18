using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.Pattern._1
{
    public class OrderEntity
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int[] OrderDetails { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
