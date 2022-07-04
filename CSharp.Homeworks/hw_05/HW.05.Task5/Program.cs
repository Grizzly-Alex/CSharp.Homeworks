//data
int myNum = 0;
int showNum = 0;
bool incorrectData = true;

//input data
while (incorrectData)
{
    Console.Write("Enter number in the range of 1 to 100: ");

    if (int.TryParse(Console.ReadLine(), out int num))
    {
        if ((num > 0 && num < 101))
        {
            myNum = num;
            incorrectData = false;
        }
        else
        {
            Console.WriteLine("Incorrect number! Number out of range.");
        }

    }
    else
    {
        Console.WriteLine("Incorrect data!");
    }
}

//output data
Console.WriteLine("\n\t *** Draw a Triangle *** \n");

for (int vert = 0; vert < myNum; vert++)
{
    if (showNum.Equals(9))
    {
        showNum = 0;
    }
    else
    {
        showNum++;
    }   

    for (int horiz = myNum; horiz > vert; horiz--)
    {      
        if (horiz.Equals(vert+1))
        {
            Console.Write(showNum);
        }
        else
        {
            Console.Write(showNum + " ");
        }             
    }

    Console.WriteLine();

    for (int space = vert; space >= 0; space--)
    {
        Console.Write(" ");
    }   
}