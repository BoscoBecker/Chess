using Chess.layers.chessboard;
using Chess.Enums;

namespace Chess.layers.chess;

public class King : Piece{
    public King(Chessboard chessboard, Color color) : base(chessboard, color) {
    }
    public override string ToString() => Resources.Translate_Culture.King;

}