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





            Console.WriteLine("integer bir de�er:" + myNum);
            Console.WriteLine();

            Console.WriteLine("double bir de�er:" + myDoubleNum);
            Console.WriteLine();

            Console.WriteLine("character bir de�er:" + myLetter);
            Console.WriteLine();

            Console.WriteLine("boolen bir de�er:" + myBool);
            Console.WriteLine();

            Console.WriteLine("string bir de�er:" + myText);
            Console.WriteLine();

            Console.WriteLine("integer bir de�er:" + a);
            Console.WriteLine();

            Console.WriteLine("integer bir de�er string d�n��t�:" + b);
            Console.WriteLine();

            Console.WriteLine("string bir de�er:" + c);
            Console.WriteLine();

            Console.WriteLine("string bir de�er integr d�n�t�:" + d);




        }
    }
}