using TicTacToe.Player;

namespace TicTacToe
{
    public class Game
    {
        private readonly Field _field;
        private Player.Player _humanPlayer;

        public Game(IViewer viewer)
        {
            StartGame(viewer);

            _field = new Field(3);
            _humanPlayer = new HumanPlayer(MarkType.X);
        }

        public void StartGame(IViewer viewer)
        {
            viewer.ShowLogo();

            viewer.DrawField(_field);
            viewer.DrawUserInstructions();
        }
    }
}