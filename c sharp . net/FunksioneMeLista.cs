using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_._net
{
    internal abstract class FunksioneMeLista
    {
        private static readonly string germatToNumber;

        public int GjejMeTeMadhinNeListe(List<int> lista)
        {

            return lista.Max();


        }

        public int GjejShumenEListes(List<int> lista)
        {

            return lista.Sum();

        }


        /// <summary>
        /// Pret nje list me integer
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>kthen numrin me te madh cift</returns>
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


        public static List<int> ListOfMultiples(int number, int length)
        {

            List<int> lista = new List<int>();


            for (int i = 1; i <= length; i++)
            {
                lista.Add(number * i);
            }

                return lista;
        }


        public static List<int> IndexOfCapitals(string fjala)
        {
            List<int> indekset = new List<int>();

            for(int i = 0; i < fjala.Length; i++)
            {
               if (char.IsUpper(fjala[i]))
                {
                    indekset.Add(i);
                }
            }

            return indekset;

        }

        public static string returnNumberToLeter(string fjala)
        {
            List<char> germat = new List<char>();

            foreach(char a in fjala)
            {
                if (char.IsLetter(a))
                {
                    germat.Add(a);
                }
            }
          return germat.ToString();

        }




    }


}




