Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
string input1 = Console.ReadLine();
int num1 = int.Parse(input1);

Console.WriteLine("Input the second number:");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userChoice = Console.ReadLine();

if (userChoice == "A" || userChoice == "a")
{
    int result = num1 + num2;
    Console.WriteLine($"{num1} + {num2} = {result}");
    PressToExit();
}

else if (userChoice == "S" || userChoice == "s")
{
    int result = num1 - num2;
    Console.WriteLine($"{num1} - {num2} = {result}");
    PressToExit();
}

else if (userChoice == "M" || userChoice == "m")
{
    int result = num1 * num2;
    Console.WriteLine($"{num1} * {num2} = {result}");
    PressToExit();
}

else
{
    Console.WriteLine("Invalid option");
    PressToExit();
}

Console.ReadKey();

void PressToExit()
{
    Console.WriteLine("Press any key to close");
}