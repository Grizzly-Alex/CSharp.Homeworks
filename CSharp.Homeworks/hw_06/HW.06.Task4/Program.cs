using System.Globalization;
using System.Text;


CultureInfo polandCulture = new CultureInfo("en-PL");
CultureInfo chinaCulture = new CultureInfo("en-CN");
CultureInfo britanianCulture = new CultureInfo("en-GB");
CultureInfo hollandCulture = new CultureInfo("en-US");
CultureInfo italyCulture = new CultureInfo("en-IT");
CultureInfo franceCulture = new CultureInfo("en-FR");
CultureInfo canadaCulture = new CultureInfo("en-CA");
CultureInfo usaCulture = new CultureInfo("en-US");
CultureInfo belarusCulture = new CultureInfo("en-BY");

var cultures = new Dictionary<string, CultureInfo>()
{
    { "Poland", polandCulture},
    { "China", chinaCulture},
    { "Grit Britain", britanianCulture},
    { "Holland", hollandCulture},
    { "Italy", italyCulture},
    { "France", franceCulture},
    { "Canada", canadaCulture},
    { "USA", usaCulture},
    { "Belarus", belarusCulture},
};

DateTime time = DateTime.Now;

Console.OutputEncoding = Encoding.Unicode;


Console.WriteLine("\n*** Using String Format ***\n");

foreach (var cultur in cultures)
{
    CultureInfo.CurrentCulture = cultur.Value;

    string coinStr = 1.ToString("C0");
    string dataStr = String.Format("{0:d} at {0:t}", time);

    string textFormat = String.Format("Date and time format for {0} is “{1}”. The national currency is \"{2}\".", cultur.Key, dataStr, coinStr);

    Console.WriteLine(textFormat);
}


Console.WriteLine("\n*** Using Interpolated Strings ***\n");

foreach (var cultur in cultures)
{
    CultureInfo.CurrentCulture = cultur.Value;

    string coinStr = 1.ToString("C0");
    string dataStr = String.Format("{0:d} at {0:t}", time);

    string textInterpol = $"Date and time format for {cultur.Key} is “{dataStr}”. The national currency is \"{coinStr}\".";

    Console.WriteLine(textInterpol);
}