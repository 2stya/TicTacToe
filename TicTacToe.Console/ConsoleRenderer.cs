namespace TicTacToe.Console
{
    public class ConsoleRenderer : IRenderer
    {
        public virtual void DrawField(Field field)
        {
            string stringToDrawField = Render.GetFieldRender(field);
            System.Console.Clear();
            System.Console.WriteLine(stringToDrawField);
        }

        public virtual void DrawLogo()
        {
            System.Console.Clear();
            System.Console.WriteLine(Render.GetLogoRender());
            System.Console.Read();
        }

        public virtual void DrawUserInstructions()
        {
            System.Console.WriteLine(Render.GetUserInstructionsRender());
        }
    }
}