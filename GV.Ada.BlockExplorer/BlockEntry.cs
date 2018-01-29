using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class BlockEntry
	{

		[JsonProperty("cbeEpoch")]
		public int Epoch { get; set; }

		[JsonProperty("cbeSlot")]
		public int Slot { get; set; }

		[JsonProperty("cbeBlkHash")]
		public string BlockHash { get; set; }

		[JsonProperty("cbeTimeIssued")]
		public long TimeIssued { get; set; }

		[JsonProperty("cbeTxNum")]
		public int TxNum { get; set; }

		[JsonProperty("cbeTotalSent")]
		public CoinInfo TotalSent { get; set; }

		[JsonProperty("cbeSize")]
		public int Size { get; set; }

		[JsonProperty("cbeBlockLead")]
		public string BlockLead { get; set; }

		[JsonProperty("cbeFees")]
		public CoinInfo Fees { get; set; }
	}
}
