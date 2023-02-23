using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_._net.Models
{
    internal abstract class Person
    {
        public Person(string name, string surname, string address, string city, string phones, int age)
        {
            Name = name;
            Surname = surname;
            Address = address;
            City = city;
            this.phones = phones;
            Age = age;
        }

        public Person()
        {

        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string phones { get; set; }
        public int Age { get; set; }




    }
}
