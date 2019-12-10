using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Info("Start of app!");

            int height = 0;
            int weight = 0;

            if (args.Length == 0)
            {
                Console.WriteLine("Please input height");
                Int32.TryParse(Console.ReadLine(), out height);
                Console.WriteLine("Please input weight");
                Int32.TryParse(Console.ReadLine(), out weight);
            }
            else
            {
                Int32.TryParse(args[0], out height);
                Int32.TryParse(args[1], out weight);
            }

            ChessBoard chessBoard = new ChessBoard(height, weight);

            chessBoard.FillBoard();

            new FildDrawer(chessBoard).DrawChessBoard();

  
        }
    }
}
