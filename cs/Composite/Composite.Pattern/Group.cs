using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Pattern
{
    public class Group
    {
        public string Name { get; set; }
        public List<Tree> Trees { get; set; }
        public Group() {
            Trees = new List<Tree>();
        }
    }
}
