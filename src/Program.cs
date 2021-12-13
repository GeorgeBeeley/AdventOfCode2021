
namespace AdventOfCode2021
{

  class Program
  {
    static void Main(string[] args)
    {
      var day = 3;
      var input = File.ReadLines($"inputs/problem-{day}-input.txt");
      var answer = new Day3().SolveProblemB(input);
      Console.WriteLine($"Answer: {answer}");
    }
  }
}
