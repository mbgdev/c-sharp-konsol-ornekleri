using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mesaj�n�z� yaz�n�z...");

            string mesaj = Console.ReadLine();

            Console.WriteLine("Hello World!");
            Console.WriteLine("Yazd���n�z Mesaj: " + mesaj);
        }
    }
}