using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(s1);

            Console.WriteLine();

            Console.WriteLine("What word would you like to look for in the sentence?");
            string searchFor = Console.ReadLine();

            Console.WriteLine($"What word would you like to replace {searchFor} with?");
            string newWord = Console.ReadLine();

            bool X = s1.Contains(searchFor);
            if (X)
            {
                Console.WriteLine(s1.Replace(searchFor, newWord));
            }
                 else
                 {
                      Console.WriteLine($"Sorry, I could not find the word {searchFor}.");

                    for (int i = searchFor.Length-1; i >= 0; i--)
                     {
                         Console.WriteLine($"{searchFor[i]}");
                     }


                 }
                       
            
        

           
            
            //bool b = s1.Contains(searchFor);
            //Console.WriteLine(b);

            //string newWord = "create";
            //newWord.Replace(oldWord);
           




            
            
            
            





        }
    }
}
