using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Example of a delegate funciton that wraps the UppercaseString method
            /// </summary>
            Console.WriteLine("What string would like like to make upper case");
            string name = Console.ReadLine();
            Func<string, string> convertMethod = UppercaseString;

            Console.WriteLine(convertMethod(name));

            string UppercaseString(string input)
            {
                return input.ToUpper();
            }

            //Lambda expressions
            int x;
            Console.WriteLine("Please enter the number you want squared: ");
            x = int.Parse(Console.ReadLine()); 
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(x));

            // Passing lambda expression as argument
            string[] words = { "the ", "quick ", "brown ", "fox ", "jumped ", "over ", "the ", "lazy ", "dogs " };
            foreach (string str in words)
            {
                Console.Write(str);
            }
            Console.WriteLine();
            Array.Sort(words, (str1, str2) => (str1.Length - str2.Length) == 0 ? str1.CompareTo(str2) : str2.Length - str1.Length);

            // lambda: (str1, str2) => (str1.Length - str2.Length) == 0 ? str1.CompareTo(str2) : str2.Length - str1.Length
            // sorts longer strings first, falls back to alphabetical

            foreach (string str in words)
            {
                Console.Write(str);
            }
        }

        //
    }
}
