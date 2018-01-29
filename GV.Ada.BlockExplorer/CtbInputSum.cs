using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class InputSum : ICoinInfo
	{

		[JsonProperty("getCoin")]
		public string GetCoin { get; set; }
	}
}
