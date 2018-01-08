namespace TicTacToe
{
    public interface IRenderer
    {
        void Draw(Field field);
        void ShowLogo();
        void DrawUserInstructions();
    }
}