using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Interface:
             *  Used to build a loosely coupled application.
             *  Does not contain any implementation.
             */

            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
