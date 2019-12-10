using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Row
    {
        private List<Cell> listCells = new List<Cell>();

        private int _countOfCells;

        public int CountOfCells
        {
            get
            {
                return _countOfCells;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Count of cells <= 0");
                }
                else
                {
                    _countOfCells = value;
                }
            }
        }

        public bool IsEvenRow { get; set; }

        public Row()
        {
            CountOfCells = 0;
            IsEvenRow = true;
        }

        public Row(int countOfCells, bool isEvenRow)
        {
            CountOfCells = countOfCells;
            IsEvenRow = isEvenRow;
        }

        public void CreateRow()
        {
            if (IsEvenRow)
            {
                for (int index = 0; index < _countOfCells - 1; index++)
                {
                    listCells.Add(new Cell("*"));
                }

                listCells.Add(new Cell(" "));
            }

            if (!IsEvenRow)
            {
                listCells.Add(new Cell(" "));

                for (int index = 1; index < _countOfCells; index++)
                {
                    listCells.Add(new Cell("*"));
                }
            }
        }

        public override string ToString()
        {
            string str = "";

            for(int index = 0; index < listCells.Count; index++)
            {
                if (listCells[index].Symbol != " ")
                {
                    str += listCells[index].Symbol.ToString() + " ";
                }
                else
                {
                    str += listCells[index].Symbol.ToString();
                }
            }

            return str;

        }
    }
}
