namespace Chess.chessboard;

public class Position(int line, int column) {
    private int line { get; set; } = line;
    private int column { get; set; } = column;

    public override string ToString()
    {
        return $"{line} ,{column}";
    }
}