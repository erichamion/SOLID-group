using System.Collections.Generic;

namespace creditcards
{
    class InterestAdder
    {
        public static double SumInterest<T>(List<T> interestEarners) where T : IInterestEarner
        {
            double counter = 0;
            foreach (IInterestEarner interestEarner in interestEarners)
            {
                counter += interestEarner.GetInterest();

            }
            return counter;
        }
    }
}
