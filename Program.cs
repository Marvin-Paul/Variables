/*Console.WriteLine("Hello, World!");
int x;
int y;

x = 7;

y= x + 3;
Console.WriteLine(y);
Console.ReadLine();

Console.WriteLine("What is your name?");
Console.Write("Type Your first name:");
string myFirstName;
myFirstName = Console.ReadLine();
string myLastName;
Console.Write(" Type your LastName");
myLastName = Console.ReadLine();
Console.WriteLine("Hello, " + myFirstName + " " + myLastName         + "!");
Console.ReadLine();
Dicision Making 1

Console.WriteLine("Marvin's Giveaway?");
Console.Write("Choose a door: 1, 2, or 3: ");
string userValue = Console.ReadLine() ?? "";

string message;

if (userValue == "1")

    message = "You won a new car!";

else if (userValue == "2")

    message = "You won a new boat!";

else if (userValue == "3")

    message = "You won a new cat!";

else
{
    message = "Sorry, we didn't understand. You lose!";
}

Console.WriteLine(message);
Console.ReadLine();


Console.WriteLine("Marvin's Giveaway?");
Console.Write("Choose a door: 1, 2, or 3: ");
string userValue = Console.ReadLine();
String message = (userValue == "1") ? "You won a new car!"."Stand of limit";
Console.Write(".");
Console.WriteLine();

// for iteration
for (int i = 0; i < 10; i++)
{
    //Console.WriteLine(i);
    if (i == 5)
    {
        Console.WriteLine("We have reached the number 5");
        break;
    }
}
for (int myValue = 0; myValue  < 12; myValue++)
{
    Console.WriteLine(myValue);
}

int [] number= new int[5];
number[0] = 1; number[1] = 2; number[2] = 3; number[3] = 4; number[4] = 5;
Console.WriteLine(number.Length);
Console.ReadLine();

string[] names = new string[] { "Marvin", "John", "Mary", "Jane" };
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
Console.ReadLine();

foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.ReadLine();


String zig = "Marvin Paul" +
        " is a software developer";
Char[] charArray = zig.ToCharArray();
Array.Reverse(charArray);
foreach (char zigChar in charArray)
{
    Console.Write(zigChar);
}
    Console.ReadLine();


helloWorld();
Console.ReadLine();

 static void helloWorld()
{
    Console.WriteLine("Hello, World!");
}
// Name guessing game

using System;

namespace NameGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of names to randomly pick from
            string[] names = { "Marvin", "Catherine", "Alice", "David", "Emma", "Lucas" };

            // Pick a random name
            Random random = new Random();
            int randomIndex = random.Next(names.Length);
            string secretName = names[randomIndex];

            int attemptsLeft = 3;
            bool hasWon = false;

            Console.WriteLine("=================================");
            Console.WriteLine("  WELCOME TO THE NAME GAME APP   ");
            Console.WriteLine("=================================");
            Console.WriteLine($"Guess the secret name from this list:\n[{string.Join(", ", names)}]\n");

            // Game Loop
            while (attemptsLeft > 0 && !hasWon)
            {
                Console.Write($"Enter your guess ({attemptsLeft} attempts remaining): ");
                string userGuess = Console.ReadLine()?.Trim();

                if (string.Equals(userGuess, secretName, StringComparison.OrdinalIgnoreCase))
                {
                    hasWon = true;
                }
                else
                {
                    attemptsLeft--;
                    if (attemptsLeft > 0)
                    {
                        Console.WriteLine("Incorrect guess! Try again.\n");
                    }
                }
            }

            // Game Result
            Console.WriteLine("\n---------------------------------");
            if (hasWon)
            {
                Console.WriteLine($"🎉 Congratulations! You correctly guessed '{secretName}'!");
            }
            else
            {
                Console.WriteLine($"❌ Game Over! The secret name was '{secretName}'.");
            }
            Console.WriteLine("---------------------------------");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
*/
// While Itteratiion statement

Console.WriteLine("Choose an Option:");
Console.WriteLine("1) Option 1"); 
Console.WriteLine("2) Option 2"); 
Console.WriteLine("3) Exit");
String result = Console.ReadLine();
if (result == "1")
{
}
else if (result == "2")
{
}
else if (result == "3")
{
    Console.WriteLine("Exiting the program...");
    return;
}
else
{
    Console.WriteLine("Invalid option. Please try again.");
}