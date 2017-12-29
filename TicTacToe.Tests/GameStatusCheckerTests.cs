using Xunit;

namespace TicTacToe.Tests
{
    public class GameStatusCheckerTests
    {
        private const int FieldSideSize = 3;
        private readonly Field _field;

        public GameStatusCheckerTests()
        {
            _field = new Field(FieldSideSize);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnXWinsHorizontallyTop_ReturnsXWins()
        {
            for (int i = 0; i < FieldSideSize; i++)
            {
                _field.SetMark(MarkType.X, new MarkPlace(0, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnOWinsHorizontallyBottom_ReturnsOWins()
        {
            for (int i = 0; i < FieldSideSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(FieldSideSize - 1, i));

            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnEmptyField_ReturnsGameInProgress()
        {
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.GameInProgress, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnOWinsVerticallyLeft_ReturnsOWins()
        {
            for (int i = 0; i < FieldSideSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(0, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnXWinsVerticallySecondRow_ReturnsXWins()
        {
            for (int i = 0; i < FieldSideSize; i++)
            {
                _field.SetMark(MarkType.X, new MarkPlace(1, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnOWinsVerticallyRight_ReturnsOWins()
        {
            for (int i = 0; i < FieldSideSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(FieldSideSize - 1, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnOWinsDiagonallyRight_ReturnsOWins()
        {
            for (int i = 0; i < FieldSideSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(i, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnXWinsDiagonallyLeft_ReturnsXWins()
        {
            for (int i = 0; i < FieldSideSize; i++)
            {
                _field.SetMark(MarkType.X, new MarkPlace(FieldSideSize - 1 - i, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }
    }
}