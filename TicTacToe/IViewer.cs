namespace TicTacToe
{
    public interface IViewer
    {
        void DrawField(Field field);
        void ShowLogo();
        void DrawUserInstructions();
    }
}