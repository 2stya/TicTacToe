using System;

namespace TicTacToe.Player
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(MarkType mark) : base(mark) { }

        public override int GetPlayerChoice()
        {
            return int.Parse(Console.ReadKey(true).ToString());
        }
    }
}
