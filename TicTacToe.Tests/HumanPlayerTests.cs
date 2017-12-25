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

            MarkPlace markPlace = player.GetMarkPlace("6");

            Assert.Equal(MarkPlace.BottomLeft, markPlace);
        }

        [Fact]
        public void MakeAMove_WithFieldAndCenterRightMarkPlacePassed_SetThePlayersMarkToFifthMemberOfFieldNotToOtherPlaces()
        {
            var field = new Field();
            var player = new HumanPlayer(MarkType.X);
            var markPlace = MarkPlace.CenterRight;
            var expectedMarks = new[]
            {
                MarkType.Empty, MarkType.Empty, MarkType.Empty,
                MarkType.Empty, MarkType.Empty, MarkType.X,
                MarkType.Empty, MarkType.Empty, MarkType.Empty
            };

            player.MakeAMove(field, player.Mark, markPlace);
            var marks = field.GetMarksOnField();

            Assert.Equal(expectedMarks, marks);
        }
    }
}