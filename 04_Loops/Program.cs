using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
  internal class Program
  {
    static void Main(string[] args)
    {

      #region For Döngüsü

      //int i;
      //for (i = 1; i <= 5; i++)
      //{
      //  Console.WriteLine("C# EĞİTİM KAMPI");
      //}
      //--------------------------------

      //for (int i = 1; i <= 20; i++)
      //{
      //  Console.WriteLine(i);
      //}

      //--------------------------------

      //for(int i = 3; i <= 50; i += 3)    // döngü 3 te başlasın 50 den küçük eşitse bitsin ve 3 er artsın
      //{
      //  Console.WriteLine(i);
      //}

      //--------------------------------

      //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
      //int finishValue=int.Parse(Console.ReadLine());

      //for(int i=1; i<=finishValue; i++)
      //{
      //  Console.WriteLine("Yaşasın Cumhuriyet");
      //}

      #endregion

      #region For döngüsü ile karar yapıları

      //for(int i =1;i<=100;i++)
      //{
      //  if (i % 5 == 0)               //i nin 5 ile bölümünden kalan 0 olanları getirir
      //  {
      //    Console.WriteLine(i);
      //  }
      //}

      //------------------------------

      //int totalValue = 0;

      //for(int i =1;i<=10;i++)
      //{
      //  totalValue += i;
      //}

      //Console.WriteLine(totalValue);

      //------------------------------

      //int totalValue = 0;

      //for(int i = 0; i < 20; i++)
      //{
      //  if (i % 2 == 0)
      //  {
      //    totalValue += i;
      //    Console.WriteLine(i);
      //  }
      //}
      //Console.WriteLine("-------");
      //Console.WriteLine(totalValue);

      //------------------------------

      //int totalValue = 0;

      //for(int i =1;i<=10;i++)
      //{
      //  totalValue += 1;
      //}

      //Console.WriteLine(totalValue);

      //------------------------------

      //int totalValue = 0;

      //for(int i = 1; i < 20; i++)
      //{
      //  if (i % 2 == 00)
      //  {
      //    totalValue += i;
      //    Console.WriteLine(i);
      //  }
      //}
      //Console.WriteLine("---------");
      //Console.WriteLine(totalValue);

      //------------------------------

      //int count = 0;
      //for(int i=1; i<=50;i++)
      //{
      //  if(i%7 == 0)
      //  {
      //    count++;
      //  }
      //}
      //Console.WriteLine(count);

      #endregion

      #region bakteri artışı
      //int bacterium = 1;
      //for(int i = 1; i <= 24; i++)
      //{
      //  bacterium *= 2;
      //  Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
      //}



      #endregion

      #region While döngüsü

      //while (şart)
      //{
      //  işlemler
      //}
      //---------------------

      //int i = 1;
      //while (i <= 10)
      //{
      //  Console.WriteLine("Merhaba Döngüler");
      //  i++;
      //}
      //---------------------

      //int i = 1;
      //while (i <= 10)
      //{
      //  if (i % 3 == 0)
      //  {
      //    Console.WriteLine(i);
      //  }
      //  i++;
      //}

      //----------------------

      //int i = 0;
      //int sum = 0;

      //while (i <= 10)
      //{
      //  sum += i;
      //  i++;
      //}

      //Console.WriteLine(sum);
      //----------------------







      #endregion

      #region örnek sınav sorusu

      //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.


      //Console.Write("Sayısıyı giriniz: ");
      //int number=int.Parse(Console.ReadLine());
      //int ones, tens, hundreds;
      //int sum;

      //ones = number % 10; 
      //hundreds = number / 100; //4.56  =>4 alır
      //tens = (number % 100)/10;

      //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

      //sum = hundreds + tens + ones;

      //Console.WriteLine(sum);


      #endregion




      Console.Read();









    }




  }
}
