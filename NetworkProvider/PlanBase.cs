using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkProvider
{
	abstract class PlanBase
	{

		public abstract decimal PricePerMinute { get; set; }

		public virtual decimal GetTotalPrice(int minutes)
		{
			return PricePerMinute * minutes;
		}

	}
}
