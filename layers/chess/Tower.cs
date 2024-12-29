using Chess.chessboard;

namespace Chess.layers;

public class Tower : Piece{
    public Tower(Chessboard chessboard, Color color) : base(chessboard, color) {
    }

    public override string ToString() => "T";
}