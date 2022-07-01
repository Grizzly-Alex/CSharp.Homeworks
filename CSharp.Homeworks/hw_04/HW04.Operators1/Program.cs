//data
int firstNum;
int secondNum;

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

//processing and response
int sum = firstNum + secondNum;
Console.WriteLine("Sum: " + sum);