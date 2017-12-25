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

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnOWinsHorizontallyBottom_ReturnsOWins()
        {
            _field.SetMark(MarkType.O, MarkPlace.BottomLeft);
            _field.SetMark(MarkType.O, MarkPlace.BottomCenter);
            _field.SetMark(MarkType.O, MarkPlace.BottomRight);

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
            _field.SetMark(MarkType.O, MarkPlace.TopLeft);
            _field.SetMark(MarkType.O, MarkPlace.CenterLeft);
            _field.SetMark(MarkType.O, MarkPlace.BottomLeft);

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnXWinsVerticallyCenter_ReturnsXWins()
        {
            _field.SetMark(MarkType.X, MarkPlace.TopCenter);
            _field.SetMark(MarkType.X, MarkPlace.CenterCenter);
            _field.SetMark(MarkType.X, MarkPlace.BottomCenter);

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnOWinsVerticallyRight_ReturnsOWins()
        {
            _field.SetMark(MarkType.O, MarkPlace.TopRight);
            _field.SetMark(MarkType.O, MarkPlace.CenterRight);
            _field.SetMark(MarkType.O, MarkPlace.BottomRight);

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnOWinsDiagonallyRight_ReturnsOWins()
        {
            _field.SetMark(MarkType.O, MarkPlace.TopRight);
            _field.SetMark(MarkType.O, MarkPlace.CenterCenter);
            _field.SetMark(MarkType.O, MarkPlace.BottomLeft);

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void CheckIfGameHasEnded_OnXWinsDiagonallyLeft_ReturnsXWins()
        {
            _field.SetMark(MarkType.X, MarkPlace.TopLeft);
            _field.SetMark(MarkType.X, MarkPlace.CenterCenter);
            _field.SetMark(MarkType.X, MarkPlace.BottomRight);

            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            Assert.Equal(GameStatus.XWins, gameStatus);
        }
    }
}
