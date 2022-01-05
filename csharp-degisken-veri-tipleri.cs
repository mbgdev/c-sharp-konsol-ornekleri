using System;

namespace Degisken_VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {

            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            int a = 0;
            string b = a.ToString();
            string c = "36";
            int d = int.Parse(c);





            Console.WriteLine("integer bir deðer:" + myNum);
            Console.WriteLine();

            Console.WriteLine("double bir deðer:" + myDoubleNum);
            Console.WriteLine();

            Console.WriteLine("character bir deðer:" + myLetter);
            Console.WriteLine();

            Console.WriteLine("boolen bir deðer:" + myBool);
            Console.WriteLine();

            Console.WriteLine("string bir deðer:" + myText);
            Console.WriteLine();

            Console.WriteLine("integer bir deðer:" + a);
            Console.WriteLine();

            Console.WriteLine("integer bir deðer string dönüþtü:" + b);
            Console.WriteLine();

            Console.WriteLine("string bir deðer:" + c);
            Console.WriteLine();

            Console.WriteLine("string bir deðer integr dönþtü:" + d);




        }
    }
}