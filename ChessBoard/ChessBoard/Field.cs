using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    abstract class Field
    {
        protected int Height { get; set; }
        protected int Width { get; set; }

        public Field()
        {
            Height = 0;
            Width = 0;
        }

        public Field(int width, int height)
        {
            Height = height;
            Width = width;
        }
    }
}
