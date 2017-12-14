namespace TicTacToe.Player
{
    public abstract class Player
    {
        private MarkType mark;

        public Player(MarkType markType)
        {
            mark = markType;
        }

        public abstract void MakeAMove(MarkPlace markPlace);

        public abstract int DefinePlayersMove();
    }
}