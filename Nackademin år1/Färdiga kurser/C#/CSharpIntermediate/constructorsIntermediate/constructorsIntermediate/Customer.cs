using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorsIntermediate
{
    //Gör klassen PUBLIC
    public class Customer
    {
        //Deklarerar FIELDS med STOR bokstav - Gör dem PUBLICA bara nu när vi lär oss       
        public int Id;
        public string Name;
        public List<Order> Orders; //SKapar en list av  ordrar
        

        //DEFAULT construcotr
        public Customer()
        {
            Orders = new List<Order>();
        }

        //OVERLOADING CONSTRUCTOR
        //konstruktor med en inparameter
        public Customer(int id)
        {
            this.Id = id;
        }

        //KONSTRUKTOR med två inparametrar
        public Customer(int id, string name)
        {
            //initialiserar parametrarna
            this.Id = id;
            this.Name = name;
        }
        
    }
}
