using System.Linq.Expressions;
using Chess.layers.chessboard;

namespace Chess.chessboard;

public class Chessboard(int lines, int columns) {
    public int lines { get; set; } = lines;
    public int Columns { get; set; } = columns;
    private Piece[,] pieces = new Piece[lines, columns];
    public Piece piece(int line, int column) => pieces[line, column];
    public Piece piece(Position position) => pieces[position.line, position.column];
    
    /// <summary>
    /// Verifies if there is a piece in the given position of the chessboard.
    /// </summary>
    /// <param name="position">The position of the piece to verify.</param>
    /// <returns>True if there is a piece in this position, false otherwise.</returns>
    /// <exception cref="ChessboardException">When the given position is invalid.</exception>
    private bool piecesExists(Position position) { 
        validatePosition(position);
        return piece(position) != null;
    }

    /// <summary>
    /// Places a piece on the board at a given position
    /// </summary>
    /// <param name="piece">The piece to be placed</param>

    /// <exception cref="ChessboardException">If the given position already has a piece</exception>

    public void putPiece(Piece piece, Position position) {
        if (piecesExists(position)) throw new ChessboardException("There is already a piece in this position!");
        pieces[position.line, position.column] = piece;
        piece.position = position;
    }

    /// <summary>
    /// Checks whether a given position is valid on this chessboard.
    /// <para>
    /// A position is valid if it is within the bounds of the board.
    /// </para>
    /// </summary>

    /// <param name="position">The position to check.</param>

    /// <returns><see langword="true"/> if the position is valid, <see langword="false"/> otherwise.</returns>
    private bool isValidPosition(Position position) => position.line >= 0 && position.line < lines &&
                                                       position.column >= 0 && position.column < columns;
    
    /// <summary>
    /// Verifies if the given position is inside the chessboard,
    /// throwing a <see cref="ChessboardException"/> if it is not.
    /// </summary>
    private void validatePosition(Position position){
        if (!isValidPosition(position)) throw new ChessboardException("Invalid position!");
    }
    
}