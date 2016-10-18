using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo.ITS.FirstConsole
{
	public interface IProduct //if sum1 use an interface all the elements of it are usable
	{

		string Name { get; set; }

		decimal Price { get; set; }

		string GetUpperName();
	}
}
