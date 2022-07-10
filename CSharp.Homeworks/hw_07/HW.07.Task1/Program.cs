using System.Text;

//data
string text = "1a!2.3!!.. 4.!.?6 7! ..?”";
char[] simbals = text.ToCharArray();
int questIndex = 0;
StringBuilder sb = new StringBuilder();

//parsing logic before a question mark
for (int i = 0; !simbals[i].Equals('?');)
{
    if (!simbals[i].Equals('!') && !simbals[i].Equals('!'))
    {
        sb.Append(simbals[i]);
    }

    i++;
    questIndex = i; 
}

//parsing logic after a question mark
for (int i = questIndex; i < simbals.Length; i++)
{
    if (simbals[i].Equals(' '))
    {
        sb.Append('_');
    }
    else
    {
        sb.Append(simbals[i]);
    }

}

//output
string newText = sb.ToString();
Console.WriteLine(newText);