// namespace WordCounter.Models
// {
//   public class Word
//   {
//     private string _findWord;
//     private int _wordCount = 0;
//
//
//     public Word (string findWord)
//     {
//       _findWord = findWord;
//     }
//
//     public string GetFindWord()
//     {
//       return _findWord;
//     }
//     //added word count getter
//     public int GetWordCount()
//     {
//       return _wordCount;
//     }
//     //added word count getter
//
//     public void SetFindWord(string newFindWord)
//     {
//       _findWord = newFindWord;
//     }
//
//     public int SearchForWord(string userInput)
//     {
//       // int _wordCount = 0;
//       string searchForWord = userInput;
//       string[] searchArray = searchForWord.Split(' ');
//
//       foreach(string element in searchArray)
//       {
//         if(element == _findWord)
//         {
//           _wordCouWnt ++;
//         }
//
//       }
//       return _wordCount;
//     }
//   }
// }

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _phrase;
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
      int counter = 0;
      string phrase = userInput;
      string[] userArray = phrase.Split(" ");

      foreach (string word in userArray)
      {
        if (word == _word)
        {
          counter ++;
        }
      }
      return counter;
    }

  }
}
