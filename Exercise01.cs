namespace codingProblems
{
    public class Exercise01
{
    public bool containsNegative(IEnumerable<int> numbers)
    {
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

