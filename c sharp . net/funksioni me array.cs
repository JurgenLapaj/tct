using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_._net
{
    internal class funksioni_me_array_me_lista
    {

        public int GjejMeTeMadhin(int[] array)
        {

            int max = 0;
            
            foreach(int iteam in array) {
            
                if (iteam > max) max = iteam;
            
            }
         

            return max;
        }

        public int GjejShumenEArray(int[] array)
        {
            int sum = 0;

            foreach (int iteam in array)
            {
                if (!(iteam + sum))
                {
                    continue;
                }
                sum = iteam;
            }

            return sum;
        }

        public int GjejShumenENumrvaCift(int[] array)
        {
            int sum = 0;

            foreach (int iteam in array)
            {
                if (iteam % 2 == 0)
                {

                }
            }

            return sum;

        }



    }
}
