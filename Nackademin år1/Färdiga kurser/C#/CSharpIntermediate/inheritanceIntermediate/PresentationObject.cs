using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceIntermediate
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlikn(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
    //BAS-klassen
    public class PresentationObject
    {
        //Definerar PROPERTIES
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object was copied to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated to clipboard");
        }
    }
}
