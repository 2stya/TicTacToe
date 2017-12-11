using System;
using TicTacToe.Player;
using Xunit;

namespace TicTacToe.Tests
{
    public class HumanPlayerTests
    {
        [Fact]
        public void HumanPlayer_OnCreationWithEmptyMarkPassed_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => new HumanPlayer(MarkType.Empty));
        }
    }
}
