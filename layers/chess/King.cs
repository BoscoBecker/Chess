using Chess.layers.chessboard;
using Chess.Enums;

namespace Chess.layers.chess;

public class King : Piece{
    public King(Chessboard chessboard, Color color) : base(chessboard, color){
    }

    public override string ToString() => Resources.Translate_Culture.King;

    private bool Canmove(Position position){
        var piece = Chessboard.Piece(position);
        return piece is null || piece.Color != Color;
    }

    public override bool[,] GetPossibleMovements(){
        var possibleMovements = new bool[Chessboard.Lines, Chessboard.Columns];
        var position = new Position(0, 0);
        
        // Above
        position.DefineValues(position.line - 1, position.column);
        if (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;
        }   
        //North East
        position.DefineValues(position.line - 1, position.column);
        if (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;
        }
        //Right
        position.DefineValues(position.line - 1, position.column);
        if (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;
        }
        //Southeast
        position.DefineValues(position.line - 1, position.column+1);
        if (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;
        }
        //below
        position.DefineValues(position.line + 1, position.column);
        if (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;
        }        
        //south-west
        position.DefineValues(position.line +1 , position.column-1);
        if (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;
        }
        //left
        position.DefineValues(position.line, position.column-1);
        if (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;        
        } 
        //northwest
        position.DefineValues(position.line+1, position.column-1);
        if (Chessboard.IsValidPosition(position) && Canmove(position)){
            possibleMovements[position.line, position.column] = true;         
        }         
        return possibleMovements;
    }
}