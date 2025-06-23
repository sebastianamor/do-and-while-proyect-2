string? readResult;
bool validEntry = false;
int number = 0 ;
Console.WriteLine(" Enter an integer value between 5 and 10  ");
do
{
    readResult = Console.ReadLine();

    if ( int.TryParse(readResult, out number))
    {
        if (number >= 5 && number <= 10 )
        {
            validEntry = true;
            Console.WriteLine($"great, {number} is good");
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again  ");
        }
    }
} while (validEntry == false);