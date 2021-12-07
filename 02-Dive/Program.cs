namespace Dive
{

  class Program
  {

    static void Main(string[] args)
    {

      var input = File.ReadLines("problem-input.txt");
      int horizontalPos = 0, depth = 0, aim = 0;

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
      
      Console.WriteLine("HorizontalPos: " + horizontalPos);
      Console.WriteLine("Depth: " + depth);
      Console.WriteLine("Multiplied Value: " + (depth * horizontalPos));
    }
  }
}