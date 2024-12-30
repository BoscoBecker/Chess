using System.Globalization;
using Chess.Resources;

namespace Chess.layers.Presentation;

public  class InfoGame{
    public static InfoGame SetCultureLanguage(){
        Console.Write(@"  Welcome to Chess game  ");
        Console.Write(@" 🇺🇸/🇧🇷 Select the language:  EN=English or PT=Portuguese: ");
        var language = Console.ReadLine()?.ToLowerInvariant();
        CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(language == "pt" ? "pt" : "en");
        Console.WriteLine(Translate_Culture.LanguageSelected, CultureInfo.CurrentUICulture.DisplayName);
        return new InfoGame();
    }

    public void ShowInfoCulture(){
        Console.WriteLine(Translate_Culture.ShowInfo);
    }
}