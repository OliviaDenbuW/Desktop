using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_Interface
{
    public interface List
    {
        //Return the size of the list
        int Size();

        //Add elem to the end of the list
        void Add(int i);

        //remove all elements from List
        void Clear();

        //Returns the elem at index i
        int Get(int i);
    }
}
