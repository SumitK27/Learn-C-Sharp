using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Person
    {
        // Encapsulation
        // private fields are not accessible outside of the class they are declared in.
        private string _name;
        private DateTime _birthdate;

        public void SetName(string name)
        {
            if(!string.IsNullOrWhiteSpace(name))
            {
                this._name = name;
            }
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return this._birthdate;
        }
    }
}
