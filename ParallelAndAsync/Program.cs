using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ParallelAndAsync
{
    class Program
    {
        static void Main1()
        {
            //MultiThreadig
            //Thread thread = new Thread();

            //TPL - Task Parallel Library
            //Task task = new Task();
            int[] numbers = { 23, 34, 564, 23, 56, 54, 890, 0, 1, 2 };
            Stopwatch stopwatch = new Stopwatch();
            //Sequential
            stopwatch.Start();
            foreach (int num in numbers)
            {
                Compute(num);
            }
            Console.WriteLine($"The time taken(Sequential) : {stopwatch.ElapsedMilliseconds} ms");

            //Parallel
            stopwatch.Restart();
            Parallel.ForEach(numbers, num =>
            {
                Compute(num);
            });
            Console.WriteLine($"The time taken(Parallel) : {stopwatch.ElapsedMilliseconds} ms");

        }

        static void Compute(int x)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Computed for {x}");
        }

        static void Main2()
        {
            //Example: Making Breakfast
            //Making Tea
            //-Trun on Burner 2s
            //-Put on kettle 1s
            //-Add water 2s
            //-Boil it 3min
            //-Grid teas masala 10s
            //-Add sugar and masalas 2s
            // -Add milk 2s
            //Boil it 2min

            //Fry eggs
            //Trun on burner 2s
            //Put on pan 1s
            //Add oil 2s
            //Crack eggs and stir it 2min
            //fry it 1min

            //Everything ready serve it

            //Sequential 
            TrunOnBurner();
            Console.WriteLine("Burner truned on");

            PutOn("Kettle");
            Console.WriteLine("Put Kettle on the burner");

            Add("Water");
            Console.WriteLine("Water added");

            Boil("Water");
            Console.WriteLine("Water Boiled");
            GridTeaMasala();
            Console.WriteLine("Masala grinded");
            Add("Masala");
            Console.WriteLine("Masala added");
            Add("Sugar");
            Console.WriteLine("Sugar added");
            Add("Milk");
            Console.WriteLine("Milk added");
            Boil("Milk");
            Console.WriteLine("Milk boiled");

            TrunOnBurner();
            Console.WriteLine("Burner truned on");

            PutOn("Pan");
            Console.WriteLine("Pan is on burner");
            Add("Oil");
            Console.WriteLine("Oil added");
            CrackAndStirr();
            Console.WriteLine("Eggs cracked and stirred");

            FryEggs();
            Console.WriteLine("Fried eggs");
            Serve();
            Console.WriteLine("Served");
        }

        static async Task Main()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            var trunOnBurner1 = TrunOnBurner();
            var putKettle = PutOn("Kettle");
            var addWater = Add("Water");
            var boilWater = Boil("Water");
            var gridMasala = GridTeaMasala();
            var addMasala = Add("Masala");
            var addSugar = Add("Sugar");
            var addMilk = Add("Milk");
            var boilMilk = Boil("Milk");
            var trunOnBurner2 = TrunOnBurner();
            var putPan = PutOn("Pan");
            var addOil = Add("Oil");
            var crackAndStirr = CrackAndStirr();
            var fryEggs = FryEggs();
            var serve = Serve();


            await trunOnBurner1;
            Console.WriteLine("Burner truned on");

            await putKettle;
            Console.WriteLine("Put Kettle on the burner");

            await addWater;
            Console.WriteLine("Water added");

            await boilWater;
            Console.WriteLine("Water Boiled");
            await gridMasala;
            Console.WriteLine("Masala grinded");

            await addMasala;
            Console.WriteLine("Masala added");

            await addSugar;
            Console.WriteLine("Sugar added");
            await addMilk;
            Console.WriteLine("Milk added");
            await boilMilk;
            Console.WriteLine("Milk boiled");

            await trunOnBurner2;
            Console.WriteLine("Burner truned on");

            await putPan;
            Console.WriteLine("Pan is on burner");

            await addOil;
            Console.WriteLine("Oil added");

            await crackAndStirr;
            Console.WriteLine("Eggs cracked and stirred");

            await fryEggs;
            Console.WriteLine("Fried eggs");

            await serve;
            Console.WriteLine("Served");

            Console.WriteLine($"The time taken(Parallel) : {sw.ElapsedMilliseconds} ms");

        }
        private static async Task GridTeaMasala()
        {
            await Task.Delay(2000);
        }
        private static async Task TrunOnBurner()
        {
            await Task.Delay(2000);
        }
        private static async Task PutOn(string pot)
        {
            await Task.Delay(2000);
        }
        private static async Task Add(string item)
        {
            await Task.Delay(1000);
        }

        private static async Task Boil(string item)
        {
            await Task.Delay(2000);
        }

        private static async Task CrackAndStirr()
        {
            await Task.Delay(2000);
        }
        private static async Task FryEggs()
        {
            await Task.Delay(2000);
        }

        private static async Task Serve()
        {
            await Task.Delay(10000);
        }
    }
}
