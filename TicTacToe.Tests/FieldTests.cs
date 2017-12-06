using System.Linq;
using Xunit;

namespace TicTacToe.Tests
{
    public class FieldTests
    {
        private Field _field;
        public FieldTests()
        {
            _field = new Field();
        }

        [Fact]
        public void FieldShouldContain9PlacesForMarks()
        {
            Assert.Equal(9, _field.GetMarksOnField().Length);
        }

        [Fact]
        public void NewFieldShouldHaveOnlyEmptyMarks()
        {
            int emptyMarksCount = _field.GetMarksOnField().Select(i => i == MarkType.Empty).Count();
            Assert.Equal(9, emptyMarksCount);
        }

        [Fact]
        public void SetOToZeroPositionShouldFillTopLeftFieldPlace()
        {
            _field.SetMark(MarkType.O, MarkPlace.TopLeft);

            var fieldWithOneMark = _field.GetMarksOnField();
            Assert.Equal(MarkType.O, fieldWithOneMark[0]);
        }
    }
}
