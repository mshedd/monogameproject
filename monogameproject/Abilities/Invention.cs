using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameproject
{
	public abstract class Invention : Ability
	{
		public Invention(Game game, int c) : base(game, c)
		{

		}
	}
}