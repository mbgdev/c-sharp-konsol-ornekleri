using System;

class MainClass
{

    public static string ConsonantCount(string str)
    {

        // code goes here
        string sezsiz = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
        sezsiz.ToLower();

        int sayac = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (sezsiz.Contains(str[i]))
            {
                sayac++;
            }

        }
        str = sayac.ToString();

        return str;

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(ConsonantCount(Console.ReadLine()));
    }

}