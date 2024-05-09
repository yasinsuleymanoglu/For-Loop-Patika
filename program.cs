static void  Main()
{
  // Döngüler
    #region For Loop ve Break Continue Ifadeleri

    //ekrandan girilen sayıya kadar tek sayıları ekrana yazdır.
    Console.WriteLine("Bir sayı giriniz:");
    int sayi  = int.Parse(Console.ReadLine());
    for (int i = 1;i <= sayi; i++)
    {
        if(i%2!=0)
        {
            Console.WriteLine(i);
               
        }
            
    }
    int tektop = 0;
    int çifttop = 0;
    for(int i =1; i<=1000;i++)
    {
        if (i % 2 != 0)
        {
            tektop += i;

        }
        else
           çifttop += i;
       

    }
    Console.WriteLine(tektop);
    Console.WriteLine(çifttop);
    // break , continue

    // break for döngüsünde if içindeki işlem sağlandığı anda işlemi sonlandırır
    // continue da da işlem if içindeki yere gelince atlar ve çalışmaya devam eder.
