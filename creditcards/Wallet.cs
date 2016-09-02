using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcards
{
    public class Wallet : IinterestEarner
    {
        public List<IinterestEarner> Cards { get; }

        public double GetInterest()
        {
            return InterestAdder.SumInterest(Cards);
        }

        public Wallet(List<IinterestEarner> cards)
        {
            this.Cards = cards;
        }
    }
}
