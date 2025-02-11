namespace Algorithms;

public class MobileAverage
{
    public int SizeWindow { get; set; } = 4;

    public List<double> CalculateMovingAverage(List<double> figures)
    {
        int n = figures.Count;
        List<double> resultats = new ();

        for (int i = 0; i < figures.Count - SizeWindow; i++)
        {
            IEnumerable<double> window = figures.Skip(i).Take(SizeWindow+1);

            var temp1 = window.First();
            var temp2 = window.Skip(i + 1).Take(SizeWindow - 1);
            var temp3 = window.Last();


            double temp = 0.5 * window.First() + window.Skip(i+1).Take(SizeWindow-1).Sum() + 0.5 * window.Last();
            resultats.Add(temp / SizeWindow);
        }

        return resultats;
    }
}
