namespace E2._1_BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gewicht (kg): "); double gewicht = double.Parse(Console.ReadLine());
Console.Write("Lengte (m): "); double lengte = double.Parse(Console.ReadLine());
double bmi = gewicht / (lengte * lengte);
Console.WriteLine($"BMI: {bmi:F2}");
        }
    }
}
