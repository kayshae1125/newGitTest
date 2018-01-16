using System;

namespace newGitConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            //User interacts with console by inputting information and pressing enter.  
            var username = Console.ReadLine(); 
            Console.WriteLine("Nice to meet you, " + username + "!");
            //Here comes the cat 
            Cat cCat = new Cat();
            cCat.Hiss();
            Cat.Meow();
            cCat.Age = 10; 
            Console.WriteLine(cCat.GetAge());  
            Console.Read(); 
        }
    }  
}
