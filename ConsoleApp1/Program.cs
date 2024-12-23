// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, welcome to our  calculator program!");
Console.WriteLine("Please enter the first number: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");

int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the operation you would like to perform: a for addition, s for subtraction, m for multiplication, d for division");

string operation = Console.ReadLine();

if (operation == "a") {
    Console.WriteLine("The result of adding " + firstNumber + " and " + secondNumber + " is " + (firstNumber + secondNumber));
} else if (operation == "s") {
    Console.WriteLine("The result of subtracting " + firstNumber + " and " + secondNumber + " is " + (firstNumber - secondNumber));
} else if (operation == "m") {
    Console.WriteLine("The result of multiplying " + firstNumber + " and " + secondNumber + " is " + (firstNumber * secondNumber));
} else if (operation == "d") {
    Console.WriteLine("The result of dividing " + firstNumber + " and " + secondNumber + " is " + (firstNumber / secondNumber));
} else {
    Console.WriteLine("Invalid operation selected");
}

// Console.ReadKey();