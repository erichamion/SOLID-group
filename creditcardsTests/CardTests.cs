using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace creditcards.Tests
{
    [TestClass()]
    public class CardTests
    {
        [TestMethod()]
        public void NameTest()
        {
            //Arrange
            Card card = new Card(100.00, new MockCardType());
            string name;

            //Act
            name = card.Name;


            //Assert
            Assert.AreEqual("FakeCard", name);
        }

        [TestMethod()]
        public void GetInterestTest()
        {
            //Arrange
            Card card = new Card(100.00, new MockCardType());
            double interest;

            //Act
            interest = card.GetInterest();

            //Assert
            Assert.AreEqual(10.00, interest, .00000000001);
        }
    }

    class MockCardType : ICardType
    {
        public string Name
        {
            get { return "FakeCard"; }
        }

        public double InterestRate
        {
            get { return 0.10; }
        }
    }
}