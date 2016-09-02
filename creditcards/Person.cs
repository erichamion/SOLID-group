using System.Collections.Generic;

namespace creditcards
{
    public class Person<T> : IInterestEarner where T : IInterestEarner
    {
        public List<T> Wallets { get; }

        public double GetInterest()
        {
            return InterestAdder.SumInterest(Wallets);
        }
        public Person(List<T> Wallets) 
        {
            this.Wallets = Wallets;
        }
    }
}
