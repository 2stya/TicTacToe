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
        public void MakeAMove_WithFieldAndCenterRightMarkPlacePassed_SetThePlayersMarkToFifthMemberOfFieldNotToOtherPlaces()
        {
            const int size = 3;

            var field = new Field(size);
            var player = new HumanPlayer(MarkType.X);
            var markPlace = new MarkPlace(1, 2);
            var expectedMarks = new[]
            {
                MarkType.Empty, MarkType.Empty, MarkType.Empty,
                MarkType.Empty, MarkType.Empty, MarkType.X,
                MarkType.Empty, MarkType.Empty, MarkType.Empty
            };

            player.MakeAMove(field, player.Mark, markPlace);
            var marks = field.GetAllMarksOnField();

            Assert.Equal(expectedMarks, marks);
        }
    }
}