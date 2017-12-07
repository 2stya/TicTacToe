using Xunit;

namespace TicTacToe.Console.Tests
{
    public class ConsoleViewerTests
    {
        [Fact]
        public void VerifyHeaderLookOfField()
        {
            Field field = new Field();
            ConsoleViewer viewer = new ConsoleViewer();
            string fieldDrawString = viewer.PrepareStringToDrawField(field);

            Assert.StartsWith("┌-┬-┬-┐\n", fieldDrawString);
        }
    }
}
