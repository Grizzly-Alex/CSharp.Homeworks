
//Data
int shInt = 1; 
Int32 clrInt = 2;

byte shByte = 1;
Byte clrByte = 2;

char shChar = '1';
Char clrChar = '2';

float shFloat = 1.2f;
Single clrFloat = 2.2f;

double shDouble = 11.3d;
Double clrDouble = 22.6d;

string shString = "any word";
String clrString = "any word";

object shObject = new object();
Object clrObject = new object();


//Output
Console.WriteLine("Int C#: " + shInt.GetType());
Console.WriteLine("Int CLR: " + clrInt.GetType());

Console.WriteLine("Byte C#: " + shByte.GetType());
Console.WriteLine("Byte CLR: " + clrByte.GetType());

Console.WriteLine("Char C#: " + shChar.GetType());
Console.WriteLine("Char CLR: " + clrChar.GetType());

Console.WriteLine("Float C#: " + shFloat.GetType());
Console.WriteLine("Float CLR: " + clrFloat.GetType());

Console.WriteLine("Double C#: " + shDouble.GetType());
Console.WriteLine("Double CLR: " + clrDouble.GetType());

Console.WriteLine("String C#: " + shString.GetType());
Console.WriteLine("String CLR: " + clrString.GetType());

Console.WriteLine("Object C#: " + shObject.GetType());
Console.WriteLine("Object CLR: " + clrObject.GetType());



