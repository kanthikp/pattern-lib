using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Pattern._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StockTicker st = new StockTicker();

            GoogleMonitor gf = new GoogleMonitor(st);
            MicrosoftMonitor mf = new MicrosoftMonitor(st);

            foreach (var s in SampleData.getNext())
            {
                st.Stock = s;
            }
        }
    }
}
