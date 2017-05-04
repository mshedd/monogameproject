using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameproject
{
	public class Player : DrawableGameComponent
	{
		private List<Card> _deck;
		public List<Card> Deck { get { return _deck; } set { _deck = value; } }

		private List<Card> _hand;
		public List<Card> Hand { get { return _hand; } set { _hand = value; } }

		private string _name;
		public string Name { get { return _name; } set { _name = value; } }

		private int _lumber_count;
		public int Lumber { get { return _lumber_count; } set { _lumber_count = value; } }

		private int _food_count;
		public int Money { get { return _food_count; } set { _food_count = value; } }

		private int _metal_count;
		public int Metal { get { return _metal_count; } set { _metal_count = value; } }

		public Player(Game game) : base(game)
		{

		}
	}
}