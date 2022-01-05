using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aritmetik operatorler");

            int x = 5;
            int y = 6;
            int sonuc = 0;
            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y);
            Console.WriteLine();

            Console.WriteLine(sonuc);
            Console.WriteLine();

            //toplama
            sonuc = x + y;
            Console.WriteLine("toplam:" + sonuc);
            Console.WriteLine();
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            //Çýkarma
            sonuc = x - y;
            Console.WriteLine("Çýkarma:" + sonuc);
            Console.WriteLine();
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            sonuc = y - x;
            Console.WriteLine("Çýkarma:" + sonuc);
            Console.WriteLine(); Console.WriteLine("**********************************************");
            Console.WriteLine();

            //Çarpma
            sonuc = x * y;
            Console.WriteLine("Çarpma:" + sonuc);
            Console.WriteLine(); Console.WriteLine("**********************************************");
            Console.WriteLine();

            //Bölme

            Console.WriteLine("Bölme");

            int a = 12;
            int b = 3;
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + y);
            sonuc = a / b;
            Console.WriteLine("Bölme:" + sonuc);
            Console.WriteLine();

            Console.WriteLine("**********************************************");
            Console.WriteLine();

            Console.WriteLine("C# Atama Operatörleri");

            int w = 5;
            Console.WriteLine("int w = 5:> " + w);
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            w += 3;
            Console.WriteLine("w += 3:> " + w);
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            w -= 3;
            Console.WriteLine("w -= 3:> " + w);
            Console.WriteLine("**********************************************");
            Console.WriteLine();


            w *= 3;
            Console.WriteLine("w *= 3:> " + w);
            Console.WriteLine("**********************************************");
            Console.WriteLine();


            w /= 3;
            Console.WriteLine("w /= 3:> " + w);
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            w %= 3;
            Console.WriteLine("w %= 3:> " + w);
            Console.WriteLine("**********************************************");
            Console.WriteLine();


            w &= 3;
            Console.WriteLine("w &= 3:> " + w);
            Console.WriteLine("**********************************************");
            Console.WriteLine();


            w |= 3;
            Console.WriteLine("w |= 3:> " + w);
            Console.WriteLine("**********************************************");
            Console.WriteLine();


            w ^= 3;
            Console.WriteLine("w ^= 3:> " + w);
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            w >>= 3;
            Console.WriteLine("w >>= 3:> " + w);
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            w <<= 3;
            Console.WriteLine("w <<= 3:> " + w);
            Console.WriteLine();


            Console.WriteLine("**********************************************");
            Console.WriteLine();




            Console.WriteLine("C# Karþýlaþtýrma Operatörleri");
            Console.WriteLine();

            int l = 5;
            int t = 3;
            Console.WriteLine("l:" + l);
            Console.WriteLine("t" + t);
            Console.WriteLine();

            Console.WriteLine("l <= t  " + (l <= t));




            Console.WriteLine("l >= t  " + (l >= t));
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            Console.WriteLine("l < t  " + (l < t));
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            Console.WriteLine("l > t  " + (l > t));
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            Console.WriteLine("l != t  " + (l != t));
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            Console.WriteLine("l == t  " + (l == t));
            Console.WriteLine("**********************************************");
            Console.WriteLine();



            Console.WriteLine("C# Mantýksal Operatörler");

            Console.WriteLine();


            int p = 5;
            Console.WriteLine("p:" + p);
            Console.WriteLine();

            Console.WriteLine("p > 3 && p< 10 " + (p > 3 && p < 10));
            Console.WriteLine("**********************************************");
            Console.WriteLine();


            Console.WriteLine("p > 3 || p< 10 " + (p > 3 || p < 10));
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            Console.WriteLine("p > 3 && p< 10 " + (!(p > 3 && p < 10)));
            Console.WriteLine("**********************************************");
            Console.WriteLine();




        }
    }
}