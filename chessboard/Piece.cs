using chessboard;

namespace Chess.chessboard;

public class Piece(Position position, Color color, Chessboard chessboard) {
    private Position position { get; set; } = position;
    public Color color { get; protected set; } = color;
    public int AmountOfMovements { get; protected set; } = 0;

    public Chessboard chessboard { get; protected set; } = chessboard;


    public override string ToString()
    {
        return $"Position: {position}, Color: {color}, AmountOfMovements: {AmountOfMovements}";
    }
}