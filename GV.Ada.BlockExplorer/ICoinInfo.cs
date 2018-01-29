using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GV.Ada.BlockExplorer
{
	public interface ICoinInfo
	{
		string GetCoin { get; set; }
		decimal GetAdaLove();
	}

	public class CoinInfo : ICoinInfo
	{
		[JsonProperty("getCoin")]
		public string GetCoin { get; set; }

		public decimal GetAdaLove()
		{
			if (string.IsNullOrEmpty(GetCoin))
			{
				return 0;
			}
			return AdaConvert.FromLove(long.Parse(GetCoin));
		}
	}
}
