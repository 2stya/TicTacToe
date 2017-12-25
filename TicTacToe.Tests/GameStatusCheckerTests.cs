using Xunit;

namespace TicTacToe.Tests
{
    public class GameStatusCheckerTests
    {
        private Field field;

        public GameStatusCheckerTests()
        {
            field = new Field();
        }

        [Fact]
        public void CheckIfGameHasEnded_OnXWinsHorizontallyTop_ReturnsXWins()
        {
            field.SetMark(MarkType.X, MarkPlace.TopLeft);
            field.SetMark(MarkType.X, MarkPlace.TopCenter);
            field.SetMark(MarkType.X, MarkPlace.TopRight);

            var gameStatus = GameStatusChecker.CheckIfGameHasEnded(field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnYWinsHorizontallyBottom_ReturnsOWins()
        {
            field.SetMark(MarkType.O, MarkPlace.BottomLeft);
            field.SetMark(MarkType.O, MarkPlace.BottomCenter);
            field.SetMark(MarkType.O, MarkPlace.BottomRight);

            var gameStatus = GameStatusChecker.CheckIfGameHasEnded(field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnEmptyField_ReturnsGameInProgress()
        {
            var gameStatus = GameStatusChecker.CheckIfGameHasEnded(field);

            Assert.Equal(GameStatus.GameInProgress, gameStatus);
        }
    }
}
