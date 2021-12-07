namespace SonarSweep {
  class Program {
    static void Main(string[] args) {

      var input = File.ReadLines("problem-input.txt");
      var increased = 0;
      var decreased = 0;

      for (int i = 0; i < input.Count(); i++) {
        if (i > 0 && Int32.Parse(input.ElementAt(i)) > Int32.Parse(input.ElementAt(i-1)))
          increased++;
        else
          decreased++;
      }

      Console.WriteLine("Increased: " + increased);
      Console.WriteLine("Decreased: " + decreased);
    }
  } 
}