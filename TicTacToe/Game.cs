using System;
using System.Collections;
using System.Linq;

namespace TicTacToe
{
    public class Game
    {
        public Field field;
        public IViewer viewer;

        public Game(IViewer viewer)
        {
            field = new Field();

            StartGame(viewer);
        }

        public void StartGame(IViewer viewer)
        {
            Console.WriteLine("Field:");
            viewer.DrawField(field);
        }
    }
}