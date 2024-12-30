using Chess.Enums;
using Chess.layers.chess;
using Chess.layers.chessboard;

namespace Chess.layers.engine;

public class ChessGame{
    public Chessboard Chessboard{ get; private set; }
    private int Turn = 0;
    private Color CurrentPlayer;

    public ChessGame(){
        Chessboard = new Chessboard(8,8);
        Turn = 1;
        CurrentPlayer = Color.Black;
        PutPieces();
    }

    public void ExecuteMovement(Position source, Position destination){
        var piece = Chessboard.RemovePiece(source);
        piece.IncAmountOfMovements();
        var currentPiece = Chessboard.RemovePiece(destination);
        Chessboard.PutPiece(piece, destination);
    }

    private void PutPieces(){
        Chessboard.PutPiece(new Tower(Chessboard, Color.White), 
                            new PositionChess('C',1).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.White), 
                            new PositionChess('C',2).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.White), 
                            new PositionChess('D',1).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.White), 
                            new PositionChess('E',1).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.White), 
                            new PositionChess('F',1).toPosition());
    }

}