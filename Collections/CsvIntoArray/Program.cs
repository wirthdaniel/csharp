using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvIntoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calling methods with a 'params' parameter
            ParamsTest('a');
            ParamsTest('a', 'b', 'c');
            ParamsTest(new char[] { 'a', 'b' });

            ParamsTest2(2);
            ParamsTest2(2, 3);
            ParamsTest2(new int[] { 1, 2, 3, 4 });
            #endregion

            string filePath = "path";

            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);
        }

        #region Methods with 'params' parameter
        //By using the params keyword, you can specify a method parameter that takes a variable number of arguments. 
        //The parameter type must be a single-dimensional array.
        public static void ParamsTest(params char[] args)
        {
            ;
        }

        public static void ParamsTest2(params int[] args)
        {
            ;
        }
        #endregion
    }
}
