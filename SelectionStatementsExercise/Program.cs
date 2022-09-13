var r = new Random();
var favNumber = r.Next(1, 1000);
//var favNumber = 33;

Console.Write("Gues what my favorite number is: ");
var userInput = int.Parse(Console.ReadLine());


while (userInput != favNumber)
{
    if (userInput > favNumber)
    {
        Console.Write("Too high. Guess again: ");
        userInput = int.Parse(Console.ReadLine());
    }
    else if (userInput < favNumber)
    {
        Console.Write("Too low. Guess again: ");
        userInput = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("You guessed it!");
