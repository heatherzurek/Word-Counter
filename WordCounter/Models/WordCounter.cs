namespace WordCounter.Models
{
  public class Word
  {
    private string _findWord;
    private int _wordCount = 0;

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

    public void SearchForWord(string userInput)
    {
      string searchForWord = userInput;
      string[] searchArray = searchForWord.Split(' ');

      foreach(string element in searchArray)
      {
        if(element == _findWord)
        {
          _wordCount ++;
        }

      }
    }
  }
}
