namespace Library
{
  public class NumberGeneratorService : INumberGenerator
  {
    public List<int> GenerateRandomSequence(int firstIndex, int lastIndex)
    {
      Random random = new Random();
      var randomNumbersList = Enumerable.Range(firstIndex, lastIndex).OrderBy(_ => random.Next()).ToList();
      return randomNumbersList;
    }
  }
}