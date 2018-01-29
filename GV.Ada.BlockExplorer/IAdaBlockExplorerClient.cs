using System.Threading.Tasks;

namespace GV.Ada.BlockExplorer
{
	public interface IAdaBlockExplorerClient
	{
		Task<BlocksPageResponse> GetBlocksPage(int? page = null);
		Task<BlockSummaryResponse> GetBlockSummary(string blockHash);
		Task<BlockTransactionsResponse> GetBlockTransactions(string blockHash);
		Task<BlocksPageResponse> GetEpochPage(int epoch, int? page = null);
		Task<BlocksPageItem> GetLatestBlock();
		Task<int> GetSlotCountByEpoch(int epoch);
		Task<TransactionSummaryResponse> GetTransaction(string transactionHash);
	}
}