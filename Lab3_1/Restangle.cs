class Restangle
{
    private double side1;
    private double side2;

    public Restangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public double CalculateArea()
    { return side1 * side2; }
    public double CalculatePerimetr()
    { return 2 * (side1 * side2); }
    public double Area
    {
        get { return CalculateArea(); }
    }
    public double Perimeter
    {
        get { return CalculatePerimetr(); }
    }
}