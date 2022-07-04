//data
int firstNum;
int secondNum;
int sumNum;

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
int sum = firstNum + secondNum;

//give answer
Console.Write("Enter the sum of the numbers: ");
while (!(int.TryParse(Console.ReadLine(), out sumNum)))
{
    Console.WriteLine("Incorrect data!");
    Console.Write("Please, enter the correct data: ");
}

//response processing
if (sum.Equals(sumNum))
{
    Console.WriteLine("Answer is correct!");
}
else
{
    Console.WriteLine("Answer is incorrect!");
    Console.WriteLine("Correct answer: " + sum);
}

if (sum > sumNum)
{
    Console.WriteLine("Number is should be more!");
}
else if (sum < sumNum)
{
    Console.WriteLine("Number is should be less!");
}