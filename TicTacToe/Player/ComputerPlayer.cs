namespace TicTacToe.Player
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(MarkType markType) : base(markType)
        {

        }

        public override MarkPlace DefinePlayersMove(string input)
        {
            throw new System.NotImplementedException();
        }

        public override void MakeAMove(Field field, MarkPlace markPlace)
        {
            throw new System.NotImplementedException();
        }
    }
}
