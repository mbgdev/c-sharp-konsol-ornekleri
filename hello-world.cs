using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mesajýnýzý yazýnýz...");

            string mesaj = Console.ReadLine();

            Console.WriteLine("Hello World!");
            Console.WriteLine("Yazdýðýnýz Mesaj: " + mesaj);
        }
    }
}