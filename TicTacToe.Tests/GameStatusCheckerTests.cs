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
            SetRowWithMark(0, MarkType.X);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnBottomRowFilledWithO_ReturnsOWins()
        {
            // Arrange
            SetRowWithMark(FieldSize - 1, MarkType.O);

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
            SetColumnWithMark(0, MarkType.O);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnRightColumnFilledWithX_ReturnsXWins()
        {
            // Arrange
            SetColumnWithMark(FieldSize - 1, MarkType.X);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnSecondColumnFilledWithO_ReturnsOWins()
        {
            // Arrange
            SetColumnWithMark(1, MarkType.O);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnMainDiagonalFilledWithO_ReturnsOWins()
        {
            // Arrange
            SetMainDiagonalWithMark(MarkType.O);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.OWins, gameStatus);
        }

        [Fact]
        public void GetGameStatus_OnSecondaryDiagonalFilledWithX_ReturnsXWins()
        {
            // Arrange
            SetSecondaryDiagonalWithMark(MarkType.X);

            // Act
            GameStatus gameStatus = GameStatusChecker.GetGameStatus(_field);

            // Assert
            Assert.Equal(GameStatus.XWins, gameStatus);
        }

        private void SetRowWithMark(int row, MarkType markType)
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(markType, new MarkPlace(row, i));
            }
        }

        private void SetColumnWithMark(int column, MarkType markType)
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(markType, new MarkPlace(i, column));
            }
        }

        private void SetMainDiagonalWithMark(MarkType markType)
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(markType, new MarkPlace(i, i));
            }
        }

        private void SetSecondaryDiagonalWithMark(MarkType markType)
        {
            for (int i = 0; i < FieldSize; i++)
            {
                _field.SetMark(markType, new MarkPlace(FieldSize - 1 - i, i));
            }
        }
    }
}