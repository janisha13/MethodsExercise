using System;

namespace Methodsexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?");
            String name = Console.ReadLine();
            Console.Write("What is your favorite color?");
            String color = Console.ReadLine();
            Console.Write("What is your favoite animal?");
            String animal = Console.ReadLine();

            Console.WriteLine($"Hi, {name}, {color} is a great choice. Can you draw a picture of a {animal}, by chance? ");
            Console.ReadLine();
        }
    }
}
