using System;
using System.ComponentModel;

namespace TicTacToe.Player
{
    public class HumanPlayer : Player
    {
        private readonly MarkType _markType;

        public HumanPlayer(MarkType markType) : base(markType)
        {
            if (markType == MarkType.Empty)
            {
                throw new ArgumentException("HumanPlayer can be created only with X or O MarkType parameter");
            }
            if (!Enum.IsDefined(typeof(MarkType), markType))
                throw new InvalidEnumArgumentException(nameof(markType), (int) markType, typeof(MarkType));

            _markType = markType;
        }

        public override MarkPlace DefinePlayersMove(string userInput)
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
                throw new ArgumentOutOfRangeException("Move can be done only inside of field");
            }

            return (MarkPlace) markPlaceIndex;
        }

        public override void MakeAMove(Field field, MarkPlace markPlace)
        {
            field.SetMark(this._markType, markPlace);
        }

        private string GetHumanChoice()
        {
            return Console.ReadKey(true).ToString();
        }
    }
}
