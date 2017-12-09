using Xunit;

namespace TicTacToe.Console.Tests
{
    public class ConsoleViewerTests
    {
        private ConsoleViewer viewer;

        public ConsoleViewerTests()
        {
            viewer = new ConsoleViewer();
        }

        [Fact]
        public void VerifyHeaderAndFooterLookOfField()
        {
            Field field = new Field();
            string fieldDrawString = viewer.PrepareStringToDrawField(field);

            Assert.StartsWith("┌-┬-┬-┐\n", fieldDrawString);
            Assert.EndsWith("└-┴-┴-┘", fieldDrawString);
        }

        [Fact]
        public void VerifyLogo()
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
    }
}
