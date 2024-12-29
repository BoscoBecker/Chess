using Chess.chessboard;
using Chess.layers;
using Chess.layers.chessboard;
using chessboard;

namespace Chess {
    internal abstract class Program {
        private static void Main() {
            try{
                var chessboard = new Chessboard(8, 8);
                chessboard.putPiece(new Tower(chessboard,Color.black), 
                                    new Position(1,3));
                chessboard.putPiece(new King(chessboard,Color.black), 
                                    new Position(1,3));
                Screen.PrintChessBoard(chessboard);
            }
            catch (ChessboardException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
