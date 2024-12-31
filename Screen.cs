using Chess.layers.chessboard;
using Chess.Enums;
using Chess.layers.chess;

namespace Chess;
public abstract class Screen {
    public static void PrintChessboard(Chessboard chessboard) {
        for (var i = 0; i < chessboard.Lines; i++) {
            Console.Write( 8 - i + " ");
            for (var j = 0; j < chessboard.Columns; j++){
                if (chessboard.Piece(i, j) is null)
                    Console.Write("- ");
                else
                    PrintPiece(chessboard.Piece(i,j));
            }
            Console.WriteLine();
        }
        Console.WriteLine("  A B C D E F G H");
    }

    public static PositionChess ReadPositionChess(){
        var positionReaded = Console.ReadLine();
        var column = positionReaded[0];
        var line = int.Parse(positionReaded[1].ToString());
        return new PositionChess(column, line);
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