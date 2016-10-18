using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCounter
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Schema di funzionamento: TASTO DI SCELTA - TIPO FRUTTO (PREZZO)");
			Console.WriteLine(" ");
			Console.WriteLine("A - Ananas (4€ al pezzo); \nO - Arance (2€ al pezzo); \nM - Mele: (1€ al pezzo)");
			Console.WriteLine(" ");
			Console.WriteLine("Che frutto vuoi?");
			ConsoleKeyInfo cki;

			List<IFruit> basket = new List<IFruit>();

			bool typeSel = true;
			bool checkOut = false;

			do
			{
				cki = Console.ReadKey(true);
				string fruitType = cki.Key.ToString();
				string fuckingFruit;

				switch (fruitType)
				{
					case "A":
						fuckingFruit = "Ananas";
						Console.WriteLine("Quanti/e " + fuckingFruit + " vuoi?");
						break;
					case "M":
						fuckingFruit = "Mele";
						Console.WriteLine("Quanti/e " + fuckingFruit + " vuoi?");
						break;
					case "O":
						fuckingFruit = "Arance";
						Console.WriteLine("Quanti/e " + fuckingFruit + " vuoi?");
						break;
					default:
						Console.WriteLine("Nessun frutto corrisponde al tipo da te inserito.");
						break;
				}

				string qtLine = Console.ReadLine();
				int fruitQuantity;
				int.TryParse(qtLine, out fruitQuantity);
				bool qtSel = true;

				do
				{
					Console.WriteLine("Hai scelto di aggiungerene " + fruitQuantity + " " + fruitType);
					for (int i = 0; i < fruitQuantity; i++)
					{
						if (fruitType.Equals("A"))
						{
							basket.Add(new Pineapple(4));
						}
						else if (fruitType.Equals("M"))
						{
							basket.Add(new Apple(1));
						}
						else if (fruitType.Equals("O"))
						{
							basket.Add(new Orange(2));
						}

					};

					checkOut = true;
					qtSel = false;

					Console.WriteLine("Vuoi aggiungerne altra frutta? Y/N");

					do
					{
						cki = Console.ReadKey(true);
						string confirm = cki.Key.ToString();
						if (confirm.Equals("Y") || confirm.Equals("y"))
						{
							Console.WriteLine("Digita 'A' per Ananas, 'O' per Arance e 'M' per Mele; subito dopo ti verrà chiesta la quantità desiderata :)");
							checkOut = false;
							qtSel = false;

						}
						//Io qui chiudo l'ordine e mostro il totale dei prodotti e il costo ma si può fare un tasto dedicato ecc
						//A voi eventuali raffinatezze
						else if (confirm.Equals("N") || confirm.Equals("n"))
						{
							Console.WriteLine("Perfetto, l'ordine è stato effettuato!");
							//Mostrare il totale dei pezzi e del prezzo
						}
					} while (checkOut);

				} while (qtSel);

			} while (typeSel);

		}
	}
}
