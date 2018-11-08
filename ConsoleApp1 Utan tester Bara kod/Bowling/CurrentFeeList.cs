using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bowling
{
    class CurrentFeeList
    {
        private static CurrentFeeList instance = null;
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

        public int GetPriceForFeeType(FeeType feeType)
        {
            foreach (CurrentFee fee in currentFees)
                if (fee.FeeType == feeType) return fee.Amount;
            return 0;
        }

        public List<CurrentFee> currentFees;
        private CurrentFeeList()
        {
            currentFees = new List<CurrentFee>();
            currentFees.Add(new CurrentFee { FeeType = FeeType.CompetitionFee, Amount = 100 });
            currentFees.Add(new CurrentFee { FeeType = FeeType.MemberFee, Amount = 200 });
            currentFees.Add(new CurrentFee { FeeType = FeeType.GameFee, Amount = 20 });
        }

    }
}
