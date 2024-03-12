namespace ThingsToDoWithOOP;

class Calculate
{
    // Example of Polymorphism
    public static double CalculateArea(int length)
    {
        return length * length;
    }

    public static double CalculateArea(double r)
    {
        return Math.PI * r * r;
    }

    public static void main(string[] args)
    {
        int x = 2;
        double y = 2d;
        CalculateArea(x);
        CalculateArea(y);
    }

}
