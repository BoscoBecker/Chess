using Chess.chessboard;
using chessboard;

namespace Chess.layers;

public class King : Piece{
    public King(Chessboard chessboard, Color color) : base(chessboard, color) {
    }

    public override string ToString() => "K";

}