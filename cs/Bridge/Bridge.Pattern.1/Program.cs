using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Pattern._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var faq = new FAQ();
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation");
            faq.Print();

            var book = new Book
                            {
                                Title = "Lots of Patterns",
                                Author = "Jhon Sonmez",
                                Text = "Blah blah blah..."
                            };
            book.Print();
            var paper = new TermPaper
                            {
                                Class = "Design Patterns",
                                Student = "John Doe",
                                Text = "some text",
                                References = "GOF"
                            };
            paper.Print();

            Console.ReadKey();
        }
    }
}
