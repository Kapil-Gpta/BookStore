namespace BookStore
{
    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public abstract double GetPrice();
    }

    /* Open closed principle: genres will be derived from class Book */ 
    public class Crime : Book
    {
        private const double Discount = .05;
        public override double GetPrice()
        {
            return Price * (1- Discount);
        }
    }

    public class Fantasy : Book
    {
        public override double GetPrice()
        {
            return Price;
        }
    }

    public class Romance : Book
    {
        public override double GetPrice()
        {
            return Price;
        }
    }
}