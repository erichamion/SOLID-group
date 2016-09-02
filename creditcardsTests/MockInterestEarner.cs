using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using creditcards;
namespace creditcards.Tests
{
    class MockInterestEarner : IInterestEarner
    {
        public double GetInterest()
        {
            return 42;
        }
    }
}
