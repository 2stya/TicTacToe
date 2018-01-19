using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TicTacToe.Tests
{
    public class FieldTests
    {
        private readonly Field _field;

        public FieldTests()
        {
            const int size = 3;
            _field = new Field(size);
        }

        [Fact]
        public void Field_OnCreation_Contains9PlacesForMarks()
        {
            Assert.Equal(9, _field.GetAllMarksOnField().Count());
        }

        [Fact]
        public void Field_OnCreation_HaventNonEmptyMarks()
        {
            IEnumerable<MarkType> emptyFieldMarks = _field.GetAllMarksOnField();

            int notEmptyMarksCount = emptyFieldMarks.Count(type => type != MarkType.Empty);

            Assert.Equal(0, notEmptyMarksCount);
        }

        [Fact]
        public void SetMark_OmarkToTopLeftPosition_OmarkAsFirstFieldElement()
        {
            _field.SetMark(MarkType.O, new MarkPlace(0, 0));

            var topLeftPositionMark = _field.GetMark(new MarkPlace(0, 0));
            Assert.Equal(MarkType.O, topLeftPositionMark);
        }

        [Fact]
        public void SetMark_OnBusyPlace_NotChangeInitialMark()
        {
            MarkPlace bottomRightPosition = new MarkPlace(_field.SideSize - 1, _field.SideSize - 1);

            _field.SetMark(MarkType.X, bottomRightPosition);
            _field.SetMark(MarkType.O, bottomRightPosition);

            Assert.Equal(MarkType.X, _field.GetMark(bottomRightPosition));
        }
    }
}