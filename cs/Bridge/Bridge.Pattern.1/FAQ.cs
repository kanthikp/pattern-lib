using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Pattern._1
{
    public class FAQ: Manuscript
    {
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public FAQ(IFormatter formatter):base(formatter)
        {
            Questions = new Dictionary<string, string>();
        }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            foreach (var q in Questions)
            {
                Console.WriteLine(formatter.Format("\tQuestion", q.Key));
                Console.WriteLine(formatter.Format("\tAnswer", q.Value));
            }
            Console.WriteLine();
        }
    }
}
