using TicTacToe.Player;

namespace TicTacToe
{
    public class Game
    {
        private IViewer _viewer;
        public Field Field { get; }
        public Players Players { get; }

        public Game(IViewer viewer)
        {
            _viewer = viewer;
            const int size = 3;
            
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