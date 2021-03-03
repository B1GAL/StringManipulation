using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(quote);

            Console.WriteLine();

            Console.WriteLine("What word would you like to look for in the above sentence?");
            string searchFor = Console.ReadLine();

            Console.WriteLine("What word would you like to replace it with?");
            string ReplaceWord = Console.ReadLine();




            Console.WriteLine($"Sorry, I could not find the word {ReplaceWord}");
            
            






        }
    }
}
