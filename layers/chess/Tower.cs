
using Chess.layers.chessboard;
using Chess.Enums;


namespace Chess.layers.chess;

public class Tower : Piece{
    public Tower(Chessboard chessboard, Color color) : base(chessboard, color) {
    }

    public override string ToString() => Resources.Translate_Culture.Tower;
}