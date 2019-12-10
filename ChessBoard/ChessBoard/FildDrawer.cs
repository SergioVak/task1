using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class FildDrawer
    {
        private IDrawableBoard _fild;
   
        public FildDrawer(IDrawableBoard fild)
        {
            _fild = fild;
        }

        public void DrawChessBoard()
        {
            string board = string.Empty;

            for (int index = 0; index < _fild.CountOfRows; index++)
            {
                board += _fild[index].ToString() + Environment.NewLine;
            }

            Console.WriteLine(board);
        }
    }
}
