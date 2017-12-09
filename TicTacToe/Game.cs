using System;

namespace TicTacToe
{
    public class Game
    {
        private Field field;

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