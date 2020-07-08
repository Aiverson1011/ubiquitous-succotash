using System;

namespace MyTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetCat();
        }

        static void GetCat()
        {
            Console.WriteLine("THis is my Cat!");
            GetDog();
        }

        static void GetDog()
        {
            Console.WriteLine("This is my dog");
        }
    }
}
