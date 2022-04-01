/**       
 *--------------------------------------------------------------------
 * 	   File name: Program.cs
 * 	Project name: Lab 6 - Methods
 *--------------------------------------------------------------------
 * Author's name and email:	 Chelsea Mull, mullc1@etsu.edu				
 *          Course-Section: CSCI 1250-002
 *           Creation Date:	 4/1/2022		
 * -------------------------------------------------------------------
 */

static void ShowCharacter()
{
    System.Console.WriteLine("Enter a word(s): ");
    string userWord = Console.ReadLine();

    System.Console.WriteLine("Enter the character position in the word(s) you would like to display: ");
    int index = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine(userWord[index-1]);
}

static void CalculateRetail()
{
    System.Console.WriteLine("Enter item's wholesale cost: ");
    double wholesaleCost = Convert.ToDouble(Console.ReadLine());

    System.Console.WriteLine("Enter item's markup percentage: ");
    double markupPercentage = Convert.ToDouble(Console.ReadLine());

    System.Console.WriteLine($"The item's retail price is ${wholesaleCost+(wholesaleCost*(markupPercentage/100))}");
}

static void Celsius()
{
    double c;

    System.Console.WriteLine("Enter a temperature in Fahrenheit: ");
    double f = Convert.ToDouble(Console.ReadLine());

    for(f=80; f<=100; f++)
    {
        System.Console.WriteLine($"{c=5/9(f-32)}");
    }
}

static void IsPrime()
{
    Console.WriteLine("Enter a number:");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber == 0 || userNumber == 1)
    {
        Console.WriteLine(userNumber + " is not prime number");
        Console.ReadLine();
    }
    else
    {
        for (int a = 2; a <= userNumber / 2; a++)
        {
            if (userNumber % a == 0)
            {
                Console.WriteLine("False");
                return;
            }

        }
        Console.WriteLine("True");
    }
}

ShowCharacter();
CalculateRetail();
Celsius();
IsPrime();
