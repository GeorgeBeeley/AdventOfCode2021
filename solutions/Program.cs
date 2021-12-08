namespace SonarSweep
{
  class Program
  {
    static void Main(string[] args)
    {
      var day = 2;
      var input = File.ReadLines($"inputs/problem-{day}-input.txt");
      Console.WriteLine($"Answer: {DayTwo.SolveProblem(input)}");
    }


    class DayOne
    {

      static int window = 3;
      static int increased = 0;
      static int decreased = 0;
      static int sum = 0;
      static int lastSum;

      public static int SolveProblem(IEnumerable<string> input)
      {
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

    class DayTwo
    {

      static int horizontalPos = 0, depth = 0, aim = 0;

      public static int SolveProblem(IEnumerable<string> input)
      {

        foreach (string line in input)
        {
          var data = line.Split(" ");

          switch (data[0])
          {
            case "forward":
              horizontalPos += Int32.Parse(data[1]);
              depth += (Int32.Parse(data[1]) * aim);
              break;

            case "down":
              aim += Int32.Parse(data[1]);
              break;

            case "up":
              aim -= Int32.Parse(data[1]);
              break;

            default:
              break;
          }
        }

        // Console.WriteLine("HorizontalPos: " + horizontalPos);
        // Console.WriteLine("Depth: " + depth);
        // Console.WriteLine("Multiplied Value: " + (depth * horizontalPos));
        return (depth * horizontalPos);
      }
    }
  
    class DayThree {

      public static int SolveProblem(IEnumerable<string> input) {


        return 0;
      }

    }
  }
}