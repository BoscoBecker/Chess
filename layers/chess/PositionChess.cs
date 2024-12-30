using Chess.layers.chessboard;

namespace Chess.layers.chess;

public class PositionChess(char column, int line){
    private char column{ get; set; } = column; 
    private int line{ get; set; } = line;
    public override string ToString() => $" {column}{line}";
    public Position toPosition() => new Position(8 -line, column-'A');
}