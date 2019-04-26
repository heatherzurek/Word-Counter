using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("dog");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      string sentence = "Lets walk the dog";
      Word newWord = new Word(sentence);

      string result = newWord.GetSentence();

      Assert.AreEqual(sentence, result);
    }

  }
}
