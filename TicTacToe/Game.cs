using TicTacToe.Player;

namespace TicTacToe
{
    public class Game
    {
        private IViewer _viewer;
        public Field Field { get; }
        public Player.Player[] Players { get; }

        public Game(IViewer viewer)
        {
            _viewer = viewer;
            int fieldSideSize = 3;
            
            Field = new Field(fieldSideSize);
            Players = new Player.Player[] {new HumanPlayer(MarkType.X), new HumanPlayer(MarkType.O) };
        }

        public void StartGame(IViewer viewer)
        {
            viewer.ShowLogo();

            viewer.DrawField(Field);
            viewer.DrawUserInstructions();
        }
    }
}