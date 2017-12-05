using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public interface IViewer
    {
        void DrawField(Field field);
    }
}
