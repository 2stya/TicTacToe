﻿namespace TicTacToe.Console
{
    public class ConsoleRenderer : IRenderer
    {
        public virtual void DrawField(Field field)
        {
            string stringToDrawField = GetFieldRender(field);
            System.Console.Clear();
            System.Console.WriteLine(stringToDrawField);
        }

        public virtual void DrawLogo()
        {
            System.Console.WriteLine(GetLogoRender());
        }

        public virtual void DrawUserInstructions()
        {
            System.Console.WriteLine(GetUserInstructionsRender());
        }

        protected virtual string GetFieldRender(Field field)
        {
            return RenderFieldTop(field.SideSize) +
                   RenderFieldPlayArea(field) +
                   RenderFieldBottom(field.SideSize);
        }

        private string RenderFieldBottom(int size)
        {
            string fieldBottom = "└";
            for (int i = 0; i < size; i++)
            {
                fieldBottom += "-";

                if (i < size - 1)
                {
                    fieldBottom += "┴";
                }
            }

            return fieldBottom + "┘";
        }

        private string RenderFieldPlayArea(Field field)
        {
            string fieldPlayArea = "";

            int size = field.SideSize;

            for (int i = 0; i < size; i++)
            {
                fieldPlayArea += "|";
                for (int j = 0; j < size; j++)
                {
                    fieldPlayArea += field.GetMark(new MarkPlace(i, j)) == MarkType.Empty ? " " : field.GetMark(new MarkPlace(i, j)).ToString();
                    fieldPlayArea += "|";
                }

                fieldPlayArea += "\n";

                if (i < size - 1)
                {
                    fieldPlayArea += "├-----┤\n";
                }


            }

            return fieldPlayArea;
        }

        private string RenderFieldTop(int size)
        {
            string fieldTop = "┌";
            for (int i = 0; i < size; i++)
            {
                fieldTop += "-";

                if (i < size - 1)
                {
                    fieldTop += "┬";
                }
            }

            return fieldTop + "┐\n";
        }

        protected virtual string GetLogoRender()
        {
            return @"  .-----------------------------------------------------------------.
 /  .-.                                                         .-.  \
|  /   \                                                       /   \  |
| |\_.  |                    TIC TAC TOE                      |    /| |
|\|  | /|                                                     |\  | |/|
| `---' |             Press Enter key to continue...          | `---' |
|       |                                                     |       | 
|       |-----------------------------------------------------|       |
\       |                                                     |       /
 \     /                                                       \     /
  `---'                                                         `---'";
        }

        protected string GetUserInstructionsRender()
        {
            return " 1|2|3\r\n -----\r\n 4|5|6\r\n -----\r\n 7|8|9";
        }
    }
}