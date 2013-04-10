using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Pattern._2
{
    class GoogleMonitor
    {
        public GoogleMonitor(StockTicker st)
        {
            st.StockChange += new EventHandler<StockChangeEventArgs>(st_StockChange);
        }

        void st_StockChange(object sender, StockChangeEventArgs e)
        {
            if (e.Stock.Symbol== "GOOG")
                Console.WriteLine("Google's new price is: {0}", e.Stock.Price);
        }

    }
}
