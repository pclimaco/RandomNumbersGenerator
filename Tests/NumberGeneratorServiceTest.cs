using Library;

namespace Tests
{
  public class NumberGeneratorServiceTest
  {
    /// <summary>
    /// Unit for testing random sequence generator function
    /// </summary>
    [Fact]
    public void GenerateRandomSequenceTest()
    {
      // Initializing data for testing
      const int firstRangeNumber = 1;
      const int LastRangeNumber = 10000;
      const int expectedCount = 10000;

      // Instantiate service a test
      NumberGeneratorService service = new NumberGeneratorService();
      var randomSequenceList = service.GenerateRandomSequence(1, 10000);
      Assert.Contains(firstRangeNumber, randomSequenceList);
      Assert.Contains(LastRangeNumber, randomSequenceList);
      Assert.Equal(expectedCount, randomSequenceList.Count);
    }
  }
}