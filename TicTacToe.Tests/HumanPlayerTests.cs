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
        public void MakeAMove_InOccupiedPlace_ThrowException()
        {
            Field field = new Field();
            HumanPlayer player = new HumanPlayer(MarkType.X);
            player.MakeAMove(MarkPlace.BottomLeft);

            Assert.Throws<ArgumentException>(() => player.MakeAMove(MarkPlace.BottomLeft));
        }
    }
}