
namespace Tests
{
  public class CodingTest
  {
    public static bool isPangram(string text)
    {
      Console.WriteLine($"text: {text} ");
      
      var textToLower = text.ToLower();
      var onlyTextLetters = textToLower.Where(letter => Char.IsLetter(letter));
      var textGroupBy = onlyTextLetters.GroupBy(letter => letter);
      var numberOfLetters = textGroupBy.Count();


      if(numberOfLetters == 26)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    //todo: Create console application todo list, add, remove, read, 

  }
}