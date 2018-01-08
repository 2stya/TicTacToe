namespace TicTacToe
{
    public interface IRenderer
    {
        void DrawField(Field field);
        void ShowLogo();
        void DrawUserInstructions();
    }
}