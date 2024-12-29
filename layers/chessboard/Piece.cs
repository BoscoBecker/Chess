using Chess.Enums;

namespace Chess.layers.chessboard;

public class Piece(Chessboard chessboard, Color color) {
    public Position Position { get; set; } = null;
    public Color Color { get; protected set; } = color;
    public int AmountOfMovements { get; protected set; } = 0;

    public Chessboard Chessboard { get; protected set; } = chessboard;
    public override string ToString() =>  $"Position: {Position}, Color: {Color}, AmountOfMovements: {AmountOfMovements}";
    public bool IsNull() => this == null;
}