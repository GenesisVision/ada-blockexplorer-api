using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GV.Ada.BlockExplorer
{
	public class AdaBlockExplorerClient : IAdaBlockExplorerClient
	{
		private readonly HttpClient client;
		private readonly string apiPath;

		public AdaBlockExplorerClient() : this("https://cardanoexplorer.com", new HttpClient())
		{
		}

		public AdaBlockExplorerClient(string apiPath, HttpClient client)
		{
			this.client = client;
			this.apiPath = apiPath;
		}

		public async Task<BlockTransactionsResponse> GetBlockTransactions(string blockHash)
		{
			var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"{apiPath}/api/blocks/txs/{blockHash}");
			var response = await client.SendAsync(httpRequest);

			response.EnsureSuccessStatusCode();
			var result = await response.Content.ReadAsStringAsync();

			var data = JsonConvert.DeserializeObject<BlockTransactionsResponse>(result);
			return data;
		}

		public async Task<BlockSummaryResponse> GetBlockSummary(string blockHash)
		{
			var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"{apiPath}/api/blocks/summary/{blockHash}");
			var response = await client.SendAsync(httpRequest);

			response.EnsureSuccessStatusCode();
			var result = await response.Content.ReadAsStringAsync();

			var data = JsonConvert.DeserializeObject<BlockSummaryResponse>(result);
			return data;
		}

		public async Task<BlocksPageItem> GetLatestBlock()
		{
			var blocks = await GetBlocksPage();
			return blocks.Items.First();
		}

		public async Task<BlocksPageResponse> GetBlocksPage(int? page = null)
		{
			var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"{apiPath}/api/blocks/pages/" + (page.HasValue ? "?page=" + page.ToString() : ""));
			var response = await client.SendAsync(httpRequest);

			response.EnsureSuccessStatusCode();
			var result = await response.Content.ReadAsStringAsync();

			var rs = JObject.Parse(result);
			var maxPage = rs.First.First.First.Value<int>();

			var list = new List<BlocksPageItem>();
			var blocks = rs.First.Last.Last.Children();
			foreach (var blockItem in blocks)
			{
				list.Add(blockItem.ToObject<BlocksPageItem>());
			}

			return new BlocksPageResponse
			{
				Items = list,
				TotalPages = maxPage
			};
		}

		public async Task<int> GetSlotCountByEpoch(int epoch)
		{
			var firstPage = await GetEpochPage(epoch);
			var lastPage = await GetEpochPage(epoch, firstPage.TotalPages);
			return lastPage.Items.First().Slot;
		}

		public async Task<BlocksPageResponse> GetEpochPage(int epoch, int? page = null)
		{
			var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"{apiPath}/api/epochs/{epoch}/" + (page.HasValue ? "?page=" + page.ToString() : ""));
			var response = await client.SendAsync(httpRequest);

			response.EnsureSuccessStatusCode();
			var result = await response.Content.ReadAsStringAsync();

			var rs = JObject.Parse(result);
			var maxPage = rs.First.First.First.Value<int>();

			var list = new List<BlocksPageItem>();
			var blocks = rs.First.Last.Last.Children();
			foreach (var blockItem in blocks)
			{
				list.Add(blockItem.ToObject<BlocksPageItem>());
			}

			return new BlocksPageResponse
			{
				Items = list,
				TotalPages = maxPage
			};
		}

		public async Task<TransactionSummaryResponse> GetTransaction(string transactionHash)
		{
			var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"{apiPath}/api/txs/summary/{transactionHash}");
			var response = await client.SendAsync(httpRequest);

			response.EnsureSuccessStatusCode();
			var result = await response.Content.ReadAsStringAsync();

			var data = JsonConvert.DeserializeObject<TransactionSummaryResponse>(result);
			return data;
		}
	}
}
