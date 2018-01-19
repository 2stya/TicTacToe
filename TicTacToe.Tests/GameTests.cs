using TicTacToe.Console;
using Xunit;

namespace TicTacToe.Tests
{
    public class GameTests
    {
        private readonly ConsoleViewerSpy _renderer;
        private readonly Game _game;

        public GameTests()
        {
            _renderer = new ConsoleViewerSpy();
            _game = new Game(_renderer);
        }

        [Fact]
        public void Game_OnCreation_ContainsFieldWithSideSizeEqual3()
        {
            // Act
            _game.StartGame();
            int fieldSize = _renderer.FieldSize;

            // Assert
            Assert.Equal(3, fieldSize);
        }

        [Fact]
        public void Game_OnCreation_ContainsTwoPlayers()
        {
            // Assert
            Assert.Equal(2, _game.Players.Count);
        }

        private class ConsoleViewerSpy : ConsoleViewer
        {
            public int FieldSize { get; private set; }

            public override void DrawField(Field field)
            {
                this.FieldSize = field.SideSize;
            }
        }
    }
}
