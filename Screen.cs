using Chess.layers.chessboard;
using Chess.Enums;

namespace Chess;
public abstract class Screen {
    public static void PrintChessboard(Chessboard chessboard) {
        for (var i = 0; i < chessboard.lines; i++) {
            Console.Write( 8 - i + " ");
            for (var j = 0; j < chessboard.Columns; j++){
                if (chessboard.piece(i, j) is null)
                    Console.Write("- ");
                else
                    PrintPiece(chessboard.piece(i,j));
            }
            Console.WriteLine();
        }
        Console.WriteLine("  A B C D E F G H");
    }

    private static void PrintPiece(Piece piece){
        if (piece.Color.Equals(Color.White)){
            Console.Write(piece);
        }
        else{
            var firstConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(piece);
            Console.ForegroundColor = firstConsoleColor;
        }
    }
}