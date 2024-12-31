using Chess.layers.chessboard;
using Chess.layers.engine;
using Chess.layers.Presentation;
using Chess.Resources;

namespace Chess {
    internal abstract class Program {
        private static void Main() {
            try{
                InfoGame.SetScreenWelcomeInfo()
                        .SetScreenCultureLanguage()
                        .StartScreenWithCultureLanguage();
                var chessGame = new ChessGame();
                while (!chessGame.EndGame){
                    Console.Clear();
                    Screen.PrintChessboard(chessGame.Chessboard);
                    Console.WriteLine();
                    
                    Console.Write(Translate_Culture.Source);  
                    
                    var source = Screen.ReadPositionChess().toPosition();
                    Console.Write(Translate_Culture.Destination);
                    
                    var destination = Screen.ReadPositionChess().toPosition();
                    chessGame.ExecuteMovement(source, destination);
                }
            }
            catch (ChessboardException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
