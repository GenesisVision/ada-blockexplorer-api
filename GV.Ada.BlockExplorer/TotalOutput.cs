using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class TotalOutput : ICoinInfo
	{

		[JsonProperty("getCoin")]
		public string GetCoin { get; set; }
	}
}
