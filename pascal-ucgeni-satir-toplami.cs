using System;

namespace ConsoleApp1
{
    class Program
    {

        public static double Numara(int arr)
        {
            double x = 1, toplam, y = 1;

            toplam = Math.Pow((x + y), arr);




            return toplam;
        }


        static void Main(string[] args)
        {
            string myNum = Console.ReadLine();


            double deger = Numara(Int32.Parse(myNum));

            {
                Console.WriteLine(deger);


            }
        }
    }
}