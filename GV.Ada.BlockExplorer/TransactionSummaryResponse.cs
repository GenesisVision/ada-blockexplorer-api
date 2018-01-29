using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class TransactionSummaryResponse
	{
		[JsonProperty("Right")]
		public TransactionSummaryItem Right { get; set; }
	}
}
