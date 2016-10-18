using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo.ITS.FirstConsole
{
	class CustomProduct : IProduct
	{
		public string Name { get; set; }
		
		public decimal Price { get; set; }

		public string GetUpperName()
		{
			return Name.ToUpper();
		}
		
	}
}
