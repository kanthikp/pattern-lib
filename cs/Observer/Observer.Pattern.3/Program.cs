using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Pattern._3
{
    class Program
    {
        static void Main(string[] args)
        {
            StockTicker st = new StockTicker();

            GoogleMonitor gf = new GoogleMonitor();
            MicrosoftMonitor mf = new MicrosoftMonitor();

            using (st.Subscribe(gf))
            using (st.Subscribe(mf))
            {
                foreach (var s in SampleData.getNext())
                {
                    st.Stock = s;
                }
            }
        }
    }
}
