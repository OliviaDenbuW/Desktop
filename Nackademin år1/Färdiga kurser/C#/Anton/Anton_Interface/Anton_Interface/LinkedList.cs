using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_Interface
{
    public class LinkedList : List
    {
        private List<int> listNumbers;

        public LinkedList()
        {
           this.listNumbers = new List<int>();
        }

        public int Size()
        {
            return this.listNumbers.Count();
        }

        public void Add(int element)
        {
            listNumbers.Add(element);
        }

        public void Clear()
        {
            listNumbers.Clear();
        }

        public int Get(int index)
        {
            return listNumbers.ElementAt(2);
        }
    }
}
