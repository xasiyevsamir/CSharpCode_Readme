namespace İsPrimitiveType;
class Program
{
    static void Main(string[] args)
    {

        // Double istifadə:
        double d1 = 0.1;
        double d2 = 0.2;
        Console.WriteLine(d1 + d2);  // Çıxış: 0.30000000000000004

        // Decimal istifadə:
        decimal m1 = 0.1m;
        decimal m2 = 0.2m;
        Console.WriteLine(m1 + m2);  // Çıxış: 0.3
    }
}
