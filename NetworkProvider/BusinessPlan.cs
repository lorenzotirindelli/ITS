using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkProvider
{
	partial class BusinessPlan : PlanBase
	{

		private decimal _pricePerMinute = 0.17m;

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
