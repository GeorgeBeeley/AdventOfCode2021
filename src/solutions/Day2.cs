namespace AdventOfCode2021 {
  class Day2
  {
    public Day2() {}

    public int SolveProblem(IEnumerable<string> input)
    {
      int horizontalPos = 0;
      int depth = 0;
      int aim = 0;
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
}