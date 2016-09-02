using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcards
{
    class InterestAdder
    {
        public static double SumInterest(List<IinterestEarner> interestEarners)
        {
            double counter = 0;
            foreach (IinterestEarner interestEarner in interestEarners)
            {
                counter += interestEarner.GetInterest();

            }
            return counter;
        }
    }
}
