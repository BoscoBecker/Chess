using Chess.Enums;

namespace Chess.layers.chessboard;

public abstract class Piece(Chessboard chessboard, Color color) {
    private int AmountOfMovements { get; set; } = 0;
    public Position Position { get; set; } = null;
    public Color Color { get; protected set; } = color;
    public Chessboard Chessboard { get; protected set; } = chessboard;
    public override string ToString() =>  $"Position: {Position}, Color: {Color}, AmountOfMovements: {AmountOfMovements}";
    public bool IsNull() => this == null;
    public void IncAmountOfMovements() => AmountOfMovements++;
    public abstract bool[,] GetPossibleMovements();
}