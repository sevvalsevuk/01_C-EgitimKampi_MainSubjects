using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_C_EgitimKampi_MainSubjects
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region YazdırmaKomutları

			//Console.WriteLine("**** Yemek Kategorileri");
			//Console.WriteLine();
			//Console.WriteLine("1-Çorbalar");
			//Console.WriteLine("2-Ana Yemekler");
			//Console.WriteLine("2-Ara Yemekler");
			//Console.WriteLine();
			//Console.WriteLine("**** Yemek Kategorileri");

			//Console.Read();
			#endregion

			#region Değişkenler

			//string
			//Değişkentürü değişken adı;

			//string name;
			//name = "şevval";
			//Console.WriteLine(name);

			//string customerName;
			//string customerSurname;
			//string customerPhone;
			//string customerEmail, district, city;

			//customerName = "Ali";
			//customerSurname = "Çınar";
			//customerPhone = "+0500 652 5623";
			//customerEmail = "deneme@gmail.com";
			//district = "Gölcük";
			//city = "Kocaeli";

			//Console.WriteLine("**** Rezervasyon Kartı");
			//Console.WriteLine();
			//Console.WriteLine("***************************");
			//Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
			//Console.WriteLine("İletişim: " + customerPhone);
			//Console.WriteLine("EMail: " + customerEmail);

			//Console.ReadLine();

			#endregion

			#region Int Değişkenler
			//int number = 24;
			//Console.WriteLine(number);

			int hamburgerPrice = 300;
			int cokePrice = 35;
			int waterPrice = 20;
			int PizzaPrice = 250;

			Console.WriteLine("**** Restoran Menü Fiyatı");
			Console.WriteLine();
			Console.WriteLine("----Hmburger Fiyatı :" + hamburgerPrice + "TL");
			Console.WriteLine("----Pizza: " + PizzaPrice + "TL");
			Console.WriteLine("----su: " + waterPrice + "TL");
			Console.WriteLine("**** Restoran Menü Fiyatı");

			Console.WriteLine();
			int totalHamburgerPrice = 0;  //0 atamak zorunda değiliz int totalHamburgerPrice;  şeklinde yazılabilir
			int totalCokePrice = 0;
			int totalPrice;

			int hamburgerCount =3;
			int cokeCount=3;
			int waterCount=2;
			int pizzaCount=1;

			totalHamburgerPrice = hamburgerPrice * hamburgerCount;
			Console.WriteLine("Hamburger Fiyatı: " + totalHamburgerPrice);

			totalCokePrice= cokePrice * cokeCount;
			Console.WriteLine("Coke Fiyatı: " + totalCokePrice + "TL");

			totalPrice = totalHamburgerPrice + totalCokePrice;
			Console.WriteLine("Toplam Tutar: " + totalPrice);

			Console.Read();


			#endregion


		}
	}
}

