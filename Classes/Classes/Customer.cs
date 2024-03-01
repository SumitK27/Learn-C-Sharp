using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            this.Id = 0;
            Orders = new List<Order>();
        }

        // Overloading constructors
        // : this() calls the default constructor
        public Customer(string name): this()
        {
            this.Name = name;
        }

        // : this(name) calls the constructor with one parameter which calls the default constructor
        // Note: This is not a good practice and makes the code harder to read and maintain
        public Customer(int id, string name): this(name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
