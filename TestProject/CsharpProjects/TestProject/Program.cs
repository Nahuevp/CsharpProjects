/*int readResult;
Console.WriteLine("Enter a number between 5 and 10");
do
{
    readResult = int.Parse(Console.ReadLine());
    if (readResult >= 5 && readResult <= 10)
        Console.WriteLine($"You entered: {readResult}");
    else
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
} while (readResult < 5 || readResult > 10);
*/

/*string roll;
string rollName = "";
do
{
    Console.WriteLine("Enter a valid roll: Administrador, Director, or Usuario");
    roll = Console.ReadLine();
    if (roll != null)
        rollName = roll.Trim();
    if (roll.ToLower() == "administrador" || roll.ToLower() == "director" || roll.ToLower() == "usuario")
        Console.WriteLine($"You entered: {roll}");
    else
        Console.WriteLine("Sorry, you entered an invalid roll, please try again");
} while (roll.ToLower() != "administrador" && roll.ToLower() != "director" && roll.ToLower() != "usuario");
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;
for (int i = 0; i < myStrings.Length; i++)
{
    periodLocation = -1;
    Console.WriteLine($"{i + 1}: {myStrings[i]}");
    do
    {
        periodLocation = myStrings[i].IndexOf('.', periodLocation + 1);
    } while (periodLocation != -1);
}