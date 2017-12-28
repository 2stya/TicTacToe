using System;
using System.Collections.Generic;
using System.Drawing;

namespace TicTacToe
{
    public enum MarkType
    {
        Empty,
        O,
        X
    }

    public class Field
    {
        public MarkType[,] MarksOnField { get; }
        public int SideSize { get; }

        public Field(int sideSize)
        {
            SideSize = sideSize;
            MarksOnField = new MarkType[sideSize, sideSize];
            Array.Clear(MarksOnField, 0, MarksOnField.Length);
        }

        public MarkType GetMark(Point markPlace)
        {
            return MarksOnField[markPlace.X, markPlace.Y];
        }

        public IEnumerable<MarkType> GetHorizontalLineMarkTypes(int lineNumber)
        {
            for (int j = 0; j < SideSize; j++)
            {
                yield return MarksOnField[lineNumber, j];
            }
        }

        public IEnumerable<MarkType> GetVerticalLineMarkTypes(int rowNumber)
        {
            for (int i = 0; i < SideSize; i++)
            {
                yield return MarksOnField[i, rowNumber];
            }
        }

        public IEnumerable<MarkType> GetMainDiagonalLineMarkTypes()
        {
            for (int i = 0; i < SideSize; i++)
            {
                yield return MarksOnField[i, i];
            }
        }

        public IEnumerable<MarkType> GetSecondaryDiagonalLineMarkTypes()
        {
            for (int i = 0; i < SideSize; i++)
            {
                yield return MarksOnField[i, SideSize - 1 - i];
            }
        }

        public IEnumerable<MarkType> GetAllMarksOnField()
        {
            foreach (var mark in MarksOnField)
            {
                yield return mark;
            }
        }

        public bool SetMark(MarkType mark, Point place)
        {
            if (MarksOnField[place.X, place.Y] == MarkType.Empty)
            {
                MarksOnField[place.X, place.Y] = mark;
                return true;
            }
            return false;
        }
    }
}