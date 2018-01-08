namespace TicTacToe.Console
{
    public class ConsoleRenderer : IRenderer
    {
        public void DrawField(Field field)
        {
            string stringToDrawField = Render.GetFieldRender(field);
            System.Console.Clear();
            System.Console.WriteLine(stringToDrawField);
        }

        public void DrawLogo()
        {
            System.Console.Clear();
            System.Console.WriteLine(Render.GetLogoRender());
            System.Console.Read();
        }

        public void DrawUserInstructions()
        {
            System.Console.WriteLine(Render.GetUserInstructionsRender());
        }
    }
}