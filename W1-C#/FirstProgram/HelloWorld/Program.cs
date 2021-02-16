using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
            
            int[] numbers = {1,2,3,4,5};

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }


        }
    }
}
