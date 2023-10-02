class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть довжину першої сторони прямокутника");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину другої сторони прямокутника");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Restangle restangle = new Restangle(side1, side2);

        Console.WriteLine("Площа прямокутника: " + restangle.Area);
        Console.WriteLine("Периметр прямокуика): " + restangle.Perimeter);
    }
}