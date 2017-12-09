using System.Linq;

using Xunit;

namespace TicTacToe.Tests
{
    public class FieldTests
    {
        private readonly Field _field;

        public FieldTests()
        {
            _field = new Field();
        }

        [Fact]
        public void Field_OnCreation_Contains9PlacesForMarks()
        {
            Assert.Equal(9, _field.GetMarksOnField().Length);
        }

        [Fact]
        public void Field_OnCreation_HaventNonEmptyMarks()
        {
            MarkType[] emptyFieldMarks = _field.GetMarksOnField();

            int notEmptyMarksCount = emptyFieldMarks.Count(type => type != MarkType.Empty);

            Assert.Equal(0, notEmptyMarksCount);
        }

        [Fact]
        public void SetMark_OmarkToTopLeftPosition_OmarkAsFirstFieldElement()
        {
            _field.SetMark(MarkType.O, MarkPlace.TopLeft);

            var fieldWithOneMark = _field.GetMarksOnField();
            Assert.Equal(MarkType.O, fieldWithOneMark[0]);
        }

        [Fact]
        public void SetMark_OnBusyPlace_NotChangeInitialMark()
        {
            _field.SetMark(MarkType.X, MarkPlace.BottomRight);
            _field.SetMark(MarkType.O, MarkPlace.BottomRight);

            var fieldWithMark = _field.GetMarksOnField();
            Assert.Equal(MarkType.X, fieldWithMark[8]);
        }
    }
}
