namespace TicTacToe
{
    public enum GameStatus
    {
        GameInProgress,
        XWins,
        OWins,
        Draw
    }

    public static class GameStatusChecker
    {
        public static GameStatus CheckIfGameHasEnded(Field field)
        {
            return GameStatus.GameInProgress;
        }
    }
}
