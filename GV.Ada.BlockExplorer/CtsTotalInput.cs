using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class TotalInput : ICoinInfo
	{

		[JsonProperty("getCoin")]
		public string GetCoin { get; set; }
	}
}
