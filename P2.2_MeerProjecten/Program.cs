namespace P2._2_MeerProjecten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nummers = {1,2,3,4,5};
int som = 0;
foreach(var n in nummers) som += n;
Console.WriteLine($"Som: {som}");
        }
    }
}
