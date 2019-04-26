namespace WordCounter.Models
{
  public class Word
  {
    private string _findWord;

    public Word (string findWord)
    {
      _findWord = findWord;
    }

    // public string GetSentence()
    // {
    //   return _sentence;
    // }

    public string GetFindWord()
    {
      return _findWord;
    }

  }

}
