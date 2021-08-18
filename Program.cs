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
            int age = Console.ReadLine();

            Console.WriteLine("Nice to meet you " + use + "and you look way younger than " +age);
            
        }
    }
}
