namespace NumericLeapfrog;
internal static class Title
{
    public static void Print()
    {
        Console.WriteLine("".PadLeft(10) + "╔".PadRight(70, '═') + "╗");
        Console.WriteLine("{0, 11}" + "{1, 70}", "║", "║");
        Console.WriteLine("{0, 11}" + "\t\tNumeric Leapfrog - A Number Guessing Game".PadRight(58) + "║", "║");
        Console.WriteLine("{0, 11}" + "{1, 70}", "║", "║");
        Console.WriteLine("{0, 11}" + "\t\tGet close to the number without going over".PadRight(58) + "║", "║");
        Console.WriteLine("{0, 11}" + "\t\tEach guess is added to the previous guesses.".PadRight(58) + "║", "║");
        Console.WriteLine("{0, 11}" + "{1, 70}", "║", "║");
        Console.WriteLine("{0, 11}" + "\t\tWin when you are within three below the number.".PadRight(58) + "║", "║");
        Console.WriteLine("{0, 11}" + "\t\tLose when you go over the number.".PadRight(58) + "║", "║");
        Console.WriteLine("{0, 11}" + "{1, 70}", "║", "║");
        Console.WriteLine("{0, 11}{2, 60}{1, 10}", "║", "║", "The number to guess is going to be between 1 and 50.");
        Console.WriteLine("{0, 11}" + "\tGet close in as few guesses as possible without going over.".PadRight(65) + "║", "║");
        Console.WriteLine("{0, 11}" + "{1, 70}", "║", "║");
        Console.WriteLine("".PadLeft(10) + "╚".PadRight(70, '═') + "╝");
        Console.WriteLine("\n");
    }
}
