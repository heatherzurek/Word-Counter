namespace WordCounter.Models
{
  public class Word
  {
    private string _sentence;

    public Word (string sentence)
    {
      _sentence = sentence;
    }

    public string GetSentence()
    {
      return _sentence;
    }

  }

}
