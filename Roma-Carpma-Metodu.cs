using System;

namespace RomaCarpmaMetodu
{
    class Program
    {


        static void Main(string[] args)
        {
            int sayi1 = 0, sayi2 = 0, Sonuc = 0, sayac = 1;
            Console.Write("Ýlk sayýyý giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ýkinci sayýyý giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (sayi1 != 1)
            {

                if (sayi1 % 2 != 0)
                {
                    Sonuc = sayi2 + Sonuc;
                    Console.WriteLine(sayac + " Adým Sayý1 deðeri " + sayi1 + " Sayý2 deðeri " + sayi2 + " Tek sayý-> Sonuç= " + Sonuc);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(sayac + " Adým Sayý1 deðeri " + sayi1 + " Sayý2 deðeri " + sayi2 + " Çift sayý-> Sonuç deðiþmez -> " + Sonuc);
                    Console.WriteLine();
                }

                sayi1 = sayi1 / 2;
                sayi2 = sayi2 * 2;
                sayac += 1;
            }

            if (sayi1 % 2 != 0)
            {
                Sonuc = Sonuc + sayi2;
                Console.WriteLine(sayac + " Adým Sayý1 deðeri " + sayi1 + " Sayý2 deðeri " + sayi2 + " Tek sayý-> Sonuç= " + Sonuc);
                Console.WriteLine();
            }


            Console.WriteLine("Çarpma Ýþleminin Sonucu " + Sonuc);




        }
    }
}