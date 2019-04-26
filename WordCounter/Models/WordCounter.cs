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
    //added word count getter
    public int GetWordCount()
    {
      return _wordCount;
    }
    //added word count getter

    public void SetFindWord(string newFindWord)
    {
      _findWord = newFindWord;
    }

    public int SearchForWord(string userInput)
    {
      int _wordCount = 0;
      string searchForWord = userInput;
      string[] searchArray = searchForWord.Split(' ');

      foreach(string element in searchArray)
      {
        if(element == _findWord)
        {
          _wordCount ++;
        }

      }
      return _wordCount;
    }
  }
}
