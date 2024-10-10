using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region double değişkenler

			//ondalık değişken double

			//double number;
			//number = 4.85;
			//Console.WriteLine(number);

			//Console.WriteLine("***** Fiyat Listesi *****");
			//Console.WriteLine();

			//double applePrice, orangePrice, strawberryPrice, potato, tomato;
			//applePrice = 12.75;
			//orangePrice = 16.82;
			//strawberryPrice = 10;
			//potato = 12.50;
			//tomato = 9.95;;

			//Console.WriteLine("----- Elma Birim Fiyatı: "+ applePrice + "TL");
			//Console.WriteLine("----- Portakal Birim Fiyatı: "+ orangePrice + "TL");
			//Console.WriteLine("----- Çilek Birim Fiyatı: "+ strawberryPrice + "TL");
			//Console.WriteLine("----- Patates Birim Fiyatı: "+ potato + "TL");
			//Console.WriteLine("----- Domates Birim Fiyatı: "+ tomato + "TL");

			//double appleGram,orangeGram,strawberryGram,potatoGram,tomatoGram;
			//appleGram = 1.245;
			//orangeGram = 2.600;
			//strawberryGram = 0.750;
			//potatoGram = 3.750;
			//tomatoGram = 2.560;

			//double orangeTotalPrice = orangeGram * orangePrice;
			//Console.WriteLine("Portakalın toplam tutarı: " + orangeTotalPrice + "TL");
			//double appleTotalPrice = appleGram * applePrice;
			//Console.WriteLine("Elmanın toplam tutarı:" + appleTotalPrice + "TL");

			//double toplamtutar = orangeTotalPrice + appleTotalPrice;
			//Console.WriteLine("Alışveriş Toplam Tutar: " + toplamtutar + "TL");

			#endregion

			#region char değişkenler

			//tek tırnakla tanımlanır
			//karakter değişimi

			//char symbol = 'a';
			//Console.WriteLine(symbol);


			#endregion

			#region klavyeden veri girişleri string değişkenler

			//string passengerName, passengerSurname, passencerCity, passencerDistrict, passencerTc;

			//Console.Write("Yolcu Adı:");
			//passengerName = Console.ReadLine();
			//Console.Write("Yolcu Soyadı:");
			//passengerSurname = Console.ReadLine();

			//Console.WriteLine("----------------");
			//Console.WriteLine("Yolcu: "+  passengerName + " " + passengerSurname);

			//Console.Write("İlçe Bilgisi:");
			//passencerDistrict = Console.ReadLine();


			#endregion

			#region klavyeden Tam Sayı Girişleri ve Dönüşümler

			//int shoesPrice, chairPrice, computerPrice, tvPrice;

			//shoesPrice = 2000;
			//chairPrice = 12000;
			//computerPrice = 30000;
			//tvPrice = 16700;

			//int shoesCount, tvCount, chairCount, computerCount;

			//Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
			//shoesCount = int.Parse(Console.ReadLine());

			//Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
			//computerCount = int.Parse(Console.ReadLine());


			//int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice;
			//Console.WriteLine();
			//Console.WriteLine("Toplam Ödencek Tutar: " + totalPrice);
			#endregion

			#region klavyeden ondalıklı sayı işlmeleri

			//double exam1, exam2, exam3, result;

			//Console.Write("Lütfen 1.sınav notunu giriniz:");
			//exam1=double.Parse(Console.ReadLine());

			//Console.Write("LÜtfen 2.sınav notunu giriniz: ");
			//exam2 = double.Parse(Console.ReadLine());

			//Console.Write("Lütfen 3.sınav notunu giriniz: ");
			//exam3 = double.Parse(Console.ReadLine());

			//result = (exam1 + exam2 + exam3) / 3;

			//Console.WriteLine("Sınav Ortalamanız: " + result);

			#endregion

			#region klavyeden karakter girişleri

			//char gender;
			//Console.Write("Lütfen cinsiyet seçiniz: ");
			//gender= char.Parse(Console.ReadLine());

			//Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);



			#endregion

			Console.Read();









		}
	}
}
