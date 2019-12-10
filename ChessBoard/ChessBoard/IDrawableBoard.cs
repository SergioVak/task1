using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    interface IDrawableBoard
    {
        int CountOfRows { get; }

        Row this[int index] { get; }
    }
}
