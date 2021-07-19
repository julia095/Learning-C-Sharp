using System;

namespace ConsoleApp
{
    class Characters
    {
       static string Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your favorite word?");
            string favoriteWord;
            string newString;
            favoriteWord = Console.ReadLine();
            if (favoriteWord.EndsWith("e"))
            {
                newString = "success";
            } else
            {
                newString = "fail";
            }
            return newString;
        }
    }
}
