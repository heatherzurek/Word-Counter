namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _phrase;
    private int _wordCount;

    public RepeatCounter (string word, string phrase)
    {
      _word = word;
      _phrase = phrase;
    }

    public string Word { get => _word; set => _word = value; }
    public string Phrase { get => _phrase; set => _phrase = value; }

    public int GetWordCount()
    {
      return _wordCount;
    }

    public void Counter(string userInput)
    {
      string searchForWord = userInput;
      string[] searchArray = searchForWord.Split(' ');

      foreach(string word in searchArray)
      {
        if(word == _word)
        {
          _wordCount ++;
        }

      }
    }

    public int GetCount()
    {
      return _wordCount;
    }

  }
}
