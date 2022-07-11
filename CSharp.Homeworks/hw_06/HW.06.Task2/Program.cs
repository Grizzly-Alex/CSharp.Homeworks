string text = "Britain is an island. We are surrounded by sea. Nowdays, you can get here by plane, or by train through the Channel Tunnel. But before planes were invented, and the Channel Tunnel was built, the only way to come to Britain was by sea.";

Console.WriteLine(" *** Delete longest word ***");
DeleteLongestWord(text);

Console.WriteLine("\n *** Swap long for short ***");
SwapLongForShort(text);

Console.WriteLine("\n *** Symbols counter ***");
SymbolsCounter(text);

Console.WriteLine("\n *** Sorting words ***");
SortingWords(text);



void SortingWords(string text)
{
    string[] strArray = text.Split();
    string temp = string.Empty;

    //sorting longest to shortest
    for (int i = 0; i < strArray.Length; i++)
    {
        for (int j = 0; j < strArray.Length; j++)
        {
            if (strArray[i].Length > strArray[j].Length)
            {
                temp = strArray[i];
                strArray[i] = strArray[j];
                strArray[j] = temp;
            }
        }

    }

    //output
    foreach (var item in strArray)
    {
        Console.WriteLine(item);
    }
}


void SymbolsCounter(string text)
{
    char[] simbols = text.ToCharArray();
    int punctuations = 0;    
    int letters = 0;

    for (int i = 0; i < simbols.Length; i++)
    {
        if (char.IsPunctuation(simbols[i]))
        {
            punctuations++;
        }
        else if (char.IsLetter(simbols[i]))
        {
            letters++;
        }

    }

    Console.WriteLine("Punctuations count: " + punctuations);
    Console.WriteLine("Letters count: " + letters);
} 


void SwapLongForShort(string text)
{
    string[] strArray = text.Split();
    string[] newArray = new string[strArray.Length];
    int minLength = int.MinValue;
    int maxLength = int.MaxValue;
    int longWordIndex = 0;
    int shortWordIndex = 0;

    //long and short word search
    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length < maxLength)
        {
            maxLength = strArray[i].Length;
            longWordIndex = i;
        }

        if (strArray[i].Length > minLength)
        {
            minLength = strArray[i].Length;
            shortWordIndex = i;
        }
    }

    //create new text
    for (int i = 0; i < newArray.Length; i++)
    {

        
        if (i.Equals(longWordIndex))
        {
            newArray[i] = strArray[shortWordIndex];
        }
        else if (i.Equals(shortWordIndex))
        {
            newArray[i] = strArray[longWordIndex];
        }
        else
        {
            newArray[i] = strArray[i];
        }    
        
    }
    
    string newText = string.Join(" ", newArray);

    //console output
    Console.WriteLine("Longest word: "+newArray[longWordIndex]);
    Console.WriteLine("Shortest word: "+newArray[shortWordIndex]);
    Console.WriteLine(newText);
}


void DeleteLongestWord(string text)
{
    string[] strArray = text.Split();
    string longWord = string.Empty;
    int longWordIndex = 0;

    //long word search
    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length > longWord.Length)
        {
            longWord = strArray[i];
            longWordIndex = i;
        }
    }

    //delete a long word
    for (int i = longWordIndex; i < strArray.Length -1; i++)
    {
        strArray[i] = strArray[i + 1];
    }

    string newText = string.Join(" ",strArray);

    //console output
    Console.WriteLine("Delete word: "+longWord);
    Console.WriteLine(newText);
}