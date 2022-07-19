using HW._09.Booking.Com.Models;
using HW._09.Booking.Com.Products;
using static System.Console;

string userName;
string password;
Register register = new();
Book book = new();
Search search = new();
User currentUser;
bool successful = false;

//autorization
do
{
    WriteLine(" *** Enter your account *** ");

    Write("Usre Name: ");
    userName = ReadLine();
    Write("Password: ");
    password = ReadLine();

    if (register.CheckAcaunt(userName))
    {
        if (register.Autorization(userName, password))
        {
            Clear();
            WriteLine("Authorization successful");          
            successful = true;  
        }
        else
        {
            Clear();
            WriteLine("Invalid password\n");
            successful = false;
        }
    }
    else
    {
        Clear();
        WriteLine("[Error]: Invalid name entered or account does not exist!\n");
        WriteLine("Retry login        -> any press key");
        WriteLine("Create an account  -> press Y");

        ConsoleKeyInfo press = ReadKey(true);
        if (press.Key.Equals(ConsoleKey.Y))
        {
            Clear();
            WriteLine("Please, create an account:");
            
            Write("- Usre Name: ");
            userName = ReadLine();
            Write("- Email: ");
            string email = ReadLine();
            Write("- Password: ");
            password = ReadLine();
            Write("- Balance: ");
            double balance;
            while (!(double.TryParse(ReadLine(), out balance)))
            {
                WriteLine("Incorrect data!");
                Write("Please, enter the correct data: ");
            }

            register.Registration(userName, email, password, balance);
            WriteLine("\nRegistration successful!");
            ReadLine();
        }
        Clear();

    }

} while (successful.Equals(false));

currentUser = register.GetUser(userName);

WriteLine($"\nWelcome to Booking {currentUser.Name}");
WriteLine($"Your balance {currentUser.Balance} $");


//choose an apartment
WriteLine("\nChoose an apartment:");
WriteLine("All list -> any press key");
WriteLine("Filtr    -> press Y");

ConsoleKeyInfo pres = ReadKey(true);

if (pres.Key.Equals(ConsoleKey.Y))
{
    int numLoc = default(int);
    Clear();
    WriteLine("Location:");
    WriteLine("Warsaw -> press 1");
    WriteLine("Berlin -> press 2");
    WriteLine("Paris  -> press 3");

    bool correctData;
    do
    {
        correctData = true;

        pres = ReadKey(true);

        switch (pres.KeyChar)
        {
            case '1':
                numLoc = 1;
                break;
            case '2':
                numLoc = 2;
                break;
            case '3':
                numLoc = 3;
                break;
            default:   
                correctData = false;
                break;
        }       
    }
    while (!correctData);

    Clear();
    int numType = default(int);
    WriteLine("Type:");
    WriteLine("Hostel -> press 1");
    WriteLine("Hotel -> press 2");

    correctData = true;
    do
    {
        correctData = true;

        pres = ReadKey(true);

        switch (pres.KeyChar)
        {
            case '1':
                numType = 1;
                break;
            case '2':
                numType = 2;
                break;
            default:
                correctData = false;
                break;
        }
    }
    while (!correctData);
    Clear();
    search.SerchApartament((TypeApartament)numType, (LocationApartament)numLoc);
}
else
{
    Clear();
    search.SerchApartament();
}


int numApartament;
WriteLine("\nChoose an apartment to buy");
Write("Enter apartment number: ");

while (!(int.TryParse(ReadLine(), out numApartament)))
{
    WriteLine("Incorrect data!");
    Write("Please, enter the correct apartament number: ");
}

Clear();

//purchase
currentUser.Pay(book.GetApartaments()[numApartament].Price);

WriteLine("Have you rented an apartment:");
book.GetApartaments()[numApartament].ViewInformation();
WriteLine($"Your current balance: {currentUser.Balance}$");