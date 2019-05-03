namespace WordCounter.Models
{
  public class RepeatCounter
  {
    // private string _findWord;
    // private int _wordCount = 0;
    private string _word;
    private string _phrase;
    private string[] _splitPhrase;

    public RepeatCounter (string word, string phrase)
    {
      _word = word;
      _phrase = phrase;
      _splitPhrase = phrase.Split(" ");
    }

    public string Word { get => _word; set => _word = value; }
    public string Phrase { get => _phrase; set => _phrase = value; }
    public string SplitPhrase { get => _splitPhrase; set => _splitPhrase = value; }

    public int SearchForWord(string userInput)
    {
      // int _wordCount = 0;
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
    
    public static void ClearAll()
    {
      _findWord.Clear();
    }
  }
}
