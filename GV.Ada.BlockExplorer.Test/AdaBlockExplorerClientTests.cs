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

		[Fact]
		public async void GetEpochPageTest()
		{
			var service = new AdaBlockExplorerClient();
			var result = await service.GetEpochPage(24);
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetLatestBlockTest()
		{
			var service = new AdaBlockExplorerClient();
			var result = await service.GetLatestBlock();
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetSlotCountByEpochTest()
		{
			var service = new AdaBlockExplorerClient();
			var result = await service.GetSlotCountByEpoch(24);
			Assert.Equal(21599, result);
		}

		[Fact]
		public async void GetTransactionTest()
		{
			var service = new AdaBlockExplorerClient();
			var result = await service.GetTransaction("02712610f05e284db32c37eda9c1212f0a719585a0b4f8f822af669eb2b3d384");
			Assert.NotNull(result);
		}



	}
}
