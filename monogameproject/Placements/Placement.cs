using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameproject
{
	public abstract class Placement : Card
	{
		private int _x;
		public int X { get { return _x; } set { _x = value; } }
		private int _y;
		public int Y { get { return _y; } set { _y = value; } }

		public Placement(Game game, int c, int[] p) : base(game, c)
		{
			_x = p[0];
			_y = p[1];
		}
	}
}