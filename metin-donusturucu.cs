class Result
{

        //Soru    Metin dönüştürücü 
        //kelime 4 karakterden küçükse bir küçük bir büyük karakter
        //kelime 3 ile 7 arasında ise karakterler küçük 
        //kelime 7 ve üzeri karakterler büyük
    public static string donustur(string kelimeGrubu)
    {
        int ku = 0;
        
        char[] str = kelimeGrubu.ToArray();

        for (int j = 0; j < str.Length; j++)
        {


            if (str[j] == ',')
            {

                if (ku < 4)
                {
                    int bk = 0;

                    for (int i = j-ku; i < j;i++ )
                        {
                       

                            if (bk % 2 == 0 && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                            {
                                string a = str[i].ToString().ToLower();

                                char[] b = a.ToCharArray();
                                str[i] = b[0];
                            bk++;
                            

                            }
                            else if (str[i] != '0' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                            {
                                string a = str[i].ToString().ToUpper();

                                char[] b = a.ToCharArray();
                                str[i] = b[0];
                            bk++;
                          
                            }
                        }
                    
                   
                 
                  
                    ku = 0;
                }

            
                if (ku > 3 && ku < 7)
                {
                    
                    for (int i = j - ku; i < j; i++)
                    {
                        if (str[i] != '0' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                        {
                            string a = str[i].ToString().ToLower();

                            char[] b = a.ToCharArray();
                            str[i] = b[0];
                        }

                    }
                    ku = 0;

                }

                if(ku >=7)
                {
                    for (int i = j - ku; i < j; i++)
                    {
                        if (str[i] != '0' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                        {
                            string a = str[i].ToString().ToLower();

                            char[] b = a.ToCharArray();
                            str[i] = b[0];
                        }

                    }
                    ku = 0;
                }



            }
            else
                ku++;



        }












        String s = new String(str);

        return s;
    }



    public static void Main(string[] args)
    {
        while (true)
        {
            string kelimeGrubu = Console.ReadLine();

            Console.WriteLine(donustur(kelimeGrubu));
        }

       


    }
}
