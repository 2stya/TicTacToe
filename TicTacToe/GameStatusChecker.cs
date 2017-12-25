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

            if (status == GameStatus.GameInProgress)
            {
                status = CheckIfVerticalLineIsFilled(fieldMarks);
            }

            return status;
        }

        private static GameStatus CheckIfHorizontalLineIsFilled(MarkType[] fieldMarks)
        {
            for (var i = 0; i < 3; i++)
            {
                var counterX = 0;
                var counterO = 0;
                for (var j = 0; j < 3; j++)
                {
                    switch (fieldMarks[i * 3 + j])
                    {
                        case MarkType.X:
                            counterX++;
                            break;
                        case MarkType.O:
                            counterO++;
                            break;
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

        private static GameStatus CheckIfVerticalLineIsFilled(MarkType[] fieldMarks)
        {
            for (var i = 0; i < 3; i++)
            {
                var counterX = 0;
                var counterO = 0;
                for (var j = 0; j < 3; j++)
                {
                    switch (fieldMarks[j * 3 + i])
                    {
                        case MarkType.X:
                            counterX++;
                            break;
                        case MarkType.O:
                            counterO++;
                            break;
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
