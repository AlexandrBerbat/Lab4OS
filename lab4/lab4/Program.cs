using System;
using System.Diagnostics;

namespace lab4
{
    
        class Program
        {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // 1.
            const int SIZE = 50;
            int[,] planner = Matrix.createMatrix(SIZE);

            Matrix.printMat(planner, SIZE);

            //1.1
            Matrix.sortMat(planner, SIZE);

            Console.WriteLine("SORTED");

            Matrix.printMat(planner, SIZE);

            int allIter = 0;

            for (int q = SIZE; q > 0; q--)
            {
                //2
                int[] minValues = new int[q];

                for (int i = 0; i < q; i++)
                {
                    minValues[i] = planner[0, i];
                }
                Console.WriteLine();
                Console.WriteLine("Finding the minimum 10 in the pool: ");

                MyArray.printMyArray(minValues, q);

                //3.
                allIter += MyArray.findElemEqualOne(minValues);

                //4
                planner = Matrix.modifyMatrix(planner, q);

                Console.WriteLine();
                
                Matrix.printMat(planner, q - 1);

            }

            
            Console.WriteLine("All iterations sum: ");
            Console.WriteLine(allIter);

            
            Console.WriteLine("All iterations Average: ");
            Console.WriteLine(Convert.ToDouble(allIter) / SIZE);


            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.WriteLine("Average Runtime:");
            double averageRuntime = (ts.Minutes*60000+ ts.Seconds*1000 + ts.Milliseconds) / SIZE;
            Console.WriteLine(averageRuntime + " ms");
        }
        }
    
}
