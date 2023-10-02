class Program
{
    static void Main()
    {
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(3, 0, "B");
        Point point3 = new Point(3, 4, "C");

        Figure triangle = new Figure(point1, point2, point3);
        triangle.CalculatePerimeter();

        Console.ReadLine();
    }
}