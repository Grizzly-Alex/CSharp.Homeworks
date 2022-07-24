using HW._11.DatabaseOfMotorcycles.Repository;
using HW._11.DatabaseOfMotorcycles.Menu;
using static System.Console;
using Serilog;


Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    //.WriteTo.Console() замутировал вывод лога на консоль, так как это ломает консольное меню. 
    .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Hour)
    .CreateLogger();
Log.Information($"App name: \"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}\"");


Log.Information($"application started at {DateTime.UtcNow}");


MotorcycleRepository repository = new();

Motorcycle harley1 = new("Harley-Davidson", "Livewire");
Motorcycle harley2 = new("Harley-Davidson", "Fat Bob");
Motorcycle harley3 = new("Harley-Davidson", "Nighter");
Motorcycle harley4 = new("Harley-Davidson", "Pan America");
Motorcycle harley5 = new("Harley-Davidson", "Sportster");
Motorcycle harley6 = new("Harley-Davidson", "Street Bob");
Motorcycle harley7 = new("Harley-Davidson", "Low Rider");
Motorcycle harley8 = new("Harley-Davidson", "Glide");
Motorcycle harley9 = new("Harley-Davidson", "Breakout");
Motorcycle harley10 = new("Harley-Davidson", "Road King");
Motorcycle ducati1 = new("Ducati", "Diavel");
Motorcycle ducati2 = new("Ducati", "Hypermotard");
Motorcycle ducati3 = new("Ducati", "Monster");
Motorcycle ducati4 = new("Ducati", "Multistrada");
Motorcycle ducati5 = new("Ducati", "Streetfighter");
Motorcycle ducati6 = new("Ducati", "Superbike");
Motorcycle ducati7 = new("Ducati", "Scrambler");
Motorcycle ducati8 = new("Ducati", "SuperSport");

repository.CreateMotorcycle(
    harley1,
    harley2,
    harley3,
    harley4,
    harley5,
    harley6,
    harley7,
    harley8,
    harley9,
    harley10,
    ducati1,
    ducati2,
    ducati3,
    ducati4,
    ducati5,
    ducati6,
    ducati7,
    ducati8);

Menu menu = new();
Main();

void Main()
{


    //Clear();
    CursorVisible = false;
    
    List<String> strings = new List<string> { "Show all list", "Add motorcycle", "Exit"};
    List<Object> item = new(strings);

    menu.ResetSelectIndex();
    int selected = menu.ShowGraphicSelection(item, "~[DATABAS OF MOTORCYCLES]~\n");

    switch (selected)
    {
        case 0:
            List();
            break;
        case 1:
            CreatedMotorcycle();
            break;
        case 2:
            Clear();
            Log.Information($"Application stoped at {DateTime.UtcNow}");
            Environment.Exit(0);
            break;           
    }
}

void List()
{
    Log.Information("Started the list menu");

    Clear();
    CursorVisible = false;

    List<Object> item = new(repository.GetMotorcycles());
    int selected = menu.ShowGraphicSelection(item, "~[LIST OF MOTORCYCLES]~\n");
    Guid selecetId = repository.GetMotorcycles()[selected].GetId();

    MotoMenu(selecetId);
}

void MotoMenu(Guid id)
{
    Log.Information("Started the action menu");

    Clear();
    CursorVisible = false;
   
    List<String> strings = new List<string> { "Delete motorcycle", "Change motorcycle", "Exit" };
    List<Object> item = new(strings);

    menu.ResetSelectIndex();
    int selected = menu.ShowGraphicSelection(item, "~[ACTION MENU]~\n");
   

    switch (selected)
    {
        case 0:
            Remove(id);
            break;
        case 1:
            ModifyMotocycle(id);
            break;
        case 2:
            Main();
            break;
    }
}

void Remove(Guid id)
{
    Clear();
    CursorVisible = false;

    Write($" Successfully removed: ");
    WriteLine(repository.GetMotorcycleByID(id).ToString());
    repository.DeleteMotorcycle(repository.GetMotorcycleByID(id));
       
    ReadLine();
    Main();
}

void CreatedMotorcycle()
{
    Log.Information("Started the created motorcycle menu");

    Clear();
    CursorVisible = true;
    WriteLine("~[CREATION OF MOTORCYCLE]~\n");

    ForegroundColor = ConsoleColor.Green;
    Write("Name: ");
    string name = ReadLine();
    Write("Model: ");
    string model = ReadLine();
    ResetColor();

    Motorcycle newMotorcycle = new(name, model);
    repository.CreateMotorcycle(newMotorcycle);
    
    Main();
}

void ModifyMotocycle(Guid id)
{
    Log.Information("Started the update motorcycle menu");

    Clear();
    CursorVisible = true;
      
    Motorcycle modifyMoto = repository.GetMotorcycleByID(id);

    WriteLine("~[UPDATE OF MOTORCYCLE]~\n");

    ForegroundColor = ConsoleColor.Yellow;
    WriteLine("Before: " + modifyMoto.ToString() + "\n");


    ForegroundColor = ConsoleColor.Green;

    Write("Name: ");
    string newName = ReadLine();

    if (!newName.Equals(""))
    {
        modifyMoto.Name = newName;
        Log.Information("Changed name");
    }

    Write("Model: ");
    string newModel = ReadLine();
    if (!newModel.Equals(""))
    {
        modifyMoto.Model = newModel;
        Log.Information("Changed model");
    }

    Write("Year: ");
    int newYear;
    if (int.TryParse(ReadLine(), out newYear))
    {
        modifyMoto.Year = newYear;
        Log.Information("Changed yerar");
    }

    Write("Odometer: ");
    int newOdometer;
    if (int.TryParse(ReadLine(), out newOdometer))
    {
        modifyMoto.Odometer = newOdometer;
        Log.Information("Changed odometer");
    }

    repository.UpdateMotorcycle(modifyMoto);

    ForegroundColor = ConsoleColor.Yellow;

    WriteLine("\nAfter: " + modifyMoto.ToString());
    ReadLine();

    ResetColor();

    Main();
}