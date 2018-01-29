using Newtonsoft.Json;
using System.Collections.Generic;

namespace GV.Ada.BlockExplorer
{
	public class BlockSummaryItem
	{

		[JsonProperty("ctbId")]
		public string Id { get; set; }

		[JsonProperty("ctbTimeIssued")]
		public long TimeIssued { get; set; }

		[JsonProperty("ctbInputs")]
		public IList<IList<dynamic>> CtbInputs { get; set; }

		[JsonProperty("ctbOutputs")]
		public IList<IList<dynamic>> CtbOutputs { get; set; }

		[JsonProperty("ctbInputSum")]
		public CoinInfo InputSum { get; set; }

		[JsonProperty("ctbOutputSum")]
		public CoinInfo OutputSum { get; set; }

		public IList<AdaInput> GetInputs()
		{
			var list = new List<AdaInput>();
			foreach (var item in CtbInputs)
			{
				list.Add(new AdaInput()
				{
					WalletAddress = item[0],
					Amount = item[1].getCoin
				});
			}
			return list;
		}

		public IList<AdaInput> GetOutputs()
		{
			var list = new List<AdaInput>();
			foreach (var item in CtbOutputs)
			{
				list.Add(new AdaInput()
				{
					WalletAddress = item[0],
					Amount = item[1].getCoin
				});
			}
			return list;
		}
	}
}
