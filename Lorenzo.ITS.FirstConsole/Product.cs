using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo.ITS.FirstConsole
{
	class Product : IProduct//default internal
	{

		public string Name { get; set; }

		public string _code; //private variables could be with _ and/or lower case
		public string Code
		{
			get { return _code; }
			set { _code = value + "aaa"; } //could write "private set" making it not modifiable
		}

		public int Id { get; set; }

		public decimal Price { get; set; }

		public string GetUpperName()
		{
			string result = Name.ToUpper();
			return result;
		}

	}
}
