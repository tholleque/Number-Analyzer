// Number Analyzer
Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();
string input = "";

do { 
Console.WriteLine("Please enter a number between 1 and 100:");
int num = int.Parse(Console.ReadLine());

    if (num < 0 || num > 100)
    {
        Console.WriteLine($"Inupt outside of Data Range, {name}!");
    }
    else if (num % 2 == 0)
    {
        if (num <= 24)
        {
            Console.WriteLine($"Even and less than 25, {name}.");
        }
        else if (num >= 26 && num <= 60)
        {
            Console.WriteLine($"Even and between 26 and 60, {name}.");
        }
        else
        {
            Console.WriteLine($"Even and greater than 60, {name}.");
        }
    }
    else
    {
        if (num < 60)
        {
            Console.WriteLine($"Odd and less than 60, {name}.");
        }
        else
        {
            Console.WriteLine($"Odd and greater than 60, {name}.");
        }
    }

    Console.WriteLine("Would you like to continue? y/n");
    input = Console.ReadLine();
    if (input != "y")
    {
        Console.WriteLine("Goodbye!");
    }
} while (input == "y");






