namespace Chess.chessboard;

public class Chessboard(int lines, int colmuns) {
    public int lines { get; set; } = lines;
    public int colmuns { get; set; } = colmuns;
    private Piece[,] pieces = new Piece[lines, colmuns];
    public Piece piece(int line, int column) => pieces[line, column];
    public override string ToString() =>  $" Lines:{lines}, " +
                                          $"columns:{colmuns}, " +
                                          $"Pieces:{pieces} ";

}