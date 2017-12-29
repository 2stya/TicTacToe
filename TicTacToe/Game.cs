﻿using TicTacToe.Player;

namespace TicTacToe
{
    public class Game
    {
        private readonly Field _field;
        private Player.Player _humanPlayer;

        public Game(IViewer viewer)
        {
            int fieldSideSize = 3;

            StartGame(viewer);
            _field = new Field(fieldSideSize);
            _humanPlayer = new HumanPlayer(MarkType.X);
        }

        public void StartGame(IViewer viewer)
        {
            viewer.ShowLogo();

            viewer.DrawField(_field);
            viewer.DrawUserInstructions();
        }
    }
}