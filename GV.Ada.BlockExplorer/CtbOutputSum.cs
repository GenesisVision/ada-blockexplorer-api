using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class OutputSum : ICoinInfo
	{

		[JsonProperty("getCoin")]
		public string GetCoin { get; set; }
	}
}
