using System;

namespace RomaCarpmaMetodu
{
    class Program
    {


        static void Main(string[] args)
        {
            int sayi1 = 0, sayi2 = 0, Sonuc = 0, sayac = 1;
            Console.Write("�lk say�y� giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("�kinci say�y� giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (sayi1 != 1)
            {

                if (sayi1 % 2 != 0)
                {
                    Sonuc = sayi2 + Sonuc;
                    Console.WriteLine(sayac + " Ad�m Say�1 de�eri " + sayi1 + " Say�2 de�eri " + sayi2 + " Tek say�-> Sonu�= " + Sonuc);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(sayac + " Ad�m Say�1 de�eri " + sayi1 + " Say�2 de�eri " + sayi2 + " �ift say�-> Sonu� de�i�mez -> " + Sonuc);
                    Console.WriteLine();
                }

                sayi1 = sayi1 / 2;
                sayi2 = sayi2 * 2;
                sayac += 1;
            }

            if (sayi1 % 2 != 0)
            {
                Sonuc = Sonuc + sayi2;
                Console.WriteLine(sayac + " Ad�m Say�1 de�eri " + sayi1 + " Say�2 de�eri " + sayi2 + " Tek say�-> Sonu�= " + Sonuc);
                Console.WriteLine();
            }


            Console.WriteLine("�arpma ��leminin Sonucu " + Sonuc);




        }
    }
}