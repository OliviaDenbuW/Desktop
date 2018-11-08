using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenganExtra.Bowling
{
    class CurrentFeeList
    {
        //I konstruktorn skapar vi t
        static private CurrentFeeList instance = null;
        public static CurrentFeeList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CurrentFeeList();
                }
                return instance;
            }
        }
        //SINGELTON
        //KOmmer bara finnas ett enda objekt av denna typen, CUrrentFeeList ska bara finnas en.
        //

        //I vårt system vill vi alltid ha tre poster av typen currantFee
        //Det blir prislistan som häll
        //Lägger in i en lista men vi vill ha en lista (CurrantFeeList. vi vill bara ha som en globalVariable)
        public List<CurrantFee> currantFees { get; set; }

        public int GetPriceForFeeType(FeeType feeType)
        {
            foreach (CurrantFee fee in currantFees)
            {
                if (fee.FeeType == feeType) return fee.Amount;
                return 0;
            }
        }
        //Konstruktorn är private så går inte att komma ut, utan att gå viaz statiska instans som kommer alltid returnera en och samma lista
        private CurrentFeeList()
        {
            currantFees = new List<CurrantFee>();
            currantFees.Add(new CurrantFee { FeeType = FeeType.CompetitionFee, Amount = 100 });
            currantFees.Add(new CurrantFee { FeeType = FeeType.GameFee, Amount = 100 });
            currantFees.Add(new CurrantFee { FeeType = FeeType.MemberFee, Amount = 100 });
        }
    }
}
