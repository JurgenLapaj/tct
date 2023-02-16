using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_._net
{
    internal class FunksioneMeLista
    {

        public int GjejMeTeMadhinNeListe(List<int> lista)
        {

            return lista.Max();


        }

        public int GjejShumenEListes(List<int> lista)
        {

            return lista.Sum();

        }


        public int GjejShumenENumrvaCiftNeListe(List<int> lista)
        {

            return lista.where(a=> a % 2 == 0).Sum();

        }
    }
}