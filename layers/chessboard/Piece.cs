namespace Chess.chessboard;

public class Piece(Chessboard chessboard, Color color) {
    public Position position { get; set; } = null;
    public Color color { get; protected set; } = color;
    public int AmountOfMovements { get; protected set; } = 0;

    public Chessboard Chessboard { get; protected set; } = chessboard;
    public override string ToString() =>  $"Position: {position}, Color: {color}, AmountOfMovements: {AmountOfMovements}";
    
}