string textReaderResult = "Hello guys from the most popular programming course - C#!";
string[] arrayOfTextResult = textReaderResult.Split(' ');

foreach (string str in arrayOfTextResult)
{
    foreach (char ch in str)
    {
        byte dec = Convert.ToByte(ch);
        string bin = Convert.ToString(ch, 2);

        Console.WriteLine(ch+": "+dec+" -> "+bin);
    }
}