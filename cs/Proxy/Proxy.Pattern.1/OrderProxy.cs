using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.Pattern._1
{
    public class OrderProxy: Order
    {
        private bool _customerLoaded;
        private bool _entityLoaded;
        private bool _itemsLoaded;
        private Customer _customer;
        private List<OrderDetails> _orderDetails;

        public OrderProxy(int id)
        {
            _id = id;
        }

        public override DateTime OrderDate
        {
            get
            {
                GetEntity();
                return OrderEntity.OrderDate;
            }
        }
        public override Customer Customer
        {
            get
            {
                return GetCustomer();
            }
        }
        public override List<OrderDetails> Items
        {
            get
            {
                return GetItems();
            }
        }
        protected override void GetEntity()
        {
            if (!_entityLoaded)
            {
                base.GetEntity();
                _entityLoaded = true;
            }
        }
        protected override Customer GetCustomer()
        {
            if (!_customerLoaded)
            {
                GetEntity();
                _customer = base.GetCustomer();
                _customerLoaded = true;
            }
            return _customer;
        }
        protected override List<OrderDetails> GetItems()
        {
            if (!_itemsLoaded)
            {
                GetEntity();
                _orderDetails = base.GetItems();
                _itemsLoaded = true;
            }
            return _orderDetails;
        }        
    }
}
