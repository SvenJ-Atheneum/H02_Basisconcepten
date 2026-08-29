namespace E2._2_Temperatuurconverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celsius: "); double c = double.Parse(Console.ReadLine());
double f = (c * 9 / 5) + 32;
Console.WriteLine($"{c}°C = {f}°F");
        }
    }
}
