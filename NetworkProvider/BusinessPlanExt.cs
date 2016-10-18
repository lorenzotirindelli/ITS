using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkProvider
{
	partial class BusinessPlan
	{

		public decimal GetTotalPriceWithOption(int minutes)
		{
			var result = PricePerMinute * (minutes - 60);
			if (result < 0)
				result = 0;
			return result;
		}

	}
}
