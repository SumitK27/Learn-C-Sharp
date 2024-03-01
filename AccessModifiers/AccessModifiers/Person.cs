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
        
        // Propertie are used to access private fields from outside of the class.
        public DateTime BirthDate {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        // Creates private field internally
        // Can be checked by navigating to Project Directory -> bin -> Debug -> net8.0 -> `ildasm AccessModifiers.dll`
        public string Place { get; set; }

        // Make gender only set once and not changeable
        public string gender { get; private set; }

        public Person(string gender)
        {
            this.gender = gender;
        }

        // Calculated Property
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - this._birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

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
    }
}
