namespace AdventOfCode2021
{
  class Day3
  {
    public Day3() { }

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

      for (int i = 0; i < binaryLength; i++)
      {
        foreach (string line in input)
        {
          if (line.ElementAt(i) == '1') ones[i]++;
          if (line.ElementAt(i) == '0') zeros[i]++;
        }
      }

      var oxygenGeneratorRating = GetLifeSupportRating(input, ones, zeros, binaryLength, new char[] { '0', '0', '1' });
      var co2ScrubberRating = GetLifeSupportRating(input, ones, zeros, binaryLength, new char[] { '1', '1', '0' });

      // return $"{new string(oxygenGeneratorRating)} {new string(co2ScrubberRating)}";
      return Convert.ToInt32(new string(oxygenGeneratorRating), 2) * Convert.ToInt32(new string(co2ScrubberRating), 2);
    }

    char[] GetLifeSupportRating(IEnumerable<string> input, int[] ones, int[] zeros, int binaryLength, char[] key)
    {

      var rating = new List<char[]>();
      foreach (string str in input)
        rating.Add(str.ToCharArray());

      var lateralPos = 0;
      while (rating.Count() > 1)
      {
        if (lateralPos == binaryLength)
          lateralPos = 0;

        for (int i = rating.Count() - 1; i >= 0; i--)
        {
          if (ones[lateralPos] == zeros[lateralPos] && rating[i][lateralPos] == key[0]) rating.RemoveAt(i);
          if (ones[lateralPos] > zeros[lateralPos] && rating[i][lateralPos] == key[1]) rating.RemoveAt(i);
          if (ones[lateralPos] < zeros[lateralPos] && rating[i][lateralPos] == key[2]) rating.RemoveAt(i);
        }

        lateralPos++;
      }

      return rating[0];
    }
  }
}