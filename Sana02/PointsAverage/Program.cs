
namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 student ratings on a 100-point scale:");

            int[] points = new int[5];
            double average;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Rating {i + 1}: ");
                points[i] = int.Parse(Console.ReadLine());

                if (points[i] < 0 || points[i] > 100)
                {
                    Console.WriteLine("Error");
                    i--;
                }
            }
            average = CalculateAverage(points);

            if (average >= 50)
            {
                Console.WriteLine($"Averge rating: {average:F2}.The student is admitted to the exam.");
            }
            else
            {
                Console.WriteLine($"Averge rating: {average:F2}. The student is not admitted to the exam.");
            }

            Console.ReadKey();
        }

        static double CalculateAverage(int[] points)
        {
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += points[i];
            }
            return sum / 5;
        }
    }
}