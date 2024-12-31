using System.Globalization;
using Chess.Resources;

namespace Chess.layers.Presentation;

public  class InfoGame{
    public static InfoGame SetScreenWelcomeInfo(){
        Console.WriteLine(@"              Welcome to Chess game                ");
        Console.WriteLine(@"    ______ ___    __  ________  ______  _______    "); 
        Console.WriteLine(@"   /   ____|  |    |  |   _____|/   ___|/   ___|   ");    
        Console.WriteLine(@"   |  |    |  |____|  |  |___  |   (___|   (___    ");
        Console.WriteLine(@"   |  |    |   ____       ___|  \___    \____   \  ");
        Console.WriteLine(@"   |  |____|  |    |  |  |_____ ____)   | |__)  |  ");
        Console.WriteLine(@"   \_______|__|    |__|________|_______/________/   ");
        Console.WriteLine();
        Console.WriteLine(@"-------------------Scroll down !-------------------");
        Console.WriteLine();
        return new InfoGame();
    }
    
    public InfoGame SetScreenCultureLanguage(){
        Console.Write(@"Select the language:  EN=English or PT=Portuguese: ");
        CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(Console.ReadLine()?.ToLowerInvariant() == "pt" ? "pt" : "en");
        Console.WriteLine(Translate_Culture.LanguageSelected, CultureInfo.CurrentUICulture.DisplayName);
        return this;
    }

    public void StartScreenWithCultureLanguage(){
        Console.WriteLine(Translate_Culture.ShowInfo);
    }
}