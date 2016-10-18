using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCounter
{
	class Apple : IFruit
	{
		public string Name { get; set; }

		public decimal Price { get; set; }

		public Apple(decimal p)
		{
			Name = "Apple";
			Price = p;
		}
		public string GetName()
		{
			return Name;
		}

		public decimal GetPrice()
		{
			return Price;
		}
	}
}
