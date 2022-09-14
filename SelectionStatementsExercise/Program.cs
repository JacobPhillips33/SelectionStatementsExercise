var r = new Random();
var favNumber = r.Next(1, 1000);

Console.Write("Guess what my favorite number is: ");
var userInput = double.Parse(Console.ReadLine());

while (userInput != favNumber)
{
    var response = userInput > favNumber ? "Too high. Guess again: " : "Too low. Guess again: ";
    Console.Write(response);
    userInput = double.Parse(Console.ReadLine());
}
Console.WriteLine("Great job! You guessed it!");