using Chess.chessboard;
using Chess.layers;
using chessboard;

namespace Chess {
    internal abstract class Program {
        private static void Main() {
            var chessboard = new Chessboard(8, 8);
            chessboard.PutPiece(new Tower(chessboard,Color.black), 
                                new Position(1,3));
            chessboard.PutPiece(new King(chessboard,Color.black), 
                                new Position(0,0));
            Screen.PrintChessBoard(chessboard);
            Console.ReadLine();
        }
    }
}
