using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo.ITS.FirstConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			// VALUE TYPE
			int a = 123;
			int b = a;

			Console.WriteLine("ciao");
			Console.WriteLine(b);
			a = 0;
			Console.WriteLine(b); //b still 123 - Being a value type means that this assign the value (like doing angular.copy)


			//REFERENCE TYPE
			StringBuilder sb1 = new StringBuilder("testo di prova");
			StringBuilder sb2 = sb1;

			Console.WriteLine(sb2.ToString());
			sb1.Append(" test di concatenzazione");
			Console.WriteLine(sb2.ToString()); //Being a reference type means that this change the value (like JS)

			//Environment.NewLine - solo su WINZOZZ
			Console.WriteLine("sono le ore {0} del {1}",
				DateTime.Now.ToShortTimeString(),
				DateTime.Now.ToShortDateString());

			//var in fase di compilazione viene identificato con un tipo primitivo (il più adeguato secondo compilatore
			//devo definire var subito (ex: var prova = 1;) 
			var x = string.Format(@"sono le ore {0} del {1}",
				DateTime.Now.ToShortTimeString(),
				DateTime.Now.ToShortDateString());

			var y = $"sono le ore { DateTime.Now.ToShortTimeString()} del { DateTime.Now.ToShortDateString()}";


			Product product = new Product();
			product.Code = "ABC";
			product.Name = "Prodotto 1";
			product.Id = 1;

			Console.WriteLine(product.GetUpperName());

			//Array dimensione fissa, liste dimensione variabile
			List<IProduct> list = new List<IProduct>();
			list.Add(new Product());
			list.Add(new CustomProduct());

			foreach (var item in list)
			{
				Console.WriteLine(item.Name);

				//example 1
				if (item is Product)
				{
					Product p = (Product)item;
					//Product p2 = item as Product; //if item is Product fine, if not -> NULL
					Console.WriteLine(p.Id);
				}

				//example 2
				Product p2 = item as Product;
				if (p2 != null)
				{
					Console.WriteLine(p2.Id);
				}
			}
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary.Add(0, "ABC");
			dictionary.Add(1, "ABC");
			//dictionary.Add(1, "ABC"); explode because duplicated key (1)

			if (dictionary.ContainsKey(2))
				dictionary[2] = "GGGG";

			var dict2 = new Dictionary<string, string>();
			dict2["aaa"] = "xxxxx";
			Console.WriteLine(dict2["aaa"]);



			Console.ReadKey();

		}
	}
}
