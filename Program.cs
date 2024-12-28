using Chess.chessboard;

namespace Chess {
    internal abstract class Program {
        private static void Main() {
            var chessboard = new Chessboard(8, 8);
            Screen.PrintChessBoard(chessboard);
            Console.ReadLine();
        }
    }
}
