class Cylinder
{
    private double height;
    private Circle circle;

    public Cylinder(double height, Circle c)
    {
        this.height = height;
        circle = c;
    }

    public double GetVolume()
    {
        double volume = height * circle.GetArea();
        return volume;
    }
}