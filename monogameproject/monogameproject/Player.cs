using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monogameproject
{
	public class Player
	{
		private List<Card> _deck;
		public List<Card> Deck { get { return _deck; } set { _deck = value; } }

		private List<Card> _hand;
		public List<Card> Hand { get { return _hand; } set { _hand = value; } }

		private string _name;
		public string Name { get { return _name; } set { _name = value; } }
	}
}