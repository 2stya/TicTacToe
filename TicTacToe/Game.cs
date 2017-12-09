using System;

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
            viewer.ShowLogo();
            viewer.DrawField(field);
            viewer.DrawUserInstructions();
        }
    }
}