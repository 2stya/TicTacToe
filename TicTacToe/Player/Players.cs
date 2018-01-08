namespace TicTacToe.Player
{
    public class Players
    {
        private readonly Player[] _players;
        internal Player Player1 => _players[0];
        internal Player Player2 => _players[1];
        public int Count => _players.Length;

        public Players()
        {
            _players = new Player[] {new HumanPlayer(MarkType.X), new HumanPlayer(MarkType.O) };
        }
    }
}