namespace Library
{
  /// <summary>
  /// Class to handle random number list generation
  /// </summary>
  public interface INumberGenerator
  {
    /// <summary>
    /// This method generates a list of numbers within the provided parameters and orders the sequence in a random order.
    /// </summary>
    /// <param name="startIndex">Start index of the sequence.</param>
    /// <param name="lastIndex">Last index of the sequence.</param>
    /// <returns>List of numbers within the provided parameters</returns>
    List<int> GenerateRandomSequence(int startIndex, int lastIndex);
  }
}
