//data
int firstNum;
int secondNum;
int result;
int answer = 0;
bool correctData;
ConsoleKeyInfo cki;

//manual data input
Console.Write("Enter the first number: ");
while (!(int.TryParse(Console.ReadLine(), out firstNum)))
{
    Console.WriteLine("Incorrect data!");
    Console.Write("Please, enter the correct data: ");
}

Console.Write("Enter the second number: ");
while (!(int.TryParse(Console.ReadLine(), out secondNum)))
{
    Console.WriteLine("Incorrect data!");
    Console.Write("Please, enter the correct data: ");
}

//processing
do
{
    correctData = true;

    Console.Write("Enter the operator + or - : ");
    cki = Console.ReadKey();

    switch (cki.KeyChar)
    {
        case '+':
            answer = firstNum + secondNum;
            break;

        case '-':
            answer = firstNum - secondNum;
            break;

        default:
            Console.WriteLine();
            Console.WriteLine("Incorrect data!");
            correctData = false;
            break;
    }
}
while (!correctData);

//give answer
Console.WriteLine();
Console.Write($"\nGive answer: {firstNum} {cki.KeyChar} {secondNum} = ");

while (!(int.TryParse(Console.ReadLine(), out result)))
{
    Console.WriteLine("Incorrect data!");
    Console.Write("Please, enter the correct data: ");
}

//response processing
if (answer == result)
{
    Console.WriteLine("Answer is correct!");
}
else
{
    Console.WriteLine("Answer is incorrect!");
    Console.WriteLine("Correct answer: " + answer);
}

if (answer > result)
{
    Console.WriteLine("Number is should be more!");
}
else if (answer < result)
{
    Console.WriteLine("Number is should be less!");
}