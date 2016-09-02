using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcards
{
    public class Person: IinterestEarner
    {
        public List<IinterestEarner> Wallets { get; }

        public double GetInterest()
        {
            double counter = 0;
            foreach (IinterestEarner wallet in Wallets)
            {
                counter +=wallet.GetInterest();

            }
            return counter;
        }
        public Person(List<IinterestEarner> Wallets) 
        {
            this.Wallets = Wallets;
        }
    }
}
