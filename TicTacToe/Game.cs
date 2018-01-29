using TicTacToe.Player;

namespace TicTacToe
{
    public class Game
    {
        private readonly Field _field;
        private readonly IRenderer _renderer;
        public Players Players { get; }
        private const int Size = 3;

        public Game(IRenderer renderer)
        {
            _renderer = renderer;

            _field = new Field(Size);
            Players = new Players();
            _renderer = renderer;
        }

        public void StartGame()
        {
            _renderer.DrawLogo();
            _renderer.DrawField(_field);
            _renderer.DrawUserInstructions();
        }
    }
}