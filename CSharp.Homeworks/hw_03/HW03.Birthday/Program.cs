Console.WriteLine("I can calculate your age!");
Console.WriteLine();

//Input
Console.WriteLine("What is your year of birth?");
int yearOfBirth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is your month of birth?");
int monthOfBirth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is year now?");
int yearOfNow = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("What is month now?");
int monthOfNow = Convert.ToInt32(Console.ReadLine());

//Logic
int answer = yearOfNow - yearOfBirth;
int age;

if(monthOfNow < monthOfBirth)
{
    age = answer - 1;
}
else 
{
    age = answer ;
}

//Output
Console.WriteLine("You are "+ age +" years old.");