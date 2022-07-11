//data
Random random = new Random();
int maxElements = 10;
int elementCount = 10;

//random array
Console.WriteLine("\nRandom array:");

int[] randomArray = new int[elementCount];

for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = random.Next(maxElements);
    Console.WriteLine(randomArray[i]);
}

//manual array
int[] manualArray = new int[elementCount];
manualArray[0] = 1;
manualArray[1] = 2;
manualArray[2] = 3;
manualArray[3] = 4;
manualArray[4] = 5;
manualArray[5] = 6;
manualArray[6] = 7;

Console.WriteLine("\nManual array:");

for (int i = 0; i < manualArray.Length; i++)
{
    Console.WriteLine(manualArray[i]);
}

//sum array
int[] sumArray = new int[elementCount];

Console.WriteLine("\nSum array:");

for (int i = 0; i < sumArray.Length; i++)
{
    sumArray[i] = randomArray[i] + manualArray[i];
    Console.WriteLine(sumArray[i]);
}