using Chess.layers.chessboard;
using Chess.layers.engine;
using Chess.layers.Presentation;

namespace Chess {
    internal abstract class Program {
        private static void Main() {
            try{
                InfoGame.SetCultureLanguage()
                        .ShowInfoCulture();

                var chessGame = new ChessGame();
                Screen.PrintChessboard(chessGame.Chessboard);
            }
            catch (ChessboardException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
