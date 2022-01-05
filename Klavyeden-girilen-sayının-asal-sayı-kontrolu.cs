using System;

class MainClass
{

    public static int PrimeTime(int num)
    {


        // code goes here  
        for (int i = 2; i < num; i++)
            if (num % i == 0)
            {
                return 0;
            }


        return 1;


    }

    static void Main()
    {
        int sonuc = (PrimeTime(int.Parse(Console.ReadLine())));
        if (sonuc == 0)
            Console.WriteLine(false);
        else
            Console.WriteLine(true);


    }

}


