namespace creditcards
{
    public class MastercardCardType : ICardType
    {
        public string Name
        {
            get { return "Mastercard"; }
        }
        public double InterestRate { get { return 0.05; } }
    }
}