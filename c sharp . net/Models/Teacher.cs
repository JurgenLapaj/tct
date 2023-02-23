using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_._net.Models
{
    internal class Teacher : Person
    {
        public Teacher(string teachingSubject, string name, string surname, string address, string phone,string city, int age) : base(name,  surname,  address,  city, phone, age)
        {
            TeachingSubject = teachingSubject;
        }

        public string TeachingSubject { get; set; } 


    }
}
