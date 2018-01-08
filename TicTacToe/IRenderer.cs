namespace TicTacToe
{
    public interface IRenderer
    {
        void Draw(Field field);
        void DrawLogo();
        void DrawUserInstructions();
    }
}