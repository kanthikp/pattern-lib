using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Pattern._2
{
    public class StockChangeEventArgs : EventArgs
    {
        public Stock Stock { get; set; }

        public StockChangeEventArgs(Stock stock)
        {
            this.Stock = stock;
        }
    }
}
