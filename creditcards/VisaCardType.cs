namespace creditcards
{
    public class VisaCardType : ICardType
    {
        public string Name
        {
            get { return "Visa"; }
        }
        public double InterestRate { get { return 0.10; } }
    }
}
