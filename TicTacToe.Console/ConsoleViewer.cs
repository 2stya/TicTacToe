﻿using System.Linq;

namespace TicTacToe.Console
{
    public class ConsoleViewer : IViewer
    {
        public string PrepareStringToDrawField(Field field)
        {
            string[] marksOnField = field.GetAllMarksOnField()
                .Select(i => i.ToString().Replace("Empty", " "))
                .ToArray();
            
            return "┌-┬-┬-┐\n" +
                    $"|{marksOnField[0]}|{marksOnField[1]}|{marksOnField[2]}|\n" +
                    "├-----┤\n" + 
                    $"|{marksOnField[3]}|{marksOnField[4]}|{marksOnField[5]}|\r\n" +
                    "├-----┤\n" +
                    $"|{marksOnField[6]}|{marksOnField[7]}|{marksOnField[8]}|\r\n" +
                    "└-┴-┴-┘";
        }

        public virtual void DrawField(Field field)
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

        public virtual void ShowLogo()
        {
            System.Console.Clear();
            System.Console.WriteLine(PrepareStringToDrawLogo());
            System.Console.Read();
        }

        public string PrepareStringToDrawUserInstructions()
        {
            return " 1|2|3\r\n -----\r\n 4|5|6\r\n -----\r\n 7|8|9";
        }

        public virtual void DrawUserInstructions()
        {
            System.Console.WriteLine(PrepareStringToDrawUserInstructions());
        }
    }
}