using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class ChessBoard : Field, IDrawableBoard
    {
        private List<Row> listRows = new List<Row>();

        public int CountOfRows
        {
            get
            {
                return listRows.Count;
            }
        }

        public Row this[int index]
        {
            get
            {
                return listRows[index];
            }
        }

        public ChessBoard(int height, int width) : base(height, width)
        {
            
        }

        public void FillBoard()
        {
            for(int index = 0; index < Height; index++)
            {
                if (index % 2 == 0)
                {
                    Row row = new Row(Width, true);
                    row.CreateRow();
                    listRows.Add(row);
                }
                else
                {
                    Row row = new Row(Width, false);
                    row.CreateRow();
                    listRows.Add(row);
                }
            }
        }
    }
}
