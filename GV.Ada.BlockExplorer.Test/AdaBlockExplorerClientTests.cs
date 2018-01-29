using System;
using Xunit;

namespace GV.Ada.BlockExplorer.Test
{
    public class AdaBlockExplorerClientTests
	{
        [Fact]
        public async void GetBlocksPageLatestTest()
        {
			var service = new AdaBlockExplorerClient();
			var result = await service.GetBlocksPage();
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetBlockSummaryTest()
		{
			var service = new AdaBlockExplorerClient();
			var result = await service.GetBlockSummary("3dc7a73a3e27384cfc4b0d01045e072a1c80fdd9ca628a3f03ebe51e4028158a");
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetBlockTransactionsTest()
		{
			var service = new AdaBlockExplorerClient();
			var result = await service.GetBlockTransactions("3dc7a73a3e27384cfc4b0d01045e072a1c80fdd9ca628a3f03ebe51e4028158a");
			Assert.NotNull(result);
		}
	}
}
