using System;
using System.ComponentModel;

namespace TicTacToe.Player
{
    public abstract class Player
    {
        public MarkType Mark { get; }

        public Player(MarkType mark)
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
    }
}