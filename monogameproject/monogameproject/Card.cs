using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monogameproject
{
	public abstract class Card
	{
		private int _cost;
		public int Cost { get { return _cost; } set { _cost = value; } }
	}
}