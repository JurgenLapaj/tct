using c_sharp_._net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_._net.Helpers
{
    internal abstract class PersonHelpers
    {
        /// <summary>
        /// Merr si imput Nje liste me persona 
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Personat e renditur sipas moshes emrit dhe mbiemrit</returns>
        public static List<Person> RenditPersonSipasMoshes(List<Person> persons)
        {
            return persons.OrderBy(a =>a.Age).ThenBy (a => a.Name).ThenBy(a => a.Surname).ToList();
        }

        /// <summary>
        /// Merr si imput nji list me persona
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Kthen moshen mesatare te personave</returns>
        public static double GjejMoshenMesatare(List<Person> persons)
        {
            return persons.Average(a => a.Age);
        }
    }
}
