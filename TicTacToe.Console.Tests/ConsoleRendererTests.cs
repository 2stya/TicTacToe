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
            Assert.StartsWith("┌-┬-┬-┐", _renderer.FieldRender);
            Assert.EndsWith("└-┴-┴-┘", _renderer.FieldRender);
        }

        private class ConsoleRendererTestable : ConsoleRenderer
        {
            public string FieldRender;

            protected override string GetFieldRender(Field field)
            {
                FieldRender = base.GetFieldRender(field);
                return FieldRender;
            }
        }
    }
}