public class Rectangle
{
    protected int a; // сторона a
    protected int b; // сторона b
    private readonly int color;

    public Rectangle(int a, int b, int color)
    {
        this.a = a;
        this.b = b;
        this.color = color;
    }

    public void DisplaySides()
    {
        Console.WriteLine($"Сторона a: {a}, сторона b: {b}");
    }

    public int CalculatePerimeter()
    {
        return 2 * (a + b);
    }

    public int CalculateArea()
    {
        return a * b;
    }

    public bool IsSquare()
    {
        return a == b;
    }

    public int SideA
    {
        get { return a; }
        set { a = value; }
    }

    public int SideB
    {
        get { return b; }
        set { b = value; }
    }

    public int Color
    {
        get { return color; }
    }
}
public class Tests
{
    public void RectangleTest()
    {
        Rectangle[] rectangles = new Rectangle[]
{
            new Rectangle(5, 5, 1),  // квадрат
            new Rectangle(3, 4, 2),
            new Rectangle(6, 6, 3),  // квадрат
            new Rectangle(7, 8, 4),
            new Rectangle(10, 10, 5) // квадрат
};

        // Інформація про кожен прямокутник
        Console.WriteLine("Інформація про прямокутники:");
        foreach (var rectangle in rectangles)
        {
            rectangle.DisplaySides();
            Console.WriteLine($"Периметр: {rectangle.CalculatePerimeter()}, Площа: {rectangle.CalculateArea()}");
            Console.WriteLine($"Цей прямокутник {(rectangle.IsSquare() ? "є" : "не є")} квадратом\n");
        }

        // Підрахунок кількості квадратів
        int squareCount = 0;
        foreach (var rectangle in rectangles)
        {
            if (rectangle.IsSquare())
                squareCount++;
        }
        Console.WriteLine($"Загальна кількість квадратів: {squareCount}");

        Console.ReadLine();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Tests r_test = new Tests();
        r_test.RectangleTest();
    }
}