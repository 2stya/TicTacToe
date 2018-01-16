using TicTacToe.Player;

namespace TicTacToe
{
    public class Game
    {
        const int size = 3;
        private IViewer _viewer;
        public Field Field { get; }
        public Players Players { get; }

        public Game(IViewer viewer)
        {
            _viewer = viewer;

            Field = new Field(size);
            Players = new Players();
        }

        public void StartGame(IViewer viewer)
        {
            viewer.ShowLogo();

            viewer.DrawField(Field);
            viewer.DrawUserInstructions();
        }
    }
}