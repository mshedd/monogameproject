using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameproject
{
	public abstract class Card : DrawableGameComponent
	{
		private int _cost;
		
		public int Cost { get { return _cost; } set { _cost = value; } }

		public Card(Game game, int c) : base(game)
		{
			_cost = c;
		}
	}
}