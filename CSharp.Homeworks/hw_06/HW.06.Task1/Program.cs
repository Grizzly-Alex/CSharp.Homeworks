//Data
char oldChar = 'O';
char newChar = 'A';

//Input
Console.WriteLine("Enter the poem on one line. Strings must be split \";\" symbol:");
string? poem = Console.ReadLine();

//Logic
string[]? poemStr = poem?.Split(';');

for (int s = 0; s < poemStr?.Length; s++)
{
    char[] chars = poemStr[s].ToCharArray();

    for (int c = 0; c < chars.Length; c++)
    {
        if (chars[c].Equals(oldChar))
        {
            chars[c] = newChar;
        }
    }
    string changeStr = new string(chars);

    Console.WriteLine(changeStr);   
}