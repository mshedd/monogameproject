﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monogameproject
{
	public abstract class Placement : Card
	{
		private int _x;
		public int X { get { return _x; } set { _x = value; } }
		private int _y;
		public int Y { get { return _y; } set { _y = value; } }
	}
}