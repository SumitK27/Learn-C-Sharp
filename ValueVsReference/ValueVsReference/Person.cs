using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReference
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} is {Age} years old";
        }
    }
}
