using System;


    class IterationStatement 
    {
        static void Main3()
        {
            IterationStatement ii = new IterationStatement();
            ii.LearnForLoop();
            ii.LearnWhileLoop();
        }
        void LearnForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine("This is loop");
            }

        int[] numbers = new int[] {1,2,3,4,5,433,56,4};
            foreach (int x in numbers)
            {
                if(x%2 == 0)
                {
                    Console.WriteLine($"{x} It might be even");
                }
                else
                {
                    Console.WriteLine($"{x} is odd");
                }
            }
        }
    void LearnWhileLoop()
    {
        char confirm = 'Y';
        while(confirm == 'Y')
        {
            Console.WriteLine("Im beautiful");
            Console.WriteLine("Wanna Continue???");
            confirm = Console.ReadKey().KeyChar;
        }
        //DoWhile

        do
        {
            Console.WriteLine("Im beautiful");
            Console.WriteLine("Wanna Continue???");
            confirm = Console.ReadKey().KeyChar;
        }while(confirm == 'Y');
    }
   
    }
