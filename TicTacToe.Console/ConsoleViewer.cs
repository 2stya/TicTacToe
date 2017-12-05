using System.Linq;

namespace TicTacToe.Console
{
    public class ConsoleViewer : IViewer
    {
        public ConsoleViewer()
        {
            
        }

        public void DrawField(Field field)
        {
            var marksOnField = field.GetMarksOnField().Select(i => i.ToString().Replace("Empty", " ")).ToArray();

            System.Console.WriteLine("┌-┬-┬-┐");
            System.Console.WriteLine($"|{marksOnField[0]}|{marksOnField[1]}|{marksOnField[2]}|");
            System.Console.WriteLine($"|{marksOnField[3]}|{marksOnField[4]}|{marksOnField[5]}|");
            System.Console.WriteLine($"|{marksOnField[6]}|{marksOnField[7]}|{marksOnField[8]}|");
            System.Console.WriteLine("└-┴-┴-┘");
        }
    }
}
