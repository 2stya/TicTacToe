using Xunit;

namespace TicTacToe.Console.Tests
{
    public class ConsoleRendererTests
    {
        private readonly ConsoleRenderer _renderer;

        public ConsoleRendererTests()
        {
            _renderer = new ConsoleRenderer();
        }

//        [Fact]
//        public void GetFieldRender_OnCreation_ReturnsStringWithTopAndBottomBorders()
//        {
//            const int size = 3;
//            Field field = new Field(size);
//            string fieldDrawString = Render.GetFieldRender(field);

//            Assert.StartsWith("┌-┬-┬-┐", fieldDrawString);
//            Assert.EndsWith("└-┴-┴-┘", fieldDrawString);
//        }

//        [Fact]
//        public void GetLogoRender_OnCreation_ReturnsLogo()
//        {
//            string actualLogo = Render.GetLogoRender();
//            const string expectedLogo = @"  .-----------------------------------------------------------------.
// /  .-.                                                         .-.  \
//|  /   \                                                       /   \  |
//| |\_.  |                    TIC TAC TOE                      |    /| |
//|\|  | /|                                                     |\  | |/|
//| `---' |             Press Enter key to continue...          | `---' |
//|       |                                                     |       | 
//|       |-----------------------------------------------------|       |
//\       |                                                     |       /
// \     /                                                       \     /
//  `---'                                                         `---'";

//            Assert.Equal(expectedLogo, actualLogo);
//        }

//        [Fact]
//        public void GetUserInstructionsRender_OnCreation_ReturnsUserInstructions()
//        {
//            string actualInstructions = Render.GetUserInstructionsRender();
//            const string expectedInstructions = @" 1|2|3
// -----
// 4|5|6
// -----
// 7|8|9";
//            Assert.Equal(expectedInstructions, actualInstructions);
//        }
    }
}