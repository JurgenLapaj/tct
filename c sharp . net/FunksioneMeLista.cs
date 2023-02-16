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

            return lista.Where(a => a % 2 == 0).Sum();

        }


        public List<string> KonvertoUppercase(List<string> lista)
        {
            return lista.Select(a => a.ToUpper()).ToList();
        }

        public int KtheSHumenENumraveNegativ(List<int> lista) {
        
        
        return lista.Where(a => a < 0).ToList().Sum();
        
        }

        public List<int> KtheNumratPozitivCift(List<int> lista)
        {
            int a = 10;

            if (a > 0 && a % 2 == 0)
            {
            }

            return lista.Where(a => a > 0 && a % 2 == 0).ToList();
        }


    }


}




