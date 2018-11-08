using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class CurrentFeeList
    {
        /*
         ANVÄNDER SINGELTON PATTERN

                - Pga vi gör konstruktorn privat så kan man inte utifrån skapa upp en till instans av den här klassen (singelton)
                        - Kommer bara finnas ett objekt av den här typen (currentFeelist ska bara finnas en av)

                - Vi använder den här listan som en typ av prislista (om den ändras så har de bakåt som använt listan samma värden)

                - I den här listan lägger vi in Amount och FeeType på resp. item (görs i konstruktorn)


          METODER:
                - GetPriceForFeeType()
          
          KONSTRUKTOR (privat) och PROPERTIES (ngn statisk....googla)
         */
    }
}
