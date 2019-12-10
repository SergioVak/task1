using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Cell
    {
        public string Symbol { get; set; } 

        public Cell()
        {
            Symbol = "*";
        }

        public Cell(string symbol)
        {
            Symbol = symbol;
        }


    }
}
