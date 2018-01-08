namespace TicTacToe
{
    public interface IRenderer
    {
        void DrawField(Field field);
        void DrawLogo();
        void DrawUserInstructions();
    }
}