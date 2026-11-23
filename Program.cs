using codingProblems;

public class Program
{
    private static void Main(string[] args)
    {
       Exercise01 exercise = new Exercise01();
        var result = exercise.containsNegative(new List<int> { 5, 3, 4,7 });
        Console.WriteLine(result);
    }
}