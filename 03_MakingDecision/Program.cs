﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
  internal class Program
  {
    static void Main(string[] args)
    {
      #region If Else

      //Console.Write("Lütfen şifreyi giriniz: ");
      //string password;
      //password= Console.ReadLine();
      //if(password == "abcd")
      //{
      //  Console.WriteLine("Şifre Doğru");
      //}
      //else
      //{
      //  Console.WriteLine("Şifre yanlış");
      //}

      //----------------------------------------------------

      //string capital, country;
      //Console.Write("Başkenti Giriniz: ");
      //capital= Console.ReadLine();
      //Console.Write("Ülkeyi Giriniz: ");
      //country= Console.ReadLine();
      //if(capital=="ankara" && country == "türkiye")
      //{
      //  Console.Write("veriler doğru");
      //}
      //else
      //{
      //  Console.Write("veriler hatalı");
      //}

      //----------------------------------------------------

      //int number;
      //Console.Write("Sayıyı giriniz: ");
      //number=int.Parse(Console.ReadLine());
      //if (number == 5)
      //{
      //  Console.WriteLine("Sayı doğru");
      //}
      //else
      //{
      //  Console.WriteLine("sayı hatalı");
      //}

      //----------------------------------------------------

      //int exam1, exam2, exam3, ortalama;
      //string result= "";
      //Console.Write("Sınav1: ");
      //exam1 = int.Parse(Console.ReadLine());
      //Console.Write("Sınav2: ");
      //exam2 = int.Parse(Console.ReadLine());
      //Console.Write("Sınav3: ");
      //exam3 = int.Parse(Console.ReadLine());
      //ortalama = (exam1 + exam2 + exam3) / 3;
      //Console.Write("Sınavların ortalaması: " +" " +ortalama);
      //if (ortalama > 0 & ortalama <= 50)
      //{
      //  result = "Sonuç başarısız";
      //}
      //if (ortalama > 50 & ortalama <= 70)
      //{
      //  result = "Sonuç orta";
      //}
      //if (ortalama > 70 & ortalama <= 84)
      //{
      //  result = "Sonuç iyi";
      //}
      //if (ortalama > 84)
      //{
      //  result = "Sonuç çok iyi";
      //}

      //Console.WriteLine(result);


      //----------------------------------------------------

      //string city;
      //Console.Write("Lütfen şehir girişi yapınız: ");
      //city= Console.ReadLine();
      //if(city=="adana" | city=="ankara" | city == "kocaeli")
      //{
      //  Console.WriteLine("Şehir mevcut");
      //}
      //else
      //{
      // Console.WriteLine("şehir mevcut değil");
      //}

      //----------------------------------------------------

      //Console.Write("Lütfen kullanıcı adını giriniz: ");
      //string username=Console.ReadLine();
      //if(username!= "admin")
      //{
      //  Console.WriteLine("bu kullanıcı adı hatalı");
      //}
      //else
      //{
      //  Console.WriteLine("hoşgeldiniz");



      //Console.Read();



      #endregion

      #region mod işlemleri

      //int number;
      //number = 26;
      //int sonuc = number % 5;
      //Console.WriteLine(sonuc);

      //--------------------------------------------

      //Console.WriteLine("Lütfen 1.sayıyı giriniz: ");
      //int number1=int.Parse(Console.ReadLine());

      //Console.WriteLine("Lütfen 2.sayıyı giriniz: ");
      //int number2=int.Parse(Console.ReadLine());

      //int result = number1 % number2;
      //Console.WriteLine("1.sayının 2.sayıya bölümünden kalan: " +  result);

      //--------------------------------------------
      //Console.Write("lütfen bir sayı giriniz: ");
      //int number=int.Parse(Console.ReadLine());

      //if(number % 2 == 0)
      //{
      //  Console.WriteLine("Sayı çifttir");
      //}
      //else
      //{
      //  Console.WriteLine("Sayı tektir");
      //}

      #endregion

      #region char Değişkenler ile karar yapıları

      //char team;
      //Console.Write("Lütfen takım sembolünü giriniz: ");
      //team=char.Parse(Console.ReadLine());

      //if(team=='g' | team == 'G')
      //{
      //  Console.Write("Galatasaray");
      //}
      //if(team =='f' | team == 'F')
      //{
      //  Console.Write("Fenerbahçe");
      //}

      //if(team=='b' | team == 'B')
      //{
      //  Console.WriteLine("Beşiktaş");
      //}


      #endregion

      #region Örnek Proje Uygulaması

      //Console.WriteLine("***** Sevük Restoran *****");
      //Console.WriteLine();
      //Console.WriteLine("------------------------");
      //Console.WriteLine("1-Pizzalar");
      //Console.WriteLine("2-Çorbalar");
      //Console.WriteLine("3-İçecekler");
      //Console.WriteLine("4-Tatlılar");
      //Console.WriteLine("------------------------");

      //string menuItem;
      //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
      //menuItem=Console.ReadLine();

      //if (menuItem == "1")
      //{
      //  Console.WriteLine();
      //  Console.WriteLine("------Pizzalar-----");
      //  Console.WriteLine();
      //  Console.WriteLine("1-Margarita Pizza");
      //  Console.WriteLine("2-Karışık Pizza");
      //  Console.WriteLine("3-Vejeteryan Pizza");
      //  Console.WriteLine("------Pizzalar-----");
      //  Console.WriteLine();

      //}
      //if (menuItem == "2")
      //{
      //  Console.WriteLine();
      //  Console.WriteLine("------Çorbalar-----");
      //  Console.WriteLine();
      //  Console.WriteLine("1-Mercimek Çorbası");
      //  Console.WriteLine("2-Yayla Çorbası");
      //  Console.WriteLine("3-Ezogelin Çorbası ");
      //  Console.WriteLine("------Çorbalar-----");
      //  Console.WriteLine();

      //}
      //if (menuItem == "3")
      //{
      //  Console.WriteLine();
      //  Console.WriteLine("------İçecekler-----");
      //  Console.WriteLine();
      //  Console.WriteLine("1-Çay");
      //  Console.WriteLine("2-Ayran");
      //  Console.WriteLine("3-Kola ");
      //  Console.WriteLine("------İçecekler-----");
      //  Console.WriteLine();

      //}
      //if (menuItem == "4")
      //{
      //  Console.WriteLine();
      //  Console.WriteLine("------Tatlılar-----");
      //  Console.WriteLine();
      //  Console.WriteLine("1-Sütlaç");
      //  Console.WriteLine("2-Kazandibi");
      //  Console.WriteLine("3-Magnolia ");
      //  Console.WriteLine("------Tatlılar-----");
      //  Console.WriteLine();

      //}





      //Console.Read();



      #endregion

      #region switch case
      //Console.Write("Lütfen ay girişi yapınız: ");
      //int montNumber=int.Parse(Console.ReadLine());

      //switch(montNumber)
      //{
      //  case 1: Console.WriteLine("Ocak"); break;
      //  case 2: Console.WriteLine("Şubat"); break;
      //  case 3: Console.WriteLine("Mart"); break;
      //  case 4: Console.WriteLine("Nisan"); break;
      //  case 5: Console.WriteLine("Mayıs"); break;
      //  case 6: Console.WriteLine("Haziran"); break;
      //  case 7: Console.WriteLine("Temmuz"); break;
      //  case 8: Console.WriteLine("Ağustos"); break;
      //  case 9: Console.WriteLine("Eylül"); break;
      //  case 10: Console.WriteLine("Ekim"); break;
      //  case 11: Console.WriteLine("Kasım"); break;
      //  case 12: Console.WriteLine("Aralık"); break;
      //  default: Console.Write("Hatalı veri girişi"); break;

      //}

      #endregion

      #region hesap makinesi
      //int number1, number2, result;
      //char symbol;
      //Console.Write("1.Sayıyı giriniz: ");
      //number1=int.Parse(Console.ReadLine());

      //Console.Write("2.Sayıyı giriniz: ");
      //number2=int.Parse(Console.ReadLine());

      //Console.Write("Lütfen yapmak istediğininz işlemi giriniz: ");
      //symbol=char.Parse(Console.ReadLine());


      //switch (symbol)
      //{
      //  case '+':
      //    result = number1 + number2;
      //    Console.WriteLine(result); break;
      //  case '-':
      //    result = number1 - number2;
      //    Console.WriteLine(result);break;
      //  case '*':
      //    result = number1 * number2;
      //    Console.WriteLine(result); break; 
      //  case '/':
      //    result=number1 / number2;
      //    Console.WriteLine(result); break;

      //}
      //Console.Read();


      #endregion





    }


  }
}
