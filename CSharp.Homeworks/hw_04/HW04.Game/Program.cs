char button;

while (true) 
{
    Thread.Sleep(500);

    if (Console.KeyAvailable)
    {
        button = char.ToLower(Console.ReadKey(true).KeyChar);
        switch (button)
        {        
            case 'w':
                Console.WriteLine("\nPressing button: " + button +" >>>>>> Move Up");
                break;
            case 's':
                Console.WriteLine("\nPressing button: " + button + " >>>>>> Move Down");
                break;
            case 'd':
                Console.WriteLine("\nPressing button: " + button + " >>>>>> Move Right");
                break;
            case 'a':
                Console.WriteLine("\nPressing button: " + button + " >>>>>> Move Left");
                break;
            default:
                Console.WriteLine("Not pressing button >>>>>> Idle");
                break;
        }
    }
    else
    {
        Console.WriteLine("Not pressing button >>>>>> Idle");
    }
}