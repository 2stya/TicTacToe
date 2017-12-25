using System;
using System.ComponentModel;

namespace TicTacToe.Player
{
    public abstract class Player
    {
        public MarkType Mark { get; }

        protected Player(MarkType mark)
        {
            if (mark == MarkType.Empty)
            {
                throw new ArgumentException("HumanPlayer can be created only with X or O Mark parameter");
            }
            if (!Enum.IsDefined(typeof(MarkType), mark))
                throw new InvalidEnumArgumentException(nameof(mark), (int)mark, typeof(MarkType));

            Mark = mark;
        }

        public abstract int GetPlayerChoice();

        public void MakeAMove(Field field, MarkType markType, MarkPlace markPlace)
        {
            field.SetMark(markType, markPlace);
        }

        public virtual MarkPlace GetMarkPlace(string userInput)
        {
            int markPlaceIndex;

            if (string.IsNullOrWhiteSpace(userInput))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(userInput));
            }

            try
            {
                markPlaceIndex = int.Parse(userInput);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Incorrect input");
            }

            if (markPlaceIndex < 0 || markPlaceIndex > 8)
            {
                throw new ArgumentOutOfRangeException($"Move can be done only inside of field");
            }

            return (MarkPlace)markPlaceIndex;
        }
    }
}