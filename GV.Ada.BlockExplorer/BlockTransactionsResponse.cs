using Newtonsoft.Json;
using System.Collections.Generic;

namespace GV.Ada.BlockExplorer
{
	public class BlockTransactionsResponse
	{
		[JsonProperty("Right")]
		public IList<BlockSummaryItem> Right { get; set; }
	}
}
