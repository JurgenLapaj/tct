using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_._net.Models
{
    internal class Dog : Animals
    {
        public Dog(bool doesBite, string name, string ngjyra, string lloji, int numriIKembeve) : base(name, ngjyra, lloji, numriIKembeve)
        {
            DoesBite = doesBite;
        }
     public bool DoesBite { get; set; }
        


    }
}
