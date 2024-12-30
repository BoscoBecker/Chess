using Chess.Enums;
using Chess.layers.chess;
using Chess.layers.chessboard;

namespace Chess.layers.engine;

public class ChessGame{
    private int Turn = 0;
    private Color CurrentPlayer;
    public Chessboard Chessboard{ get; private set; }

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
        Chessboard.PutPiece(new Tower(Chessboard, Color.Black), new PositionChess('C',1).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.Black), new PositionChess('C',2).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.Black), new PositionChess('D',2).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.Black), new PositionChess('E',2).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.Black), new PositionChess('E',1).toPosition());
        Chessboard.PutPiece(new King(Chessboard,  Color.Black), new PositionChess('D',1).toPosition());
        
        Chessboard.PutPiece(new Tower(Chessboard, Color.White), new PositionChess('C',7).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.White), new PositionChess('C',8).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.White), new PositionChess('D',7).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.White), new PositionChess('E',7).toPosition());
        Chessboard.PutPiece(new Tower(Chessboard, Color.White), new PositionChess('E',8).toPosition());
        Chessboard.PutPiece(new King(Chessboard,  Color.White), new PositionChess('D',8).toPosition());

    }

}