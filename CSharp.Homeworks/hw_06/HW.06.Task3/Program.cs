using System.Text;

//data
StringBuilder sb = new();
string text = "gdfgdf234dg54gf*23oP42";
char[] symbal = text.ToCharArray();
int indOper = 0;
int result = 0;

//search first num and operator
for (int i = 0; !(symbal[i].Equals('*') || symbal[i].Equals('/') || symbal[i].Equals('+') || symbal[i].Equals('-'));)
{   
    if (char.IsDigit(symbal[i]))
    {
        sb.Append(symbal[i]);
    }

    i++;
    indOper = i;
}

char oper = symbal[indOper];
int numFirst = int.Parse(sb.ToString());    
sb.Clear();

//search second num 
for (int i = indOper; i < symbal.Length; i++)
{
    if (char.IsDigit(symbal[i]))
    {
        sb.Append(symbal[i]);
    }   
}

int numSecond = int.Parse(sb.ToString());
sb.Clear();

//operation
switch (oper)
{
    case '+':
        result = numFirst + numSecond;
        break;       
    case '-':
        result = numFirst - numSecond;
        break;
    case '*':
        result = numFirst * numSecond;
        break;
    case '/':
        result = numFirst / numSecond;
        break;
}

//output
Console.WriteLine(numFirst +""+ oper +""+ numSecond + "=" + result);