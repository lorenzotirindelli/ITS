using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkProvider
{
	class EasyPlan : PlanBase
	{

		private decimal _pricePerMinute = 0.05m;

		public override decimal PricePerMinute
		{
			get { return _pricePerMinute; }
			set { }
		}

		public override decimal GetTotalPrice(int minutes)
		{
			return PricePerMinute * minutes;
		}

	}
}
