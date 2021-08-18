using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            string use = Console.ReadLine();
            Console.WriteLine("And what is your age?");
            string use2 = Console.ReadLine();
            int age = Convert.ToInt32(use2);

            Console.WriteLine("Nice to meet you " + use + "and you look way younger than " +age);
            
        }
    }
}
