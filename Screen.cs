using Chess.chessboard;

namespace Chess;

public class Screen {
    public static void PrintChessBoard(Chessboard chessboard) {
        for (var i = 0; i < chessboard.lines; i++) {
            for (var j = 0; j < chessboard.colmuns; j++) {
                // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
                if (chessboard.piece(i, j) is null)
                    Console.Write("- ");
                else
                    Console.Write(chessboard.piece(i,j)+" ");
            }
            Console.WriteLine();
        }    
    }
}