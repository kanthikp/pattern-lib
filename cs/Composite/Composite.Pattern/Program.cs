using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxleafsToCreate = 1023;
            Console.WriteLine("You have gained {0} leafs, use them wisely.", maxleafsToCreate);

            var bonsai = new Tree { Name = "bonsai" };
            var cypress = new Tree { Name = "cypress" };
            var baobab = new Tree { Name = "baobab" };
            var pine = new Tree { Name = "pine" };
            var ceiba = new Tree { Name = "ceiba" };
            var oldTree = new Tree { Name = "oldTree" };
            var newTree = new Tree { Name = "newTree" };
            var oldnewtrees = new Group { Trees = { oldTree, newTree } };

            var trees = new Group { Name = "Trees", Trees = { cypress, baobab, pine, oldnewtrees } };

            var forests = new Group { Trees = { trees, bonsai, ceiba } };

            forests.Leafs += maxleafsToCreate;
            forests.Stats();           

            Console.ReadKey();
        }
    }
    
}
