using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class BlockSummaryResponse
	{

		[JsonProperty("Right")]
		public BlockSummaryWrapper Right { get; set; }
	}
}
