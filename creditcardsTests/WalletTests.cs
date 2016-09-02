using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace creditcards.Tests
{
    [TestClass()]
    public class WalletTests
    {
        [TestMethod()]
        public void GetInterestTest()
        {
            //Arrange
            List<IInterestEarner> mockCards = new List<IInterestEarner> { new MockInterestEarner(), new MockInterestEarner(), };
            Wallet wallet = new Wallet(mockCards);
            double result;
            //Act
            result = wallet.GetInterest();
            //Assert
            Assert.AreEqual(84, result);
        }

        [TestMethod()]
        public void WalletTest()
        {
            //Arrange
            List<IInterestEarner> mockCards = new List<IInterestEarner> { new MockInterestEarner(), new MockInterestEarner(), };
            //Act
            Wallet wallet = new Wallet(mockCards);
            //Assert

            Assert.IsTrue(wallet.Cards.SequenceEqual(mockCards));
        }
    }
}