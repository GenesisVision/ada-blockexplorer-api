using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class BlockSummaryWrapper
	{
		[JsonProperty("cbsEntry")]
		public BlockEntry Entry { get; set; }

		[JsonProperty("cbsPrevHash")]
		public string PrevHash { get; set; }

		[JsonProperty("cbsNextHash")]
		public string NextHash { get; set; }

		[JsonProperty("cbsMerkleRoot")]
		public string MerkleRoot { get; set; }
	}
}
