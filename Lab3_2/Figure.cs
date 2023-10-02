class Figure
{
    private Point[] points;
    public Figure(Point p1, Point p2, Point p3)
    { points = new Point[] { p1, p2, p3 }; }

    public Figure(Point p1, Point p2, Point p3, Point p4)
    { points = new Point[] { p1, p2, p3, p4 }; }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    { points = new Point[] { p1, p2, p3, p4, p5 }; }
    
    public double GetSideLength(Point A, Point B)
    {
        double sideLength = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)); 
        return sideLength;
    }
    public void CalculatePerimeter()
    {
        double perimeter = 0.0;
        for(int i = 0; i < points.Length; i++)
        {
            int nextIndex = (i + 1) % points.Length;
            double sideLength = GetSideLength(points[i], points[nextIndex]);
            perimeter += sideLength;
        }
        Console.WriteLine($"Perimeter: {perimeter}");
    }
}
