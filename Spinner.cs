namespace NumericLeapfrog;
internal static class Spinner
{
    public static void Run()
    {
        Span<char> spinPositions = ['/', '-', '\\', '|'];

        Console.Write("\nProcessing...");
        Console.CursorVisible = false;

        int counter = 0;
        while (counter < Random.Shared.Next(10, 30))
        {
            Console.Write(spinPositions[(counter++) & 3] + "\b");
            Thread.Sleep(100);
        }
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.CursorVisible = true;
    }

    public static void Run(int counterMax)
    {
        Span<char> spinPositions = ['/', '-', '\\', '|'];

        Console.Write("\nProcessing...");
        Console.CursorVisible = false;

        int counter = 0;
        while (counter < counterMax)
        {
            Console.Write(spinPositions[(counter++) & 3] + "\b");
            Thread.Sleep(100);
        }
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.CursorVisible = true;
    }
}
