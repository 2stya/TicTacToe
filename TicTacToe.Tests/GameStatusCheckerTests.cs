using Xunit;

namespace TicTacToe.Tests
{
    public class GameStatusCheckerTests
    {
        private readonly Field _field;

        public GameStatusCheckerTests()
        {
            _field = new Field();
        }

        [Fact]
        public void CheckIfGameHasEnded_OnXWinsHorizontallyTop_ReturnsXWins()
        {
            _field.SetMark(MarkType.X, MarkPlace.TopLeft);
            _field.SetMark(MarkType.X, MarkPlace.TopCenter);
            _field.SetMark(MarkType.X, MarkPlace.TopRight);

            GameStatus gameStatus = GameStatusChecker.CheckIfGameHasEnded(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnYWinsHorizontallyBottom_ReturnsOWins()
        {
            _field.SetMark(MarkType.O, MarkPlace.BottomLeft);
            _field.SetMark(MarkType.O, MarkPlace.BottomCenter);
            _field.SetMark(MarkType.O, MarkPlace.BottomRight);

            GameStatus gameStatus = GameStatusChecker.CheckIfGameHasEnded(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnEmptyField_ReturnsGameInProgress()
        {
            GameStatus gameStatus = GameStatusChecker.CheckIfGameHasEnded(_field);

            Assert.Equal(GameStatus.GameInProgress, gameStatus);
        }
    }
}
