namespace HistorianHysteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputLines lines = Utils.GetInputLines();

            Console.WriteLine(HistorianHysteriaPt1(lines));
        }

        static int HistorianHysteriaPt1(InputLines lines)
        {
            lines.FirstLine.Sort();
            lines.SecondLine.Sort();

            return lines.FirstLine.Zip(lines.SecondLine)
                           .Sum(x => Math.Abs(x.First - x.Second));
        }

        static int HistorianHysteriaPt2(InputLines lines)
        {
            return lines.FirstLine.Distinct()
                                      .Select(x => x * lines.SecondLine.Where(y => x == y).Count())
                                      .Sum();
        }

    }
}
