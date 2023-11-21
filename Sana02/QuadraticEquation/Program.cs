
    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Two solutions: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"One solution: x = {x}");
        }
        else
        {
            Console.WriteLine("There are no solutions");
        }
        Console.ReadKey();
    }
}
