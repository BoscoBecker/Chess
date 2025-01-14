
namespace Chess.layers.chessboard;

public class Position(int line, int column) {
    public int line { get; set; } = line;
    public int column { get; set; } = column;
    public override string ToString() => $"{line} ,{column}";
    public void DefineValues(int line, int column){
        this.line = line;
        this.column = column;
    }

}