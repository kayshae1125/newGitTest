using System;

namespace newGitConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            var username = Console.ReadLine(); 
            Console.WriteLine("Nice to meet you, " + username + "!");
            Console.WriteLine("New Line.. what happens now?");
            Console.WriteLine("Let's add another row"); 
            Console.ReadKey(); 
        }
    }
}
