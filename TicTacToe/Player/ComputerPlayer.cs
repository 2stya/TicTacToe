using System;

namespace TicTacToe.Player
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(MarkType mark) : base(mark) { }

        public override int GetPlayerChoice()
        {
            return new Random(9).Next();
        }

        public override void MakeAMove(Field field, MarkType markType, MarkPlace markPlace)
        {
            throw new System.NotImplementedException();
        }
    }
}
