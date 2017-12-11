using System;

namespace TicTacToe.Player
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(MarkType markType) : base(markType)
        {

        }

        public override void MakeAMove()
        {
            throw new System.NotImplementedException();
        }

        public override int DefinePlayersMove()
        {
            throw new NotImplementedException();
        }
    }
}
