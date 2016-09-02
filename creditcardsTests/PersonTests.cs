using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace creditcards.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void GetInterestTest()
        {   //Arrange
            List<MockInterestEarner> mockWallets = new List<MockInterestEarner> { new MockInterestEarner(), new MockInterestEarner(), };
            Person<MockInterestEarner> person = new Person<MockInterestEarner>(mockWallets);
            double result;
            //Act
            result = person.GetInterest();
            //Assert
            Assert.AreEqual(84, result);
        }

        [TestMethod()]
        public void PersonTest()
        {
            
            //Arrange
            List<MockInterestEarner> mockWallets = new List<MockInterestEarner> {new MockInterestEarner(), new MockInterestEarner(), };
            //Act
            Person<MockInterestEarner> person = new Person<MockInterestEarner>(mockWallets);
            //Assert
            
            Assert.IsTrue(person.Wallets.SequenceEqual(mockWallets));
        }

        
    }

}