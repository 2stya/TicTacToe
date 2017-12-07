using System;

namespace TicTacToe
{
    public enum MarkPlace
    {
        TopLeft,
        TopCenter,
        TopRight,
        CenterLeft,
        CenterCenter,
        CenterRight,
        BottomLeft,
        BottomCenter,
        BottomRight
    }

    public enum MarkType
    {
        Empty,
        O,
        X
    }

    public class Field
    {
        private readonly MarkType[] marksOnField;

        public Field()
        {
            marksOnField = new MarkType[9];
            Array.Clear(marksOnField, 0, marksOnField.Length);
        }

        public MarkType[] GetMarksOnField()
        {
            return marksOnField;
        }

        public bool SetMark(MarkType mark, MarkPlace place)
        {
            if (marksOnField[(int) place] == MarkType.Empty)
            {
                marksOnField[(int) place] = mark;
                return true;
            }
            return false;
        }
    }
}