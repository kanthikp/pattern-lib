using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Pattern._3
{
    public class ComplicatedUnstableObject: ICloneable
    {
        internal ComplicatedUnstableObject(string a, int b, int c, char d, string e)
        { }
        internal ComplicatedUnstableObject(int ba, int c, char d, string e)
        { }
        internal ComplicatedUnstableObject(string a, char da, string c)
        { }
        internal ComplicatedUnstableObject(string a, int c, char d, string e, string f)
        { }
        //only expose one simple constructor for your API and do the complex stuff inside.
        public static ComplicatedUnstableObject Reference()
        {
            return new ComplicatedUnstableObject("a", 7, 34, 'c', "st");
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
