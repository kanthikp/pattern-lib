using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.Pattern._1
{
    public class CustomerRepository : Repository<CustomerEntity>
    {
        public override CustomerEntity GetById(int id)
        {            
            Console.WriteLine("--> Fetching Customer" + id);
            return new CustomerEntity()
                        {
                            Name = "Customer-"+Convert.ToString(id)
                        };
        }
    }
}
