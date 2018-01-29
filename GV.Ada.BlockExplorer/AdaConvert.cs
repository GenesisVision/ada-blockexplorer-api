using System;
using System.Collections.Generic;
using System.Text;

namespace GV.Ada.BlockExplorer
{
	public static class AdaConvert
	{
		public static decimal FromLove(long amount)
		{
			return Convert.ToDecimal(amount) / 1000000m;
		}
	}
}
