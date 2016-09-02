namespace creditcards
{
    public class Card : IInterestEarner
    {
        public string Name => _cardType.Name;
        private readonly double _balance;
        private readonly ICardType _cardType;
        private double Interest => _cardType.InterestRate;

        public Card(double balance, ICardType cardType)
        {
            _balance = balance;
            _cardType = cardType;
        }
        public double GetInterest()
        {
            return _balance*Interest;
        }
    }
}
