using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcards
{
    public class Wallet : IInterestEarner
    {
        public List<IInterestEarner> Cards { get; }

        public double GetInterest()
        {
            return InterestAdder.SumInterest(Cards);
        }

        public Wallet(List<IInterestEarner> cards)
        {
            this.Cards = cards;
        }
    }
}
