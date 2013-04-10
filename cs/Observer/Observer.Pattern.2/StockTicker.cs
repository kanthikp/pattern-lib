using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Pattern._2
{
    class StockTicker
    {
        private Stock stock;
        public Stock Stock
        {
            get { return stock; }
            set 
            {
                stock = value;
                this.OnStockChange(new StockChangeEventArgs(this.stock));
            }
        }
        public string Exchange { get; set; }
        public event EventHandler<StockChangeEventArgs> StockChange;
        public event EventHandler ExchangeChange;

        protected virtual void OnStockChange(StockChangeEventArgs e)
        {
            if (StockChange != null)
            {
                StockChange(this, e);
            }
        }

    }
}
