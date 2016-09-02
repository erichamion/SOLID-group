using creditcards;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace creditcardsTests
{
    [TestClass]
    public class CaseTests
    {
        [TestMethod]
        public void TestCase1()
        {
            //Arrange
            List<Wallet> wallets = new List<Wallet>
            {
                new Wallet(new List<IInterestEarner>
                {
                    new Card(100.00, new VisaCardType()),
                    new Card(100.00, new MastercardCardType()),
                    new Card(100.00, new DiscoverCardType())
                })
            };
            Person<Wallet> person = new Person<Wallet>(wallets);
            double personInterest;
            double expectedPersonInterest = 16.00;
            List<double> cardInterests = new List<double>();
            List<double> expectedCardInterests = new List<double>
            {
                10.00,
                5.00,
                1.00
            };

            //Act
            personInterest = person.GetInterest();
            foreach (Wallet wallet in person.Wallets)
            {
                foreach (Card card in wallet.Cards)
                {
                    cardInterests.Add(card.GetInterest());
                }
            }

            //Assert
            Assert.AreEqual(expectedPersonInterest, personInterest);
            Assert.AreEqual(cardInterests.Count, expectedCardInterests.Count);
            for (int x = 0; x < cardInterests.Count; x++)
            {
                Assert.AreEqual(expectedCardInterests[x], cardInterests[x], 0.0000000001);
            }

        }

        [TestMethod]
        public void TestCase2()
        {
            //Arrange
            List<Wallet> wallets = new List<Wallet>
            {
                new Wallet(new List<IInterestEarner>
                {
                    new Card(100.00, new VisaCardType()),
                    new Card(100.00, new DiscoverCardType())
                }),
                new Wallet(new List<IInterestEarner>
                {
                    new Card(100.00, new MastercardCardType())
                })
            };
            Person<Wallet> person = new Person<Wallet>(wallets);
            double personInterest;
            double expectedPersonInterest = 16.00;
            List<double> walletInterests = new List<double>();
            List<double> expectedWalletInterests = new List<double>
            {
                11.00,
                5.00
            };

            //Act
            personInterest = person.GetInterest();
            foreach (Wallet wallet in person.Wallets)
            {
                walletInterests.Add(wallet.GetInterest());
            }

            //Assert
            Assert.AreEqual(expectedPersonInterest, personInterest);
            Assert.AreEqual(walletInterests.Count, expectedWalletInterests.Count);
            for (int x = 0; x < walletInterests.Count; x++)
            {
                Assert.AreEqual(expectedWalletInterests[x], walletInterests[x], 0.0000000001);
            }

        }

        [TestMethod]
        public void TestCase3()
        {
            //Arrange
            List<Wallet> wallets1 = new List<Wallet>
            {
                new Wallet(new List<IInterestEarner>
                {
                    new Card(100.00, new VisaCardType()),
                    new Card(100.00, new MastercardCardType()),
                    new Card(100.00, new DiscoverCardType())
                })
            };
            List<Wallet> wallets2 = new List<Wallet>
            {
                new Wallet(new List<IInterestEarner>
                {
                    new Card(100.00, new VisaCardType()),
                    new Card(100.00, new MastercardCardType())
                })
            };
            Person<Wallet> person1 = new Person<Wallet>(wallets1);
            Person<Wallet> person2 = new Person<Wallet>(wallets2);
            double person1Interest, person2Interest;
            double expectedPerson1Interest = 16.00, expectedPerson2Interest = 15.00;
            List<double> person1WalletInterests = new List<double>();
            List<double> person2WalletInterests = new List<double>();
            List<double> person1ExpectedWalletInterests = new List<double>
            {
                16.00
            };
            List<double> person2ExpectedWalletInterests = new List<double>
            {
                15.00
            };

            //Act
            person1Interest = person1.GetInterest();
            person2Interest = person2.GetInterest();
            foreach (Wallet wallet in person1.Wallets)
            {
                person1WalletInterests.Add(wallet.GetInterest());
            }
            foreach (Wallet wallet in person2.Wallets)
            {
                person2WalletInterests.Add(wallet.GetInterest());
            }

            //Assert
            Assert.AreEqual(expectedPerson1Interest, person1Interest);
            Assert.AreEqual(expectedPerson2Interest, person2Interest);
            Assert.AreEqual(person1WalletInterests.Count, person1ExpectedWalletInterests.Count);
            Assert.AreEqual(person2WalletInterests.Count, person2ExpectedWalletInterests.Count);
            for (int x = 0; x < person1WalletInterests.Count; x++)
            {
                Assert.AreEqual(person1ExpectedWalletInterests[x], person1WalletInterests[x], 0.0000000001);
            }
            for (int x = 0; x < person2WalletInterests.Count; x++)
            {
                Assert.AreEqual(person2ExpectedWalletInterests[x], person2WalletInterests[x], 0.0000000001);
            }

        }
    }
}
