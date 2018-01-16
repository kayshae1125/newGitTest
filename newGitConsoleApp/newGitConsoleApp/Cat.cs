using System;
namespace newGitConsoleApp
{
    class Cat
    { 
        public string Name = string.Empty;
        public int Age = 0; 
        public void Hiss()
        {
            Console.WriteLine("Hiss"); 
        }
        
        public static void Meow()
        {
            Console.WriteLine("Meow.");
        }

        public int GetAge()

        {
            return Age;
        }
    }
}
