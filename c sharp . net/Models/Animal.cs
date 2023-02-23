using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_._net.Models
{
    internal class Animals
    {
        public Animals()
        {
        }

        public Animals(string name,string ngjyra, string lloji, int numriIKembeve)
        {
            Name = name;
            Ngjyra = ngjyra;
            Lloji = lloji;
            NumriIKembeve = numriIKembeve;
        }

        public string Name { get; set; }
        public string Ngjyra { get; set; }
        public string Lloji { get; set;}
        public int NumriIKembeve { get; set; }




    }
}
