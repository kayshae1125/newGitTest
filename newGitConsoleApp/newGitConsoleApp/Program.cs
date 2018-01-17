using System;

namespace newGitConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            //Introduction
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
            
            bool Happy = true;
            
            if (Happy == true) 
            {
                Console.WriteLine("I am happy!"); 
            }
            else 
            {
                Console.WriteLine("I am NOT happy."); 
            }
            if (Happy) Console.WriteLine("I'm reallyyy happy....");

            //Using switches

            int Age = 43;
            
            switch(Age)
            {
                case 0:
                   Console.WriteLine("You haven't been born yet."); 
                   break;
                case 5:
                    Console.WriteLine("You are too young to go to school."); 
                    break;
                    
               case 10:
                    Console.WriteLine("You are at the correct age.");
                    break;
                    
               default: 
                    Console.WriteLine("I don't know.");
                    break;                 
            }     
        }
    }  
}
