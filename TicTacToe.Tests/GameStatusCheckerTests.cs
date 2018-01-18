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
            SetRowWith(0, MarkType.X);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnBottomRowFilledWithO_ReturnsOWins()
        {
            // Arrange
            SetRowWith(FieldSize - 1, MarkType.O);

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
            SetColumnWith(0, MarkType.O);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnRightColumnFilledWithX_ReturnsXWins()
        {
            // Arrange
            SetColumnWith(FieldSize - 1, MarkType.X);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnSecondColumnFilledWithO_ReturnsOWins()
        {
            // Arrange
            SetColumnWith(1, MarkType.O);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnMainDiagonalFilledWithO_ReturnsOWins()
        {
            // Arrange
            SetMainDiagonalWith(MarkType.O);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnSecondaryDiagonalFilledWithX_ReturnsXWins()
        {
            // Arrange
            SetSecondaryDiagonalWith(MarkType.X);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        private void SetRowWith(int row, MarkType markType)
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(markType, new MarkPlace(row, i));
            }
        }

        private void SetColumnWith(int column, MarkType markType)
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(markType, new MarkPlace(i, column));
            }
        }

        private void SetMainDiagonalWith(MarkType markType)
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(markType, new MarkPlace(i, i));
            }
        }

        private void SetSecondaryDiagonalWith(MarkType markType)
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(markType, new MarkPlace(FieldSize - 1 - i, i));
            }
        }
    }
}