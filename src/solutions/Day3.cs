namespace AdventOfCode2021
{
  class Day3
  {
    public Day3() {}

    public int SolveProblemA(IEnumerable<string> input)
    {
      int sum = 0;
      int count = input.Count();
      int length = input.ElementAt(0).Length;
      char[] gammaChars = new char[length];
      char[] epsilonChars = new char[length];

      for (int i = 0; i < length; i++)
      {
        foreach (string line in input)
          sum += (line.ToCharArray()[i] - '0');

        gammaChars[i] = (sum < (count / 2)) ? '0' : '1';
        epsilonChars[i] = (sum < (count / 2)) ? '1' : '0';
        sum = 0;
      }

      return Convert.ToInt32(new string(gammaChars), 2) * Convert.ToInt32(new string(epsilonChars), 2);
    }

    public int SolveProblemB(IEnumerable<string> input)
    {
      int binaryLength = input.ElementAt(0).Length;
      int[] ones = new int[binaryLength];
      int[] zeros = new int[binaryLength];

      char[] gammaChars = new char[binaryLength];
      char[] epsilonChars = new char[binaryLength];

      for (int i = 0; i < binaryLength; i++)
      {
        foreach (string line in input)
        {
          if (line.ElementAt(i) == '1')
            ones[i]++;
          if (line.ElementAt(i) == '0')
            zeros[i]++;
        }

        gammaChars[i] = (ones[i] > zeros[i]) ? '1' : '0';
        epsilonChars[i] = (ones[i] > zeros[i]) ? '0' : '1';
      }

      return Convert.ToInt32(new string(gammaChars), 2) * Convert.ToInt32(new string(epsilonChars), 2);
    }
  }
}