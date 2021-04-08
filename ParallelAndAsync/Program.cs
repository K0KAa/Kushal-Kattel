using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ParallelAndAsync
{
    class Program
    {
        static void Main()
        {
            //MultiThreadig
            //Thread thread = new Thread();

            //TPL - Task Parallel Library
            //Task task = new Task();
            int[] numbers = {23,34,564,23,56,54,890,0,1,2};
            Stopwatch stopwatch = new Stopwatch();
            //Sequential
            stopwatch.Start();
            foreach(int num in numbers)
            {
                Compute(num);
            }
            Console.WriteLine($"The time taken(Sequential) : {stopwatch.ElapsedMilliseconds} ms");

            //Parallel
            stopwatch.Restart();
            Parallel.ForEach(numbers , num => {
                Compute(num);
            });
            Console.WriteLine($"The time taken(Parallel) : {stopwatch.ElapsedMilliseconds} ms");

        }

        static void Compute(int x)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Computed for {x}");
        }
    }
}
