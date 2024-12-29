using Chess.chessboard;

namespace Chess.layers;

public class PositionChess(char column, int line){
    private char column{ get; set; } = column; 
    private int line{ get; set; } = line;
    public override string ToString() => $" {column}{line}";
    public Position toPosition() => new Position(8 -line, column-'a');
}