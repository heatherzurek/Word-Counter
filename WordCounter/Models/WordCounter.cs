namespace WordCounter.Models
{
  public class Word
  {
    private string _findWord;
    private string _wordCount;


    public Word (string findWord)
    {
      _findWord = findWord;
    }

    public string GetFindWord()
    {
      return _findWord;
    }
    //added word count getter
    public string GetWordCount()
    {
      return _wordCount;
    }
    //added word count getter

    public void SetFindWord(string newFindWord)
    {
      _findWord = newFindWord;
    }

    public int SearchForWord(int userInput)
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
    // put a method for how m any times the word occurs here
  }
}
