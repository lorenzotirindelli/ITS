using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCounter
{
	public interface IFruit
	{

		string Name { get; set; }

		decimal Price { get; set; }

		string GetName();
		
		decimal GetPrice();

	}
}
