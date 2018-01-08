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
        public void GetGameStatus_OnTopRowFilledWithX_ReturnsXWins()
        {
            // Arrange
            SetTopRowWithX();

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnBottomRowFilledWith_ReturnsOWins()
        {
            // Arrange
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(FieldSize - 1, i));

            }

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnEmptyField_ReturnsGameInProgress()
        {
            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.GameInProgress, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnLeftColumnFilledWithO_ReturnsOWins()
        {
            // Arrange
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(0, i));
            }

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnRightColumnFilledWithX_ReturnsXWins()
        {
            // Arrange
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.X, new MarkPlace(1, i));
            }

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnRightColumnFilledWithO_ReturnsOWins()
        {
            // Arrange
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(FieldSize - 1, i));
            }

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnMainDiagonalFilledWithO_ReturnsOWins()
        {
            // Arrange
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.O, new MarkPlace(i, i));
            }

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnSecondaryDiagonalFilledWith_ReturnsXWins()
        {
            // Arrange
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.X, new MarkPlace(FieldSize - 1 - i, i));
            }

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        private void SetTopRowWithX()
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(MarkType.X, new MarkPlace(0, i));
            }
        }
    }
}