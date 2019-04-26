namespace WordCounter.Models
{
  public class Word
  {
    private string _findWord;

    public Word (string findWord)
    {
      _findWord = findWord;
    }

    public string GetFindWord()
    {
      return _findWord;
    }

    public void SetFindWord(string newFindWord)
    {
      _findWord = newFindWord;
    }

  }

}
