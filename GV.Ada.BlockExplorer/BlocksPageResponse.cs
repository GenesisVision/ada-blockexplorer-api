using System.Collections.Generic;

namespace GV.Ada.BlockExplorer
{
	public class BlocksPageResponse
	{
		public List<BlocksPageItem> Items { get; set; }
		public int TotalPages { get; set; }
	}
}
