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

        [Fact]
        public void DrawLogo_OnRun_UseConsoleLogoRender()
        {
            // Arrange
            const string expectedLogoRender = @"  .-----------------------------------------------------------------.
 /  .-.                                                         .-.  \
|  /   \                                                       /   \  |
| |\_.  |                    TIC TAC TOE                      |    /| |
|\|  | /|                                                     |\  | |/|
| `---' |             Press Enter key to continue...          | `---' |
|       |                                                     |       | 
|       |-----------------------------------------------------|       |
\       |                                                     |       /
 \     /                                                       \     /
  `---'                                                         `---'";

            // Act
            _renderer.DrawLogo();

            // Assert
            Assert.Equal(expectedLogoRender, _renderer.LogoRender);
        }

        [Fact]
        public void DrawUserInstructions_OnRun_UseConsoleUserInstructionsRender()
        {
            // Arrange
            const string expectedInstructions = @" 1|2|3
 -----
 4|5|6
 -----
 7|8|9";

            // Act
            _renderer.DrawUserInstructions();

            // Assert
            Assert.Equal(expectedInstructions, _renderer.UserInstructionsRender);

        }

        private class ConsoleRendererTestable : ConsoleRenderer
        {
            public string FieldRender { get; private set; }
            public string LogoRender { get; private set; }
            public string UserInstructionsRender { get; private set; }

            protected override string GetFieldRender(Field field)
            {
                FieldRender = base.GetFieldRender(field);
                return FieldRender;
            }

            protected override string GetLogoRender()
            {
                LogoRender = base.GetLogoRender();
                return LogoRender;
            }

            protected override string GetUserInstructionsRender()
            {
                UserInstructionsRender = base.GetUserInstructionsRender();
                return UserInstructionsRender;
            }
        }
    }
}