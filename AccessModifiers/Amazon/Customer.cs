namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //var rating = CalculateRating(excludeOrders: true);
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");
            }
            else
            {
                Console.WriteLine("Promoted to Level 2");
            }

        }

        // This method is only accessible within the Customer class
        // Avoid using protected unless you are creating a class that is meant to be inherited from
        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
