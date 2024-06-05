
class Program
{
    static void Main(string[] args)
    {
        var piEstimate1000 = EstimatePi(1000);
        var piEstimate10000 = EstimatePi(10000);
        var piEstimate100000 = EstimatePi(100000);
        var piEstimate1000000 = EstimatePi(1000000);

        Console.WriteLine($"Estimarea pentru {1000} mostre este: {piEstimate1000}");
        Console.WriteLine($"Estimarea pentru {10000} mostre este: {piEstimate10000}");
        Console.WriteLine($"Estimarea pentru {100000} mostre este: {piEstimate100000}");
        Console.WriteLine($"Estimarea pentru {1000000} mostre este: {piEstimate1000000}");

    }

    static double EstimatePi(int numSamples)
    {
        var numPointsInCircle = 0;
        var rand = new Random();

        for (int i = 0; i < numSamples; i++)
        {
            var x = rand.NextDouble() * 2 - 1;
            var y = rand.NextDouble() * 2 - 1;

            if (x * x + y * y <= 1)
            {
                numPointsInCircle++;
            }
        }

        return 4.0 * numPointsInCircle / numSamples;
    }
}