using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Array;
using System.Collections;

namespace ConsoleApp189
{
    class Program
    {
        private static int[] intValues = { 1, 2, 3, 4, 5, 6 };
        private static double[] doubleValues = { 8.4, 9.3, 0.2, 7.9, 3.4 };
        private static int[] intValuesCopy;
        static void Main(string[] args)
        {
            intValuesCopy = new int[intValues.Length];

            Console.WriteLine("Initial array values:\n");

            PrintArray();

            Sort(doubleValues);

            Array.Copy(intValues, intValuesCopy, intValues.Length);
        }
    }
    }

