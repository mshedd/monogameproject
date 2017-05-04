using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameproject
{
	public class Match : DrawableGameComponent
	{
		private Player[] _players;
		public Player[] Players { get { return _players; } set { _players = value; } }

		private Placement[,] _board;
		public Placement[,] Board { get { return _board; } set { _board = value; } }

		private List<Card> _battleplandeck;
		public List<Card> BattlePlanDeck { get { return _battleplandeck; } set { _battleplandeck = value; } }

		public Match(Game game, Player[] p) : base(game)
		{
			_players = p;
			_board = new Placement[7, 7];
		}
	}
}