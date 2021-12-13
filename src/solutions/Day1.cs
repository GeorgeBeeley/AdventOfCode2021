namespace AdventOfCode2021
{
  class Day1
  {
    public Day1() {}

    public int SolveProblem(IEnumerable<string> input)
    {
      int window = 3;
      int increased = 0;
      int decreased = 0;
      int sum = 0;
      int lastSum = 0;

      for (int i = 0; i + window < input.Count(); i++)
      {
        lastSum = sum;
        sum = GetSum(input, i, window);

        if (sum > lastSum)
          increased++;
        else if (sum < lastSum)
          decreased++;
        else
          continue;
      }

      return increased;
    }

    int GetSum(IEnumerable<string> obj, int index, int window)
    {
      var sum = 0;

      for (int j = index; j < index + window; j++)
      {
        sum += Int32.Parse(obj.ElementAt(j));
      }

      return sum;
    }
  }
}