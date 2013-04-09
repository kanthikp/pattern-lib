using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Prototype.Pattern
{
    class WebPageDigger : ICloneable
    {
        private string title;
        private int headerTagCount;
        private string firstHeaderTagContents;

        public WebPageDigger(string url) 
        {
            var clien = new WebClient();
            Dig(clien.DownloadString(url));

        }
        private void Dig(string page)
        {
            title = "foo title";
            headerTagCount = 3;
            firstHeaderTagContents = "bar header text";
        }
        public void PrintPageData()
        {
            Console.WriteLine("Title: {0},\nHeader Count: {1},\nFirst Header: {2}", title, headerTagCount, firstHeaderTagContents);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
