
namespace Chess.layers.chessboard;

public class Chessboard(int lines, int columns) {
    public int Lines { get; set; } = lines;
    public int Columns { get; set; } = columns;
    private Piece[,] pieces = new Piece[lines, columns];
    public Piece Piece(int line, int column) => pieces[line, column];
    private Piece Piece(Position position) => pieces[position.line, position.column];

    private bool PiecesExists(Position position) { 
        ValidatePosition(position);
        return Piece(position) is not null;
    }
    public void PutPiece(Piece piece, Position position) {
        if (PiecesExists(position)) throw new ChessboardException("There is already a piece in this position!");
        pieces[position.line, position.column] = piece;
        piece.Position = position;
    }
    public Piece RemovePiece(Position position){
        if (Piece(position) is null) return null;
        var currentPiece = Piece(position);
        currentPiece.Position = null;
        pieces[position.line, position.column] = null;
        return currentPiece;
    }
    private bool IsValidPosition(Position position) => position.line >= 0 && position.line < lines &&
                                                       position.column >= 0 && position.column < columns;
    private void ValidatePosition(Position position){
        if (!IsValidPosition(position)) throw new ChessboardException("Invalid position!");
    }
}