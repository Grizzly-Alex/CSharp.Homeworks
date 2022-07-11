#region
//Data
bool incorrectData;
int[] myArray = new int[10];
#endregion

#region
//Input
Console.WriteLine(" *** FIL UP ARRAY *** \n");
for (int i = 0; i < myArray.Length-1; i++)
{
    incorrectData = true;

    while (incorrectData)
    {
        Console.Write("Enter array element at index "+i+": ");

        if (int.TryParse(Console.ReadLine(), out int num))
        {
            myArray[i] = num;
            incorrectData = false;
        }
        else
        {
            Console.WriteLine("Incorrect data!");
        }       
    }
}

//Output
Console.WriteLine("\n *** SHOW ARRAY ELEMENTS *** \n");
foreach (int item in myArray)
{
    Console.Write(" "+item+" | ");
}
#endregion

#region
//Input
Console.WriteLine("\n\n *** ADD NEW ARRAY ELEMENT ***\n");
int newNum = 0;
incorrectData = true;

while (incorrectData)
{
    Console.Write("Give the num: ");

    if (int.TryParse(Console.ReadLine(), out int num))
    {
        newNum = num;
        incorrectData = false;
    }
    else
    {
        Console.WriteLine("Incorrect data!");
    }
}

int index = 0;
incorrectData = true;

while (incorrectData)
{
    Console.Write("Give the index from 0 to " + (myArray.Length-1) + " : ");

    if (int.TryParse(Console.ReadLine(), out int num))
    {
        if(num > (myArray.Length-1) || num < 0)
        {
            Console.WriteLine("Num out of range!");
        }
        else
        {
            index = num;
            incorrectData = false;
        }

    }
    else
    {
        Console.WriteLine("Incorrect data!");
    }
}

//Output
Console.WriteLine("\n *** SHOW ARRAY ELEMENTS *** \n");

int temp = myArray.Length - index;
Array.Copy(myArray, index, myArray, index + 1, temp - 1);
myArray[index] = newNum;

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(" "+myArray[i]+" | ");
}
Console.WriteLine();
#endregion