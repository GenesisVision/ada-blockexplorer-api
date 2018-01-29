using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
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
