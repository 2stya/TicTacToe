using System.Linq;

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
        public static GameStatus GetGameStatus(Field field)
        {
            GameStatus status = GetHorizontalLinesStatus(field);

            if (status == GameStatus.GameInProgress)
            {
                status = GetVerticalLinesStatus(field);
            }

            if (status == GameStatus.GameInProgress)
            {
                status = GetMainDiagonalLineStatus(field);
            }

            if (status == GameStatus.GameInProgress)
            {
                status = GetRightDiagonalLineStatus(field);
            }

            return status;
        }

        private static GameStatus GetHorizontalLinesStatus(Field field)
        {
            for (var i = 0; i < field.SideSize; i++)
            {
                var horizontalLineMarks = field.GetHorizontalLineMarkTypes(i);

                if (horizontalLineMarks.All(m => m == MarkType.O))
                {
                    return GameStatus.OWins;
                }

                if (horizontalLineMarks.All(m => m == MarkType.X))
                {
                    return GameStatus.XWins;
                }
            }

            return GameStatus.GameInProgress;
        }

        private static GameStatus GetVerticalLinesStatus(Field field)
        {
            for (var i = 0; i < field.SideSize; i++)
            {
                var verticalLineMarks = field.GetVerticalLineMarkTypes(i);

                if (verticalLineMarks.All(m => m == MarkType.O))
                {
                    return GameStatus.OWins;
                }

                if (verticalLineMarks.All(m => m == MarkType.X))
                {
                    return GameStatus.XWins;
                }
            }

            return GameStatus.GameInProgress;
        }

        private static GameStatus GetMainDiagonalLineStatus(Field field)
        {
            var mainDiagonalMarks = field.GetMainDiagonalLineMarkTypes();

            if (mainDiagonalMarks.All(m => m == MarkType.O))
            {
                return GameStatus.OWins;
            }

            if (mainDiagonalMarks.All(m => m == MarkType.X))
            {
                return GameStatus.XWins;
            }

            return GameStatus.GameInProgress;
        }

        private static GameStatus GetRightDiagonalLineStatus(Field field)
        {
            var secondaryDiagonalLineMarkTypes = field.GetSecondaryDiagonalLineMarkTypes();

            if (secondaryDiagonalLineMarkTypes.All(m => m == MarkType.O))
            {
                return GameStatus.OWins;
            }

            if (secondaryDiagonalLineMarkTypes.All(m => m == MarkType.X))
            {
                return GameStatus.XWins;
            }

            return GameStatus.GameInProgress;
        }
    }
}