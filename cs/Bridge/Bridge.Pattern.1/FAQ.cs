using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Pattern._1
{
    public class FAQ: IManuscript
    {
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public FAQ()
        {
            Questions = new Dictionary<string, string>();
        }

        public void Print()
        {
            Console.WriteLine("Title: {0}", Title);
            foreach (var q in Questions)
            {
                Console.WriteLine("\tQuestion: {0}", q.Key);
                Console.WriteLine("\tAnswer: {0}", q.Value);
            }
            Console.WriteLine();
        }
    }
}
