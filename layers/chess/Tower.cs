
using Chess.layers.chessboard;
using Chess.Enums;


namespace Chess.layers.chess;

public class Tower : Piece{
    public Tower(Chessboard chessboard, Color color) : base(chessboard, color) {
    }

    public override string ToString() => Resources.Translate_Culture.Tower;
    
    private bool Canmove(Position position){
        var piece = Chessboard.Piece(position);
        return piece is null || piece.Color != Color;
    }
    public override bool[,] GetPossibleMovements(){
        var possibleMovements = new bool[Chessboard.Lines, Chessboard.Columns];
        var position = new Position(0, 0);
        
        // Above
        position.DefineValues(position.line-1, position.column);
        while (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;
            if ((Chessboard.Piece(position) != null) && (Chessboard.Piece(position).Color != Color)){
                break;
            }
            position.line -= 1;
        }
        
        // Below 
        position.DefineValues(position.line+1, position.column);
        while (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;
            if ((Chessboard.Piece(position) != null) && (Chessboard.Piece(position).Color != Color)){
                break;
            }
            position.line += 1;
        }
        
        //Right        
        position.DefineValues(position.line, position.column+1);
        while (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;
            if ((Chessboard.Piece(position) != null) && (Chessboard.Piece(position).Color != Color)){
                break;
            }
            position.column += 1;
        }    
        
        //Left        
        position.DefineValues(position.line, position.column-1);
        while (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;
            if ((Chessboard.Piece(position) != null) && (Chessboard.Piece(position).Color != Color)){
                break;
            }
            position.column -= 1;
        }        

        
        
        return possibleMovements;
    }
}