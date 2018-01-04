using Xunit;

namespace TicTacToe.Tests
{
    public class GameTests
    {
        [Fact]
        public void Game_OnCreation_ContainsFieldWithSideSizeEqual3()
        {
            IViewer viewer = null;
            
            Game game = new Game(viewer);
            Field field = game.Field;

            Assert.Equal(3, field.SideSize);
        }

        [Fact]
        public void Game_OnCreation_ContainsTwoPlayers()
        {
            IViewer viewer = null;
            
            Game game = new Game(viewer);

            Assert.Equal(2, game.Players.Length);
        }
    }
}
