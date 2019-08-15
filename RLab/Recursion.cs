using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLab
{
    class Recursion
    {
        private static int ARR_SIZE = 10;
        private static int MIN_ARR_VAL = -100;
        private static int MAX_ARR_VAL = 100;
        private static Random rand = new Random();
        private static int[] arr;

        static void Main(string[] args)
        {
            int depth = 0;
            arr = new int[ARR_SIZE];

            for (int i = 0; i < ARR_SIZE; i++)
            {
                arr[i] = rand.Next(MIN_ARR_VAL, MAX_ARR_VAL);
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
            RecursionFunc(depth);
            Console.ReadKey();
        }

        private static void RecursionFunc(int depth)
        {
            if (depth < arr.Length)
            {
                if (arr[depth] < 0)
                {
                    Console.Write("{0} ", arr[depth]);
                }
                RecursionFunc(depth + 1);
                if (arr[depth] > 0)
                {
                    Console.Write("{0} ", arr[depth]);
                }
            }
        }
    }
}
