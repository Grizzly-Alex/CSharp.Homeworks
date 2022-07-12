//Data
int numRound = 2;


Console.WriteLine("I can calculate the root of a quadratic equation ax*x + bx + c = 0");


// Input
Console.Write("Enter value a: ");
double a = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter value b: ");
double b = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter value c: ");
double c = Convert.ToSingle(Console.ReadLine());


//Logic
double discrim = b * b - 4 * a * c;
Console.WriteLine("discriminante: " + discrim);

double rootOfDiscrim=Convert.ToSingle(Math.Sqrt(discrim));


if (discrim < 0)
{
    Console.WriteLine("No roots.");
}
else if (discrim.Equals(0))
{
    double x1 = (-b + rootOfDiscrim) / (2 * a);
    Console.WriteLine("Root equals: " + Math.Round(x1, numRound));
}
else if (discrim > 0)
{

    double x1 = (-b + rootOfDiscrim) / (2 * a);
    double x2 = (-b - rootOfDiscrim) / (2 * a);

    Console.WriteLine("First root equals: " + Math.Round(x1, numRound));
    Console.WriteLine("Second root equals: " + Math.Round(x2, numRound));
}