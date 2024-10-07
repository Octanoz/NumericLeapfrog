using NumericLeapfrog;

while (true)
{
    Title.Print();

    int guesses = 1;
    int targetNumber = Random.Shared.Next(1, 51);
    int currentValue = GuessNumber(guesses);

    while (currentValue < targetNumber - 3)
    {
        Console.WriteLine(
            $"""

            Your guess is currently {currentValue} which is still more than 3 below the mystery number.
            You have made {guesses} {(guesses == 1 ? "guess" : "guesses")}.

            Remember that your next guess will be added to the current guess.
            """);

        currentValue += GuessNumber(guesses);
        guesses++;
    }

    Console.WriteLine((currentValue <= targetNumber) switch
    {
        true => $"\nYOU WIN! The number was {targetNumber}, you had {currentValue} after {guesses} {(guesses == 1 ? "guess" : "guesses")}.",
        false => $"\nSorry, you lose. The number was {targetNumber}, you had {currentValue} after {guesses} {(guesses == 1 ? "guess" : "guesses")}."
    });

    if (Continue() == 'n')
    {
        Console.WriteLine();
        break;
    }

    Console.Clear();
}

int GuessNumber(int guesses)
{
    Span<char> eraseUserInput = stackalloc char[30];
    eraseUserInput[..15].Fill(' ');
    eraseUserInput[15..].Fill('\b');
    
    Console.Write($"Please enter your {(guesses == 1 ? "first" : "next")} guess: ");

    int guess;
    while (!int.TryParse(Console.ReadLine(), out guess))
    {
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.Write($"Please enter a valid, numerically written number: {eraseUserInput}");
    }

    Spinner.Run();

    return guess;
}

char Continue()
{
    ConsoleKeyInfo key;
    do
    {
        Console.Write("\nWould you like to play again? (y/n): ");
        key = Console.ReadKey();
    } while (key.KeyChar is not 'y' and not 'n');

    return key.KeyChar;
}