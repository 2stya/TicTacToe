using Xunit;

namespace TicTacToe.Tests
{
    public class GameStatusCheckerTests
    {
        private const int FieldSize = 3;
        private readonly Field _field;

        public GameStatusCheckerTests()
        {
            _field = new Field(FieldSize);
        }

        [Fact]
        public void GetGameStatus_OnXWinsHorizontallyTop_ReturnsXWins()
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.X, new MarkPlace(0, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnOWinsHorizontallyBottom_ReturnsOWins()
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(FieldSize - 1, i));

            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnEmptyField_ReturnsGameInProgress()
        {
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.GameInProgress, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnOWinsVerticallyLeft_ReturnsOWins()
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(0, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnXWinsVerticallySecondRow_ReturnsXWins()
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.X, new MarkPlace(1, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnOWinsVerticallyRight_ReturnsOWins()
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(FieldSize - 1, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnOWinsDiagonallyRight_ReturnsOWins()
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(i, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnXWinsDiagonallyLeft_ReturnsXWins()
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.X, new MarkPlace(FieldSize - 1 - i, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }
    }
}