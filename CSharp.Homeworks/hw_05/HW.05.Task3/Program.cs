long[] myArray = new long[10];
int maxValue = 10;   
Random random = new Random();

//Fill Up Array
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(maxValue);  
    Console.Write(myArray[i] + " | ");
}

//My Reverse Method
Console.WriteLine("\n\n*** My Reverse Method ***\n");

long[] tempArray = new long[myArray.Length];
for (int i = 0; i < myArray.Length; i++)
{
    int index = i + 1;
    tempArray[^index] = myArray[i];
}
for (int i = 0; i < tempArray.Length; i++)
{
    myArray[i] = tempArray[i];
}

foreach (int i in myArray)
{
    Console.Write(i + " | ");   
}    