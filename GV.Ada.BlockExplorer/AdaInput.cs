using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GV.Ada.BlockExplorer
{
	public class AdaInput
	{
		public string WalletAddress { get; set; }
		public long Amount { get; set; }
	}
}
