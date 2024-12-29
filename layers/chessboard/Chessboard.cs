
namespace Chess.layers.chessboard;

public class Chessboard(int lines, int columns) {
    public int lines { get; set; } = lines;
    public int Columns { get; set; } = columns;
    private Piece[,] pieces = new Piece[lines, columns];
    public Piece piece(int line, int column) => pieces[line, column];
    public Piece piece(Position position) => pieces[position.line, position.column];

    private bool piecesExists(Position position) { 
        validatePosition(position);
        return piece(position) != null;
    }

    public void putPiece(Piece piece, Position position) {
        if (piecesExists(position)) throw new ChessboardException("There is already a piece in this position!");
        pieces[position.line, position.column] = piece;
        piece.Position = position;
    }

    private bool isValidPosition(Position position) => position.line >= 0 && position.line < lines &&
                                                       position.column >= 0 && position.column < columns;
    private void validatePosition(Position position){
        if (!isValidPosition(position)) throw new ChessboardException("Invalid position!");
    }
    
}