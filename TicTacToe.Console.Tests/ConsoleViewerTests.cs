using Xunit;

namespace TicTacToe.Console.Tests
{
    public class ConsoleViewerTests
    {
        private readonly ConsoleViewer viewer;

        public ConsoleViewerTests()
        {
            viewer = new ConsoleViewer();
        }

        [Fact]
        public void PrepareStringToDrawField_OnCreation_ReturnsStringWithTopAndBottomBorders()
        {
            const int size = 3;
            Field field = new Field(size);
            string fieldDrawString = viewer.PrepareStringToDrawField(field);

            Assert.StartsWith("┌-┬-┬-┐", fieldDrawString);
            Assert.EndsWith("└-┴-┴-┘", fieldDrawString);
        }

        [Fact]
        public void PrepareStringToDrawLogo_OnCreation_ReturnsLogo()
        {
            string actualLogo = viewer.PrepareStringToDrawLogo();
            string expectedLogo = @"  .-----------------------------------------------------------------.
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
            string actualInstructions = viewer.PrepareStringToDrawUserInstructions();
            string expectedInstructions = @" 1|2|3
 -----
 4|5|6
 -----
 7|8|9";
            Assert.Equal(expectedInstructions, actualInstructions);
        }
    }
}