using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class CtsFees : ICoinInfo
	{

		[JsonProperty("getCoin")]
		public string GetCoin { get; set; }
	}
}
