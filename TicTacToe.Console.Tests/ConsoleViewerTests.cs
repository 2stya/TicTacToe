using Xunit;

namespace TicTacToe.Console.Tests
{
    public class ConsoleViewerTests
    {
        [Fact]
        public void VerifyHeaderAndFooterLookOfField()
        {
            Field field = new Field();
            ConsoleViewer viewer = new ConsoleViewer();
            string fieldDrawString = viewer.PrepareStringToDrawField(field);

            Assert.StartsWith("┌-┬-┬-┐\n", fieldDrawString);
            Assert.EndsWith("└-┴-┴-┘", fieldDrawString);
        }
    }
}
