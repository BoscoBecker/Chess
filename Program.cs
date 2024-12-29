using System.Globalization;
using Chess.Enums;
using Chess.layers.chess;
using Chess.layers.chessboard;


namespace Chess {
    internal abstract partial class Program {
        private static void Main() {
            try{
                Console.WriteLine("Select the language: EN=English or PT=Portuguese");
                var language = Console.ReadLine()?.ToLowerInvariant();
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(language == "pt" ? "pt" : "en");

                var chessboard = new Chessboard(8, 8);
                chessboard.putPiece(new Tower(chessboard,Color.Black), 
                                    new Position(1,3));
                chessboard.putPiece(new King(chessboard,Color.White), 
                                    new Position(1,4));
                chessboard.putPiece(new Tower(chessboard,Color.Black), 
                                    new Position(4,2));
                Screen.PrintChessboard(chessboard);
                
            }
            catch (ChessboardException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
