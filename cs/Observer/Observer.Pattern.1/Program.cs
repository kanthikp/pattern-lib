using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Pattern._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StockTicker subj = new StockTicker();

            GoogleObserver gobs = new GoogleObserver(subj);
            MicrosoftObserver mobs = new MicrosoftObserver(subj);

            foreach (var s in SampleData.getNext())
                subj.Stock = s;
        }
    }
}
