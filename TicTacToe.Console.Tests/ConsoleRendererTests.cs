﻿using Xunit;

namespace TicTacToe.Console.Tests
{
    public class ConsoleRendererTests
    {
        private readonly ConsoleRenderer _renderer;

        public ConsoleRendererTests()
        {
            _renderer = new ConsoleRenderer();
        }

        [Fact]
        public void PrepareStringToDrawField_OnCreation_ReturnsStringWithTopAndBottomBorders()
        {
            const int fieldSideSize = 3;
            Field field = new Field(fieldSideSize);
            string fieldDrawString = Render.GetFieldRender(field);

            Assert.StartsWith("┌-┬-┬-┐", fieldDrawString);
            Assert.EndsWith("└-┴-┴-┘", fieldDrawString);
        }

        [Fact]
        public void PrepareStringToDrawLogo_OnCreation_ReturnsLogo()
        {
            string actualLogo = Render.GetLogoRender();
            const string expectedLogo = @"  .-----------------------------------------------------------------.
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

            Assert.Equal(expectedLogo, actualLogo);
        }

        [Fact]
        public void PrepareStringToDrawUserInstructions_OnCreation_ReturnsUserInstructions()
        {
            string actualInstructions = Render.GetUserInstructionsRender();
            const string expectedInstructions = @" 1|2|3
 -----
 4|5|6
 -----
 7|8|9";
            Assert.Equal(expectedInstructions, actualInstructions);
        }
    }
}