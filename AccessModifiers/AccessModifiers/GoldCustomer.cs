// Import the Amazon namespace to use the Customer class
using Amazon;

namespace AccessModifiers
{
    public class GoldCustomer: Customer
    {
        public void OfferVoucher()
        {
            this.CalculateRating(excludeOrders: true);
        }
    }
}
