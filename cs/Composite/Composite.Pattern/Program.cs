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
            var trees = new Group { Name = "bigTrees", Trees = { cypress, baobab, pine } };

            var singleTrees = new List<Tree> { bonsai, ceiba };
            var groups = new List<Group> { trees };

            var totalToSplitBy = singleTrees.Count + groups.Count;

            var amountForEach = maxleafsToCreate / totalToSplitBy;
            var leftOver = maxleafsToCreate % totalToSplitBy;

            foreach (var singleTree in singleTrees) {
                singleTree.Leafs += amountForEach + leftOver;
                leftOver = 0;
                singleTree.Stats();
            }

            foreach (var group in groups) {
                var amountForEachGroupTree = amountForEach / group.Trees.Count;
                var leftOverForGroup = amountForEachGroupTree%group.Trees.Count;

                foreach (var tree in group.Trees) {
                    tree.Leafs += amountForEachGroupTree + leftOverForGroup;
                    leftOverForGroup = 0;
                    tree.Stats();
                }
            }

            Console.ReadKey();

        }
    }
}
