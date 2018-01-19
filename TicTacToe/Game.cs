using TicTacToe.Player;

namespace TicTacToe
{
    public class Game
    {
        private readonly Field _field;
        private readonly IViewer _viewer;
        public Players Players { get; }
        const int size = 3;

        public Game(IViewer viewer)
        {
            _viewer = viewer;

            _field = new Field(size);
            Players = new Players();
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