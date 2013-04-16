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
            List<IManuscript> documents = new List<IManuscript>();
            var faq = new FAQ();
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation");
            documents.Add(faq);

            var book = new Book
                            {
                                Title = "Lots of Patterns",
                                Author = "Jhon Sonmez",
                                Text = "Blah blah blah..."
                            };
            documents.Add(book);

            var paper = new TermPaper
                            {
                                Class = "Design Patterns",
                                Student = "John Doe",
                                Text = "some text",
                                References = "GOF"
                            };
            documents.Add(paper);

            foreach (var d in documents)
                d.Print();

            Console.ReadKey();
        }
    }
}
