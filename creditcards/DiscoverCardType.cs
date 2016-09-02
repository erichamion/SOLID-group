namespace creditcards
{
    public class DiscoverCardType : ICardType
    {
        public string Name
        {
            get { return "Discover"; }
        }
        public double InterestRate { get { return 0.01; } }
    }
}