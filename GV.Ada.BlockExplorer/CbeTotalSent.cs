using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class TotalSent : ICoinInfo
	{

		[JsonProperty("getCoin")]
		public string GetCoin { get; set; }
	}
}
