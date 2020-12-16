using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class MyArray
    {


        public static void printMyArray(int[] arr, int n)
        {
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                
            }
            Console.WriteLine();
        }

        public static int findElemEqualOne(int[] arr)
        {

            int buffer = 0;
            int counter = 0;

            while (arr[0] != 1)
            {

                arr[0]--;
                counter++;
            }

            if (arr[0] == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Got it!!!");
                buffer = arr[0];

                Console.WriteLine(buffer);
                Console.WriteLine();
                Console.WriteLine("Number of iterations:");
                Console.WriteLine(counter);
            }


            return counter;
        }

    }
}
