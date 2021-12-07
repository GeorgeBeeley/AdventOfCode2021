namespace SonarSweep
{
  class Program
  {
    static void Main(string[] args)
    {

      var input = File.ReadLines("problem-input.txt");
      var window = 3;
      var increased = 0;
      var decreased = 0;

      int sum = 0, lastSum;

      for (int i = 0; i + window < input.Count(); i++)
      {
        lastSum = sum;
        sum = GetSum(input, i, window);

        if (sum > lastSum)
          increased++;
        else if (sum < lastSum)
          decreased++;
        else
          Console.WriteLine("no change");
      }

      Console.WriteLine("Increased: " + increased);
      Console.WriteLine("Decreased: " + decreased);
    }

    static int GetSum(IEnumerable<string> obj, int index, int window)
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