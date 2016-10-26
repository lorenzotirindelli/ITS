using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lorenzo.Northwind.Data;

namespace Lorenzo.Northwind.ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var csConfig = ConfigurationManager.ConnectionStrings["northwind"];
			if (csConfig == null)
			{
				throw new ApplicationException("ConnectionString northwind non presente");
			}

			var cs = csConfig.ConnectionString;

			IDataAccess data = new SqlDataAccess(cs);

			var categories = data.GetCategories();

			foreach (var category in categories)
			{
				Console.WriteLine($"{category.Id} - {category.Name} - {category.Description}");
			}

			var c = data.GetCategory(1);
			if (c != null)
			{
				Console.WriteLine($"Categoria: {c.Name}");
			}

			Console.ReadLine();
		}
	}
}
