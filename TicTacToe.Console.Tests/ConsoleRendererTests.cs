using Xunit;

namespace TicTacToe.Console.Tests
{
    public class ConsoleRendererTests
    {
        private readonly ConsoleRendererTestable _renderer;

        public ConsoleRendererTests()
        {
            _renderer = new ConsoleRendererTestable();
        }

        [Fact]
        public void DrawField_OnRun_UseConsoleRenderedField()
        {
            // Arrange
            Field field = new Field(3);

            // Act
            _renderer.DrawField(field);

            // Assert
            Assert.StartsWith("┌-┬-┬-┐", _renderer._fieldRender);
            Assert.EndsWith("└-┴-┴-┘", _renderer._fieldRender);
        }

        private class ConsoleRendererTestable : ConsoleRenderer
        {
            public string _fieldRender;

            protected override string GetFieldRender(Field field)
            {
                _fieldRender = base.GetFieldRender(field);
                return _fieldRender;
            }
        }
    }
}