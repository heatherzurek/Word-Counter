namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _phrase;
    int count = 0;
    // private string[] _splitPhrase;

    public RepeatCounter (string word, string phrase)
    {
      _word = word;
      _phrase = phrase;
      // _splitPhrase = phrase.Split(" ");
    }

    public string Word { get => _word; set => _word = value; }
    public string Phrase { get => _phrase; set => _phrase = value; }

    public int Counter(string userInput)
    {
      // int count = 0;
      string phrase = userInput;
      string[] userPhrase = phrase.Split(" ");

      foreach (string word in userPhrase)
      {
        if (word == _word)
        {
          count ++;
        }
      }
      return count;
    }

  }
}
