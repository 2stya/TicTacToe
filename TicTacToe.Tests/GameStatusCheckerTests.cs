using System.Drawing;
using Xunit;

namespace TicTacToe.Tests
{
    public class GameStatusCheckerTests
    {
        private readonly Field _field;

        public GameStatusCheckerTests()
        {
            _field = new Field(3);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnXWinsHorizontallyTop_ReturnsXWins()
        {
            for (int i = 0; i < _field.SideSize; i++)
            {
                _field.SetMark(MarkType.X, new Point(0, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnOWinsHorizontallyBottom_ReturnsOWins()
        {
            for (int i = 0; i < _field.SideSize; i++)
            {
                _field.SetMark(MarkType.O, new Point(_field.SideSize - 1, i));

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
            for (int i = 0; i < _field.SideSize; i++)
            {
                _field.SetMark(MarkType.O, new Point(0, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnXWinsVerticallySecondRow_ReturnsXWins()
        {
            for (int i = 0; i < _field.SideSize; i++)
            {
                _field.SetMark(MarkType.X, new Point(1, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnOWinsVerticallyRight_ReturnsOWins()
        {
            for (int i = 0; i < _field.SideSize; i++)
            {
                _field.SetMark(MarkType.O, new Point(_field.SideSize - 1, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnOWinsDiagonallyRight_ReturnsOWins()
        {
            for (int i = 0; i < _field.SideSize; i++)
            {
                _field.SetMark(MarkType.O, new Point(i, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnXWinsDiagonallyLeft_ReturnsXWins()
        {
            for (int i = 0; i < _field.SideSize; i++)
            {
                _field.SetMark(MarkType.X, new Point(_field.SideSize - 1 - i, i));
            }

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }
    }
}