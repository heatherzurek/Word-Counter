namespace WordCounter.Models
{
  public class WordCounter
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
