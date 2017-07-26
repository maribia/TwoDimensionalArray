using System;

namespace TwoDimensionalArray
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int x = 10000;
            int y = 5000;

            long xyTime, yxTime;
            

            int[,] array = new int[x, y];
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    array[i, j] = 1;
                }
            }
            watch.Stop();
            xyTime = watch.ElapsedMilliseconds;

            watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = 1;
                }
            }
            watch.Stop();
            yxTime = watch.ElapsedMilliseconds;

            Console.WriteLine("xy = {0}ms, yx = {1}ms", xyTime, yxTime);

        }


    }
}
