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
            MarkType[] fieldMarks = field.GetMarksOnField();

            GameStatus status = CheckIfHorizontalLineIsFilled(fieldMarks);


            return GameStatus.GameInProgress;
        }

        private static GameStatus CheckIfHorizontalLineIsFilled(MarkType[] fieldMarks)
        {
            for (int i = 0; i < 3; i++)
            {
                int counterX = 0;
                int counterO = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (fieldMarks[i * 3 + j] == MarkType.X)
                    {
                        counterX++;
                    }
                    else if (fieldMarks[i * 3 + j] == MarkType.O)
                    {
                        counterO++;
                    }
                }

                if (counterX == 3)
                {
                    return GameStatus.XWins;
                }
                else if (counterO == 3)
                {
                    return GameStatus.OWins;
                }
            }

            return GameStatus.GameInProgress;
        }
    }
}
