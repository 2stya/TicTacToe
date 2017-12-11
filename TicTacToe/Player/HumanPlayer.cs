using System;

namespace TicTacToe.Player
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(MarkType markType) : base(markType)
        {
            if (markType == MarkType.Empty)
            {
                throw new ArgumentException("HumanPlayer can be created only with X or O MarkType parameter");
            }
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
