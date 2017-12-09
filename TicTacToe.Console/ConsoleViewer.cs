using System.Linq;

namespace TicTacToe.Console
{
    public class ConsoleViewer : IViewer
    {
        public ConsoleViewer()
        {
            
        }

        public string PrepareStringToDrawField(Field field)
        {
            var marksOnField = field.GetMarksOnField().Select(i => i.ToString().Replace("Empty", " ")).ToArray();
            return "┌-┬-┬-┐\n" +
                    $"|{marksOnField[0]}|{marksOnField[1]}|{marksOnField[2]}|\n" +
                    $"|{marksOnField[3]}|{marksOnField[4]}|{marksOnField[5]}|\n" +
                    $"|{marksOnField[6]}|{marksOnField[7]}|{marksOnField[8]}|\n" +
                    "└-┴-┴-┘";
        }

        public void DrawField(Field field)
        {
            string stringToDrawField = PrepareStringToDrawField(field);
            System.Console.Clear();
            System.Console.WriteLine(stringToDrawField);
        }

        public string PrepareStringToDrawLogo()
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

        public void ShowLogo()
        {
            System.Console.Clear();
            System.Console.WriteLine(PrepareStringToDrawLogo());
            System.Console.Read();
        }

        public string PrepareStringToDrawUserInstructions()
        {
            throw new System.NotImplementedException();
        }

        public void DrawUserInstructions()
        {
            System.Console.WriteLine(PrepareStringToDrawUserInstructions());
        }
    }
}