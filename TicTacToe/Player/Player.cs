namespace TicTacToe.Player
{
    public abstract class Player
    {
        private MarkType mark;

        public Player(MarkType markType)
        {
            mark = markType;
        }

        public abstract void MakeAMove(Field field, MarkPlace markPlace);

        public abstract MarkPlace DefinePlayersMove(string userInput);
    }
}