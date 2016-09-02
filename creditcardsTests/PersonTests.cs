using Microsoft.VisualStudio.TestTools.UnitTesting;
using creditcards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcards.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void GetInterestTest()
        {   //Arrange
            List<IinterestEarner> mockWallets = new List<IinterestEarner> { new MockInterestEarner(), new MockInterestEarner(), };
            Person person = new Person(mockWallets);
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
            List<IinterestEarner> mockWallets = new List<IinterestEarner> {new MockInterestEarner(), new MockInterestEarner(), };
            //Act
            Person person = new Person(mockWallets);
            //Assert
            
            Assert.IsTrue(person.Wallets.SequenceEqual(mockWallets));
        }

        
    }

}