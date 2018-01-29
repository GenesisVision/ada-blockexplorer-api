using System;
using System.Collections.Generic;
using System.Text;

namespace GV.Ada.BlockExplorer
{
	public interface ICoinInfo
	{
		string GetCoin { get; set; }
		decimal GetAdaLove();
	}
}
