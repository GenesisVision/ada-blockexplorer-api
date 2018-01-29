using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class Fees : ICoinInfo
	{

		[JsonProperty("getCoin")]
		public string GetCoin { get; set; }
	}
}
