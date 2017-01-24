using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._09.SubsetsWihtSumZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is for counting how many subsets of a given set of \r\nnumbers have sum equal to zero.");
            Console.Write("Enter how long the set must be. N = ");

            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            for (int currentEl = 0; currentEl < myArray.Length; currentEl++)
            {
                myArray[currentEl] = int.Parse(Console.ReadLine());
            }
            // We have to sum every possible combination numbers in the array (every subset). 
            // So we sum or we don't sum any given number.Two choices.
            // That makes 2 to the power of the numbers in the array possibilities.

            double possibilities = Math.Pow(2, n);
            int zeroSums = 0;

            for (int currentPoss = 1; currentPoss < possibilities; currentPoss++)
            {
                int[] arrayForCalc = new int[myArray.Length];
                for (int p = 0; p < myArray.Length; p++)
                {
                    arrayForCalc[p] = myArray[p];
                }

                // Whether we sum or not sum is (true or false) a number can 
                // be represented whit 1's and 0's.
                // Every possibilitie of 1's and 0's is the bitwise representation 
                // of the var "currentPoss" so we place it in an array.

                int[] bitwiseI = new int[myArray.Length];
                for (int j = 0; j < myArray.Length; j++)
                {
                    bitwiseI[j] = 1 & (currentPoss >> j); 
                }
                // We multiply the two arrays so we can get only the numbers we want to sum.
                for (int h = 0; h < myArray.Length; h++)
                {
                    arrayForCalc[h] *= bitwiseI[h];
                }
                int sum = 0;
                for (int k = 0; k < myArray.Length; k++)
                {
                    sum += arrayForCalc[k];
                }
                if (sum == 0)
                {
                    zeroSums++;
                }

            }
            Console.WriteLine("The number of subsets that have sum zero is {0}." , zeroSums);
        }
    }
}
