using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Pattern
{
    public class Group : Forest
    {
        public string Name { get; set; }
        public List<Forest> Trees { get; set; }
        public Group() {
            Trees = new List<Forest>();
        }

        int Forest.Leafs
        {
            get
            {
                int totalLeafs = 0;
                foreach (var tree in Trees) {
                    totalLeafs += tree.Leafs;
                }
                return totalLeafs;
            }
            set
            {
                var eachSplit = value / Trees.Count;
                var leftOver = value % Trees.Count;
                foreach (var tree in Trees) {
                    tree.Leafs += eachSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        void Forest.Stats()
        {
            foreach (var tree in Trees)
                tree.Stats();
        }
    }
}
