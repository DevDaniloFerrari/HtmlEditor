public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());
        HandleMenuOption(option);
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

public static void WriteOptions()
{
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("HTML Editor");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("============");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Select an option");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - New file");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Open");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Exit");
        Console.SetCursorPosition(3, 10);
        Console.Write("Option: ");
    }

    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
            default: Show(); break;
        }
    }
}
