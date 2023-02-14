using System;
using System.Collections.Generic;
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
            
            for(int i = 0 ; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }




            return max;
        }

        public int GjejShumenEArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            return sum;
        }

        public int GjejShumenENumrvaCift(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum = sum + array[i];
                }

            }

            return sum;

        }



    }
}
