using TicTacToe.Console;
using Xunit;

namespace TicTacToe.Tests
{
    public class GameTests
    {
        private IViewer _renderer;

        public GameTests()
        {
            _renderer = new ConsoleViewer();
        }
        [Fact]
        public void Game_OnCreation_ContainsFieldWithSideSizeEqual3()
        {
            // Arrange
            IViewer viewer = null;
            
            // Act
            Game game = new Game(viewer);

            // Assert
            Field field = game.Field;
            Assert.Equal(3, field.SideSize);
        }

        [Fact]
        public void Game_OnCreation_ContainsTwoPlayers()
        {
            // Act
            Game game = new Game(_renderer);

            // Assert
            Assert.Equal(2, game.Players.Count);
        }
    }
}
