using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkProvider
{
	class Program
	{
		static void Main(string[] args)
		{

			bool exit = false;

			do
			{

				Console.WriteLine("Inserisci il numero di minuti con cui eseguire la simulazione.");
				Console.OutputEncoding = System.Text.Encoding.UTF8;
				bool endCalc = false;

				string minuteStr = Console.ReadLine();
				int minutes;
				int.TryParse(minuteStr, out minutes);

				if (minutes >= 0)
				{
					Console.WriteLine("Hai impostato il calcolo per " + minutes + " minuti.");
				}
				else
				{
					Console.WriteLine("Ci dispiace ma non è possibile eseguire il calcolo con numeri minori di 0. Inseriscine uno maggiore e riprova.");
					Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
					endCalc = true;
				}

				while (!endCalc) {

					PlanBase easyPlan = new EasyPlan();
					decimal CostoEasy = easyPlan.GetTotalPrice(minutes);

					PlanBase businessPlan = new BusinessPlan();
					decimal CostoBusiness = businessPlan.GetTotalPrice(minutes);

					BusinessPlan businessPlanWithOption = new BusinessPlan();
					decimal CostoBusinessWithOption = businessPlanWithOption.GetTotalPriceWithOption(minutes);

					Console.WriteLine("Il costo per " + minutes + " minuti di chiamate con il piano Business è di: " + CostoBusiness + "€");
					Console.WriteLine("Il costo per " + minutes + " minuti di chiamate con il piano Business e l'opzione '60 minuti gratis' è di: " + CostoBusinessWithOption + "€");
					Console.WriteLine("Il costo per " + minutes + " minuti di chiamate con il piano Easy è di: " + CostoEasy + "€");
					Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

					endCalc = true;

				}

			} while (!exit);

		}
	}
}
