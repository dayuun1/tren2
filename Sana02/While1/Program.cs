internal class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Enter n");
       int n = int.Parse(Console.ReadLine());
        double a = FirstMethod(n);
        double b = SecondMethod(n);
        int c = ThirdMethod(n);
        Console.WriteLine($"a = {a}; b = {b}; c = {c}");
    }
    static double FirstMethod(int n)
    {
        double a = 0;
        for (int i = 1; i <= n; i++)
        {
            a += Math.Pow(-1, i) / (2 * i + 1);
        }

        return a;
    }
    static double SecondMethod(int n)
    {
        double b = 0;
        for (int i = 1; i <= n; i++)
        {
            b += 1 + 1 / Math.Pow(i, 2);
        }
        return b;
    }
    static int ThirdMethod(int n)
    {
        int c = 0, fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            c += fact;
        }
        return c;
    }
}
