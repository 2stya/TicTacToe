namespace TicTacToe.Console
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IViewer viewer = new ConsoleViewer();
            Game game = new Game(viewer);
        }
    }
}