using TicTacToe.Player;

namespace TicTacToe
{
    public class Game
    {
        protected readonly Field _field;
        private readonly IRenderer _renderer;
        public Players Players { get; }
        const int size = 3;

        public Game(IRenderer renderer)
        {
            _renderer = renderer;

            _field = new Field(size);
            Players = new Players();
            this._renderer = renderer;
        }

        public void StartGame()
        {
            _renderer.DrawLogo();
            _renderer.DrawField(_field);
            _renderer.DrawUserInstructions();
        }
    }
}