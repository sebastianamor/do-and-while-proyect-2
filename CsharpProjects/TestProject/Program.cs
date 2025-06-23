string? readResult;
bool validEntry = false;
int number = 0;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    
    // Primero verifica si es un número
    if (!int.TryParse(readResult, out number))
    {
        Console.WriteLine("Please enter only numbers (digits 0-9)");
        continue;
    }
    
    // Luego verifica el rango
    if (number >= 5 && number <= 10)
    {
        validEntry = true;
        Console.WriteLine($"Great, {number} is a valid input");
    }
    else
    {
        Console.WriteLine($"Sorry, {number} is not between 5 and 10, please try again");
    }
    
} while (!validEntry);