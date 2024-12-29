
namespace Chess.layers.chessboard;

public class Position(int line, int column) {
    public int line { get; set; } = line;
    public int column { get; set; } = column;

    public override string ToString()
    {
        return $"{line} ,{column}";
    }
}