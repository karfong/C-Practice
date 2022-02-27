/*Use the array elements / values to do multiplication*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT207NWeek7_Chapter7Arrays
{
    class ArrayAsParameter
    {
        static void Main3(string[] args)
        {
            int[] array = {5, 6, 7};//array with values initialized

            //call function
            /*TAKE NOTE: 1) Do not put the array size
             *           2) Do not put the square bracket
             */          
            int output = MultiplyFirstElement(array);

            Console.Write("The First Element Multiplication: {0}", output);

            Console.ReadLine();
        }

        //method/ function to pass in array as argument
        static int MultiplyFirstElement(int[] arr)
        {
            return arr[0] * 2;
        }

     }
}
