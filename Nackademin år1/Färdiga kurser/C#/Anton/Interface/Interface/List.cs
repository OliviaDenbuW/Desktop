using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface List
    {
        //return the size of the list
        int Size();

        //Add elem elem to the end of the list
        void Add(int i);

        //remove all items from list
        void Clear();

        //returns the element at index i
        //* param i the index of the item
        //return the element at index
        int Get(int i);
    }
}
