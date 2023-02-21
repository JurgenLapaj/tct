using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_._net
{
    internal class Person
    {
        //private
        private string _name;
        private int age;
        private string surname;
        //protected
        protected  int AgePublic;
            protected string NamePublic;
            protected string SurnamePublic;


        //public

        public string NamePublic;
        public string SurnamePublic;
        public int AgePublic;

        public string NamePublic { get; set; }
    }
}
