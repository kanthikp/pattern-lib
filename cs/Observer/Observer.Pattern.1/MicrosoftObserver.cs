using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Pattern._1
{
    public class MicrosoftObserver: AbstractObserver
    {
        public MicrosoftObserver(StockTicker subj)
        {
            this.DataSource = subj;
            subj.Register(this);
        }
        private StockTicker DataSource { get; set; }
        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;

            if (symbol == "MSFT" && price > 10.00m)
                Console.WriteLine("Microsoft has reached the target price: {0}", price);
                
        }
    }
}
