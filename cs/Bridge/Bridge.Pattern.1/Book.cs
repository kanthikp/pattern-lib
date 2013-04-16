using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Pattern._1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        internal void Print()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Text: {0}", Text);
            Console.WriteLine();
        }
    }
}
