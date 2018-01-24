namespace TicTacToe.Console
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IRenderer viewer = new ConsoleRenderer();
            Game game = new Game(viewer);

            game.StartGame();
        }
    }
}