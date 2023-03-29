public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DrawScreen();
    }

    public static void DrawScreen()
    {
        DrawLine();

        DrawSpace(10);

        DrawLine();
    }

    private static void DrawSpace(int total)
    {
        for (int lines = 0; lines <= total; lines++)
        {
            Console.Write("|");
            for (int i = 0; i < 30; i++)
                Console.Write(" ");
            Console.Write("|");

            BreakLine();
        }
    }

    private static void DrawLine()
    {
        Console.Write("+");
        for (int i = 0; i < 30; i++)
            Console.Write("-");
        Console.Write("+");

        BreakLine();
    }

    private static void BreakLine() => Console.Write(Environment.NewLine);
}
