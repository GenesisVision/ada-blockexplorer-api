using Newtonsoft.Json;
using System.Collections.Generic;

namespace GV.Ada.BlockExplorer
{
	public class TransactionSummaryItem
	{

		[JsonProperty("ctsId")]
		public string Id { get; set; }

		[JsonProperty("ctsTxTimeIssued")]
		public long TxTimeIssued { get; set; }

		[JsonProperty("ctsBlockTimeIssued")]
		public long BlockTimeIssued { get; set; }

		[JsonProperty("ctsBlockHeight")]
		public int BlockHeight { get; set; }

		[JsonProperty("ctsBlockEpoch")]
		public int BlockEpoch { get; set; }

		[JsonProperty("ctsBlockSlot")]
		public int BlockSlot { get; set; }

		[JsonProperty("ctsBlockHash")]
		public string BlockHash { get; set; }

		[JsonProperty("ctsRelayedBy")]
		public object RelayedBy { get; set; }

		[JsonProperty("ctsTotalInput")]
		public CoinInfo TotalInput { get; set; }

		[JsonProperty("ctsTotalOutput")]
		public CoinInfo TotalOutput { get; set; }

		[JsonProperty("ctsFees")]
		public CoinInfo Fees { get; set; }

		[JsonProperty("ctsInputs")]
		public IList<IList<dynamic>> Inputs { get; set; }

		[JsonProperty("ctsOutputs")]
		public IList<IList<dynamic>> Outputs { get; set; }
	}

}
