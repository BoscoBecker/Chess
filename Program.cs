using System.Globalization;
using Chess.layers.chessboard;
using Chess.layers.engine;
using Chess.Resources;

namespace Chess {
    internal abstract partial class Program {
        private static void Main() {
            try{
                Console.Write("Select the language: EN=English or PT=Portuguese: ");
                var language = Console.ReadLine()?.ToLowerInvariant();
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(language == "pt" ? "pt" : "en");
                Console.WriteLine(Translate_Culture.LanguageSelected, CultureInfo.CurrentUICulture.DisplayName);
                
                var ChessGame = new ChessGame(); 
                Screen.PrintChessboard(ChessGame.Chessboard);
            }
            catch (ChessboardException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
