using System;

namespace TicTacToe.Player
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(MarkType markType) : base(markType)
        {
            if (markType == MarkType.Empty)
            {
                throw new ArgumentException("HumanPlayer can be created only with X or O MarkType parameter");
            }
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
            throw new NotImplementedException();
        }

        private string GetHumanChoice()
        {
            return Console.ReadKey(true).ToString();
        }
    }
}
