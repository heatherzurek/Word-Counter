namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _phrase;
    private int _wordCount = 0;
    // private int _count;
    // private string[] _splitPhrase;

    public RepeatCounter (string word, string phrase)
    {
      _word = word;
      _phrase = phrase;
      // _splitPhrase = phrase.Split(" ");
    }

    public string Word { get => _word; set => _word = value; }
    public string Phrase { get => _phrase; set => _phrase = value; }

    public int GetWordCount()
    {
      return _wordCount;
    }

    // public int Counter(string userInput)
    // {
    //   int count = 0;
    //   string phrase = userInput;
    //   string[] userPhrase = phrase.Split(" ");
    //
    //   foreach (string word in userPhrase)
    //   {
    //     if (word == _word)
    //     {
    //       count ++;
    //     }
    //   }
    //   return count;
    // }

    public int SearchForWord(string userInput)
    {
      // int _wordCount = 0;
      string searchForWord = userInput;
      string[] searchArray = searchForWord.Split(' ');

      foreach(string element in searchArray)
      {
        if(element == _word)
        {
          _wordCount ++;
        }

      }
      return _wordCount;
    }

  }
}
