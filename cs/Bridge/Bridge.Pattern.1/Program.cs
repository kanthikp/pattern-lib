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
            List<Manuscript> documents = new List<Manuscript>();
            var formatter = new StandarFormatter();
            var backwards = new BackwardsFormatter();
            var fancyformatter = new FancyFormatter();

            var faq = new FAQ(fancyformatter);
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation");
            documents.Add(faq);

            var book = new Book(backwards)
                            {
                                Title = "Lots of Patterns",
                                Author = "Jhon Sonmez",
                                Text = "Blah blah blah..."
                            };
            documents.Add(book);

            var paper = new TermPaper(formatter)
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
