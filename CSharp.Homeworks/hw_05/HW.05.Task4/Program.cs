//data
int myNum = 0;
int sum = 0;
bool incorrectData = true;

//input data
while (incorrectData)
{
    Console.Write("Enter, positive number: ");

    if (int.TryParse(Console.ReadLine(), out int num))
    {
        if(num > 0)
        {
            myNum = num;
            incorrectData = false;
        }
        else
        {
            Console.WriteLine("Incorrect number! Number is less zero.");
        }

    }
    else
    {
        Console.WriteLine("Incorrect data!");
    }
}

//logic
for (int i = 0; i <= myNum; i++)
{
    sum += i;
}

Console.WriteLine("Sum of numbers: " + sum );