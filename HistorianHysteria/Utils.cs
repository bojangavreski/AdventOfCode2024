
public class Utils
{
    public static InputLines GetInputLines()
    {
        InputLines lines = new InputLines();

        Tuple<int, int> tuple;
        using (StreamReader streamReader = new StreamReader(Console.OpenStandardInput()))
        {
            while (true)
            {
                string line = streamReader.ReadLine();
                if (line == null ||
                   line.Trim().Equals(String.Empty))
                {
                    break;
                }

                tuple = ParseLine(line);
                lines.FirstLine.Add(tuple.Item1);
                lines.SecondLine.Add(tuple.Item2);
            }
        }

        return lines;
    }

    private static Tuple<int, int> ParseLine(string line)
    {
        string[] splitted = line.Split("   ");

        _ = int.TryParse(splitted[0], out int first);
        _ = int.TryParse(splitted[1], out int second);

        return Tuple.Create(first, second);
    }
}
