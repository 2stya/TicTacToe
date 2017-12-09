namespace TicTacToe.Player
{
    public abstract class Player
    {
        private MarkType mark;
        public abstract void MakeAMove();

        public Player(MarkType markType)
        {
            mark = markType;
        }
    }
}