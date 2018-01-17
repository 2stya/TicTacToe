using TicTacToe.Player;

namespace TicTacToe
{
    public class Game
    {
        private readonly Field _field;
        private readonly IViewer _viewer;
        private Player.Player _humanPlayer;

        public Game(IViewer viewer)
        {
            int fieldSideSize = 3;

            _field = new Field(fieldSideSize);
            _humanPlayer = new HumanPlayer(MarkType.X);
            this._viewer = viewer;
        }

        public void StartGame()
        {
            _viewer.ShowLogo();

            _viewer.DrawField(_field);
            _viewer.DrawUserInstructions();
        }
    }
}