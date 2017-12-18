using System;
using TicTacToe.Player;
using Xunit;

namespace TicTacToe.Tests
{
    public class HumanPlayerTests
    {
        [Fact]
        public void OnCreation_WithEmptyMarkPassed_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => new HumanPlayer(MarkType.Empty));
        }

        [Fact]
        public void DefinePlayersMove_ReceivingSix_ReturnsBottomLeftMarkPlace()
        {
            HumanPlayer player = new HumanPlayer(MarkType.O);

            MarkPlace markPlace = player.DefinePlayersMove("6");

            Assert.Equal(MarkPlace.BottomLeft, markPlace);
        }
    }
}